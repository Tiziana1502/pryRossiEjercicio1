namespace pryRossiEjercicio1
{
    partial class frmRegistro
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
            lblUsuario = new Label();
            lstModulo = new ComboBox();
            btnAceptar = new Button();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtContraseña = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(291, 74);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += this.label1_Click;
            // 
            // lstModulo
            // 
            lstModulo.FormattingEnabled = true;
            lstModulo.Location = new Point(376, 174);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(135, 23);
            lstModulo.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(567, 70);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(376, 74);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(135, 23);
            txtUsuario.TabIndex = 3;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(291, 126);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(291, 177);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 5;
            lblModulo.Text = "Módulo";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(376, 126);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(135, 23);
            txtContraseña.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(567, 126);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(txtContraseña);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(lstModulo);
            Controls.Add(lblUsuario);
            Name = "frmRegistro";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private ComboBox lstModulo;
        private Button btnAceptar;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtContraseña;
        private Button btnCancelar;
    }
}