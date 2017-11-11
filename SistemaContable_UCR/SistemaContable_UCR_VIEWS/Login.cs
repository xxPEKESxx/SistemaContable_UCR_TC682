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
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_VIEWS
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile_Entrar_Click(object sender, EventArgs e)
        {
            Conection conetion = new Conection();

            if ((conetion.StartSesion(idUser.Text, metroTextBox_Password.Text)))
            {

                Operation__Center Oc = new Operation__Center();
                Oc.Visible = true;
                Visible = false;

            }
            else {

                MetroMessageBox.Show(this, "Por favor escriba correctamente la contraseña y la cedula", "Cedula o contrasela erroneos ");
            }


        }

        private void metroTile_Register_Click(object sender, EventArgs e)
        {
            Register re = new Register();

            re.Visible = true;
            Visible = false;
        }
    }
}
