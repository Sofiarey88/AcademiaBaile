namespace Academia.Forms
{
    partial class FrmInscriptos
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
            dataGridInscriptos = new DataGridView();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            txtBusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridInscriptos).BeginInit();
            SuspendLayout();
            // 
            // dataGridInscriptos
            // 
            dataGridInscriptos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridInscriptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInscriptos.GridColor = Color.FromArgb(255, 192, 192);
            dataGridInscriptos.Location = new Point(79, 68);
            dataGridInscriptos.Name = "dataGridInscriptos";
            dataGridInscriptos.RowHeadersWidth = 51;
            dataGridInscriptos.RowTemplate.Height = 29;
            dataGridInscriptos.Size = new Size(889, 326);
            dataGridInscriptos.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Coral;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(979, 459);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(460, 426);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "NUEVO";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Yellow;
            btnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(761, 428);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(138, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 33);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "BUSCAR:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(177, 25);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(723, 27);
            txtBusqueda.TabIndex = 6;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // FrmInscriptos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 500);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Controls.Add(dataGridInscriptos);
            Name = "FrmInscriptos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inscriptos";
            ((System.ComponentModel.ISupportInitialize)dataGridInscriptos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridInscriptos;
        private Button btnSalir;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private TextBox txtBusqueda;
    }
}