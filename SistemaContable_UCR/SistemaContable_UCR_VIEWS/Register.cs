﻿using System;
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
            this.Close();


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
            if (registro_passwordConfirn.Text.Equals(register_password.Text))
            {
                if (registro_passwordConfirn.Text != "" && register_password.Text != "" 
                    && registro_dni.Text != "" && registro_nombre.Text != ""
                    && registro_apellidos.Text != ""
               ) {

                }
                else {
                    MetroMessageBox.Show(this, "Alguno de los campos estan en blanco, por favor llene todos los campos", "LLENE TODOS LOS CAMPOS!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else {
                MetroMessageBox.Show(this, "La contraseña no coinside con la contraseña de confirmacion", "Las dos contraseñas deben ser las mismas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
