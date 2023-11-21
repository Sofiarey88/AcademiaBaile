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
    public partial class RitmosViewForm : Form
    {

        ReportViewer reporte = new ReportViewer();
        AcademiaContext db = new AcademiaContext();
        public RitmosViewForm()
        {
            InitializeComponent();
            reporte.Dock = DockStyle.Fill;
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            Controls.Add(reporte);
        }

        private void RitmosViewForm_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "Academia.Reportes.RitmosReport.rdlc";
            var ritmos = db.Ritmos.ToList();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSRitmoss", ritmos));
            reporte.RefreshReport();
        }
    }
}
