namespace Zeiterfassung
{
    partial class KatVerwaltung
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
            this.lbKat3 = new System.Windows.Forms.ListBox();
            this.lbKat2 = new System.Windows.Forms.ListBox();
            this.lbKat1 = new System.Windows.Forms.ListBox();
            this.tbKat1 = new System.Windows.Forms.TextBox();
            this.tbKat2 = new System.Windows.Forms.TextBox();
            this.tbKat3 = new System.Windows.Forms.TextBox();
            this.cmdKat1löschen = new System.Windows.Forms.Button();
            this.cmdKat2löschen = new System.Windows.Forms.Button();
            this.cmdKat3löschen = new System.Windows.Forms.Button();
            this.cmdKat3hinzu = new System.Windows.Forms.Button();
            this.cmdKat2hinzu = new System.Windows.Forms.Button();
            this.cmdKat1hinzu = new System.Windows.Forms.Button();
            this.lblKat1 = new System.Windows.Forms.Label();
            this.lblKat2 = new System.Windows.Forms.Label();
            this.lblKat3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKat3
            // 
            this.lbKat3.DisplayMember = "Kategorie3";
            this.lbKat3.FormattingEnabled = true;
            this.lbKat3.Location = new System.Drawing.Point(432, 43);
            this.lbKat3.Name = "lbKat3";
            this.lbKat3.Size = new System.Drawing.Size(204, 199);
            this.lbKat3.TabIndex = 3;
            this.lbKat3.ValueMember = "Kategorie3";
            // 
            // lbKat2
            // 
            this.lbKat2.DisplayMember = "Kategorie2";
            this.lbKat2.FormattingEnabled = true;
            this.lbKat2.Location = new System.Drawing.Point(222, 43);
            this.lbKat2.Name = "lbKat2";
            this.lbKat2.Size = new System.Drawing.Size(204, 199);
            this.lbKat2.TabIndex = 2;
            this.lbKat2.ValueMember = "Kategorie2";
            this.lbKat2.SelectedIndexChanged += new System.EventHandler(this.lbKat2_SelectedIndexChanged);
            // 
            // lbKat1
            // 
            this.lbKat1.DisplayMember = "Kategorie1";
            this.lbKat1.FormattingEnabled = true;
            this.lbKat1.Location = new System.Drawing.Point(12, 43);
            this.lbKat1.Name = "lbKat1";
            this.lbKat1.Size = new System.Drawing.Size(204, 199);
            this.lbKat1.TabIndex = 1;
            this.lbKat1.ValueMember = "Kategorie1";
            this.lbKat1.SelectedIndexChanged += new System.EventHandler(this.lbKat1_SelectedIndexChanged);
            // 
            // tbKat1
            // 
            this.tbKat1.Location = new System.Drawing.Point(15, 283);
            this.tbKat1.MaxLength = 30;
            this.tbKat1.Name = "tbKat1";
            this.tbKat1.Size = new System.Drawing.Size(200, 20);
            this.tbKat1.TabIndex = 4;
            // 
            // tbKat2
            // 
            this.tbKat2.Location = new System.Drawing.Point(222, 283);
            this.tbKat2.MaxLength = 30;
            this.tbKat2.Name = "tbKat2";
            this.tbKat2.Size = new System.Drawing.Size(204, 20);
            this.tbKat2.TabIndex = 5;
            // 
            // tbKat3
            // 
            this.tbKat3.Location = new System.Drawing.Point(432, 283);
            this.tbKat3.MaxLength = 30;
            this.tbKat3.Name = "tbKat3";
            this.tbKat3.Size = new System.Drawing.Size(204, 20);
            this.tbKat3.TabIndex = 6;
            // 
            // cmdKat1löschen
            // 
            this.cmdKat1löschen.Location = new System.Drawing.Point(15, 248);
            this.cmdKat1löschen.Name = "cmdKat1löschen";
            this.cmdKat1löschen.Size = new System.Drawing.Size(200, 29);
            this.cmdKat1löschen.TabIndex = 7;
            this.cmdKat1löschen.Text = "Kategorie löschen";
            this.cmdKat1löschen.UseVisualStyleBackColor = true;
            this.cmdKat1löschen.Click += new System.EventHandler(this.cmdKat1löschen_Click);
            // 
            // cmdKat2löschen
            // 
            this.cmdKat2löschen.Location = new System.Drawing.Point(222, 248);
            this.cmdKat2löschen.Name = "cmdKat2löschen";
            this.cmdKat2löschen.Size = new System.Drawing.Size(204, 29);
            this.cmdKat2löschen.TabIndex = 8;
            this.cmdKat2löschen.Text = "Kategorie löschen";
            this.cmdKat2löschen.UseVisualStyleBackColor = true;
            this.cmdKat2löschen.Click += new System.EventHandler(this.cmdKat2löschen_Click);
            // 
            // cmdKat3löschen
            // 
            this.cmdKat3löschen.Location = new System.Drawing.Point(432, 248);
            this.cmdKat3löschen.Name = "cmdKat3löschen";
            this.cmdKat3löschen.Size = new System.Drawing.Size(204, 29);
            this.cmdKat3löschen.TabIndex = 9;
            this.cmdKat3löschen.Text = "Kategorie löschen";
            this.cmdKat3löschen.UseVisualStyleBackColor = true;
            this.cmdKat3löschen.Click += new System.EventHandler(this.cmdKat3löschen_Click);
            // 
            // cmdKat3hinzu
            // 
            this.cmdKat3hinzu.Location = new System.Drawing.Point(432, 309);
            this.cmdKat3hinzu.Name = "cmdKat3hinzu";
            this.cmdKat3hinzu.Size = new System.Drawing.Size(204, 29);
            this.cmdKat3hinzu.TabIndex = 12;
            this.cmdKat3hinzu.Text = "Kategorie hinzufügen";
            this.cmdKat3hinzu.UseVisualStyleBackColor = true;
            this.cmdKat3hinzu.Click += new System.EventHandler(this.cmdKat3hinzu_Click);
            // 
            // cmdKat2hinzu
            // 
            this.cmdKat2hinzu.Location = new System.Drawing.Point(222, 309);
            this.cmdKat2hinzu.Name = "cmdKat2hinzu";
            this.cmdKat2hinzu.Size = new System.Drawing.Size(204, 29);
            this.cmdKat2hinzu.TabIndex = 11;
            this.cmdKat2hinzu.Text = "Kategorie hinzufügen";
            this.cmdKat2hinzu.UseVisualStyleBackColor = true;
            this.cmdKat2hinzu.Click += new System.EventHandler(this.cmdKat2hinzu_Click);
            // 
            // cmdKat1hinzu
            // 
            this.cmdKat1hinzu.Location = new System.Drawing.Point(15, 309);
            this.cmdKat1hinzu.Name = "cmdKat1hinzu";
            this.cmdKat1hinzu.Size = new System.Drawing.Size(200, 29);
            this.cmdKat1hinzu.TabIndex = 10;
            this.cmdKat1hinzu.Text = "Kategorie hinzufügen";
            this.cmdKat1hinzu.UseVisualStyleBackColor = true;
            this.cmdKat1hinzu.Click += new System.EventHandler(this.cmdKat1hinzu_Click);
            // 
            // lblKat1
            // 
            this.lblKat1.AutoSize = true;
            this.lblKat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKat1.Location = new System.Drawing.Point(12, 9);
            this.lblKat1.Name = "lblKat1";
            this.lblKat1.Size = new System.Drawing.Size(101, 20);
            this.lblKat1.TabIndex = 13;
            this.lblKat1.Text = "Kategorie 1";
            // 
            // lblKat2
            // 
            this.lblKat2.AutoSize = true;
            this.lblKat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKat2.Location = new System.Drawing.Point(219, 9);
            this.lblKat2.Name = "lblKat2";
            this.lblKat2.Size = new System.Drawing.Size(101, 20);
            this.lblKat2.TabIndex = 14;
            this.lblKat2.Text = "Kategorie 2";
            // 
            // lblKat3
            // 
            this.lblKat3.AutoSize = true;
            this.lblKat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKat3.Location = new System.Drawing.Point(429, 9);
            this.lblKat3.Name = "lblKat3";
            this.lblKat3.Size = new System.Drawing.Size(101, 20);
            this.lblKat3.TabIndex = 15;
            this.lblKat3.Text = "Kategorie 3";
            // 
            // KatVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(653, 353);
            this.Controls.Add(this.lblKat3);
            this.Controls.Add(this.lblKat2);
            this.Controls.Add(this.lblKat1);
            this.Controls.Add(this.cmdKat3hinzu);
            this.Controls.Add(this.cmdKat2hinzu);
            this.Controls.Add(this.cmdKat1hinzu);
            this.Controls.Add(this.cmdKat3löschen);
            this.Controls.Add(this.cmdKat2löschen);
            this.Controls.Add(this.cmdKat1löschen);
            this.Controls.Add(this.tbKat3);
            this.Controls.Add(this.tbKat2);
            this.Controls.Add(this.tbKat1);
            this.Controls.Add(this.lbKat3);
            this.Controls.Add(this.lbKat2);
            this.Controls.Add(this.lbKat1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KatVerwaltung";
            this.Text = "Kategorien Verwalten";
            this.Load += new System.EventHandler(this.KatVerwaltung_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KatVerwaltung_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKat3;
        private System.Windows.Forms.ListBox lbKat2;
        private System.Windows.Forms.ListBox lbKat1;
        private System.Windows.Forms.TextBox tbKat1;
        private System.Windows.Forms.TextBox tbKat2;
        private System.Windows.Forms.TextBox tbKat3;
        private System.Windows.Forms.Button cmdKat1löschen;
        private System.Windows.Forms.Button cmdKat2löschen;
        private System.Windows.Forms.Button cmdKat3löschen;
        private System.Windows.Forms.Button cmdKat3hinzu;
        private System.Windows.Forms.Button cmdKat2hinzu;
        private System.Windows.Forms.Button cmdKat1hinzu;
        private System.Windows.Forms.Label lblKat1;
        private System.Windows.Forms.Label lblKat2;
        private System.Windows.Forms.Label lblKat3;
    }
}