namespace Academia.Forms
{
    partial class FrmNuevo
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            comboRitmo = new ComboBox();
            comboProfesor = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 70);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(227, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(382, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 130);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(227, 130);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(392, 27);
            txtEdad.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(497, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(217, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 211);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Ritmo:";
            // 
            // comboRitmo
            // 
            comboRitmo.FormattingEnabled = true;
            comboRitmo.Location = new Point(227, 211);
            comboRitmo.Name = "comboRitmo";
            comboRitmo.Size = new Size(392, 28);
            comboRitmo.TabIndex = 7;
            // 
            // comboProfesor
            // 
            comboProfesor.FormattingEnabled = true;
            comboProfesor.Location = new Point(217, 277);
            comboProfesor.Name = "comboProfesor";
            comboProfesor.Size = new Size(392, 28);
            comboProfesor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 277);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "Profesor:";
            // 
            // FrmNuevo
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
            Name = "FrmNuevo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ingresar un nuevo inscripto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEdad;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label3;
        private ComboBox comboRitmo;
        private ComboBox comboProfesor;
        private Label label4;
    }
}