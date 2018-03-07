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
        bool firstChar = true;      // wird bei der Zahleneingabe benötigt, um am Anfang der Zahl besonders zu reagieren.
        bool kommaSperre = false;   // wird benötigt um zu verhindern, dass das Zeichen ',' falsch eingesetzt werden kann.  
        bool exponentSperre = true; // wird benötigt um zu verhindern, dass das Zeichen 'e' falsch eingesetzt werden kann.
        double zahl, zahl1, zahl2, memory;
        byte bearbeiteZahl = 1;     // 1 = zahl1 soll ermittelt werden, 2 = zahl2 soll ermittelt werden
        byte zahl1Zustand = 0;      // 0 = unbearbeitet, 1 = Zwischenergebnis, 2 = Endergebnis
        byte zahl2Zustand = 0;      // 0 = unbearbeitet, 1 = Zwischenergebnis, 2 = Endergebnis
        char operation = ' ';
        double resultat;
        string resultatText = "";
        bool folgeAktion = false;   // wird benötigt um mit dem vorherigen Rechenergebnis weiter zu rechnen.

        public Form1()
        {
            InitializeComponent();
            lblFormel.Text = "";
            txtAnzeige.Text = "";
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(Button_Click);
            btn2.Click += new EventHandler(Button_Click);
            btn3.Click += new EventHandler(Button_Click);
            btn4.Click += new EventHandler(Button_Click);
            btn5.Click += new EventHandler(Button_Click);
            btn6.Click += new EventHandler(Button_Click);
            btn7.Click += new EventHandler(Button_Click);
            btn8.Click += new EventHandler(Button_Click);
            btn9.Click += new EventHandler(Button_Click);
            btn0.Click += new EventHandler(Button_Click);
            btnKomma.Click += new EventHandler(Button_Click);
            txtAnzeige.Focus();
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        { // Tastatureingabe
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
                case '\b':
                    loescheZeichen();
                    break;
                case 'e':
                    if (firstChar)
                    { MessageBox.Show("Fehlerhafte Eingabe.\nEin Exponent ohne Basiszahl ist nicht zulässig."); }
                    else if (exponentSperre == false)
                    {
                        exponentSperre = true;
                        txtAnzeige.Text += e.KeyChar;
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
                case '\r':
                    Berechnung(true);
                    break;
                default:
                    MessageBox.Show("Es wurde ein falsches Zeichen eingeben\noder eine falsche Taste betätigt.");
                    break;
            }
            e.Handled = true; // verhindert das das Zeichen noch einmal ausgegeben wird. genaue Arbeitsweise muss noch untersucht werden.
            txtAnzeige.Focus();
            txtAnzeige.Select(txtAnzeige.Text.Length, 0);
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
                    case "btn1":
                        eingabeChar = '1';
                        break;
                    case "btn2":
                        eingabeChar = '2';
                        break;
                    case "btn3":
                        eingabeChar = '3';
                        break;
                    case "btn4":
                        eingabeChar = '4';
                        break;
                    case "btn5":
                        eingabeChar = '5';
                        break;
                    case "btn6":
                        eingabeChar = '6';
                        break;
                    case "btn7":
                        eingabeChar = '7';
                        break;
                    case "btn8":
                        eingabeChar = '8';
                        break;
                    case "btn9":
                        eingabeChar = '9';
                        break;
                    case "btn0":
                        eingabeChar = '0';
                        break;
                    case "btnKomma":
                        eingabeChar = ',';
                        break;
                }
            }
            catch (Exception ex)  // gehört zu "try" -  muss noch untersucht werden.
            { MessageBox.Show("Uerwarteter Fehler ist aufgetreten. Details: " + ex.Message); }
            Eingabe_prüfen_freigeben(eingabeChar);
            txtAnzeige.Focus();
            txtAnzeige.Select(txtAnzeige.Text.Length, 0);
        }

        public void Eingabe_prüfen_freigeben(char zeichen)
        {   // Es kommen nur die Zeichen "0-9" und "," in Betracht. Alle anderen wurden bereits ausgeschlossen! 
            // Etwas problematisch war, dass sowohl Tastatur- wie auch die Buttoneingabe auf diese Funktion zugreifen.
            // Dies war besonders bei der Exponenteneingabe (nur mit der Tastatureingabe möglich) ein Problem.
            if (firstChar)
            {
                if (folgeAktion)
                { NormiereBerechnung(false); }
                txtAnzeige.Text = ""; // alternativ: textBoxAnzeige.Text = string.Empty;
                firstChar = false;
                exponentSperre = false;
                if (zeichen != '0')
                {
                    if (zeichen == ',')
                    {
                        kommaSperre = true;
                        txtAnzeige.Text = "0" + zeichen;
                    }
                    else { txtAnzeige.Text = "" + zeichen; }
                }
                exponentSperre = false;
            }
            else if (zeichen == ',')
            {
                if (kommaSperre == false)
                {
                    kommaSperre = true;
                    txtAnzeige.Text += zeichen;
                }
                else { MessageBox.Show("Fehlerhafte Eingabe.\nEin Komma kann nur einmal vergeben werden."); }
            }
            else { txtAnzeige.Text += zeichen; }
        }

        private void btnAddieren_Click(object sender, EventArgs e) { VerarbeiteEingabe('+'); }
        private void btnSubtrahieren_Click(object sender, EventArgs e) { VerarbeiteEingabe('-'); }
        private void btnMultiplizieren_Click(object sender, EventArgs e) { VerarbeiteEingabe('*'); }
        private void btnTeilen_Click(object sender, EventArgs e) { VerarbeiteEingabe('/'); }

        private void VerarbeiteEingabe(char rechenArt)
        {
            txtAnzeige.Focus();
            txtAnzeige.Select(txtAnzeige.Text.Length, 0);
            if (folgeAktion)
            {
                folgeAktion = false;
                operation = rechenArt;
                lblFormel.Text = resultatText + " " + operation + " ";
                txtAnzeige.Text = "";
            }
            else
            {
                if (bearbeiteZahl == 1)
                {
                    if (zahl1Zustand == 0)
                    {
                        if (Umwandlung("VerarbeiteEingabe")) { zahl1 = zahl; }
                        else { return; }
                    }
                    zahl1Zustand = 2; // Ermittlung zahl1 abgeschlossen
                    bearbeiteZahl = 2;
                    operation = rechenArt;
                    lblFormel.Text = zahl1.ToString("#,##0.#####") + " " + operation + " ";
                    NormierungEingabe(true);
                }
                else
                {
                    if (zahl2Zustand == 0)
                    {
                        if (Umwandlung("VerarbeiteEingabe")) { zahl2 = zahl; }
                        else { return; }
                    }
                    zahl2Zustand = 2;
                    Berechnung(false);
                    operation = rechenArt;
                    lblFormel.Text += operation + " ";
                    NormierungEingabe(true);
                }
            }
        }

        private void btnGleich_Click(object sender, EventArgs e)
        { Berechnung(true); txtAnzeige.Focus(); txtAnzeige.Select(txtAnzeige.Text.Length, 0); }

        private void Berechnung(bool buttonGleich)
        {
            string zahl2Text = "";
            if (folgeAktion) { return; }
            if (zahl2Zustand == 0)
            {
                if (Umwandlung("Berechnung"))
                {
                    zahl2 = zahl;
                    zahl2Zustand = 2;
                }
                else { return; }
            }
            if (zahl1Zustand > 0 && zahl2Zustand > 0)
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
            zahl2Text = zahl2.ToString();
            if (buttonGleich)
            {
                folgeAktion = true; // Weitere Berechnung auf Grundlage des alten Ergebnisses wird ermöglicht.
                resultatText = resultat.ToString("#,##0.#####");
                lblFormel.Text += zahl2Text + " = " + resultatText;
            }
            else { lblFormel.Text += zahl2Text + " "; }
            zahl1 = resultat;
            zahl1Zustand = 2;
            zahl2 = 0;
            zahl2Zustand = 0;
            txtAnzeige.Text = resultat.ToString("#,##0.#####");
            NormierungEingabe(false);
        }

        private void btnQuadrat_Click(object sender, EventArgs e)
        {
            txtAnzeige.Focus();
            double ergebnis = 0;
            if (bearbeiteZahl == 1 && zahl1Zustand == 0
                || bearbeiteZahl == 2 && zahl2Zustand == 0)
            {
                if (!Umwandlung("btnQuadrat_Click")) { return; }
                ergebnis = zahl * zahl;
            }
            if (bearbeiteZahl == 1)
            {
                if (zahl1Zustand == 0)
                { zahl1 = ergebnis; zahl1Zustand = 1; }
                else
                {
                    ergebnis = zahl1 * zahl1; zahl1Zustand = 1; zahl1 = ergebnis;
                }
            }
            else
            {
                if (zahl2Zustand == 0)
                { zahl2 = ergebnis; zahl2Zustand = 1; }
                else
                { ergebnis = zahl2 * zahl2; zahl2Zustand = 1; zahl2 = ergebnis; }
            }
            if (folgeAktion) { AenderZahl1(ergebnis); }
            txtAnzeige.Text = ergebnis.ToString("#,##0.#####"); // 5 Kommastellen möglich
            txtAnzeige.Select(txtAnzeige.Text.Length, 0);
        }

        private void btnWurzel_Click(object sender, EventArgs e)
        {
            txtAnzeige.Focus();
            double ergebnis = 0;
            if (bearbeiteZahl == 1 && zahl1Zustand == 0
                || bearbeiteZahl == 2 && zahl2Zustand == 0)
            {
                if (!Umwandlung("btnWurzel_Click")) { return; }
                if (zahl < 0) { MessageBox.Show("Wurzelziehen aus negativen Zahlen nicht möglich"); return; }
                ergebnis = Math.Sqrt(zahl);
            }
            if (bearbeiteZahl == 1)
            {
                if (zahl1Zustand == 0)
                { zahl1 = ergebnis; zahl1Zustand = 1; }
                else
                {
                    if (zahl1 < 0) { MessageBox.Show("Wurzelziehen aus negativen Zahlen nicht möglich"); return; }
                    ergebnis = Math.Sqrt(zahl1); zahl1Zustand = 1; zahl1 = ergebnis;
                }
            }
            else
            {
                if (zahl2Zustand == 0)
                { zahl2 = ergebnis; zahl2Zustand = 1; }
                else
                {
                    if (zahl2 < 0) { MessageBox.Show("Wurzelziehen aus negativen Zahlen nicht möglich"); return; }
                    ergebnis = Math.Sqrt(zahl2); zahl2Zustand = 1; zahl2 = ergebnis;
                }
            }
            if (folgeAktion) { AenderZahl1(ergebnis); }
           txtAnzeige.Text = ergebnis.ToString("#,##0.#####"); // 5 Kommastellen möglich
            txtAnzeige.Select(txtAnzeige.Text.Length, 0);
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            txtAnzeige.Focus();
            double ergebnis = 0;
            if (bearbeiteZahl == 1 && zahl1Zustand == 0
               || bearbeiteZahl == 2 && zahl2Zustand == 0)
            {
                if (!Umwandlung("btnPlusMinus_Click")) { return; }
                ergebnis = zahl * -1;
            }
            if (bearbeiteZahl == 1)
            {
                if (zahl1Zustand == 0)
                { zahl1 = ergebnis; zahl1Zustand = 1; }
                else
                { ergebnis = zahl1 * -1; zahl1Zustand = 1; zahl1 = ergebnis; }
            }
            else
            {
                if (zahl2Zustand == 0)
                { zahl2 = ergebnis; zahl2Zustand = 1; }
                else
                { ergebnis = zahl2 * -1; zahl2Zustand = 1; zahl2 = ergebnis; }
            }
            if (folgeAktion) { AenderZahl1(ergebnis); }
           txtAnzeige.Text = ergebnis.ToString("#,##0.#####"); // 5 Kommastellen möglich
            txtAnzeige.Select(txtAnzeige.Text.Length, 0);
        }

        private void btnProzent_Click(object sender, EventArgs e)
        {
            txtAnzeige.Focus();
            double ergebnis = 0;
            if (folgeAktion || zahl2Zustand != 0) { operation = ' '; }
            if ((Double.TryParse(txtAnzeige.Text, out zahl2)))
            {
                switch (operation)
                {
                    case '+':
                        ergebnis = zahl1 + zahl1 / 100 * zahl2;
                        lblFormel.Text = zahl1 + " + " + zahl2 + "% = ";
                        break;
                    case '-':
                        ergebnis = zahl1 - zahl1 / 100 * zahl2;
                        lblFormel.Text = zahl1 + " - " + zahl2 + "% = ";
                        break;
                    case '*':
                        ergebnis = zahl1 / 100 * zahl2;
                        lblFormel.Text = zahl2 + "% von " + zahl1 + " = ";
                        break;
                    default:
                        MessageBox.Show("Folgende Vorgehensweise ist bei der Prozentrechnung zu beachten" +
                                        "\n1. Man kann sicherheitshalber vorher [C] betätigen" +
                                        "\n2. eine Zahl eingeben" +
                                        "\n3. eine der 3 Rechenarten [+], [-] oder [*] eingeben" +
                                        "\n4. eine zweite Zahl eingeben" +
                                        "\n5. [%] betätigen" +
                                        "\n6. Durch Eingabe einer Rechenart, kann das Ergebnis weiterverwendet werden");
                        //NormierungEingabe(true);
                        //NormiereBerechnung(true);
                        return;
                }
                txtAnzeige.Text = ergebnis.ToString();
                lblFormel.Text += txtAnzeige.Text;
                bearbeiteZahl = 1;
                zahl1 = ergebnis;
                zahl1Zustand = 1;
                zahl2Zustand = 0;
                folgeAktion = true;
                resultatText = txtAnzeige.Text;
                NormierungEingabe(false);
            }
            else
            {
                MessageBox.Show("Es wurde keine korrekte Zahl eingegeben!\nBitte wiederholen sie die Eingabe");
                txtAnzeige.Text = "";
            }
            txtAnzeige.Select(txtAnzeige.Text.Length, 0);
        }

        private void btnKehrwert_Click(object sender, EventArgs e)
        {
            txtAnzeige.Focus();
            double ergebnis = 0;
            if (bearbeiteZahl == 1 && zahl1Zustand == 0
              || bearbeiteZahl == 2 && zahl2Zustand == 0)
            {
                if (!Umwandlung("btnKehrwert_Click")) { return; }
                ergebnis = 1 / zahl;
            }
            if (bearbeiteZahl == 1)
            {
                if (zahl1Zustand == 0)
                { zahl1 = ergebnis; zahl1Zustand = 1; }
                else
                { ergebnis = 1 / zahl1; zahl1Zustand = 1; zahl1 = ergebnis; }
            }
            else
            {
                if (zahl2Zustand == 0)
                { zahl2 = ergebnis; zahl2Zustand = 1; }
                else
                { ergebnis = 1 / zahl2; zahl2Zustand = 1; zahl2 = ergebnis; }
            }
            if (folgeAktion) { AenderZahl1(ergebnis); }
            txtAnzeige.Text = ergebnis.ToString("#,##0.#####"); // 5 Kommastellen möglich
            txtAnzeige.Select(txtAnzeige.Text.Length, 0);
        }

        private void btnDel_Click(object sender, EventArgs e)
        { loescheZeichen(); }

        private void loescheZeichen()
        {
            txtAnzeige.Focus();
            if (txtAnzeige.Text != "")
            {
                txtAnzeige.Text = txtAnzeige.Text.Substring(0, txtAnzeige.Text.Length - 1);
                if (txtAnzeige.Text != "")
                {
                    if (!Umwandlung("loescheZeichen")) { return; }
                    txtAnzeige.Text = zahl.ToString("#,##0.#####");
                    txtAnzeige.Select(txtAnzeige.Text.Length, 0);
                }
                else
                {
                    zahl = 0;
                    txtAnzeige.Text = ("");
                }
                if (bearbeiteZahl == 1 || folgeAktion)
                { zahl1 = zahl; if (folgeAktion) { resultatText = txtAnzeige.Text; } }
                else
                { zahl2 = zahl; }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtAnzeige.Focus();
            txtAnzeige.Text = "";
            if (bearbeiteZahl == 1)
            { zahl1 = 0; zahl1Zustand = 0; }
            else
            {
                zahl2 = 0; zahl2Zustand = 0;
                if (folgeAktion)
                {
                    bearbeiteZahl = 1;
                    zahl1Zustand = 0;
                    folgeAktion = false;
                }
            }
            NormierungEingabe(true);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtAnzeige.Focus();
            NormierungEingabe(true);
            NormiereBerechnung(true);
        }

        private bool Umwandlung(string ursprung)
        {
            if ((Double.TryParse(txtAnzeige.Text, out zahl)))
            { return true; }  // kein Fehler
            else
            {

                MessageBox.Show("Methode = " + ursprung + "\n" + "Es wurde keine korrekte Zahl eingegeben!\nBitte wiederholen sie die Eingabe");
                txtAnzeige.Text = "";
                return false;   // Fehler
            }
        }

        private void AenderZahl1(double wert)
        {
            folgeAktion = false;
            NormiereBerechnung(false);
            bearbeiteZahl = 1;
            zahl1 = wert;
            zahl1Zustand = 1; txtAnzeige.Text = wert.ToString("#,##0.#####"); // 5 Kommastellen möglich
        }

        private void NormierungEingabe(bool zusatzLoeschung)
        {
            firstChar = true;
            kommaSperre = false;
            exponentSperre = false;
            if (zusatzLoeschung) { txtAnzeige.Text = ""; }
        }

        private void NormiereBerechnung(bool zusatzLoeschung)
        {
            bearbeiteZahl = 1;
            zahl1 = 0;
            zahl1Zustand = 0;
            zahl2 = 0;
            zahl2Zustand = 0;
            lblFormel.Text = "";
            resultat = 0;
            folgeAktion = false;
            if (zusatzLoeschung)
            {
                txtAnzeige.Text = "";
                operation = ' ';
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            // Wechsle die Farbe einige "M"-Buttons
            memory = 0;
            lblMemory.Text = "0";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtAnzeige.Text = memory.ToString();
            if (bearbeiteZahl == 1)
            { zahl1 = memory; zahl1Zustand = 1; }
            else
            { zahl2 = memory; zahl2Zustand = 1; }
            if (folgeAktion) { AenderZahl1(memory); }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            // Wechsle die Farbe einige "M"-Buttons
            if (bearbeiteZahl == 1 && zahl1Zustand == 0
               || bearbeiteZahl == 2 && zahl2Zustand == 0)
            {
                if (!Umwandlung(" btnMminus_Click")) { return; }
                memory = memory - zahl;
            }
            else
            if (bearbeiteZahl == 1)
            { memory = memory - zahl1; }
            else
            { memory = memory - zahl2; }
            lblMemory.Text = memory.ToString();
            txtAnzeige.Focus();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // Wechsle die Farbe einige "M"-Buttons
            if (bearbeiteZahl == 1 && zahl1Zustand == 0
               || bearbeiteZahl == 2 && zahl2Zustand == 0)
            {
                if (!Umwandlung("btnMplus_Click")) { return; }
                memory = memory + zahl;
            }
            else
            if (bearbeiteZahl == 1)
            { memory = memory + zahl1; }
            else
            { memory = memory + zahl2; }
            lblMemory.Text = memory.ToString();
            txtAnzeige.Focus();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            // Wechsle die Farbe einige "M"-Buttons
            if (bearbeiteZahl == 1 && zahl1Zustand == 0
               || bearbeiteZahl == 2 && zahl2Zustand == 0)
            {
                if (!Umwandlung("btnMS_Click")) { return; }
                memory = zahl;
            }
            else
            if (bearbeiteZahl == 1)
            { memory = zahl1; }
            else
            { memory = zahl2; }
            txtAnzeige.Focus();
            lblMemory.Text = memory.ToString();

        }
    }
}

