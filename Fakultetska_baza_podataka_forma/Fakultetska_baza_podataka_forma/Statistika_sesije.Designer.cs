namespace Fakultetska_baza_podataka_forma
{
    partial class Statistika_sesije
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.grafikon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_ukupno_vreme_ucenja = new System.Windows.Forms.Label();
            this.lbl_efektivno_vreme_ucenja = new System.Windows.Forms.Label();
            this.lbl_efikasnost = new System.Windows.Forms.Label();
            this.txt_ukupno_vreme = new System.Windows.Forms.TextBox();
            this.txt_efektivno_vreme = new System.Windows.Forms.TextBox();
            this.txt_efikasnost = new System.Windows.Forms.TextBox();
            this.btn_osvezi = new System.Windows.Forms.Button();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.lbl_predmet = new System.Windows.Forms.Label();
            this.labelа = new System.Windows.Forms.Label();
            this.lbl_od = new System.Windows.Forms.Label();
            this.lbl_do = new System.Windows.Forms.Label();
            this.datum_pocetka = new System.Windows.Forms.DateTimePicker();
            this.datum_zavrsetka = new System.Windows.Forms.DateTimePicker();
            this.lbl_test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafikon)).BeginInit();
            this.SuspendLayout();
            // 
            // grafikon
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.grafikon.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.grafikon.Legends.Add(legend3);
            this.grafikon.Location = new System.Drawing.Point(12, 237);
            this.grafikon.Name = "grafikon";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Green;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Укупно време учења";
            series5.XValueMember = "Датум и ефикасност";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.YValueMembers = "Укупно време";
            series5.YValuesPerPoint = 4;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Ефективно време учења";
            series6.XValueMember = "Датум и ефикасност";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.YValueMembers = "Ефективно време";
            series6.YValuesPerPoint = 4;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.grafikon.Series.Add(series5);
            this.grafikon.Series.Add(series6);
            this.grafikon.Size = new System.Drawing.Size(1900, 770);
            this.grafikon.TabIndex = 0;
            this.grafikon.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Време учења";
            this.grafikon.Titles.Add(title3);
            // 
            // lbl_ukupno_vreme_ucenja
            // 
            this.lbl_ukupno_vreme_ucenja.AutoSize = true;
            this.lbl_ukupno_vreme_ucenja.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ukupno_vreme_ucenja.Location = new System.Drawing.Point(843, 55);
            this.lbl_ukupno_vreme_ucenja.Name = "lbl_ukupno_vreme_ucenja";
            this.lbl_ukupno_vreme_ucenja.Size = new System.Drawing.Size(231, 29);
            this.lbl_ukupno_vreme_ucenja.TabIndex = 26;
            this.lbl_ukupno_vreme_ucenja.Text = "Укупно време учења:";
            // 
            // lbl_efektivno_vreme_ucenja
            // 
            this.lbl_efektivno_vreme_ucenja.AutoSize = true;
            this.lbl_efektivno_vreme_ucenja.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efektivno_vreme_ucenja.Location = new System.Drawing.Point(807, 101);
            this.lbl_efektivno_vreme_ucenja.Name = "lbl_efektivno_vreme_ucenja";
            this.lbl_efektivno_vreme_ucenja.Size = new System.Drawing.Size(267, 29);
            this.lbl_efektivno_vreme_ucenja.TabIndex = 28;
            this.lbl_efektivno_vreme_ucenja.Text = "Ефективно време учења:";
            // 
            // lbl_efikasnost
            // 
            this.lbl_efikasnost.AutoSize = true;
            this.lbl_efikasnost.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efikasnost.Location = new System.Drawing.Point(938, 146);
            this.lbl_efikasnost.Name = "lbl_efikasnost";
            this.lbl_efikasnost.Size = new System.Drawing.Size(136, 29);
            this.lbl_efikasnost.TabIndex = 29;
            this.lbl_efikasnost.Text = "Ефикасност:";
            // 
            // txt_ukupno_vreme
            // 
            this.txt_ukupno_vreme.Enabled = false;
            this.txt_ukupno_vreme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ukupno_vreme.Location = new System.Drawing.Point(1080, 52);
            this.txt_ukupno_vreme.Name = "txt_ukupno_vreme";
            this.txt_ukupno_vreme.Size = new System.Drawing.Size(100, 37);
            this.txt_ukupno_vreme.TabIndex = 30;
            // 
            // txt_efektivno_vreme
            // 
            this.txt_efektivno_vreme.Enabled = false;
            this.txt_efektivno_vreme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efektivno_vreme.Location = new System.Drawing.Point(1080, 98);
            this.txt_efektivno_vreme.Name = "txt_efektivno_vreme";
            this.txt_efektivno_vreme.Size = new System.Drawing.Size(100, 37);
            this.txt_efektivno_vreme.TabIndex = 31;
            // 
            // txt_efikasnost
            // 
            this.txt_efikasnost.Enabled = false;
            this.txt_efikasnost.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efikasnost.Location = new System.Drawing.Point(1080, 143);
            this.txt_efikasnost.Name = "txt_efikasnost";
            this.txt_efikasnost.Size = new System.Drawing.Size(100, 37);
            this.txt_efikasnost.TabIndex = 32;
            // 
            // btn_osvezi
            // 
            this.btn_osvezi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_osvezi.Location = new System.Drawing.Point(1283, 92);
            this.btn_osvezi.Name = "btn_osvezi";
            this.btn_osvezi.Size = new System.Drawing.Size(252, 46);
            this.btn_osvezi.TabIndex = 41;
            this.btn_osvezi.Text = "Освежи";
            this.btn_osvezi.UseVisualStyleBackColor = true;
            this.btn_osvezi.Click += new System.EventHandler(this.btn_osvezi_Click);
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(126, 12);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(621, 37);
            this.cmb_predmet.TabIndex = 43;
            this.cmb_predmet.SelectedValueChanged += new System.EventHandler(this.cmb_predmet_SelectedValueChanged);
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_predmet.Location = new System.Drawing.Point(11, 15);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(109, 29);
            this.lbl_predmet.TabIndex = 42;
            this.lbl_predmet.Text = "Предмет:";
            // 
            // labelа
            // 
            this.labelа.AutoSize = true;
            this.labelа.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelа.Location = new System.Drawing.Point(12, 74);
            this.labelа.Name = "labelа";
            this.labelа.Size = new System.Drawing.Size(213, 29);
            this.labelа.TabIndex = 44;
            this.labelа.Text = "Бирање интервала:";
            // 
            // lbl_od
            // 
            this.lbl_od.AutoSize = true;
            this.lbl_od.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_od.Location = new System.Drawing.Point(68, 141);
            this.lbl_od.Name = "lbl_od";
            this.lbl_od.Size = new System.Drawing.Size(41, 29);
            this.lbl_od.TabIndex = 45;
            this.lbl_od.Text = "Од";
            // 
            // lbl_do
            // 
            this.lbl_do.AutoSize = true;
            this.lbl_do.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_do.Location = new System.Drawing.Point(374, 141);
            this.lbl_do.Name = "lbl_do";
            this.lbl_do.Size = new System.Drawing.Size(39, 29);
            this.lbl_do.TabIndex = 46;
            this.lbl_do.Text = "до";
            // 
            // datum_pocetka
            // 
            this.datum_pocetka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum_pocetka.Location = new System.Drawing.Point(115, 138);
            this.datum_pocetka.Name = "datum_pocetka";
            this.datum_pocetka.Size = new System.Drawing.Size(252, 37);
            this.datum_pocetka.TabIndex = 47;
            this.datum_pocetka.ValueChanged += new System.EventHandler(this.datum_pocetka_ValueChanged);
            // 
            // datum_zavrsetka
            // 
            this.datum_zavrsetka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum_zavrsetka.Location = new System.Drawing.Point(419, 138);
            this.datum_zavrsetka.Name = "datum_zavrsetka";
            this.datum_zavrsetka.Size = new System.Drawing.Size(252, 37);
            this.datum_zavrsetka.TabIndex = 48;
            this.datum_zavrsetka.ValueChanged += new System.EventHandler(this.datum_zavrsetka_ValueChanged);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_test.Location = new System.Drawing.Point(832, 15);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(0, 29);
            this.lbl_test.TabIndex = 49;
            // 
            // Statistika_sesije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 979);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.datum_zavrsetka);
            this.Controls.Add(this.datum_pocetka);
            this.Controls.Add(this.lbl_do);
            this.Controls.Add(this.lbl_od);
            this.Controls.Add(this.labelа);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.txt_efikasnost);
            this.Controls.Add(this.txt_efektivno_vreme);
            this.Controls.Add(this.txt_ukupno_vreme);
            this.Controls.Add(this.lbl_efikasnost);
            this.Controls.Add(this.lbl_efektivno_vreme_ucenja);
            this.Controls.Add(this.lbl_ukupno_vreme_ucenja);
            this.Controls.Add(this.grafikon);
            this.Name = "Statistika_sesije";
            this.Text = "Факултетска база података - статистика за сесије";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Statistika_sesije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafikon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafikon;
        private System.Windows.Forms.Label lbl_ukupno_vreme_ucenja;
        private System.Windows.Forms.Label lbl_efektivno_vreme_ucenja;
        private System.Windows.Forms.Label lbl_efikasnost;
        private System.Windows.Forms.TextBox txt_ukupno_vreme;
        private System.Windows.Forms.TextBox txt_efektivno_vreme;
        private System.Windows.Forms.TextBox txt_efikasnost;
        private System.Windows.Forms.Button btn_osvezi;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.Label lbl_predmet;
        private System.Windows.Forms.Label labelа;
        private System.Windows.Forms.Label lbl_od;
        private System.Windows.Forms.Label lbl_do;
        private System.Windows.Forms.DateTimePicker datum_pocetka;
        private System.Windows.Forms.DateTimePicker datum_zavrsetka;
        private System.Windows.Forms.Label lbl_test;
    }
}