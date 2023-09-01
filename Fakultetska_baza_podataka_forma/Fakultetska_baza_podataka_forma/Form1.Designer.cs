namespace Fakultetska_baza_podataka_forma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_predmet = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_vreme_pocetka = new System.Windows.Forms.Label();
            this.lbl_vreme_zavrsetka = new System.Windows.Forms.Label();
            this.lbl_ukupno_vreme = new System.Windows.Forms.Label();
            this.lbl_efektivno_vreme = new System.Windows.Forms.Label();
            this.lbl_poruka = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_vreme_pocetka = new System.Windows.Forms.TextBox();
            this.txt_vreme_zavrsetka = new System.Windows.Forms.TextBox();
            this.txt_ukupno_vreme = new System.Windows.Forms.TextBox();
            this.txt_efektivno_vreme = new System.Windows.Forms.TextBox();
            this.txt_poruka = new System.Windows.Forms.RichTextBox();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(13, 60);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(40, 29);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_predmet.Location = new System.Drawing.Point(121, 60);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(109, 29);
            this.lbl_predmet.TabIndex = 1;
            this.lbl_predmet.Text = "Предмет:";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum.Location = new System.Drawing.Point(863, 60);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(82, 29);
            this.lbl_datum.TabIndex = 2;
            this.lbl_datum.Text = "Датум:";
            // 
            // lbl_vreme_pocetka
            // 
            this.lbl_vreme_pocetka.AutoSize = true;
            this.lbl_vreme_pocetka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vreme_pocetka.Location = new System.Drawing.Point(40, 133);
            this.lbl_vreme_pocetka.Name = "lbl_vreme_pocetka";
            this.lbl_vreme_pocetka.Size = new System.Drawing.Size(171, 29);
            this.lbl_vreme_pocetka.TabIndex = 3;
            this.lbl_vreme_pocetka.Text = "Време почетка:";
            // 
            // lbl_vreme_zavrsetka
            // 
            this.lbl_vreme_zavrsetka.AutoSize = true;
            this.lbl_vreme_zavrsetka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vreme_zavrsetka.Location = new System.Drawing.Point(16, 181);
            this.lbl_vreme_zavrsetka.Name = "lbl_vreme_zavrsetka";
            this.lbl_vreme_zavrsetka.Size = new System.Drawing.Size(198, 29);
            this.lbl_vreme_zavrsetka.TabIndex = 4;
            this.lbl_vreme_zavrsetka.Text = "Време завршетка:";
            // 
            // lbl_ukupno_vreme
            // 
            this.lbl_ukupno_vreme.AutoSize = true;
            this.lbl_ukupno_vreme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ukupno_vreme.Location = new System.Drawing.Point(52, 227);
            this.lbl_ukupno_vreme.Name = "lbl_ukupno_vreme";
            this.lbl_ukupno_vreme.Size = new System.Drawing.Size(162, 29);
            this.lbl_ukupno_vreme.TabIndex = 5;
            this.lbl_ukupno_vreme.Text = "Укупно време:";
            // 
            // lbl_efektivno_vreme
            // 
            this.lbl_efektivno_vreme.AutoSize = true;
            this.lbl_efektivno_vreme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efektivno_vreme.Location = new System.Drawing.Point(14, 272);
            this.lbl_efektivno_vreme.Name = "lbl_efektivno_vreme";
            this.lbl_efektivno_vreme.Size = new System.Drawing.Size(198, 29);
            this.lbl_efektivno_vreme.TabIndex = 6;
            this.lbl_efektivno_vreme.Text = "Ефективно време:";
            // 
            // lbl_poruka
            // 
            this.lbl_poruka.AutoSize = true;
            this.lbl_poruka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poruka.Location = new System.Drawing.Point(333, 93);
            this.lbl_poruka.Name = "lbl_poruka";
            this.lbl_poruka.Size = new System.Drawing.Size(94, 29);
            this.lbl_poruka.TabIndex = 7;
            this.lbl_poruka.Text = "Порука:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(59, 60);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(40, 33);
            this.txt_id.TabIndex = 8;
            // 
            // txt_vreme_pocetka
            // 
            this.txt_vreme_pocetka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vreme_pocetka.Location = new System.Drawing.Point(217, 130);
            this.txt_vreme_pocetka.Name = "txt_vreme_pocetka";
            this.txt_vreme_pocetka.Size = new System.Drawing.Size(100, 37);
            this.txt_vreme_pocetka.TabIndex = 9;
            // 
            // txt_vreme_zavrsetka
            // 
            this.txt_vreme_zavrsetka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vreme_zavrsetka.Location = new System.Drawing.Point(217, 178);
            this.txt_vreme_zavrsetka.Name = "txt_vreme_zavrsetka";
            this.txt_vreme_zavrsetka.Size = new System.Drawing.Size(100, 37);
            this.txt_vreme_zavrsetka.TabIndex = 10;
            // 
            // txt_ukupno_vreme
            // 
            this.txt_ukupno_vreme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ukupno_vreme.Location = new System.Drawing.Point(217, 224);
            this.txt_ukupno_vreme.Name = "txt_ukupno_vreme";
            this.txt_ukupno_vreme.Size = new System.Drawing.Size(100, 37);
            this.txt_ukupno_vreme.TabIndex = 11;
            // 
            // txt_efektivno_vreme
            // 
            this.txt_efektivno_vreme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efektivno_vreme.Location = new System.Drawing.Point(217, 269);
            this.txt_efektivno_vreme.Name = "txt_efektivno_vreme";
            this.txt_efektivno_vreme.Size = new System.Drawing.Size(100, 37);
            this.txt_efektivno_vreme.TabIndex = 12;
            // 
            // txt_poruka
            // 
            this.txt_poruka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_poruka.Location = new System.Drawing.Point(338, 125);
            this.txt_poruka.Name = "txt_poruka";
            this.txt_poruka.Size = new System.Drawing.Size(570, 181);
            this.txt_poruka.TabIndex = 13;
            this.txt_poruka.Text = "";
            // 
            // datum
            // 
            this.datum.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum.Location = new System.Drawing.Point(951, 54);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(252, 37);
            this.datum.TabIndex = 14;
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(236, 57);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(621, 37);
            this.cmb_predmet.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(951, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Унеси сесију";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(951, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 46);
            this.button2.TabIndex = 17;
            this.button2.Text = "Унеси сесију";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(951, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 46);
            this.button3.TabIndex = 18;
            this.button3.Text = "Унеси сесију";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(951, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 46);
            this.button4.TabIndex = 19;
            this.button4.Text = "Унеси сесију";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 656);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.txt_poruka);
            this.Controls.Add(this.txt_efektivno_vreme);
            this.Controls.Add(this.txt_ukupno_vreme);
            this.Controls.Add(this.txt_vreme_zavrsetka);
            this.Controls.Add(this.txt_vreme_pocetka);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_poruka);
            this.Controls.Add(this.lbl_efektivno_vreme);
            this.Controls.Add(this.lbl_ukupno_vreme);
            this.Controls.Add(this.lbl_vreme_zavrsetka);
            this.Controls.Add(this.lbl_vreme_pocetka);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form1";
            this.Text = "Факултетска база података - сесије";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_predmet;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_vreme_pocetka;
        private System.Windows.Forms.Label lbl_vreme_zavrsetka;
        private System.Windows.Forms.Label lbl_ukupno_vreme;
        private System.Windows.Forms.Label lbl_efektivno_vreme;
        private System.Windows.Forms.Label lbl_poruka;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_vreme_pocetka;
        private System.Windows.Forms.TextBox txt_vreme_zavrsetka;
        private System.Windows.Forms.TextBox txt_ukupno_vreme;
        private System.Windows.Forms.TextBox txt_efektivno_vreme;
        private System.Windows.Forms.RichTextBox txt_poruka;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

