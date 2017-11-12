using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_VIEWS
{
    public partial class Register : MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void registro_Atras_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Visible = true;
            this.Visible = false;


        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void hacerClick(object sender, MouseEventArgs e)
        {
            
         }

        private void verContra_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            register_password.UseSystemPasswordChar = false;
            registro_passwordConfirn.UseSystemPasswordChar = false;

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        { 
            CoordinadorDeUsuarios cu = new CoordinadorDeUsuarios();
            
           Usuarios U = new Usuarios();

            if (registro_passwordConfirn.Text.Equals(register_password.Text))
            {
                if (registro_passwordConfirn.Text != "" && register_password.Text != "" 
                    && registro_dni.Text != "" && registro_nombre.Text != ""
                    && registro_apellidos.Text != "" && txt_register_codigoseguridad.Text != "") {
                    if (txt_register_codigoseguridad.Text.Equals("TCU-682-ACT"))
                    {

                        U.DNI = registro_dni.Text;
                        U.UserName = registro_nombre.Text;
                        U.UserLastName = registro_apellidos.Text;
                        U.UserPassword = register_password.Text;

                        if (cu.register(U))
                        {
                            MetroMessageBox.Show(this, "Usuario registrado con exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Visible=false;
                            Login lo = new Login();
                            lo.Visible = true;

                        }
                        else
                        {
                            MetroMessageBox.Show(this, "el usuario ya existe", "Lo sentimos!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else {
                        MetroMessageBox.Show(this, "Para poder registrar un usuario debe de ingresar el Código de seguridad"+"\nDebe de solicitar el codigo al encargado de proyecto de UCR a", "CÓDIGO DE SEGURIDAD ERRONEO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else {
                    MetroMessageBox.Show(this, "Alguno de los campos estan en blanco, por favor llene todos los campos", "LLENE TODOS LOS CAMPOS!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else {
                MetroMessageBox.Show(this, "La contraseña no coinside con la contraseña de confirmacion", "Las dos contraseñas deben ser las mismas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login lo = new Login();
            lo.Visible = true;
        }
    }
}
