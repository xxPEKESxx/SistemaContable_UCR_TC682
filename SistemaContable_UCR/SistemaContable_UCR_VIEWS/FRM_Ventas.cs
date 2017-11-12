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
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;
using MetroFramework;

namespace SistemaContable_UCR_VIEWS
{
    public partial class FRM_Ventas : MetroForm
    {
        public int IDProducto = 0;
        public FRM_Ventas()
        {
            InitializeComponent();
            cargarListaProducto();
           
        }

        public void cargar() {
            Transacciones pr = new Transacciones();

            CoordinadorDeTransacciones cp = new CoordinadorDeTransacciones();
            List<Transacciones> data = cp.getByType(1);
            DataTable _table = ConvertirListaToDataTable(data);



            dataGrip_listaProductos.DataSource = _table;
            dataGrip_listaProductos.ReadOnly = true;
        }
        public void cargarListaProducto()
        {
            Productos pr = new Productos();

            CoordinadorDeProductos cp = new CoordinadorDeProductos();
            List<Productos> data = cp.getAllProducts();
            DataTable _table = ConvertirListaToDataTableProductos(data);

            dataGrip_listaProductos.DataSource = _table;

            dataGrip_listaProductos.ReadOnly = true;

        }


        public DataTable ConvertirListaToDataTableProductos(System.Collections.IList data)
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

        public DataTable ConvertirListaToDataTable(System.Collections.IList data)
        {
            Transacciones pr = new Transacciones();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(Transacciones));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties) table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (Transacciones item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties) row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                table.Rows.Add(row);
            }
            return table;
        }

        private void dataGrip_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
            
        }

        private void btn_agreagar_user_Click(object sender, EventArgs e)
        {
            Transacciones tran = new Transacciones();

            Productos pro = new Productos();

            CoordinadorDeProductos cp = new CoordinadorDeProductos();
            CoordinadorDeTransacciones ct = new CoordinadorDeTransacciones();


            if (txtVentas_Cantidad.Text != "")
            {
                tran.Cantidad = int.Parse(txtVentas_Cantidad.Text);
                tran.IdProducto = IDProducto;

                tran.IdTipo = 1;

                if (ct.Save(tran))
                {

                    MetroMessageBox.Show(this, "COMPRA REGISTRADA CON EXITO.", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MetroMessageBox.Show(this, "ERROR DE REGISTROS ", "NO SE REGISTRO LA COMPRA!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {

                MetroMessageBox.Show(this, "LLENE EL CAMPO DE CANTIDAD.", "ES NECESARIO LLENAR EL CAMPO DE CANTIDADES!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
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
                this.IDProducto = pr.ID;
            }

            txtVentas_Name.Text = (pr.Producto);

        }

        private void producto_Atras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();
            oc.Visible = true;

        }

        private void FRM_Ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Operation__Center oc = new Operation__Center();
            oc.Visible = true;
        }

        private void producto_Edita_Click(object sender, EventArgs e)
        {

        }
    }
}
