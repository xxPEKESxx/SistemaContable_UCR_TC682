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

            cargarLista();
            
            
        }
        public void cargarLista() {
            Productos pr = new Productos();

            CoordinadorDeProductos cp = new CoordinadorDeProductos();
            List<Productos> data = cp.getAllProducts();
            DataTable _table = ConvertirListaToDataTable(data);
          
            dataGrip_listaProductos.DataSource = _table;

            dataGrip_listaProductos.ReadOnly = true;

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

        private void dataGrip_listaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Productos pr = new Productos();
         DataGridView dgv = sender as DataGridView;

            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                Productos pro = new Productos
                {
                    ID = (int)dgv.CurrentRow.Cells["ID"].Value,

                };

                CoordinadorDeProductos cp = new CoordinadorDeProductos();
                pr = cp.getById(pro.ID);
            }

            txtproducto_precio.Text = (pr.Precio.ToString());


        }

        private void producto_Edita_Click(object sender, EventArgs e)
        {
            //Productos pr = new Productos();

            //CoordinadorDeProductos cp = new CoordinadorDeProductos();
            //Productos aStudent = (Productos)dataGrip_listaProductos.CurrentRow.DataBoundItem;

            //pr = cp.getById(aStudent.ID);
            

            
            //txtproducto_precio.Text=(pr.Precio.ToString());
           
        }

        private void btn_agreagar_producto_Click(object sender, EventArgs e)
        {


        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {


        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {



            Productos pr = new Productos();

            CoordinadorDeProductos cp = new CoordinadorDeProductos();

            float precio = 0;
            if (txtproducto_descriocion.Text != "" && txtproducto_precio.Text != ""
                && txtproducto_name.Text != "")
            {


                precio = float.Parse(txtproducto_precio.Text.ToString());
                pr.Precio = precio;
                pr.Descripcion = txtproducto_descriocion.Text;
                pr.Producto = txtproducto_name.Text;



                if (cp.saveProduct(pr))
                {

                    MetroMessageBox.Show(this, "Producto registrado con exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                }
                else
                {
                    MetroMessageBox.Show(this, "Producto no registrado", "Por favor verificar los capos en blanco," + "\n O verifique que el nombre del producto no esta repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "FAVOR NO DEJAR CAMPOS EN BLANCO", "peligro!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
