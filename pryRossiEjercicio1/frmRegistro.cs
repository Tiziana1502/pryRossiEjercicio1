using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRossiEjercicio1
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //para crear una ventana del formulario que se indica
            // Modal significa que si no se cierra la otra ventana no se puede continuar
            frmInicio frmInicio = new frmInicio();
            frmInicio.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            //Borra los elementos de la lista
            //cmbModulo.Items.Clear();

            cmbModulo.SelectedIndex = -1;
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
