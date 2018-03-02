using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        //string zahl1Text = string.Empty, zahl2Text = string.Empty;
        string zahl2Text = "";
        double zahl, zahl1, zahl2, resultat;
        //double potenzwert;
        char operation = ' ';
        bool firstChar = true;      // wird bei der Zahleneingabe benötigt, um am Anfang der Zahl besonders zu reagieren.
        bool kommaSperre = false;   // wird benötigt um zu verhindern, dass das Zeichen ',' falsch eingesetzt werden kann.  
        bool exponentSperre = true; // wird benötigt um zu verhindern, dass das Zeichen 'e' falsch eingesetzt werden kann.
        bool folgeAktion = false;   // wird benötigt um mit dem vorherigen Rechenergebnis weiter zu rechnen.
        bool zahl1_belegt = false;
        bool zahl2_belegt = false;
        bool textBoxAnzeigeIstZahl = false;
        bool textBoxAnzeigeIstZahl1 = true;

        public Form1()
        {
            InitializeComponent();
            labelFormel.Text = "";
            textBoxAnzeige.Text = "0";
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(Button_Click);
            button2.Click += new EventHandler(Button_Click);
            button3.Click += new EventHandler(Button_Click);
            button4.Click += new EventHandler(Button_Click);
            button5.Click += new EventHandler(Button_Click);
            button6.Click += new EventHandler(Button_Click);
            button7.Click += new EventHandler(Button_Click);
            button8.Click += new EventHandler(Button_Click);
            button9.Click += new EventHandler(Button_Click);
            button0.Click += new EventHandler(Button_Click);
            buttonKomma.Click += new EventHandler(Button_Click);
        }

        private void NormierungEingabe()
        {
            firstChar = true;
            kommaSperre = false;
            exponentSperre = false;
        }

        void Button_Click(object sender, EventArgs e)
        {   //setzt den Button_Click in ein Zeichen um.
            char eingabeChar = '0';
            try
            {  /* Beschreibung "try": Fügen Sie Codeabschnitte, die Ausnahmen auslösen könnten, in einen try-Block ein und
                  Code, der Ausnahmen behandelt, in einen catch-Block.Ein catch-Block ist eine Folge von Anweisungen, 
                  die mit dem Schlüsselwort catch beginnen, gefolgt von einem Ausnahmetyp und einer auszuführenden Aktion.
                  Button ziffer = sender as Button; 
                  Ob "try" hier nötig ist, bezweifel icht etwas. Ist aber als Beispiel interessant
                  https://msdn.microsoft.com/de-de/library/xtd0s8kd(v=vs.110).aspx   */

                Button ziffer = sender as Button;
                switch (ziffer.Name)
                {
                    case "button1":
                        eingabeChar = '1';
                        break;
                    case "button2":
                        eingabeChar = '2';
                        break;
                    case "button3":
                        eingabeChar = '3';
                        break;
                    case "button4":
                        eingabeChar = '4';
                        break;
                    case "button5":
                        eingabeChar = '5';
                        break;
                    case "button6":
                        eingabeChar = '6';
                        break;
                    case "button7":
                        eingabeChar = '7';
                        break;
                    case "button8":
                        eingabeChar = '8';
                        break;
                    case "button9":
                        eingabeChar = '9';
                        break;
                    case "button0":
                        eingabeChar = '0';
                        break;
                    case "buttonKomma":
                        eingabeChar = ',';
                        break;
                }
            }
            catch (Exception ex)  // gehört zu "try" -  muss noch untersucht werden.
            { MessageBox.Show("Uerwarteter Fehler ist aufgetreten. Details: " + ex.Message); }
            Eingabe_prüfen_freigeben(eingabeChar);
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case ',':
                    Eingabe_prüfen_freigeben(e.KeyChar);
                    break;
                case 'e':
                    if (firstChar)
                    { MessageBox.Show("Fehlerhafte Eingabe.\nEin Exponent ohne Basiszahl ist nicht zulässig."); }
                    else if (exponentSperre == false)
                    {
                        exponentSperre = true;
                        textBoxAnzeige.Text += e.KeyChar;
                    }
                    else { MessageBox.Show("Fehlerhafte Eingabe.\nDer Exponent kann nur einmal vergeben werden."); }
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    VerarbeiteEingabe(e.KeyChar);
                    break;
                case ':':
                    VerarbeiteEingabe('/');
                    break;
                case '=':
                    Berechnung(true);
                    break;
                default:
                    MessageBox.Show("Es wurde ein falsches Zeichen eingeben\noder eine falsche Taste betätigt.");
                    break;
            }
            e.Handled = true; // verhindert das das Zeichen noch einmal ausgegeben wird. genaue Arbeitsweise muss noch untersucht werden.
        }

        public void Eingabe_prüfen_freigeben(char zeichen)
        {   // Es kommen nur die Zeichen "0-9" und "," in Betracht. Alle anderen wurden bereits ausgeschlossen! 
            // Etwas problematisch war, dass sowohl Tastatur- wie auch die Buttoneingabe auf diese Funktion zugreifen.
            // Dies war besonders bei der Exponenteneingabe (nur mit der Tastatureingabe möglich) ein Problem.
            if (firstChar)
            {
                if (folgeAktion)
                {
                    folgeAktion = false;
                    zahl1_belegt = false;
                    zahl1 = 0;
                }
                textBoxAnzeige.Text = "0"; // alternativ: textBoxAnzeige.Text = string.Empty;
                firstChar = false;
                exponentSperre = false;
                if (zeichen != '0')
                {
                    if (zeichen == ',')
                    {
                        kommaSperre = true;
                        textBoxAnzeige.Text = "0" + zeichen;
                    }
                    else { textBoxAnzeige.Text = "" + zeichen; }
                }
                exponentSperre = false;
            }
            else if (zeichen == ',')
            {
                if (kommaSperre == false)
                {
                    kommaSperre = true;
                    textBoxAnzeige.Text += zeichen;
                }
                else { MessageBox.Show("Fehlerhafte Eingabe.\nEin Komma kann nur einmal vergeben werden."); }
            }
            else { textBoxAnzeige.Text += zeichen; }
        }

        private void buttonAddieren_Click(object sender, EventArgs e)
        { VerarbeiteEingabe('+'); }
        private void buttonSubtrahieren_Click(object sender, EventArgs e)
        { VerarbeiteEingabe('-'); }
        private void buttonMultiplizieren_Click(object sender, EventArgs e)
        { VerarbeiteEingabe('*'); }
        private void buttonTeilen_Click(object sender, EventArgs e)
        { VerarbeiteEingabe('/'); }

        private void VerarbeiteEingabe(char rechenArt)
        {
            if (folgeAktion)
            {
                folgeAktion = false;
                operation = rechenArt;
                labelFormel.Text = textBoxAnzeige.Text + " ";
                textBoxAnzeige.Text = "0";
            }
            else
            {
                if (zahl1_belegt)
                {
                    if (!zahl2_belegt)
                    {
                        if (Umwandlung())
                        {
                            zahl2 = zahl;
                            zahl2_belegt = true;
                            zahl2Text = zahl2.ToString("#,##0.######"); // fügt Format ein. 5 Kommastellen wurden ermöglicht.
                            textBoxAnzeigeIstZahl = true;
                            textBoxAnzeigeIstZahl1 = false;
                            Berechnung(false);
                            operation = rechenArt;
                            NormierungEingabe();
                        } // Fehlermeldung bereits in Umwandlung()!!! Keine weitere Aktion.
                    }
                    // else { MessageBox.Show("VerarbeiteEingabe()\nEs können nicht zahl1 und zahl2 belegt sein!"); }
                }
                else
                {
                    if (Umwandlung())
                    {
                        operation = rechenArt;
                        zahl1 = zahl;
                        zahl1_belegt = true;
                        labelFormel.Text = zahl1.ToString("#,##0.######") + " ";
                        NormierungEingabe();
                    }
                }
            }
        }

        private void buttonGleich_Click(object sender, EventArgs e)
        { Berechnung(true); }

        private void Berechnung(bool buttonGleich)
        {
            if (!zahl2_belegt)
            {
                if (Umwandlung())
                {
                    zahl2 = zahl;
                    zahl2_belegt = true;
                    zahl2Text = zahl2.ToString("#,##0.######");  // fügt Format ein. 5 Kommastellen wurden ermöglicht.
                    textBoxAnzeigeIstZahl = true;
                    textBoxAnzeigeIstZahl1 = false;
                }
                else
                { return; }
            }
            if (zahl1_belegt && zahl2_belegt)
            {
                switch (operation)
                {
                    case '+':
                        resultat = zahl1 + zahl2;
                        break;
                    case '-':
                        resultat = zahl1 - zahl2;
                        break;
                    case '*':
                        resultat = zahl1 * zahl2;
                        break;
                    case '/':
                    case ':':
                        if (zahl2 != 0) { resultat = zahl1 / zahl2; }
                        else { MessageBox.Show("Teilen durch 0 nicht möglich\nBerechnung wird neu aufgesetzt"); }
                        break;
                }
            }
            else { return; }
            textBoxAnzeige.Text = resultat.ToString("#,##0.######"); // fügt Format ein. 5 Kommastellen wurden ermöglicht.
            if (buttonGleich)
            {
                folgeAktion = true; // Weitere Berechnung auf Grundlage des alten Ergebnisses wird ermöglicht.
                labelFormel.Text += operation + " " + zahl2Text + " = " + textBoxAnzeige.Text;
            }
            else
            { labelFormel.Text += operation + " " + zahl2Text + " "; }
            zahl1 = resultat;
            zahl2_belegt = false;
            textBoxAnzeigeIstZahl = true;
            textBoxAnzeigeIstZahl1 = true;
            NormierungEingabe();
        }

        private void buttonQuadrat_Click(object sender, EventArgs e)
        {
            if (!textBoxAnzeigeIstZahl)
            {
                if (Umwandlung())
                {
                    textBoxAnzeigeIstZahl = true;
                    resultat = zahl * zahl;
                    if (!zahl1_belegt)
                    { zahl1 = resultat; }
                    else
                    { zahl2 = resultat; }
                }
                else { return; }
            }
            else
            {
                if (textBoxAnzeigeIstZahl1)
                { zahl1 = zahl1 * zahl1; resultat = zahl1; }
                else
                { zahl2 = zahl2 * zahl2; resultat = zahl2; }
            }
            textBoxAnzeige.Text = resultat.ToString("#,##0.###############"); // 15 Kommastellen möglich
        }

        private void buttonWurzel_Click(object sender, EventArgs e)
        {
            if (!textBoxAnzeigeIstZahl)
            {
                if (Umwandlung())
                {
                    textBoxAnzeigeIstZahl = true;
                    resultat = Math.Sqrt(zahl);
                    if (!zahl1_belegt) { zahl1 = resultat; }
                    else { zahl2 = resultat; }
                }
                else { return; }
            }
            else
            {
                if (textBoxAnzeigeIstZahl1)
                { zahl1 = Math.Sqrt(zahl1); resultat = zahl1; }
                else
                { zahl2 = Math.Sqrt(zahl2); resultat = zahl2; }
            }
            textBoxAnzeige.Text = resultat.ToString("#,##0.###############"); // 15 Kommastellen möglich
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (!textBoxAnzeigeIstZahl)
            {
                if (Umwandlung()) { resultat = zahl * -1; }
                else { return; }
            }
            else
            {
                if (textBoxAnzeigeIstZahl1) { zahl1 = zahl1 * -1; resultat = zahl1; }
                else { zahl2 = zahl2 * -1; resultat = zahl2; }
            }
            textBoxAnzeige.Text = resultat.ToString("#,##0.###############"); // 15 Kommastellen möglich
        }

        private void buttonProzent_Click(object sender, EventArgs e)
        {
            if ((Double.TryParse(textBoxAnzeige.Text, out zahl2)))
            {
                resultat = 0;
                switch (operation)
                {
                    case '+':
                        resultat = zahl1 + zahl1 / 100 * zahl2;
                        labelFormel.Text = zahl1 + " + " + zahl2 + "% = ";
                        break;
                    case '-':
                        resultat = zahl1 - zahl1 / 100 * zahl2;
                        labelFormel.Text = zahl1 + " - " + zahl2 + "% = ";
                        break;
                    case '*':
                        resultat = zahl1 / 100 * zahl2;
                        labelFormel.Text = zahl2 + "% von " + zahl1 + " = ";
                        break;
                    default:
                        MessageBox.Show("Folgende Vorgehensweise ist bei der Prozentrechnung zu beachten" +
                                        "\n1. C eingeben" +
                                        "\n2. eine Zahl angeben" +
                                        "\n3. eine Rechenart eingeben" +
                                        "\n4. eine zweite Zahl angeben" +
                                        "\n5. [%] betätigen" +
                                        "\n6. C eingeben");
                        break;
                }
                textBoxAnzeige.Text = resultat.ToString();
                labelFormel.Text += textBoxAnzeige.Text;
                zahl1 = resultat;
                zahl2_belegt = false;
                textBoxAnzeigeIstZahl = true;
                textBoxAnzeigeIstZahl1 = true;
                folgeAktion = true;
                NormierungEingabe();
            }
            else
            {
                MessageBox.Show("Es wurde keine korrekte Zahl eingegeben!\nBitte wiederholen sie die Eingabe");
                textBoxAnzeige.Text = "0";
            }
        }

        private void buttonKehrwert_Click(object sender, EventArgs e)
        {
            if (!textBoxAnzeigeIstZahl)
            {
                if (Umwandlung()) { resultat = 1 / zahl; }
                else { return; }
            }
            else
            {
                if (textBoxAnzeigeIstZahl1) { resultat = 1 / zahl1; }
                else { resultat = 1 / zahl2; }
            }
            textBoxAnzeige.Text = resultat.ToString("#,##0.###############"); // 15 Kommastellen möglich


            if (!textBoxAnzeigeIstZahl)
            {
                if (Umwandlung())
                {
                    zahl = 1 / zahl;
                    textBoxAnzeige.Text = zahl.ToString("#,##0.######");
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxAnzeige.Text != "")
            {
                textBoxAnzeige.Text = textBoxAnzeige.Text.Substring(0, textBoxAnzeige.Text.Length - 1);
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxAnzeige.Text = "0";
            textBoxAnzeigeIstZahl = false;
            if (textBoxAnzeigeIstZahl1)
            { zahl1 = 0; }
            else
            { zahl2 = 0; }
            NormierungEingabe();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            operation = ' ';
            firstChar = true;      // wird bei der Zahleneingabe benötigt, um am Anfang der Zahl besonders zu reagieren.
            kommaSperre = false;   // wird benötigt um zu verhindern, dass das Zeichen ',' falsch eingesetzt werden kann.  
            exponentSperre = true; // wird benötigt um zu verhindern, dass das Zeichen 'e' falsch eingesetzt werden kann.
            folgeAktion = false;   // wird benötigt um mit dem vorherigen Rechenergebnis weiter zu rechnen.
            zahl1_belegt = false;
            zahl2_belegt = false;
            textBoxAnzeigeIstZahl = false;
            textBoxAnzeigeIstZahl1 = true;
            textBoxAnzeige.Text = "0";
            resultat = 0;
            zahl1 = 0;
            zahl2 = 0;
            labelFormel.Text = "";
            operation = ' ';
            NormierungEingabe();
        }

        private bool Umwandlung()
        {
            if ((Double.TryParse(textBoxAnzeige.Text, out zahl)))
            { return true; }  // kein Fehler
            else
            {
                MessageBox.Show("Es wurde keine korrekte Zahl eingegeben!\nBitte wiederholen sie die Eingabe");
                textBoxAnzeige.Text = "0";
                return false;   // Fehler
            }
        }
    }

}
