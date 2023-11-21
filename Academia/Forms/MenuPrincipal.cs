using Academia;
using Academia.ViewForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnInscriptos_Click(object sender, EventArgs e)
        {
            FrmInscriptos frmInscriptos = new FrmInscriptos();
            frmInscriptos.ShowDialog();
        }

        private void btnListaProfes_Click(object sender, EventArgs e)
        {
            ProfesoresViewForm profesoresViewForm = new ProfesoresViewForm();
            profesoresViewForm.ShowDialog();


        }

        private void btnListaRitmo_Click(object sender, EventArgs e)
        {
            RitmosViewForm ritmosViewForm = new RitmosViewForm();
            ritmosViewForm.ShowDialog();
        }
    }
}
