using Academia.Data;
using Academia.Moldls;
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
    public partial class FrmNuevo : Form
    {
        AcademiaContext context = new AcademiaContext();
        public FrmNuevo()
        {
            InitializeComponent();
            CargarComboRitmo();
            CargarComboProfesor();
        }

        private void CargarComboProfesor()
        {
            comboProfesor.DataSource = context.Profesores.ToList();
            comboProfesor.DisplayMember = "Nombre";
            comboProfesor.ValueMember = "Id";
            comboProfesor.SelectedValue = 0;
        }

        private void CargarComboRitmo()
        {
            comboRitmo.DataSource = context.Ritmos.ToList();
            comboRitmo.DisplayMember = "Nombre";
            comboRitmo.ValueMember = "Id";
            comboRitmo.SelectedValue = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var Inscripto = new Inscripto()
            {
                Nombre = txtNombre.Text,
                Edad = txtEdad.Text,
                RitmoId = (int)comboRitmo.SelectedValue,
                Profesorid = (int)comboProfesor.SelectedValue

            };
            context.inscriptos.Add(Inscripto);
            context.SaveChanges();
            this.Close();
        }
    }
}
