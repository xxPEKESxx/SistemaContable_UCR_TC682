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

namespace SistemaContable_UCR_VIEWS
{
    public partial class FRM_GestionVentas : MetroForm
    {
        public FRM_GestionVentas()
        {
            InitializeComponent();
        }

        private void metroTileAgregarProducto_Click(object sender, EventArgs e)
        {
            FRM_Productos producto = new FRM_Productos();
            producto.Visible = true;

            this.Visible = false;
        }
    }
}
