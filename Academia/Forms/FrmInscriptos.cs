using Academia.Data;
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
    public partial class FrmInscriptos : Form
    {
        public FrmInscriptos()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            AcademiaContext context = new AcademiaContext();
            if (txtBusqueda.Text.Trim().Length > 0)
            {
                dataGridInscriptos.DataSource = context.inscriptos.Where(s => s.Nombre.Contains(txtBusqueda.Text)).Include(s => s.Ritmo).Include(s => s.Profesor).ToList();
            }
            else
            {
                dataGridInscriptos.DataSource = context.inscriptos.Include(s => s.Ritmo).Include(s => s.Profesor).ToList();
            }
            dataGridInscriptos.Columns[3].Visible = false;
            dataGridInscriptos.Columns[5].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmNuevo frmNuevo = new FrmNuevo();
            frmNuevo.ShowDialog();
            CargarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridInscriptos.CurrentRow.Cells[0].Value;
            string nombreInscriptoAEliminar = (string)dataGridInscriptos.CurrentRow.Cells[1].Value;
            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar al inscripto {nombreInscriptoAEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new AcademiaContext();
                    var inscripto = context.inscriptos.Find(idAEliminar);
                    context.inscriptos.Remove(inscripto);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar al inscripto {nombreInscriptoAEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridInscriptos.CurrentRow.Cells[0].Value;
            FrmEditarInscripto frmEditarInscripto = new FrmEditarInscripto(idAEditar);
            frmEditarInscripto.ShowDialog();
            CargarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
