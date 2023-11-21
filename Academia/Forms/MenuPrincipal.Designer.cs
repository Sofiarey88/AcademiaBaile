namespace Academia.Forms
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            btnInscriptos = new Button();
            btnListaProfes = new Button();
            btnListaRitmo = new Button();
            SuspendLayout();
            // 
            // btnInscriptos
            // 
            btnInscriptos.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscriptos.Location = new Point(560, 21);
            btnInscriptos.Name = "btnInscriptos";
            btnInscriptos.Size = new Size(462, 39);
            btnInscriptos.TabIndex = 0;
            btnInscriptos.Text = "INSCRIPTO";
            btnInscriptos.UseVisualStyleBackColor = true;
            btnInscriptos.Click += btnInscriptos_Click;
            // 
            // btnListaProfes
            // 
            btnListaProfes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnListaProfes.Location = new Point(163, 13);
            btnListaProfes.Name = "btnListaProfes";
            btnListaProfes.Size = new Size(289, 54);
            btnListaProfes.TabIndex = 1;
            btnListaProfes.Text = "LISTA DE PROFESORES";
            btnListaProfes.UseVisualStyleBackColor = true;
            btnListaProfes.Click += btnListaProfes_Click;
            // 
            // btnListaRitmo
            // 
            btnListaRitmo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnListaRitmo.Location = new Point(1097, 21);
            btnListaRitmo.Name = "btnListaRitmo";
            btnListaRitmo.Size = new Size(253, 46);
            btnListaRitmo.TabIndex = 2;
            btnListaRitmo.Text = "LISTA DE RITMOS";
            btnListaRitmo.UseVisualStyleBackColor = true;
            btnListaRitmo.Click += btnListaRitmo_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1745, 450);
            Controls.Add(btnListaRitmo);
            Controls.Add(btnListaProfes);
            Controls.Add(btnInscriptos);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscriptos;
        private Button btnListaProfes;
        private Button btnListaRitmo;
    }
}