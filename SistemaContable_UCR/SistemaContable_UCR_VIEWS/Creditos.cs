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


namespace SistemaContable_UCR_VIEWS
{
    public partial class Creditos : MetroForm
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void Creditos_Load(object sender, EventArgs e)
        {

        }

        private void Creditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();
            oc.Visible = true;

        }
    }
}
