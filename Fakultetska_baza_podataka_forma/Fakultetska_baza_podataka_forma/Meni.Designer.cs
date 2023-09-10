namespace Fakultetska_baza_podataka_forma
{
    partial class Meni
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
            this.meni_traka = new System.Windows.Forms.MenuStrip();
            this.формеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сесијеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_tekst = new System.Windows.Forms.Label();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сесијеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.предметиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.meni_traka.SuspendLayout();
            this.SuspendLayout();
            // 
            // meni_traka
            // 
            this.meni_traka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формеToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.meni_traka.Location = new System.Drawing.Point(0, 0);
            this.meni_traka.Name = "meni_traka";
            this.meni_traka.Size = new System.Drawing.Size(524, 24);
            this.meni_traka.TabIndex = 0;
            this.meni_traka.Text = "menuStrip1";
            // 
            // формеToolStripMenuItem
            // 
            this.формеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сесијеToolStripMenuItem,
            this.предметиToolStripMenuItem});
            this.формеToolStripMenuItem.Name = "формеToolStripMenuItem";
            this.формеToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.формеToolStripMenuItem.Text = "Прегледи";
            // 
            // сесијеToolStripMenuItem
            // 
            this.сесијеToolStripMenuItem.Name = "сесијеToolStripMenuItem";
            this.сесијеToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.сесијеToolStripMenuItem.Text = "Сесије";
            this.сесијеToolStripMenuItem.Click += new System.EventHandler(this.сесијеToolStripMenuItem_Click);
            // 
            // предметиToolStripMenuItem
            // 
            this.предметиToolStripMenuItem.Name = "предметиToolStripMenuItem";
            this.предметиToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.предметиToolStripMenuItem.Text = "Предмети";
            this.предметиToolStripMenuItem.Click += new System.EventHandler(this.предметиToolStripMenuItem_Click);
            // 
            // lbl_tekst
            // 
            this.lbl_tekst.AutoSize = true;
            this.lbl_tekst.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tekst.Location = new System.Drawing.Point(47, 69);
            this.lbl_tekst.Name = "lbl_tekst";
            this.lbl_tekst.Size = new System.Drawing.Size(448, 29);
            this.lbl_tekst.TabIndex = 23;
            this.lbl_tekst.Text = "Добродошли у факултетску базу података!";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сесијеToolStripMenuItem1,
            this.предметиToolStripMenuItem1});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // сесијеToolStripMenuItem1
            // 
            this.сесијеToolStripMenuItem1.Name = "сесијеToolStripMenuItem1";
            this.сесијеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.сесијеToolStripMenuItem1.Text = "Сесије";
            this.сесијеToolStripMenuItem1.Click += new System.EventHandler(this.сесијеToolStripMenuItem1_Click);
            // 
            // предметиToolStripMenuItem1
            // 
            this.предметиToolStripMenuItem1.Name = "предметиToolStripMenuItem1";
            this.предметиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.предметиToolStripMenuItem1.Text = "Предмети";
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 162);
            this.Controls.Add(this.lbl_tekst);
            this.Controls.Add(this.meni_traka);
            this.MainMenuStrip = this.meni_traka;
            this.Name = "Meni";
            this.Text = "Факултетска база података - мени";
            this.meni_traka.ResumeLayout(false);
            this.meni_traka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip meni_traka;
        private System.Windows.Forms.ToolStripMenuItem формеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сесијеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметиToolStripMenuItem;
        private System.Windows.Forms.Label lbl_tekst;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сесијеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem предметиToolStripMenuItem1;
    }
}