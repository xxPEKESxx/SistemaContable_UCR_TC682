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
    public partial class FRM_Ventas : MetroForm
    {
        public FRM_Ventas()
        {
            InitializeComponent();
            Transacciones pr = new Transacciones();

            CoordinadorDeTransacciones cp = new CoordinadorDeTransacciones();
            List<Transacciones> data = cp.getByType(2);
            DataTable _table = ConvertirListaToDataTable(data);



            //foreach (Productos item in data)
            //{
            //   DataRow dr = _table.NewRow();
            //  dr[0] = item;
            //  _table.Rows.Add(dr);
            //}
            dataGrip_listaProductos.DataSource = _table;
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
    }
}
