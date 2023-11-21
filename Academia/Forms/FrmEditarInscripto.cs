using Academia.Data;
using Academia.Moldls;
using Microsoft.EntityFrameworkCore;
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
    public partial class FrmEditarInscripto : Form
    {
        AcademiaContext context = new AcademiaContext();
        int idIncriptoAEditado;
        Inscripto? inscripto;
        public FrmEditarInscripto(int idInscriptoAEditar)
        {
            InitializeComponent();
            this.idIncriptoAEditado = idInscriptoAEditar;
            CargarComboRitmo();
            CargarComboProfesor();
            CargarDatosEnPantalla();
        }

        private void CargarComboProfesor()
        {
            comboProfesor.DataSource = context.Profesores.ToList();
            comboProfesor.DisplayMember = "Nombre";
            comboProfesor.ValueMember = "Id";
        }

        private void CargarComboRitmo()
        {
            comboRitmo.DataSource = context.Ritmos.ToList();
            comboRitmo.DisplayMember = "Nombre";
            comboRitmo.ValueMember = "Id";
        }

        private void CargarDatosEnPantalla()
        {
            AcademiaContext context = new AcademiaContext();
            inscripto = context.inscriptos.Find(idIncriptoAEditado);
            if (inscripto != null)
            {
                txtNombre.Text = inscripto.Nombre;
                txtEdad.Text = inscripto.Edad;
                comboRitmo.SelectedValue = inscripto.RitmoId ?? 0;
                comboProfesor.SelectedValue = inscripto.Profesorid ?? 0;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AcademiaContext context = new AcademiaContext();
            inscripto.Nombre = txtNombre.Text;
            inscripto.Edad = txtEdad.Text;
            inscripto.RitmoId = (int)comboRitmo.SelectedValue;
            inscripto.Profesorid = (int)comboProfesor.SelectedValue;
            context.Entry(inscripto).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
