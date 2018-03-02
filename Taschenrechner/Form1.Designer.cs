namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAnzeige = new System.Windows.Forms.TextBox();
            this.buttonProzent = new System.Windows.Forms.Button();
            this.buttonWurzel = new System.Windows.Forms.Button();
            this.buttonQuadrat = new System.Windows.Forms.Button();
            this.buttonKehrwert = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonTeilen = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMultiplizieren = new System.Windows.Forms.Button();
            this.buttonSubtrahieren = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonAddieren = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonKomma = new System.Windows.Forms.Button();
            this.buttonGleich = new System.Windows.Forms.Button();
            this.labelFormel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAnzeige
            // 
            this.textBoxAnzeige.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnzeige.Location = new System.Drawing.Point(24, 29);
            this.textBoxAnzeige.Name = "textBoxAnzeige";
            this.textBoxAnzeige.Size = new System.Drawing.Size(218, 22);
            this.textBoxAnzeige.TabIndex = 0;
            this.textBoxAnzeige.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonProzent
            // 
            this.buttonProzent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProzent.Location = new System.Drawing.Point(24, 58);
            this.buttonProzent.Name = "buttonProzent";
            this.buttonProzent.Size = new System.Drawing.Size(50, 50);
            this.buttonProzent.TabIndex = 1;
            this.buttonProzent.Text = "%";
            this.buttonProzent.UseVisualStyleBackColor = true;
            this.buttonProzent.Click += new System.EventHandler(this.buttonProzent_Click);
            // 
            // buttonWurzel
            // 
            this.buttonWurzel.Font = new System.Drawing.Font("Symbol", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWurzel.Location = new System.Drawing.Point(80, 58);
            this.buttonWurzel.Name = "buttonWurzel";
            this.buttonWurzel.Size = new System.Drawing.Size(50, 50);
            this.buttonWurzel.TabIndex = 2;
            this.buttonWurzel.Text = "Ö";
            this.buttonWurzel.UseVisualStyleBackColor = true;
            this.buttonWurzel.Click += new System.EventHandler(this.buttonWurzel_Click);
            // 
            // buttonQuadrat
            // 
            this.buttonQuadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuadrat.Location = new System.Drawing.Point(136, 58);
            this.buttonQuadrat.Name = "buttonQuadrat";
            this.buttonQuadrat.Size = new System.Drawing.Size(50, 50);
            this.buttonQuadrat.TabIndex = 3;
            this.buttonQuadrat.Text = "x²";
            this.buttonQuadrat.UseVisualStyleBackColor = true;
            this.buttonQuadrat.Click += new System.EventHandler(this.buttonQuadrat_Click);
            // 
            // buttonKehrwert
            // 
            this.buttonKehrwert.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKehrwert.Location = new System.Drawing.Point(192, 58);
            this.buttonKehrwert.Name = "buttonKehrwert";
            this.buttonKehrwert.Size = new System.Drawing.Size(50, 50);
            this.buttonKehrwert.TabIndex = 4;
            this.buttonKehrwert.Text = "1/X";
            this.buttonKehrwert.UseVisualStyleBackColor = true;
            this.buttonKehrwert.Click += new System.EventHandler(this.buttonKehrwert_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(24, 114);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 50);
            this.buttonCE.TabIndex = 5;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(80, 114);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 50);
            this.buttonC.TabIndex = 6;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonDel.Location = new System.Drawing.Point(136, 114);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(50, 50);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "ï";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonTeilen
            // 
            this.buttonTeilen.Font = new System.Drawing.Font("Symbol", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonTeilen.Location = new System.Drawing.Point(192, 114);
            this.buttonTeilen.Name = "buttonTeilen";
            this.buttonTeilen.Size = new System.Drawing.Size(50, 50);
            this.buttonTeilen.TabIndex = 8;
            this.buttonTeilen.Text = "¸";
            this.buttonTeilen.UseVisualStyleBackColor = true;
            this.buttonTeilen.Click += new System.EventHandler(this.buttonTeilen_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(24, 170);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(80, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(136, 170);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplizieren
            // 
            this.buttonMultiplizieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplizieren.Location = new System.Drawing.Point(192, 170);
            this.buttonMultiplizieren.Name = "buttonMultiplizieren";
            this.buttonMultiplizieren.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiplizieren.TabIndex = 12;
            this.buttonMultiplizieren.Text = "X";
            this.buttonMultiplizieren.UseVisualStyleBackColor = true;
            this.buttonMultiplizieren.Click += new System.EventHandler(this.buttonMultiplizieren_Click);
            // 
            // buttonSubtrahieren
            // 
            this.buttonSubtrahieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtrahieren.Location = new System.Drawing.Point(192, 226);
            this.buttonSubtrahieren.Name = "buttonSubtrahieren";
            this.buttonSubtrahieren.Size = new System.Drawing.Size(50, 50);
            this.buttonSubtrahieren.TabIndex = 16;
            this.buttonSubtrahieren.Text = "-";
            this.buttonSubtrahieren.UseVisualStyleBackColor = true;
            this.buttonSubtrahieren.Click += new System.EventHandler(this.buttonSubtrahieren_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(136, 226);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(80, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(24, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonAddieren
            // 
            this.buttonAddieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddieren.Location = new System.Drawing.Point(192, 282);
            this.buttonAddieren.Name = "buttonAddieren";
            this.buttonAddieren.Size = new System.Drawing.Size(50, 50);
            this.buttonAddieren.TabIndex = 20;
            this.buttonAddieren.Text = "+";
            this.buttonAddieren.UseVisualStyleBackColor = true;
            this.buttonAddieren.Click += new System.EventHandler(this.buttonAddieren_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(136, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(80, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Font = new System.Drawing.Font("Symbol", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonPlusMinus.Location = new System.Drawing.Point(24, 338);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(50, 50);
            this.buttonPlusMinus.TabIndex = 21;
            this.buttonPlusMinus.Text = "±";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonPlusMinus_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(80, 338);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 22;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // buttonKomma
            // 
            this.buttonKomma.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKomma.Location = new System.Drawing.Point(136, 338);
            this.buttonKomma.Name = "buttonKomma";
            this.buttonKomma.Size = new System.Drawing.Size(50, 50);
            this.buttonKomma.TabIndex = 23;
            this.buttonKomma.Text = ",";
            this.buttonKomma.UseVisualStyleBackColor = true;
            // 
            // buttonGleich
            // 
            this.buttonGleich.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGleich.Location = new System.Drawing.Point(192, 338);
            this.buttonGleich.Name = "buttonGleich";
            this.buttonGleich.Size = new System.Drawing.Size(50, 50);
            this.buttonGleich.TabIndex = 24;
            this.buttonGleich.Text = "=";
            this.buttonGleich.UseVisualStyleBackColor = true;
            this.buttonGleich.Click += new System.EventHandler(this.buttonGleich_Click);
            // 
            // labelFormel
            // 
            this.labelFormel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFormel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelFormel.Location = new System.Drawing.Point(21, 9);
            this.labelFormel.Name = "labelFormel";
            this.labelFormel.Size = new System.Drawing.Size(220, 13);
            this.labelFormel.TabIndex = 25;
            this.labelFormel.Text = "22";
            this.labelFormel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 412);
            this.Controls.Add(this.labelFormel);
            this.Controls.Add(this.buttonGleich);
            this.Controls.Add(this.buttonKomma);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.buttonAddieren);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSubtrahieren);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonMultiplizieren);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonTeilen);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonKehrwert);
            this.Controls.Add(this.buttonQuadrat);
            this.Controls.Add(this.buttonWurzel);
            this.Controls.Add(this.buttonProzent);
            this.Controls.Add(this.textBoxAnzeige);
            this.Name = "Form1";
            this.Text = "Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAnzeige;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonKomma;
        private System.Windows.Forms.Button buttonGleich;
        private System.Windows.Forms.Button buttonTeilen;
        private System.Windows.Forms.Button buttonMultiplizieren;
        private System.Windows.Forms.Button buttonSubtrahieren;
        private System.Windows.Forms.Button buttonAddieren;
        private System.Windows.Forms.Button buttonProzent;
        private System.Windows.Forms.Button buttonWurzel;
        private System.Windows.Forms.Button buttonQuadrat;
        private System.Windows.Forms.Button buttonKehrwert;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Label labelFormel;
    }

}

