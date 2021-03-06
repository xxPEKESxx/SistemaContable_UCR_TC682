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
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_VIEWS
{
    public partial class FRM_Balance : MetroForm
    {
        public FRM_Balance()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTrasacciones = new CoordinadorDeTransacciones();

            float[] utilidad = coordinadorDeTrasacciones.getUtilityByMonth(metroDateTime1.Value);
            if (utilidad[0]!= 0 && utilidad[1] != 0)
            {
                metroLabelVentas.Text = utilidad[1].ToString();
                metroLabelCompras.Text = utilidad[0].ToString();
                metroLabelUtilidad.Text = utilidad[2].ToString();
            }
            else
            {
                MetroMessageBox.Show(this, "ERROR DE REGISTROS ", "NO SE HA ENCONTRADO REGISTROS PARA LA FECHA SELECCIONADA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroLabelVentas.Text = "VALOR";
                metroLabelCompras.Text = "VALOR";
                metroLabelUtilidad.Text = "VALOR";
            }
            

        }

        private void metroTileAtrasEditar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;

        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTrasacciones = new CoordinadorDeTransacciones();

            float[] utilidad = coordinadorDeTrasacciones.getUtilityByMonth(metroDateTime1.Value);
            if (utilidad[0] != 0 && utilidad[1] != 0)
            {
                metroLabelVentas.Text = utilidad[1].ToString();
                metroLabelCompras.Text = utilidad[0].ToString();
                metroLabelUtilidad.Text = utilidad[2].ToString();
            }
            else
            {
                MetroMessageBox.Show(this, "ERROR DE REGISTROS ", "NO SE HA ENCONTRADO REGISTROS PARA LA FECHA SELECCIONADA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroLabelVentas.Text = "VALOR";
                metroLabelCompras.Text = "VALOR";
                metroLabelUtilidad.Text = "VALOR";
            }
        }

        private void metroTileAtrasEditar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;

        }

        private void metroTileGenerarRango_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTrasacciones = new CoordinadorDeTransacciones();

            float[] utilidad = coordinadorDeTrasacciones.getUtilityByDateInterval(metroDateTimeDesde.Value, metroDateTimeHasta.Value);
            if (utilidad[0] != 0 && utilidad[1] != 0)
            {
                metroLabelVentasRango.Text = utilidad[1].ToString();
                metroLabelComprasRango.Text = utilidad[0].ToString();
                metroLabelTotalRango.Text = utilidad[2].ToString();
            }
            else
            {
                MetroMessageBox.Show(this, "ERROR DE REGISTROS ", "NO SE HA ENCONTRADO REGISTROS PARA LA FECHA SELECCIONADA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroLabelVentasRango.Text = "VALOR";
                metroLabelComprasRango.Text = "VALOR";
                metroLabelTotalRango.Text = "VALOR";
            }
        }

        private void metroTileAtrasRango_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;
        }

        private void metroTileGenerarTotal_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTrasacciones = new CoordinadorDeTransacciones();

            float[] utilidad = coordinadorDeTrasacciones.getTotalUtility();
            if (utilidad[0] != 0 && utilidad[1] != 0)
            {
                metroLabelVentasTotal.Text = utilidad[1].ToString();
                metroLabelComprasTotal.Text = utilidad[0].ToString();
                metroLabelTotalTotal.Text = utilidad[2].ToString();
            }
            else
            {
                MetroMessageBox.Show(this, "ERROR DE REGISTROS ", "NO SE HA ENCONTRADO REGISTROS PARA LA FECHA SELECCIONADA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroLabelVentasTotal.Text = "VALOR";
                metroLabelComprasTotal.Text = "VALOR";
                metroLabelTotalTotal.Text = "VALOR";
            }
        }

        private void metroTileAtrasTotal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;
        }
    }
}
