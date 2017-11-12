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

namespace SistemaContable_UCR_VIEWS
{
    public partial class FRM_HistorialVentas : MetroForm
    {
        int IDVenta = 0;
        public FRM_HistorialVentas()
        {
            InitializeComponent();
            cargar();
        }

        private void FRM_HistorialVentas_Load(object sender, EventArgs e)
        {

        }

        private void dataGrip_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargar()
        {
            Transacciones pr = new Transacciones();

            CoordinadorDeTransacciones cp = new CoordinadorDeTransacciones();
            List<Transacciones> data = cp.getByType(1);
            DataTable _table = ConvertirListaToDataTable(data);



            dataGrip_listaProductos.DataSource = _table;
            dataGrip_listaProductos.ReadOnly = true;
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

        private void dataGrip_listaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
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
                this.IDVenta = pr.ID;
            }

            txtcantidad_name.Text = (pr.Cantidad.ToString());

        }
    }
}
