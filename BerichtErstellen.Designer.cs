namespace Zeiterfassung
{
    partial class frmBerichtErstellen
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.cmdErstellen = new System.Windows.Forms.Button();
            this.lblBericht = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(105, 46);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(208, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(105, 78);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(208, 20);
            this.dtpEnd.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(19, 46);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(80, 16);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start Datum:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(22, 78);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(77, 16);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End Datum:";
            // 
            // cmdErstellen
            // 
            this.cmdErstellen.Location = new System.Drawing.Point(15, 113);
            this.cmdErstellen.Name = "cmdErstellen";
            this.cmdErstellen.Size = new System.Drawing.Size(298, 33);
            this.cmdErstellen.TabIndex = 4;
            this.cmdErstellen.Text = "Bericht erstellen";
            this.cmdErstellen.UseVisualStyleBackColor = true;
            this.cmdErstellen.Click += new System.EventHandler(this.cmdErstellen_Click);
            // 
            // lblBericht
            // 
            this.lblBericht.AutoSize = true;
            this.lblBericht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBericht.Location = new System.Drawing.Point(11, 9);
            this.lblBericht.Name = "lblBericht";
            this.lblBericht.Size = new System.Drawing.Size(140, 20);
            this.lblBericht.TabIndex = 5;
            this.lblBericht.Text = "Bericht erstellen";
            // 
            // frmBerichtErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 161);
            this.Controls.Add(this.lblBericht);
            this.Controls.Add(this.cmdErstellen);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBerichtErstellen";
            this.Text = "Bericht Erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button cmdErstellen;
        private System.Windows.Forms.Label lblBericht;
    }
}