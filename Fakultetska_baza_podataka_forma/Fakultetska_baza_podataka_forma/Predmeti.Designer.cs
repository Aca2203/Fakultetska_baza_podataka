namespace Fakultetska_baza_podataka_forma
{
    partial class Predmeti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_podaci = new System.Windows.Forms.DataGridView();
            this.btn_osvezi = new System.Windows.Forms.Button();
            this.btn_obrisi_predmet = new System.Windows.Forms.Button();
            this.btn_izmeni_predmet = new System.Windows.Forms.Button();
            this.btn_unesi_predmet = new System.Windows.Forms.Button();
            this.txt_poruka = new System.Windows.Forms.RichTextBox();
            this.txt_espb = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_poruka = new System.Windows.Forms.Label();
            this.lbl_tezina = new System.Windows.Forms.Label();
            this.lbl_espb = new System.Windows.Forms.Label();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.lbl_semestar = new System.Windows.Forms.Label();
            this.cmb_semestar = new System.Windows.Forms.ComboBox();
            this.cmb_tezina = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_podaci)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_podaci
            // 
            this.grid_podaci.AllowUserToAddRows = false;
            this.grid_podaci.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_podaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_podaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_podaci.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid_podaci.Location = new System.Drawing.Point(12, 267);
            this.grid_podaci.Name = "grid_podaci";
            this.grid_podaci.ReadOnly = true;
            this.grid_podaci.Size = new System.Drawing.Size(1191, 478);
            this.grid_podaci.TabIndex = 41;
            this.grid_podaci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_podaci_CellClick);
            // 
            // btn_osvezi
            // 
            this.btn_osvezi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_osvezi.Location = new System.Drawing.Point(932, 215);
            this.btn_osvezi.Name = "btn_osvezi";
            this.btn_osvezi.Size = new System.Drawing.Size(252, 46);
            this.btn_osvezi.TabIndex = 40;
            this.btn_osvezi.Text = "Освежи";
            this.btn_osvezi.UseVisualStyleBackColor = true;
            this.btn_osvezi.Click += new System.EventHandler(this.btn_osvezi_Click);
            // 
            // btn_obrisi_predmet
            // 
            this.btn_obrisi_predmet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi_predmet.Location = new System.Drawing.Point(932, 163);
            this.btn_obrisi_predmet.Name = "btn_obrisi_predmet";
            this.btn_obrisi_predmet.Size = new System.Drawing.Size(252, 46);
            this.btn_obrisi_predmet.TabIndex = 39;
            this.btn_obrisi_predmet.Text = "Обриши предмет";
            this.btn_obrisi_predmet.UseVisualStyleBackColor = true;
            this.btn_obrisi_predmet.Click += new System.EventHandler(this.btn_obrisi_predmet_Click);
            // 
            // btn_izmeni_predmet
            // 
            this.btn_izmeni_predmet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni_predmet.Location = new System.Drawing.Point(932, 111);
            this.btn_izmeni_predmet.Name = "btn_izmeni_predmet";
            this.btn_izmeni_predmet.Size = new System.Drawing.Size(252, 46);
            this.btn_izmeni_predmet.TabIndex = 38;
            this.btn_izmeni_predmet.Text = "Измени предмет";
            this.btn_izmeni_predmet.UseVisualStyleBackColor = true;
            this.btn_izmeni_predmet.Click += new System.EventHandler(this.btn_izmeni_predmet_Click);
            // 
            // btn_unesi_predmet
            // 
            this.btn_unesi_predmet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unesi_predmet.Location = new System.Drawing.Point(932, 61);
            this.btn_unesi_predmet.Name = "btn_unesi_predmet";
            this.btn_unesi_predmet.Size = new System.Drawing.Size(252, 46);
            this.btn_unesi_predmet.TabIndex = 37;
            this.btn_unesi_predmet.Text = "Унеси предмет";
            this.btn_unesi_predmet.UseVisualStyleBackColor = true;
            this.btn_unesi_predmet.Click += new System.EventHandler(this.btn_unesi_predmet_Click);
            // 
            // txt_poruka
            // 
            this.txt_poruka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_poruka.Location = new System.Drawing.Point(12, 80);
            this.txt_poruka.Name = "txt_poruka";
            this.txt_poruka.Size = new System.Drawing.Size(570, 181);
            this.txt_poruka.TabIndex = 34;
            this.txt_poruka.Text = "";
            // 
            // txt_espb
            // 
            this.txt_espb.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_espb.Location = new System.Drawing.Point(747, 121);
            this.txt_espb.Name = "txt_espb";
            this.txt_espb.Size = new System.Drawing.Size(100, 37);
            this.txt_espb.TabIndex = 32;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(58, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(40, 33);
            this.txt_id.TabIndex = 29;
            // 
            // lbl_poruka
            // 
            this.lbl_poruka.AutoSize = true;
            this.lbl_poruka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poruka.Location = new System.Drawing.Point(12, 48);
            this.lbl_poruka.Name = "lbl_poruka";
            this.lbl_poruka.Size = new System.Drawing.Size(94, 29);
            this.lbl_poruka.TabIndex = 28;
            this.lbl_poruka.Text = "Порука:";
            // 
            // lbl_tezina
            // 
            this.lbl_tezina.AutoSize = true;
            this.lbl_tezina.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tezina.Location = new System.Drawing.Point(645, 169);
            this.lbl_tezina.Name = "lbl_tezina";
            this.lbl_tezina.Size = new System.Drawing.Size(96, 29);
            this.lbl_tezina.TabIndex = 27;
            this.lbl_tezina.Text = "Тежина:";
            // 
            // lbl_espb
            // 
            this.lbl_espb.AutoSize = true;
            this.lbl_espb.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_espb.Location = new System.Drawing.Point(675, 125);
            this.lbl_espb.Name = "lbl_espb";
            this.lbl_espb.Size = new System.Drawing.Size(66, 29);
            this.lbl_espb.TabIndex = 26;
            this.lbl_espb.Text = "Еспб:";
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_godina.Location = new System.Drawing.Point(742, 14);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(89, 29);
            this.lbl_godina.TabIndex = 24;
            this.lbl_godina.Text = "Година:";
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naziv.Location = new System.Drawing.Point(112, 14);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(81, 29);
            this.lbl_naziv.TabIndex = 22;
            this.lbl_naziv.Text = "Назив:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 14);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(40, 29);
            this.lbl_id.TabIndex = 21;
            this.lbl_id.Text = "ID:";
            // 
            // txt_naziv
            // 
            this.txt_naziv.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_naziv.Location = new System.Drawing.Point(199, 11);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(483, 37);
            this.txt_naziv.TabIndex = 42;
            // 
            // cmb_godina
            // 
            this.cmb_godina.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(837, 9);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(86, 37);
            this.cmb_godina.TabIndex = 43;
            // 
            // lbl_semestar
            // 
            this.lbl_semestar.AutoSize = true;
            this.lbl_semestar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semestar.Location = new System.Drawing.Point(946, 14);
            this.lbl_semestar.Name = "lbl_semestar";
            this.lbl_semestar.Size = new System.Drawing.Size(116, 29);
            this.lbl_semestar.TabIndex = 44;
            this.lbl_semestar.Text = "Семестар:";
            // 
            // cmb_semestar
            // 
            this.cmb_semestar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_semestar.FormattingEnabled = true;
            this.cmb_semestar.Location = new System.Drawing.Point(1068, 9);
            this.cmb_semestar.Name = "cmb_semestar";
            this.cmb_semestar.Size = new System.Drawing.Size(86, 37);
            this.cmb_semestar.TabIndex = 45;
            // 
            // cmb_tezina
            // 
            this.cmb_tezina.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tezina.FormattingEnabled = true;
            this.cmb_tezina.Location = new System.Drawing.Point(747, 166);
            this.cmb_tezina.Name = "cmb_tezina";
            this.cmb_tezina.Size = new System.Drawing.Size(86, 37);
            this.cmb_tezina.TabIndex = 46;
            // 
            // Predmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 755);
            this.Controls.Add(this.cmb_tezina);
            this.Controls.Add(this.cmb_semestar);
            this.Controls.Add(this.lbl_semestar);
            this.Controls.Add(this.cmb_godina);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.grid_podaci);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.btn_obrisi_predmet);
            this.Controls.Add(this.btn_izmeni_predmet);
            this.Controls.Add(this.btn_unesi_predmet);
            this.Controls.Add(this.txt_poruka);
            this.Controls.Add(this.txt_espb);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_poruka);
            this.Controls.Add(this.lbl_tezina);
            this.Controls.Add(this.lbl_espb);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.lbl_id);
            this.Name = "Predmeti";
            this.Text = "Факултетска база података - предмети";
            this.Load += new System.EventHandler(this.Predmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_podaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_podaci;
        private System.Windows.Forms.Button btn_osvezi;
        private System.Windows.Forms.Button btn_obrisi_predmet;
        private System.Windows.Forms.Button btn_izmeni_predmet;
        private System.Windows.Forms.Button btn_unesi_predmet;
        private System.Windows.Forms.RichTextBox txt_poruka;
        private System.Windows.Forms.TextBox txt_espb;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_poruka;
        private System.Windows.Forms.Label lbl_tezina;
        private System.Windows.Forms.Label lbl_espb;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.Label lbl_semestar;
        private System.Windows.Forms.ComboBox cmb_semestar;
        private System.Windows.Forms.ComboBox cmb_tezina;
    }
}