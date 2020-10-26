namespace Zeitexport
{
    partial class Form1
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
            this.txtBoxProjektnummer = new System.Windows.Forms.TextBox();
            this.lblProjektnummer = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvZeiten = new System.Windows.Forms.DataGridView();
            this.colProjektbezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRessource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStunden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjektnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProjektnummer = new System.Windows.Forms.ComboBox();
            this.lblProjektnummerMissing = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblExportiert = new System.Windows.Forms.Label();
            this.lblEinträgeexport = new System.Windows.Forms.Label();
            this.dtpKalenderwoche = new System.Windows.Forms.DateTimePicker();
            this.lblDisplayKalenderwoche = new System.Windows.Forms.Label();
            this.lblKalenderwoche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZeiten)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxProjektnummer
            // 
            this.txtBoxProjektnummer.Location = new System.Drawing.Point(243, 19);
            this.txtBoxProjektnummer.Name = "txtBoxProjektnummer";
            this.txtBoxProjektnummer.Size = new System.Drawing.Size(183, 20);
            this.txtBoxProjektnummer.TabIndex = 0;
            // 
            // lblProjektnummer
            // 
            this.lblProjektnummer.AutoSize = true;
            this.lblProjektnummer.Location = new System.Drawing.Point(33, 22);
            this.lblProjektnummer.Name = "lblProjektnummer";
            this.lblProjektnummer.Size = new System.Drawing.Size(77, 13);
            this.lblProjektnummer.TabIndex = 1;
            this.lblProjektnummer.Text = "Projektnummer";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(432, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Laden";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // dgvZeiten
            // 
            this.dgvZeiten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZeiten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjektbezeichnung,
            this.colRessource,
            this.colNotiz,
            this.colDatum,
            this.colStunden,
            this.colStartzeit,
            this.colEndzeit,
            this.colProjektnummer});
            this.dgvZeiten.Location = new System.Drawing.Point(12, 155);
            this.dgvZeiten.Name = "dgvZeiten";
            this.dgvZeiten.Size = new System.Drawing.Size(775, 381);
            this.dgvZeiten.TabIndex = 4;
            // 
            // colProjektbezeichnung
            // 
            this.colProjektbezeichnung.DataPropertyName = "Projektbezeichnung";
            this.colProjektbezeichnung.HeaderText = "Name";
            this.colProjektbezeichnung.Name = "colProjektbezeichnung";
            // 
            // colRessource
            // 
            this.colRessource.DataPropertyName = "Ressource";
            this.colRessource.HeaderText = "Ressource";
            this.colRessource.Name = "colRessource";
            // 
            // colNotiz
            // 
            this.colNotiz.DataPropertyName = "Notiz";
            this.colNotiz.HeaderText = "Notiz";
            this.colNotiz.Name = "colNotiz";
            // 
            // colDatum
            // 
            this.colDatum.DataPropertyName = "Datum";
            this.colDatum.HeaderText = "Datum";
            this.colDatum.Name = "colDatum";
            // 
            // colStunden
            // 
            this.colStunden.DataPropertyName = "Stunden";
            this.colStunden.HeaderText = "Stunden";
            this.colStunden.Name = "colStunden";
            this.colStunden.ReadOnly = true;
            // 
            // colStartzeit
            // 
            this.colStartzeit.DataPropertyName = "Startzeit";
            this.colStartzeit.HeaderText = "Startzeit";
            this.colStartzeit.Name = "colStartzeit";
            // 
            // colEndzeit
            // 
            this.colEndzeit.DataPropertyName = "Endzeit";
            this.colEndzeit.HeaderText = "Endzeit";
            this.colEndzeit.Name = "colEndzeit";
            // 
            // colProjektnummer
            // 
            this.colProjektnummer.DataPropertyName = "Projektnummer";
            this.colProjektnummer.HeaderText = "Projektnummer";
            this.colProjektnummer.Name = "colProjektnummer";
            // 
            // cmbProjektnummer
            // 
            this.cmbProjektnummer.FormattingEnabled = true;
            this.cmbProjektnummer.Items.AddRange(new object[] {
            "",
            "P20-002",
            "P20-003"});
            this.cmbProjektnummer.Location = new System.Drawing.Point(116, 19);
            this.cmbProjektnummer.Name = "cmbProjektnummer";
            this.cmbProjektnummer.Size = new System.Drawing.Size(121, 21);
            this.cmbProjektnummer.TabIndex = 5;
            // 
            // lblProjektnummerMissing
            // 
            this.lblProjektnummerMissing.AutoSize = true;
            this.lblProjektnummerMissing.ForeColor = System.Drawing.Color.Red;
            this.lblProjektnummerMissing.Location = new System.Drawing.Point(513, 22);
            this.lblProjektnummerMissing.Name = "lblProjektnummerMissing";
            this.lblProjektnummerMissing.Size = new System.Drawing.Size(213, 13);
            this.lblProjektnummerMissing.TabIndex = 6;
            this.lblProjektnummerMissing.Text = "Es wurde keine Projektnummer angegeben!";
            this.lblProjektnummerMissing.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(268, 105);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // lblExportiert
            // 
            this.lblExportiert.AutoSize = true;
            this.lblExportiert.ForeColor = System.Drawing.Color.Green;
            this.lblExportiert.Location = new System.Drawing.Point(349, 110);
            this.lblExportiert.Name = "lblExportiert";
            this.lblExportiert.Size = new System.Drawing.Size(133, 13);
            this.lblExportiert.TabIndex = 8;
            this.lblExportiert.Text = "Einträge wurden exportiert!";
            this.lblExportiert.Visible = false;
            // 
            // lblEinträgeexport
            // 
            this.lblEinträgeexport.AutoSize = true;
            this.lblEinträgeexport.Location = new System.Drawing.Point(113, 81);
            this.lblEinträgeexport.Name = "lblEinträgeexport";
            this.lblEinträgeexport.Size = new System.Drawing.Size(75, 13);
            this.lblEinträgeexport.TabIndex = 9;
            this.lblEinträgeexport.Text = "Einträgeexport";
            // 
            // dtpKalenderwoche
            // 
            this.dtpKalenderwoche.CustomFormat = "dd.MM.yyyy";
            this.dtpKalenderwoche.Enabled = false;
            this.dtpKalenderwoche.Location = new System.Drawing.Point(116, 105);
            this.dtpKalenderwoche.Name = "dtpKalenderwoche";
            this.dtpKalenderwoche.Size = new System.Drawing.Size(121, 20);
            this.dtpKalenderwoche.TabIndex = 10;
            this.dtpKalenderwoche.ValueChanged += new System.EventHandler(this.DtpKalenderwocheValueChangedHandler);
            // 
            // lblDisplayKalenderwoche
            // 
            this.lblDisplayKalenderwoche.AutoSize = true;
            this.lblDisplayKalenderwoche.Location = new System.Drawing.Point(33, 107);
            this.lblDisplayKalenderwoche.Name = "lblDisplayKalenderwoche";
            this.lblDisplayKalenderwoche.Size = new System.Drawing.Size(81, 13);
            this.lblDisplayKalenderwoche.TabIndex = 11;
            this.lblDisplayKalenderwoche.Text = "Kalenderwoche";
            // 
            // lblKalenderwoche
            // 
            this.lblKalenderwoche.AutoSize = true;
            this.lblKalenderwoche.Location = new System.Drawing.Point(243, 107);
            this.lblKalenderwoche.Name = "lblKalenderwoche";
            this.lblKalenderwoche.Size = new System.Drawing.Size(19, 13);
            this.lblKalenderwoche.TabIndex = 12;
            this.lblKalenderwoche.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 548);
            this.Controls.Add(this.lblKalenderwoche);
            this.Controls.Add(this.lblDisplayKalenderwoche);
            this.Controls.Add(this.dtpKalenderwoche);
            this.Controls.Add(this.lblEinträgeexport);
            this.Controls.Add(this.lblExportiert);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblProjektnummerMissing);
            this.Controls.Add(this.cmbProjektnummer);
            this.Controls.Add(this.dgvZeiten);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblProjektnummer);
            this.Controls.Add(this.txtBoxProjektnummer);
            this.Name = "Form1";
            this.Text = "Zeitexport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZeiten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxProjektnummer;
        private System.Windows.Forms.Label lblProjektnummer;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvZeiten;
        private System.Windows.Forms.ComboBox cmbProjektnummer;
        private System.Windows.Forms.Label lblProjektnummerMissing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjektbezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRessource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStunden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjektnummer;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblExportiert;
        private System.Windows.Forms.Label lblEinträgeexport;
        private System.Windows.Forms.DateTimePicker dtpKalenderwoche;
        private System.Windows.Forms.Label lblDisplayKalenderwoche;
        private System.Windows.Forms.Label lblKalenderwoche;
    }
}

