namespace Academia.Forms
{
    partial class FrmEditarInscripto
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtEdad = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            comboRitmo = new ComboBox();
            label3 = new Label();
            comboProfesor = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(234, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(514, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(252, 150);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(384, 27);
            txtEdad.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 150);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(252, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(384, 27);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 90);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // comboRitmo
            // 
            comboRitmo.FormattingEnabled = true;
            comboRitmo.Location = new Point(244, 216);
            comboRitmo.Name = "comboRitmo";
            comboRitmo.Size = new Size(392, 28);
            comboRitmo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 216);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 12;
            label3.Text = "Ritmo:";
            // 
            // comboProfesor
            // 
            comboProfesor.FormattingEnabled = true;
            comboProfesor.Location = new Point(244, 286);
            comboProfesor.Name = "comboProfesor";
            comboProfesor.Size = new Size(392, 28);
            comboProfesor.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 286);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 14;
            label4.Text = "Profesor:";
            // 
            // FrmEditarInscripto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboProfesor);
            Controls.Add(label4);
            Controls.Add(comboRitmo);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmEditarInscripto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar datos del inscripto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtEdad;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private ComboBox comboRitmo;
        private Label label3;
        private ComboBox comboProfesor;
        private Label label4;
    }
}