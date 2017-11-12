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
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_VIEWS
{
    public partial class FRM_GestionCompras : MetroForm
    {
        public int IDCompra = 0;
        public FRM_GestionCompras()
        {
            InitializeComponent();

            List<Productos> productos = new List<Productos>();
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            productos = coordinadorDeProductos.getAllProducts();
            this.cmbProductos.DataSource = productos;
            this.cmbProductos.ValueMember = "ID";
            this.cmbProductos.DisplayMember = "Producto";
            //this.cmbProductos.DataSource = categoria.CategoriaSeleccionar().Tables[0].DefaultView;
            cargarGridCompras();

        }

        public void cargarGridCompras()
        {
            Transacciones pr = new Transacciones();

            CoordinadorDeTransacciones cp = new CoordinadorDeTransacciones();
            List<Transacciones> data = cp.getByType(2);
            DataTable _table = ConvertirListaToDataTable(data);



            metroGridCompras.DataSource = _table;
            metroGridCompras.ReadOnly = true;
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

        private void metroTileAgregarCompra_Click(object sender, EventArgs e)
        {
            Transacciones transacciones = new Transacciones();

            

           
            CoordinadorDeTransacciones coordinadorDeTransacciones = new CoordinadorDeTransacciones();



            if (txtVentas_Cantidad.Text != "")
            {
                transacciones.Cantidad = int.Parse(txtVentas_Cantidad.Text);
                transacciones.IdProducto = Convert.ToInt32(cmbProductos.SelectedValue);

                transacciones.IdTipo = 2;

                if (coordinadorDeTransacciones.Save(transacciones) != 0)
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

        private void metroTileEditar_Click(object sender, EventArgs e)
        {

        }

        private void metroGridCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Transacciones pr = new Transacciones();
            DataGridView dgv = sender as DataGridView;

            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                Transacciones pro = new Transacciones
                {
                    ID = (int)dgv.CurrentRow.Cells["ID"].Value,

                };


                CoordinadorDeTransacciones coordinacionDeTransacciones = new CoordinadorDeTransacciones();

                pr = coordinacionDeTransacciones.getById(pro.ID);
                this.IDCompra = pr.ID;
            }

            metroTextBoxEditarTab.Text = (pr.Cantidad.ToString());
        }

        private void metroTileEliminar_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTransacciones = new CoordinadorDeTransacciones();
            Transacciones transaccionAEliminar = coordinadorDeTransacciones.getById(IDCompra);

            
                /// producto.ID = productoAEditar.ID;



                if (coordinadorDeTransacciones.Delete(transaccionAEliminar.ID) > 0)
                {

                    MetroMessageBox.Show(this, "Producto eliminado con exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGridCompras();
                }
                else
                {
                    MetroMessageBox.Show(this, "Producto no eliminado", "Por favor verificar los capos en blanco," + "\n O verifique que el nombre del producto no esta repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGridCompras();
                }
            
        }

        private void metroTileBuscar_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTransacciones = new CoordinadorDeTransacciones();
            List<Transacciones> transaccionABuscar = new List<Transacciones>();

            transaccionABuscar = coordinadorDeTransacciones.getByName(txtBuscar.Text);

            DataTable _table = ConvertirListaToDataTable(transaccionABuscar);

            metroGridCompras.DataSource = _table;

            metroGridCompras.ReadOnly = true;
        }

        private void metroTileFiltrar_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTransacciones = new CoordinadorDeTransacciones();
            List<Transacciones> transaccionAFiltrar = new List<Transacciones>();

            transaccionAFiltrar = coordinadorDeTransacciones.getByDate(metroDateTimeDesde.Value, metroDateTimeHasta.Value);

            DataTable _table = ConvertirListaToDataTable(transaccionAFiltrar);

            metroGridFiltrar.DataSource = _table;

            metroGridFiltrar.ReadOnly = true;


        }
    }
}
