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

namespace SistemaContable_UCR_VIEWS
{
    public partial class Operation__Center : MetroForm
    {
        public Operation__Center()
        {
            InitializeComponent();
        }

        private void Operation__Center_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel_Administration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            FRM_Productos pro = new FRM_Productos();
            pro.Visible = true;

            this.Visible = false;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            FRM_GestionCompras compras = new FRM_GestionCompras();
            compras.Visible = true;

            this.Visible = false;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            FRM_GestionVentas ventas = new FRM_GestionVentas();
            ventas.Visible = true;

            this.Visible = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Operation__Center_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            Creditos cr = new Creditos();

            cr.Visible = true;
            this.Visible = false;

        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            FRM_Balance balance = new FRM_Balance();

            balance.Visible = true;
            this.Visible = false;
        }
    }
}
