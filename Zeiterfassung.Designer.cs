namespace Zeiterfassung
{
    partial class frmStart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mcKalender = new System.Windows.Forms.MonthCalendar();
            this.gbTätigkeit = new System.Windows.Forms.GroupBox();
            this.lblArbeitszeit = new System.Windows.Forms.Label();
            this.rbFrei = new System.Windows.Forms.RadioButton();
            this.lblStdMin = new System.Windows.Forms.Label();
            this.rbUrlaub = new System.Windows.Forms.RadioButton();
            this.cbMinuten = new System.Windows.Forms.ComboBox();
            this.rbKrank = new System.Windows.Forms.RadioButton();
            this.rbArbeitstag = new System.Windows.Forms.RadioButton();
            this.cbStunden = new System.Windows.Forms.ComboBox();
            this.cmdEintragen = new System.Windows.Forms.Button();
            this.cmdVerwalten = new System.Windows.Forms.Button();
            this.lbKat3 = new System.Windows.Forms.ListBox();
            this.lbKat2 = new System.Windows.Forms.ListBox();
            this.lbKat1 = new System.Windows.Forms.ListBox();
            this.cmdBericht = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbCVJM = new System.Windows.Forms.PictureBox();
            this.gbBericht = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdEinstellungen = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dauerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvZeit = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zeiterfassungDataSet = new Zeiterfassung.ZeiterfassungDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeitTableAdapter = new Zeiterfassung.ZeiterfassungDataSetTableAdapters.ZeitTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbTätigkeit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCVJM)).BeginInit();
            this.gbBericht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZeit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeiterfassungDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcKalender
            // 
            this.mcKalender.Location = new System.Drawing.Point(18, 46);
            this.mcKalender.MaxSelectionCount = 1;
            this.mcKalender.Name = "mcKalender";
            this.mcKalender.TabIndex = 0;
            this.mcKalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcKalender_DateChanged);
            // 
            // gbTätigkeit
            // 
            this.gbTätigkeit.Controls.Add(this.lblArbeitszeit);
            this.gbTätigkeit.Controls.Add(this.rbFrei);
            this.gbTätigkeit.Controls.Add(this.lblStdMin);
            this.gbTätigkeit.Controls.Add(this.rbUrlaub);
            this.gbTätigkeit.Controls.Add(this.cbMinuten);
            this.gbTätigkeit.Controls.Add(this.rbKrank);
            this.gbTätigkeit.Controls.Add(this.rbArbeitstag);
            this.gbTätigkeit.Controls.Add(this.cbStunden);
            this.gbTätigkeit.Controls.Add(this.cmdEintragen);
            this.gbTätigkeit.Controls.Add(this.cmdVerwalten);
            this.gbTätigkeit.Controls.Add(this.lbKat3);
            this.gbTätigkeit.Controls.Add(this.lbKat2);
            this.gbTätigkeit.Controls.Add(this.lbKat1);
            this.gbTätigkeit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbTätigkeit.Location = new System.Drawing.Point(18, 220);
            this.gbTätigkeit.Name = "gbTätigkeit";
            this.gbTätigkeit.Size = new System.Drawing.Size(774, 230);
            this.gbTätigkeit.TabIndex = 1;
            this.gbTätigkeit.TabStop = false;
            this.gbTätigkeit.Text = "Tätigkeit";
            // 
            // lblArbeitszeit
            // 
            this.lblArbeitszeit.AutoSize = true;
            this.lblArbeitszeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbeitszeit.Location = new System.Drawing.Point(641, 110);
            this.lblArbeitszeit.Name = "lblArbeitszeit";
            this.lblArbeitszeit.Size = new System.Drawing.Size(74, 15);
            this.lblArbeitszeit.TabIndex = 6;
            this.lblArbeitszeit.Text = "Arbeitszeit";
            // 
            // rbFrei
            // 
            this.rbFrei.AutoSize = true;
            this.rbFrei.Location = new System.Drawing.Point(641, 88);
            this.rbFrei.Name = "rbFrei";
            this.rbFrei.Size = new System.Drawing.Size(73, 17);
            this.rbFrei.TabIndex = 0;
            this.rbFrei.Text = "Freier Tag";
            this.rbFrei.UseVisualStyleBackColor = true;
            this.rbFrei.CheckedChanged += new System.EventHandler(this.rbFrei_CheckedChanged);
            // 
            // lblStdMin
            // 
            this.lblStdMin.AutoSize = true;
            this.lblStdMin.Location = new System.Drawing.Point(716, 136);
            this.lblStdMin.Name = "lblStdMin";
            this.lblStdMin.Size = new System.Drawing.Size(49, 13);
            this.lblStdMin.TabIndex = 5;
            this.lblStdMin.Text = "Std : Min";
            // 
            // rbUrlaub
            // 
            this.rbUrlaub.AutoSize = true;
            this.rbUrlaub.Location = new System.Drawing.Point(641, 65);
            this.rbUrlaub.Name = "rbUrlaub";
            this.rbUrlaub.Size = new System.Drawing.Size(56, 17);
            this.rbUrlaub.TabIndex = 0;
            this.rbUrlaub.Text = "Urlaub";
            this.rbUrlaub.UseVisualStyleBackColor = true;
            this.rbUrlaub.CheckedChanged += new System.EventHandler(this.rbUrlaub_CheckedChanged);
            // 
            // cbMinuten
            // 
            this.cbMinuten.FormattingEnabled = true;
            this.cbMinuten.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cbMinuten.Location = new System.Drawing.Point(681, 133);
            this.cbMinuten.Name = "cbMinuten";
            this.cbMinuten.Size = new System.Drawing.Size(36, 21);
            this.cbMinuten.TabIndex = 4;
            this.cbMinuten.Text = "00";
            // 
            // rbKrank
            // 
            this.rbKrank.AutoSize = true;
            this.rbKrank.Location = new System.Drawing.Point(641, 42);
            this.rbKrank.Name = "rbKrank";
            this.rbKrank.Size = new System.Drawing.Size(90, 17);
            this.rbKrank.TabIndex = 0;
            this.rbKrank.Text = "Krankheitstag";
            this.rbKrank.UseVisualStyleBackColor = true;
            this.rbKrank.CheckedChanged += new System.EventHandler(this.rbKrank_CheckedChanged);
            // 
            // rbArbeitstag
            // 
            this.rbArbeitstag.AutoSize = true;
            this.rbArbeitstag.BackColor = System.Drawing.SystemColors.Control;
            this.rbArbeitstag.Checked = true;
            this.rbArbeitstag.Location = new System.Drawing.Point(641, 19);
            this.rbArbeitstag.Name = "rbArbeitstag";
            this.rbArbeitstag.Size = new System.Drawing.Size(72, 17);
            this.rbArbeitstag.TabIndex = 0;
            this.rbArbeitstag.TabStop = true;
            this.rbArbeitstag.Text = "Arbeitstag";
            this.rbArbeitstag.UseVisualStyleBackColor = false;
            this.rbArbeitstag.CheckedChanged += new System.EventHandler(this.rbArbeitstag_CheckedChanged);
            // 
            // cbStunden
            // 
            this.cbStunden.FormattingEnabled = true;
            this.cbStunden.Items.AddRange(new object[] {
            "0",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cbStunden.Location = new System.Drawing.Point(641, 133);
            this.cbStunden.Name = "cbStunden";
            this.cbStunden.Size = new System.Drawing.Size(36, 21);
            this.cbStunden.TabIndex = 4;
            this.cbStunden.Text = "00";
            // 
            // cmdEintragen
            // 
            this.cmdEintragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEintragen.Location = new System.Drawing.Point(641, 160);
            this.cmdEintragen.Name = "cmdEintragen";
            this.cmdEintragen.Size = new System.Drawing.Size(124, 58);
            this.cmdEintragen.TabIndex = 3;
            this.cmdEintragen.Text = "==> Eintragen";
            this.cmdEintragen.UseVisualStyleBackColor = true;
            this.cmdEintragen.Click += new System.EventHandler(this.cmdEintragen_Click);
            // 
            // cmdVerwalten
            // 
            this.cmdVerwalten.Location = new System.Drawing.Point(431, 188);
            this.cmdVerwalten.Name = "cmdVerwalten";
            this.cmdVerwalten.Size = new System.Drawing.Size(204, 30);
            this.cmdVerwalten.TabIndex = 1;
            this.cmdVerwalten.Text = "Kategorien verwalten";
            this.cmdVerwalten.UseVisualStyleBackColor = true;
            this.cmdVerwalten.Click += new System.EventHandler(this.cmdVerwalten_Click);
            // 
            // lbKat3
            // 
            this.lbKat3.DisplayMember = "Kategorie3";
            this.lbKat3.FormattingEnabled = true;
            this.lbKat3.Location = new System.Drawing.Point(431, 19);
            this.lbKat3.Name = "lbKat3";
            this.lbKat3.Size = new System.Drawing.Size(204, 160);
            this.lbKat3.TabIndex = 0;
            this.lbKat3.ValueMember = "Kategorie3";
            // 
            // lbKat2
            // 
            this.lbKat2.DisplayMember = "Kategorie2";
            this.lbKat2.FormattingEnabled = true;
            this.lbKat2.Location = new System.Drawing.Point(221, 19);
            this.lbKat2.Name = "lbKat2";
            this.lbKat2.Size = new System.Drawing.Size(204, 199);
            this.lbKat2.TabIndex = 0;
            this.lbKat2.ValueMember = "Kategorie2";
            this.lbKat2.SelectedIndexChanged += new System.EventHandler(this.lbKat2_SelectedIndexChanged);
            // 
            // lbKat1
            // 
            this.lbKat1.DisplayMember = "Kategorie1";
            this.lbKat1.FormattingEnabled = true;
            this.lbKat1.Location = new System.Drawing.Point(11, 19);
            this.lbKat1.Name = "lbKat1";
            this.lbKat1.Size = new System.Drawing.Size(204, 199);
            this.lbKat1.TabIndex = 0;
            this.lbKat1.ValueMember = "Kategorie1";
            this.lbKat1.SelectedIndexChanged += new System.EventHandler(this.lbKat1_SelectedIndexChanged);
            // 
            // cmdBericht
            // 
            this.cmdBericht.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdBericht.Location = new System.Drawing.Point(14, 119);
            this.cmdBericht.Name = "cmdBericht";
            this.cmdBericht.Size = new System.Drawing.Size(121, 30);
            this.cmdBericht.TabIndex = 4;
            this.cmdBericht.Text = "Bericht erstellen";
            this.cmdBericht.UseVisualStyleBackColor = true;
            this.cmdBericht.Click += new System.EventHandler(this.cmdBericht_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(630, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Arbeitszeitenerfassung - CVJM Landesverband Baden e.V.";
            // 
            // pbCVJM
            // 
            this.pbCVJM.BackgroundImage = global::Zeiterfassung.Properties.Resources.cvjm_w;
            this.pbCVJM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCVJM.Location = new System.Drawing.Point(18, 18);
            this.pbCVJM.Name = "pbCVJM";
            this.pbCVJM.Size = new System.Drawing.Size(110, 94);
            this.pbCVJM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCVJM.TabIndex = 6;
            this.pbCVJM.TabStop = false;
            // 
            // gbBericht
            // 
            this.gbBericht.BackColor = System.Drawing.SystemColors.Control;
            this.gbBericht.Controls.Add(this.cmdExit);
            this.gbBericht.Controls.Add(this.cmdEinstellungen);
            this.gbBericht.Controls.Add(this.pbCVJM);
            this.gbBericht.Controls.Add(this.cmdBericht);
            this.gbBericht.Location = new System.Drawing.Point(798, 221);
            this.gbBericht.Name = "gbBericht";
            this.gbBericht.Size = new System.Drawing.Size(144, 230);
            this.gbBericht.TabIndex = 7;
            this.gbBericht.TabStop = false;
            // 
            // cmdExit
            // 
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(14, 189);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(121, 28);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Schließen";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdEinstellungen
            // 
            this.cmdEinstellungen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdEinstellungen.Location = new System.Drawing.Point(14, 155);
            this.cmdEinstellungen.Name = "cmdEinstellungen";
            this.cmdEinstellungen.Size = new System.Drawing.Size(121, 28);
            this.cmdEinstellungen.TabIndex = 7;
            this.cmdEinstellungen.Text = "Info";
            this.cmdEinstellungen.UseVisualStyleBackColor = true;
            this.cmdEinstellungen.Click += new System.EventHandler(this.cmdEinstellungen_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dauerDataGridViewTextBoxColumn
            // 
            this.dauerDataGridViewTextBoxColumn.Name = "dauerDataGridViewTextBoxColumn";
            // 
            // dgvZeit
            // 
            this.dgvZeit.AllowUserToAddRows = false;
            this.dgvZeit.AllowUserToDeleteRows = false;
            this.dgvZeit.AllowUserToOrderColumns = true;
            this.dgvZeit.AllowUserToResizeColumns = false;
            this.dgvZeit.AllowUserToResizeRows = false;
            this.dgvZeit.AutoGenerateColumns = false;
            this.dgvZeit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZeit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Dauer});
            this.dgvZeit.DataSource = this.zeitBindingSource;
            this.dgvZeit.Location = new System.Drawing.Point(208, 46);
            this.dgvZeit.Name = "dgvZeit";
            this.dgvZeit.ReadOnly = true;
            this.dgvZeit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZeit.Size = new System.Drawing.Size(734, 168);
            this.dgvZeit.TabIndex = 8;
            this.dgvZeit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvZeit_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kat1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kat1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kat2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kat2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Kat3";
            this.dataGridViewTextBoxColumn6.HeaderText = "Kat3";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // Dauer
            // 
            this.Dauer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dauer.DataPropertyName = "Dauer";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = "00:00";
            this.Dauer.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.Name = "Dauer";
            this.Dauer.ReadOnly = true;
            // 
            // zeitBindingSource
            // 
            this.zeitBindingSource.DataMember = "Zeit";
            this.zeitBindingSource.DataSource = this.zeiterfassungDataSet;
            // 
            // zeiterfassungDataSet
            // 
            this.zeiterfassungDataSet.DataSetName = "ZeiterfassungDataSet";
            this.zeiterfassungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // zeitTableAdapter
            // 
            this.zeitTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStart
            // 
            this.AcceptButton = this.cmdEintragen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbBericht);
            this.Controls.Add(this.dgvZeit);
            this.Controls.Add(this.gbTätigkeit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mcKalender);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStart";
            this.Text = "Zeiterfassung";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.gbTätigkeit.ResumeLayout(false);
            this.gbTätigkeit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCVJM)).EndInit();
            this.gbBericht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZeit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeiterfassungDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcKalender;
        private System.Windows.Forms.GroupBox gbTätigkeit;
        private System.Windows.Forms.Button cmdVerwalten;
        private System.Windows.Forms.ListBox lbKat3;
        private System.Windows.Forms.ListBox lbKat2;
        private System.Windows.Forms.ListBox lbKat1;
        private System.Windows.Forms.Button cmdEintragen;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblStdMin;
        private System.Windows.Forms.ComboBox cbMinuten;
        private System.Windows.Forms.ComboBox cbStunden;
        private System.Windows.Forms.Button cmdBericht;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbFrei;
        private System.Windows.Forms.RadioButton rbUrlaub;
        private System.Windows.Forms.RadioButton rbKrank;
        private System.Windows.Forms.RadioButton rbArbeitstag;
        private System.Windows.Forms.Label lblArbeitszeit;
        private System.Windows.Forms.PictureBox pbCVJM;
        private System.Windows.Forms.GroupBox gbBericht;
        private System.Windows.Forms.Button cmdEinstellungen;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dauerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvZeit;
        private ZeiterfassungDataSet zeiterfassungDataSet;
        private System.Windows.Forms.BindingSource zeitBindingSource;
        private Zeiterfassung.ZeiterfassungDataSetTableAdapters.ZeitTableAdapter zeitTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}