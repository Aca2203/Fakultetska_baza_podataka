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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.grafikon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_ukupno_vreme_ucenja = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.lbl_ukupno_efektivno_vreme_ucenja = new System.Windows.Forms.Label();
            this.lbl_efikasnost = new System.Windows.Forms.Label();
            this.txt_ukupno_vreme = new System.Windows.Forms.TextBox();
            this.txt_efektivno_vreme = new System.Windows.Forms.TextBox();
            this.txt_efikasnost = new System.Windows.Forms.TextBox();
            this.btn_osvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafikon)).BeginInit();
            this.SuspendLayout();
            // 
            // grafikon
            // 
            chartArea1.Name = "ChartArea1";
            this.grafikon.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafikon.Legends.Add(legend1);
            this.grafikon.Location = new System.Drawing.Point(12, 237);
            this.grafikon.Name = "grafikon";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Укупно време учења";
            series1.XValueMember = "Датум";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "Укупно време";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Ефективно време учења";
            series2.XValueMember = "Датум";
            series2.YValueMembers = "Ефективно време";
            this.grafikon.Series.Add(series1);
            this.grafikon.Series.Add(series2);
            this.grafikon.Size = new System.Drawing.Size(1132, 467);
            this.grafikon.TabIndex = 0;
            this.grafikon.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Време учења";
            this.grafikon.Titles.Add(title1);
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
            // lbl_ukupno_efektivno_vreme_ucenja
            // 
            this.lbl_ukupno_efektivno_vreme_ucenja.AutoSize = true;
            this.lbl_ukupno_efektivno_vreme_ucenja.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ukupno_efektivno_vreme_ucenja.Location = new System.Drawing.Point(11, 132);
            this.lbl_ukupno_efektivno_vreme_ucenja.Name = "lbl_ukupno_efektivno_vreme_ucenja";
            this.lbl_ukupno_efektivno_vreme_ucenja.Size = new System.Drawing.Size(346, 29);
            this.lbl_ukupno_efektivno_vreme_ucenja.TabIndex = 28;
            this.lbl_ukupno_efektivno_vreme_ucenja.Text = "Укупно ефективно време учења:";
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
            this.btn_osvezi.Location = new System.Drawing.Point(761, 96);
            this.btn_osvezi.Name = "btn_osvezi";
            this.btn_osvezi.Size = new System.Drawing.Size(252, 46);
            this.btn_osvezi.TabIndex = 41;
            this.btn_osvezi.Text = "Освежи";
            this.btn_osvezi.UseVisualStyleBackColor = true;
            this.btn_osvezi.Click += new System.EventHandler(this.btn_osvezi_Click);
            // 
            // Statistika_sesije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 716);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.txt_efikasnost);
            this.Controls.Add(this.txt_efektivno_vreme);
            this.Controls.Add(this.txt_ukupno_vreme);
            this.Controls.Add(this.lbl_efikasnost);
            this.Controls.Add(this.lbl_ukupno_efektivno_vreme_ucenja);
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
        private System.Windows.Forms.Label lbl_ukupno_efektivno_vreme_ucenja;
        private System.Windows.Forms.Label lbl_efikasnost;
        private System.Windows.Forms.TextBox txt_ukupno_vreme;
        private System.Windows.Forms.TextBox txt_efektivno_vreme;
        private System.Windows.Forms.TextBox txt_efikasnost;
        private System.Windows.Forms.Button btn_osvezi;
    }
}