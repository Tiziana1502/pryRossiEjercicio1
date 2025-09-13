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
        private int Intentos = 0;
        //Contador pra validar la cantidad de intentos del usuario

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            {
                //El boton te lleva de un formulario a otro, primero validando que los datos son correctos
                // && operador logico AND
                // || operador logico OR 

                if (txtUsuario.Text == "Adm" && txtContraseña.Text == "1@" && (cmbModulo.SelectedIndex == 0 || cmbModulo.SelectedIndex == 2 || cmbModulo.SelectedIndex == 3))
                {
                    Intentos = 0;
                    //para crear una ventana del formulario que se indica
                    // Modal significa que si no se cierra la otra ventana no se puede continuar
                    frmInicio frminicio = new frmInicio();
                    frminicio.ShowDialog();
                }
                else if (txtUsuario.Text == "John" && txtContraseña.Text == "*2b" && cmbModulo.SelectedIndex == 1)
                {
                    Intentos = 0;
                    frmInicio frminicio = new frmInicio();
                    frminicio.ShowDialog();
                }
                else if (txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c" && (cmbModulo.SelectedIndex == 0 || cmbModulo.SelectedIndex == 3))
                {
                    Intentos = 0;
                    frmInicio frminicio = new frmInicio();
                    frminicio.ShowDialog();
                }
                else if (txtUsuario.Text == "God" && txtContraseña.Text == "*@#4d" && (cmbModulo.SelectedIndex == 0 || cmbModulo.SelectedIndex == 1 || cmbModulo.SelectedIndex == 2 || cmbModulo.SelectedIndex == 3))
                {
                    Intentos = 0;
                    frmInicio frminicio = new frmInicio();
                    frminicio.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                    Intentos++;
                    if (Intentos == 3)
                    {
                        this.Close(); //cierra el formulario
                    }
                }
            }
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
            if (cmbModulo.SelectedIndex != -1)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled =false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtContraseña.Enabled = false;
                // para asignar =
                // comparar valores ==
            }
            else
            {
                txtContraseña.Enabled = true;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                cmbModulo.Enabled = true;
            }
            else
            {
                cmbModulo.Enabled = false;
                cmbModulo.SelectedIndex = -1;
            }
        }
    }
}
