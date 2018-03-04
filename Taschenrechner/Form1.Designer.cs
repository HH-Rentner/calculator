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
            this.txtAnzeige = new System.Windows.Forms.TextBox();
            this.btnProzent = new System.Windows.Forms.Button();
            this.btnWurzel = new System.Windows.Forms.Button();
            this.btnQuadrat = new System.Windows.Forms.Button();
            this.btnKehrwert = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnTeilen = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMultiplizieren = new System.Windows.Forms.Button();
            this.btnSubtrahieren = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAddieren = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnKomma = new System.Windows.Forms.Button();
            this.btnGleich = new System.Windows.Forms.Button();
            this.lblFormel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnzeige
            // 
            this.txtAnzeige.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnzeige.Location = new System.Drawing.Point(24, 29);
            this.txtAnzeige.Name = "txtAnzeige";
            this.txtAnzeige.Size = new System.Drawing.Size(218, 22);
            this.txtAnzeige.TabIndex = 0;
            this.txtAnzeige.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProzent
            // 
            this.btnProzent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProzent.Location = new System.Drawing.Point(24, 58);
            this.btnProzent.Name = "btnProzent";
            this.btnProzent.Size = new System.Drawing.Size(50, 50);
            this.btnProzent.TabIndex = 1;
            this.btnProzent.Text = "%";
            this.btnProzent.UseVisualStyleBackColor = true;
            this.btnProzent.Click += new System.EventHandler(this.btnProzent_Click);
            // 
            // btnWurzel
            // 
            this.btnWurzel.Font = new System.Drawing.Font("Symbol", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWurzel.Location = new System.Drawing.Point(80, 58);
            this.btnWurzel.Name = "btnWurzel";
            this.btnWurzel.Size = new System.Drawing.Size(50, 50);
            this.btnWurzel.TabIndex = 2;
            this.btnWurzel.Text = "Ö";
            this.btnWurzel.UseVisualStyleBackColor = true;
            this.btnWurzel.Click += new System.EventHandler(this.btnWurzel_Click);
            // 
            // btnQuadrat
            // 
            this.btnQuadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrat.Location = new System.Drawing.Point(136, 58);
            this.btnQuadrat.Name = "btnQuadrat";
            this.btnQuadrat.Size = new System.Drawing.Size(50, 50);
            this.btnQuadrat.TabIndex = 3;
            this.btnQuadrat.Text = "x²";
            this.btnQuadrat.UseVisualStyleBackColor = true;
            this.btnQuadrat.Click += new System.EventHandler(this.btnQuadrat_Click);
            // 
            // btnKehrwert
            // 
            this.btnKehrwert.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKehrwert.Location = new System.Drawing.Point(192, 58);
            this.btnKehrwert.Name = "btnKehrwert";
            this.btnKehrwert.Size = new System.Drawing.Size(50, 50);
            this.btnKehrwert.TabIndex = 4;
            this.btnKehrwert.Text = "1/X";
            this.btnKehrwert.UseVisualStyleBackColor = true;
            this.btnKehrwert.Click += new System.EventHandler(this.btnKehrwert_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(24, 114);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(50, 50);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(80, 114);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDel.Location = new System.Drawing.Point(136, 114);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 50);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "ï";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnTeilen
            // 
            this.btnTeilen.Font = new System.Drawing.Font("Symbol", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnTeilen.Location = new System.Drawing.Point(192, 114);
            this.btnTeilen.Name = "btnTeilen";
            this.btnTeilen.Size = new System.Drawing.Size(50, 50);
            this.btnTeilen.TabIndex = 8;
            this.btnTeilen.Text = "¸";
            this.btnTeilen.UseVisualStyleBackColor = true;
            this.btnTeilen.Click += new System.EventHandler(this.btnTeilen_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(24, 170);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(80, 170);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(136, 170);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnMultiplizieren
            // 
            this.btnMultiplizieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplizieren.Location = new System.Drawing.Point(192, 170);
            this.btnMultiplizieren.Name = "btnMultiplizieren";
            this.btnMultiplizieren.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplizieren.TabIndex = 12;
            this.btnMultiplizieren.Text = "X";
            this.btnMultiplizieren.UseVisualStyleBackColor = true;
            this.btnMultiplizieren.Click += new System.EventHandler(this.btnMultiplizieren_Click);
            // 
            // btnSubtrahieren
            // 
            this.btnSubtrahieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrahieren.Location = new System.Drawing.Point(192, 226);
            this.btnSubtrahieren.Name = "btnSubtrahieren";
            this.btnSubtrahieren.Size = new System.Drawing.Size(50, 50);
            this.btnSubtrahieren.TabIndex = 16;
            this.btnSubtrahieren.Text = "-";
            this.btnSubtrahieren.UseVisualStyleBackColor = true;
            this.btnSubtrahieren.Click += new System.EventHandler(this.btnSubtrahieren_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(136, 226);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(80, 226);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(24, 226);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btnAddieren
            // 
            this.btnAddieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddieren.Location = new System.Drawing.Point(192, 282);
            this.btnAddieren.Name = "btnAddieren";
            this.btnAddieren.Size = new System.Drawing.Size(50, 50);
            this.btnAddieren.TabIndex = 20;
            this.btnAddieren.Text = "+";
            this.btnAddieren.UseVisualStyleBackColor = true;
            this.btnAddieren.Click += new System.EventHandler(this.btnAddieren_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(136, 282);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(80, 282);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(24, 282);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Symbol", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPlusMinus.Location = new System.Drawing.Point(24, 338);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(50, 50);
            this.btnPlusMinus.TabIndex = 21;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(80, 338);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 50);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnKomma
            // 
            this.btnKomma.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKomma.Location = new System.Drawing.Point(136, 338);
            this.btnKomma.Name = "btnKomma";
            this.btnKomma.Size = new System.Drawing.Size(50, 50);
            this.btnKomma.TabIndex = 23;
            this.btnKomma.Text = ",";
            this.btnKomma.UseVisualStyleBackColor = true;
            // 
            // btnGleich
            // 
            this.btnGleich.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGleich.Location = new System.Drawing.Point(192, 338);
            this.btnGleich.Name = "btnGleich";
            this.btnGleich.Size = new System.Drawing.Size(50, 50);
            this.btnGleich.TabIndex = 24;
            this.btnGleich.Text = "=";
            this.btnGleich.UseVisualStyleBackColor = true;
            this.btnGleich.Click += new System.EventHandler(this.btnGleich_Click);
            // 
            // lblFormel
            // 
            this.lblFormel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFormel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblFormel.Location = new System.Drawing.Point(21, 9);
            this.lblFormel.Name = "lblFormel";
            this.lblFormel.Size = new System.Drawing.Size(220, 13);
            this.lblFormel.TabIndex = 25;
            this.lblFormel.Text = "22";
            this.lblFormel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 412);
            this.Controls.Add(this.lblFormel);
            this.Controls.Add(this.btnGleich);
            this.Controls.Add(this.btnKomma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnAddieren);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSubtrahieren);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMultiplizieren);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnTeilen);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnKehrwert);
            this.Controls.Add(this.btnQuadrat);
            this.Controls.Add(this.btnWurzel);
            this.Controls.Add(this.btnProzent);
            this.Controls.Add(this.txtAnzeige);
            this.Name = "Form1";
            this.Text = "Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAnzeige;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnKomma;
        private System.Windows.Forms.Button btnGleich;
        private System.Windows.Forms.Button btnTeilen;
        private System.Windows.Forms.Button btnMultiplizieren;
        private System.Windows.Forms.Button btnSubtrahieren;
        private System.Windows.Forms.Button btnAddieren;
        private System.Windows.Forms.Button btnProzent;
        private System.Windows.Forms.Button btnWurzel;
        private System.Windows.Forms.Button btnQuadrat;
        private System.Windows.Forms.Button btnKehrwert;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Label lblFormel;
    }

}

