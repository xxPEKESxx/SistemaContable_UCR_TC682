﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;


namespace SistemaContable_UCR_VIEWS
{
    public partial class FRM_Productos : MetroForm
    {
        public FRM_Productos()
        {
            InitializeComponent();
        }

        private void FRM_Productos_Load(object sender, EventArgs e)
        {

        }

        private void producto_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Operation__Center pc = new Operation__Center();
            pc.Visible = true;
        }

        private void btn_agreagar_user_Click(object sender, EventArgs e)
        {
            Productos pr = new Productos();

            CoordinadorDeProductos cp = new CoordinadorDeProductos();
          
            float precio = 0;
            if (txtproducto_descriocion.Text != "" && txtproducto_precio.Text != ""
                && txtproducto_name.Text != "" && cbx_tipoProducto.Text != "")
            {

                if (cbx_tipoProducto.Text.Equals("Compras"))
                {
                    pr.IdTipo = 1;
                }
                else
                {
                    pr.IdTipo = 2;
                }

                precio = float.Parse(txtproducto_precio.Text.ToString());
                pr.Precio = precio;
                pr.Descripcion = txtproducto_descriocion.Text;
                pr.Producto = txtproducto_name.Text;


            }
            else { }

          

            if (cp.saveProduct(pr)) {
                MetroMessageBox.Show(this, "Producto registrado con exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MetroMessageBox.Show(this, "Producto no registrado", "Por favor verificar los capos en blanco,"+"\n O verifique que el nombre del producto no esta repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
