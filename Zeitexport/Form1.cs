using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zeitexport.Manager;

namespace Zeitexport
{
    public partial class Form1 : Form
    {
        internal string originalText;
        internal List<Models.ZeitItem> Zeiten;

        public Form1()
        {
            InitializeComponent();
            RegisterHandler();
        }

        #region Init
        private void RegisterHandler()
        {
            this.Load += FormLoadHandler;
            txtBoxProjektnummer.TextChanged += TxtBoxTextChangedHandler;
            btnLoad.Click += BtnLoadClickHandler;
            btnExport.Click += BtnExportClickHandler;
            dtpKalenderwoche.ValueChanged += DtpKalenderwocheValueChangedHandler;

            dtpKalenderwoche.Format = DateTimePickerFormat.Custom;
        }

        #endregion

        #region Andere Methoden
        public string GetProjektnummer()
        {
            string Projektnummer;

            if (string.IsNullOrEmpty(txtBoxProjektnummer.Text))
            {
                if (string.IsNullOrEmpty(cmbProjektnummer.Text))
                {
                    lblProjektnummerMissing.Show();
                    return null;
                }
                else
                {
                    Projektnummer = cmbProjektnummer.Text;
                }
            }
            else
            {
                Projektnummer = txtBoxProjektnummer.Text;
            }

            lblProjektnummerMissing.Hide();
            return Projektnummer;
        }
        #endregion

        #region Event Handler

        private void FormLoadHandler(object sender, EventArgs e)
        {
            var myForm = sender as Form;
            myForm.Text = string.Concat("Mein ", myForm.Text);
            this.originalText = myForm.Text;
        }

        private void TxtBoxTextChangedHandler(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxProjektnummer.Text))
            {
                this.Text = this.originalText;
            } else
            {
                this.Text = this.originalText + ": " + txtBoxProjektnummer.Text;
            }

            lblExportiert.Visible = false;
        }

        private void DtpKalenderwocheValueChangedHandler(object sender, EventArgs e)
        {
            var Kalenderwoche = TemplateEngine.GetKalenderwoche(dtpKalenderwoche.Value);
            lblKalenderwoche.Text = Kalenderwoche.ToString();

            var GefundeneZeiten = Zeiten.FindAll(Item => Kalenderwoche == TemplateEngine.GetKalenderwoche(Item.Datum.Value));
            lblExportiert.Text = GefundeneZeiten.Count.ToString() + " Gefundene Einträge";
            lblExportiert.Visible = true;

            // Tabelle aktualisieren
            dgvZeiten.DataSource = GefundeneZeiten;
            dgvZeiten.Refresh();

            if (GefundeneZeiten.Count <= 0)
            {
                lblExportiert.ForeColor = System.Drawing.Color.Red;
                btnExport.Enabled = false;
            } else
            {
                lblExportiert.ForeColor = System.Drawing.Color.Black;
                btnExport.Enabled = true;
            }
        }

        private void BtnLoadClickHandler(object sender, EventArgs e)
        {
            string Projektnummer = GetProjektnummer();

            if (string.IsNullOrEmpty(Projektnummer)) return;

            var zeitenManager = new Zeiten();
            var Zeiten = zeitenManager.LoadByProjektnummer(Projektnummer);
            this.Zeiten = Zeiten;

            dtpKalenderwoche.Enabled = true;

            dgvZeiten.AutoGenerateColumns = false;
            dgvZeiten.DataSource = Zeiten;
            dgvZeiten.Refresh();
        }

        private void BtnExportClickHandler(object sender, EventArgs e)
        {
            var ExportDlg = new SaveFileDialog();
            ExportDlg.FileOk -= ExportDlgFileOkHandler;
            ExportDlg.FileOk += ExportDlgFileOkHandler;
            ExportDlg.RestoreDirectory = true;
            ExportDlg.Filter = "HTML-Dateien (*.html)|*.html";
            ExportDlg.FileName = $"{GetProjektnummer()} - Kalenderwoche {TemplateEngine.GetKalenderwoche(dtpKalenderwoche.Value)}.html";
            ExportDlg.ShowDialog();
        }

        private void ExportDlgFileOkHandler(object sender, CancelEventArgs e)
        {
            var ExportDlg = sender as SaveFileDialog;
            
            TemplateEngine.Export(TemplateEngine.GetKalenderwoche(dtpKalenderwoche.Value), ExportDlg.FileName, Zeiten, GetProjektnummer());

            lblExportiert.Text = "Einträge wurden exportiert!";
            lblExportiert.ForeColor = System.Drawing.Color.Green;
        }

        #endregion
    }
}
