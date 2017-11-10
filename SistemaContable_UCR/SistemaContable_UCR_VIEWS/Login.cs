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

using SistemaContable_UCR_Model;
using MetroFramework;

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

            if (!(conetion.StartSesion(dni_user.Text, metroTextBox_Password.Text)))//SI LA CONEXION ES CORRECTA NOS ENVIA AL CENTRO DE OPERACIONES
            {
                Operation__Center OC = new Operation__Center(); //PARA VER EL CENTRO DE OPERACION(DONDE VAN A ESTAR LAS GESTIONES DEL SISTEMA
                

                OC.Visible = true;
            }
            else
            {
                MetroMessageBox.Show(this, "Error en inicio de sesion", "DATOS ERRONEOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void metroTextBox_UserName_Click(object sender, EventArgs e)
        {

        }
    }
}
