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
            Productos pr = new Productos();

            CoordinadorDeProductos cp = new CoordinadorDeProductos();
            List<Productos> data = cp.getForIdTipe(1);
            DataTable _table = ConvertirListaToDataTable(data);

            
            
            //foreach (Productos item in data)
            //{
             //   DataRow dr = _table.NewRow();
              //  dr[0] = item;
              //  _table.Rows.Add(dr);
            //}
            dataGrip_listaProductos.DataSource = _table;
            //pr = cp.getAllProducts();
            //DataTable table = new DataTable();
            //using (var reader = ObjectReader.Create(data, "Id", "Name", "Description"))
            //{
            //    _table.Load(reader);
            //}
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
                pr.ID = 20;
                pr.Producto = "perra";
                pr.Precio = 5896;
                pr.IdTipo = 1;
                pr.Descripcion = "gtgtgt";

                //if (cbx_tipoProducto.Text.Equals("Compras"))
                //{
                //    pr.IdTipo = 1;
                //}
                //else
                //{
                //    pr.IdTipo = 2;
                //}

                //precio = float.Parse(txtproducto_precio.Text.ToString());
                //pr.Precio = precio;
                //pr.Descripcion = txtproducto_descriocion.Text;
                //pr.Producto = txtproducto_name.Text;

            cp.saveProduct(pr);
            }
            else
            {
                MetroMessageBox.Show(this, "FAVOR NO DEJAR CAMPOS EN BLANCO", "peligro!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            if (true)
            {
                MetroMessageBox.Show(this, "Producto registrado con exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MetroMessageBox.Show(this, "Producto no registrado", "Por favor verificar los capos en blanco," + "\n O verifique que el nombre del producto no esta repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public DataTable ConvertirListaToDataTable(System.Collections.IList data)
        {
            Productos pr = new Productos();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(Productos));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties) table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (Productos item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties) row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                
                table.Rows.Add(row);
            }
            return table;
        }

    }
}
