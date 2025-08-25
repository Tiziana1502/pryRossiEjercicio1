namespace pryRossiEjercicio1
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenido = new Label();
            lblLogo = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(192, 154);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(133, 26);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido!";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Red;
            lblLogo.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = SystemColors.ControlLightLight;
            lblLogo.Location = new Point(111, 228);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(305, 45);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Sintepart SRL";
            // 
            // frmPrimero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Controls.Add(lblLogo);
            Controls.Add(lblBienvenido);
            Name = "frmPrimero";
            Text = "Bienvenido al Sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblLogo;
    }
}
