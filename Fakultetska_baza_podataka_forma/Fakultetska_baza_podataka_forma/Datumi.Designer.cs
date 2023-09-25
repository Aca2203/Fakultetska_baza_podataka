namespace Fakultetska_baza_podataka_forma
{
    partial class Datumi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_podaci = new System.Windows.Forms.DataGridView();
            this.datum_zavrsetka = new System.Windows.Forms.DateTimePicker();
            this.datum_pocetka = new System.Windows.Forms.DateTimePicker();
            this.lbl_do = new System.Windows.Forms.Label();
            this.lbl_od = new System.Windows.Forms.Label();
            this.labelа = new System.Windows.Forms.Label();
            this.btn_osvezi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_podaci)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_podaci
            // 
            this.grid_podaci.AllowUserToAddRows = false;
            this.grid_podaci.AllowUserToDeleteRows = false;
            this.grid_podaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_podaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_podaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_podaci.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_podaci.Location = new System.Drawing.Point(430, 12);
            this.grid_podaci.Name = "grid_podaci";
            this.grid_podaci.ReadOnly = true;
            this.grid_podaci.Size = new System.Drawing.Size(139, 690);
            this.grid_podaci.TabIndex = 42;
            // 
            // datum_zavrsetka
            // 
            this.datum_zavrsetka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum_zavrsetka.Location = new System.Drawing.Point(76, 277);
            this.datum_zavrsetka.Name = "datum_zavrsetka";
            this.datum_zavrsetka.Size = new System.Drawing.Size(252, 37);
            this.datum_zavrsetka.TabIndex = 53;
            // 
            // datum_pocetka
            // 
            this.datum_pocetka.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum_pocetka.Location = new System.Drawing.Point(76, 168);
            this.datum_pocetka.Name = "datum_pocetka";
            this.datum_pocetka.Size = new System.Drawing.Size(252, 37);
            this.datum_pocetka.TabIndex = 52;
            // 
            // lbl_do
            // 
            this.lbl_do.AutoSize = true;
            this.lbl_do.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_do.Location = new System.Drawing.Point(175, 230);
            this.lbl_do.Name = "lbl_do";
            this.lbl_do.Size = new System.Drawing.Size(39, 29);
            this.lbl_do.TabIndex = 51;
            this.lbl_do.Text = "до";
            // 
            // lbl_od
            // 
            this.lbl_od.AutoSize = true;
            this.lbl_od.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_od.Location = new System.Drawing.Point(175, 115);
            this.lbl_od.Name = "lbl_od";
            this.lbl_od.Size = new System.Drawing.Size(41, 29);
            this.lbl_od.TabIndex = 50;
            this.lbl_od.Text = "Од";
            // 
            // labelа
            // 
            this.labelа.AutoSize = true;
            this.labelа.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelа.Location = new System.Drawing.Point(106, 72);
            this.labelа.Name = "labelа";
            this.labelа.Size = new System.Drawing.Size(180, 29);
            this.labelа.TabIndex = 49;
            this.labelа.Text = "Додавање дана:";
            // 
            // btn_osvezi
            // 
            this.btn_osvezi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_osvezi.Location = new System.Drawing.Point(76, 548);
            this.btn_osvezi.Name = "btn_osvezi";
            this.btn_osvezi.Size = new System.Drawing.Size(252, 46);
            this.btn_osvezi.TabIndex = 54;
            this.btn_osvezi.Text = "Освежи";
            this.btn_osvezi.UseVisualStyleBackColor = true;
            this.btn_osvezi.Click += new System.EventHandler(this.btn_osvezi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(76, 369);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(252, 46);
            this.btn_dodaj.TabIndex = 55;
            this.btn_dodaj.Text = "Додај дане";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // Datumi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 714);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_osvezi);
            this.Controls.Add(this.datum_zavrsetka);
            this.Controls.Add(this.datum_pocetka);
            this.Controls.Add(this.lbl_do);
            this.Controls.Add(this.lbl_od);
            this.Controls.Add(this.labelа);
            this.Controls.Add(this.grid_podaci);
            this.Name = "Datumi";
            this.Text = "Факултетска база података - датуми";
            this.Load += new System.EventHandler(this.Datumi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_podaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_podaci;
        private System.Windows.Forms.DateTimePicker datum_zavrsetka;
        private System.Windows.Forms.DateTimePicker datum_pocetka;
        private System.Windows.Forms.Label lbl_do;
        private System.Windows.Forms.Label lbl_od;
        private System.Windows.Forms.Label labelа;
        private System.Windows.Forms.Button btn_osvezi;
        private System.Windows.Forms.Button btn_dodaj;
    }
}