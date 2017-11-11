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

            if (checkbox_vistaContrasela.Checked) {
                register_password.UseSystemPasswordChar = false;
                registro_passwordConfirn.UseSystemPasswordChar = false;
            } else {

                register_password.UseSystemPasswordChar = true;
                registro_passwordConfirn.UseSystemPasswordChar = true;
            }
           
        }
    }
}
