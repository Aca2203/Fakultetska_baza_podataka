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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.grafikon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_ukupno_vreme_ucenja = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.lbl_efektivno_vreme_ucenja = new System.Windows.Forms.Label();
            this.lbl_efikasnost = new System.Windows.Forms.Label();
            this.txt_ukupno_vreme = new System.Windows.Forms.TextBox();
            this.txt_efektivno_vreme = new System.Windows.Forms.TextBox();
            this.txt_efikasnost = new System.Windows.Forms.TextBox();
            this.btn_osvezi = new System.Windows.Forms.Button();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.lbl_predmet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafikon)).BeginInit();
            this.SuspendLayout();
            // 
            // grafikon
            // 
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.grafikon.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafikon.Legends.Add(legend2);
            this.grafikon.Location = new System.Drawing.Point(12, 237);
            this.grafikon.Name = "grafikon";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Green;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Укупно време учења";
            series3.XValueMember = "Датум и ефикасност";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.YValueMembers = "Укупно време";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Ефективно време учења";
            series4.XValueMember = "Датум и ефикасност";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.YValueMembers = "Ефективно време";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.grafikon.Series.Add(series3);
            this.grafikon.Series.Add(series4);
            this.grafikon.Size = new System.Drawing.Size(1577, 730);
            this.grafikon.TabIndex = 0;
            this.grafikon.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Време учења";
            this.grafikon.Titles.Add(title2);
            // 
            // lbl_ukupno_vreme_ucenja
            // 
            this.lbl_ukupno_vreme_ucenja.AutoSize = true;
            this.lbl_ukupno_vreme_ucenja.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ukupno_vreme_ucenja.Location = new System.Drawing.Point(126, 86);
            this.lbl_ukupno_vreme_ucenja.Name = "lbl_ukupno_vreme_ucenja";
            this.lbl_ukupno_vreme_ucenja.Size = new System.Drawing.Size(231, 29);
            this.lbl_ukupno_vreme_ucenja.TabIndex = 26;
            this.lbl_ukupno_vreme_ucenja.Text = "Укупно време учења:";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.Location = new System.Drawing.Point(175, 11);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(223, 29);
            this.labela.TabIndex = 27;
            this.labela.Text = "У последњих 7 дана:";
            // 
            // lbl_efektivno_vreme_ucenja
            // 
            this.lbl_efektivno_vreme_ucenja.AutoSize = true;
            this.lbl_efektivno_vreme_ucenja.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efektivno_vreme_ucenja.Location = new System.Drawing.Point(90, 132);
            this.lbl_efektivno_vreme_ucenja.Name = "lbl_efektivno_vreme_ucenja";
            this.lbl_efektivno_vreme_ucenja.Size = new System.Drawing.Size(267, 29);
            this.lbl_efektivno_vreme_ucenja.TabIndex = 28;
            this.lbl_efektivno_vreme_ucenja.Text = "Ефективно време учења:";
            // 
            // lbl_efikasnost
            // 
            this.lbl_efikasnost.AutoSize = true;
            this.lbl_efikasnost.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efikasnost.Location = new System.Drawing.Point(221, 177);
            this.lbl_efikasnost.Name = "lbl_efikasnost";
            this.lbl_efikasnost.Size = new System.Drawing.Size(136, 29);
            this.lbl_efikasnost.TabIndex = 29;
            this.lbl_efikasnost.Text = "Ефикасност:";
            // 
            // txt_ukupno_vreme
            // 
            this.txt_ukupno_vreme.Enabled = false;
            this.txt_ukupno_vreme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ukupno_vreme.Location = new System.Drawing.Point(363, 83);
            this.txt_ukupno_vreme.Name = "txt_ukupno_vreme";
            this.txt_ukupno_vreme.Size = new System.Drawing.Size(100, 37);
            this.txt_ukupno_vreme.TabIndex = 30;
            // 
            // txt_efektivno_vreme
            // 
            this.txt_efektivno_vreme.Enabled = false;
            this.txt_efektivno_vreme.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efektivno_vreme.Location = new System.Drawing.Point(363, 129);
            this.txt_efektivno_vreme.Name = "txt_efektivno_vreme";
            this.txt_efektivno_vreme.Size = new System.Drawing.Size(100, 37);
            this.txt_efektivno_vreme.TabIndex = 31;
            // 
            // txt_efikasnost
            // 
            this.txt_efikasnost.Enabled = false;
            this.txt_efikasnost.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efikasnost.Location = new System.Drawing.Point(363, 174);
            this.txt_efikasnost.Name = "txt_efikasnost";
            this.txt_efikasnost.Size = new System.Drawing.Size(100, 37);
            this.txt_efikasnost.TabIndex = 32;
            // 
            // btn_osvezi
            // 
            this.btn_osvezi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_osvezi.Location = new System.Drawing.Point(766, 115);
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
            this.cmb_predmet.Location = new System.Drawing.Point(663, 8);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(621, 37);
            this.cmb_predmet.TabIndex = 43;
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_predmet.Location = new System.Drawing.Point(548, 11);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(109, 29);
            this.lbl_predmet.TabIndex = 42;
            this.lbl_predmet.Text = "Предмет:";
            // 
            // Statistika_sesije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 979);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.txt_efikasnost);
            this.Controls.Add(this.txt_efektivno_vreme);
            this.Controls.Add(this.txt_ukupno_vreme);
            this.Controls.Add(this.lbl_efikasnost);
            this.Controls.Add(this.lbl_efektivno_vreme_ucenja);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.lbl_ukupno_vreme_ucenja);
            this.Controls.Add(this.grafikon);
            this.Name = "Statistika_sesije";
            this.Text = "Факултетска база података - статистика за сесије";
            this.Load += new System.EventHandler(this.Statistika_sesije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafikon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafikon;
        private System.Windows.Forms.Label lbl_ukupno_vreme_ucenja;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label lbl_efektivno_vreme_ucenja;
        private System.Windows.Forms.Label lbl_efikasnost;
        private System.Windows.Forms.TextBox txt_ukupno_vreme;
        private System.Windows.Forms.TextBox txt_efektivno_vreme;
        private System.Windows.Forms.TextBox txt_efikasnost;
        private System.Windows.Forms.Button btn_osvezi;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.Label lbl_predmet;
    }
}