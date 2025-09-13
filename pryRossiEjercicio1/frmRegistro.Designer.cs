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
            cmbModulo = new ComboBox();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtContraseña = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblUsuario.Location = new Point(41, 49);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // cmbModulo
            // 
            cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModulo.Enabled = false;
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cmbModulo.Location = new Point(144, 181);
            cmbModulo.Margin = new Padding(3, 4, 3, 4);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(154, 28);
            cmbModulo.TabIndex = 1;
            cmbModulo.SelectedIndexChanged += cmbModulo_SelectedIndexChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(144, 48);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(154, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblContraseña.Location = new Point(41, 118);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(97, 23);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblModulo.Location = new Point(41, 186);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(70, 23);
            lblModulo.TabIndex = 5;
            lblModulo.Text = "Módulo";
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(144, 118);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(154, 27);
            txtContraseña.TabIndex = 6;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(179, 243);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 34);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.SteelBlue;
            btnAceptar.Enabled = false;
            btnAceptar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAceptar.ForeColor = SystemColors.ControlLightLight;
            btnAceptar.Location = new Point(41, 243);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(105, 34);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 338);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txtContraseña);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(cmbModulo);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistro";
            Text = "Login";
            Load += frmRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private ComboBox cmbModulo;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtContraseña;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}