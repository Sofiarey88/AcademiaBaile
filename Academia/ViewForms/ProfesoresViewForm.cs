using Academia.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.ViewForms
{
    public partial class ProfesoresViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        AcademiaContext db = new AcademiaContext();

        public ProfesoresViewForm()
        {
            InitializeComponent();
            //reporte ocupe todo el formulario
            reporte.Dock = DockStyle.Fill;

            //vista de impresion
            reporte.SetDisplayMode(DisplayMode.PrintLayout);

            //establecer zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;

            Controls.Add(reporte);
        }

        private void ProfesoresViewForm_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "Academia.Reportes.ProfesorReport.rdlc";
            var profesores = db.Profesores.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSProfesores", profesores));
            reporte.RefreshReport();
        }
    }
}
