using System;
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
        public int IdProducto = 0;
        
        public FRM_Productos()
        {
            InitializeComponent();

            cargarLista();
            cargarCbx_productos();
            cargar_txteditables();
            
            
            
        }
        public void cargarCbx_productos() {


            List<Productos> productos = new List<Productos>();
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            productos = coordinadorDeProductos.getAllProducts();

            this.cbx_editar_seleccionproducto.DataSource = productos;
            this.cbx_editar_seleccionproducto.ValueMember = "ID";
            this.cbx_editar_seleccionproducto.DisplayMember = "Producto";

            this.cbx_eliminar_seleccion.DataSource = productos;
            this.cbx_eliminar_seleccion.ValueMember = "ID";
            this.cbx_eliminar_seleccion.DisplayMember = "Producto";


            this.cbx_muestraProductos.DataSource = productos;
            this.cbx_muestraProductos.ValueMember = "ID";
            this.cbx_muestraProductos.DisplayMember = "Producto";


        }
        public void cargarLista()
        {
            Productos pr = new Productos();

            CoordinadorDeProductos cp = new CoordinadorDeProductos();
            List<Productos> data = cp.getAllProducts();
            DataTable _table = ConvertirListaToDataTable(data);

            metroGrid1_muestra_.DataSource = _table;

            metroGrid1_muestra_.ReadOnly = true;

        }
        public void cargar_txteditables() {
            
                if (cbx_editar_seleccionproducto.Items!=null) {

                txt_editar_nombre.Enabled = true;
                txt_editar_precio.Enabled = true;
                txt_editar_descripcion.Enabled = true;
            }
        }


        private void FRM_Productos_Load(object sender, EventArgs e)
        {

        }

        private void producto_Atras_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            Operation__Center pc = new Operation__Center();
            pc.Visible = true;
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

        //private void dataGrip_listaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        ////{
        ////    Productos pr = new Productos();
        //// DataGridView dgv = sender as DataGridView;

        ////    if (dgv == null)
        ////        return;
        ////    if (dgv.CurrentRow.Selected)
        ////    {
        ////        Productos pro = new Productos
        ////        {
        ////            ID = (int)dgv.CurrentRow.Cells["ID"].Value,

        ////        };

        ////        CoordinadorDeProductos cp = new CoordinadorDeProductos();
        ////        pr = cp.getById(pro.ID);
        ////        IdProducto = pr.ID;
        ////    }

        ////    txtproducto_precio.Text = (pr.Precio.ToString());
        ////    txtproducto_descriocion.Text = (pr.Descripcion.ToString());
        ////    txtproducto_name.Text = (pr.Precio.ToString());


        ////}

        //private void producto_Edita_Click(object sender, EventArgs e)
        ////{

        //}

     
     

        //private void btn_Agregar_Click(object sender, EventArgs e)
        ////{



        //}

        private void FRM_Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Operation__Center oc = new Operation__Center();
            this.Visible = false;
            oc.Visible = true;
        }

        private void producto_Eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void producto_Buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tab_mostrar_Productos_Click(object sender, EventArgs e)
        {

        }
        public void mostrarVentanaOperaciones() {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;
        }

        private void btn_Atras_Agregar_Click(object sender, EventArgs e)
        {
            mostrarVentanaOperaciones();
        }

        private void btn_Agregar_Agregar_Click(object sender, EventArgs e)
        {


            Productos pr = new Productos();

            CoordinadorDeProductos cp = new CoordinadorDeProductos();

            float precio = 0;
            if (txtDescripcion_Agregar.Text != "" && TxtPrecio_Agregar.Text != ""
                && Txt_nombre_Agrega.Text != "")
            {


                precio = float.Parse(TxtPrecio_Agregar.Text.ToString());
                pr.Precio = precio;
                pr.Descripcion = txtDescripcion_Agregar.Text;
                pr.Producto = Txt_nombre_Agrega.Text;
               
               



                if (cp.saveProduct(pr))
                {

                    MetroMessageBox.Show(this, "Producto registrado con exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                    cargarCbx_productos();
                }
                else
                {
                    MetroMessageBox.Show(this, "Producto no registrado", "Por favor verificar los capos en blanco," + "\n O verifique que el nombre del producto no esta repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                    cargarCbx_productos();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "FAVOR NO DEJAR CAMPOS EN BLANCO", "peligro!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_editar_Atras_Click(object sender, EventArgs e)
        {
            mostrarVentanaOperaciones();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            mostrarVentanaOperaciones();
        }

        private void btn_muestra_Atras_Click(object sender, EventArgs e)
        {
            mostrarVentanaOperaciones();
        }

        private void btn_editar_Agregar_Click(object sender, EventArgs e)
        {


            Productos producto = new Productos();

            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
          

            if (txt_editar_descripcion.Text != "" && txt_editar_precio.Text != ""
                && txt_editar_nombre.Text != "")
            {

                float precio = float.Parse(txt_editar_precio.Text.ToString());
                producto.Precio = precio;
                producto.Descripcion = txt_editar_descripcion.Text;
                producto.Producto = txt_editar_nombre.Text;
                producto.ID =  Convert.ToInt32(cbx_editar_seleccionproducto.SelectedValue);



                if (coordinadorDeProductos.updateProduct(producto))
                {

                    MetroMessageBox.Show(this, "Producto editado con exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                }
                else
                {
                    MetroMessageBox.Show(this, "Producto no editado", "Por favor verificar los capos en blanco," + "\n O verifique que el nombre del producto no esta repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "FAVOR NO DEJAR CAMPOS EN BLANCO", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_eliminar_elimnar_Click(object sender, EventArgs e)
        {


            Productos producto = new Productos();
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();


            producto.ID = Convert.ToInt32(cbx_eliminar_seleccion.SelectedValue);

            
            if (coordinadorDeProductos.deleteProduct(producto.ID))
                {

                    MetroMessageBox.Show(this, "Producto eliminado con exito", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                cargarCbx_productos();
                }
                else
                {
                    MetroMessageBox.Show(this, "Producto no eliminado", "Por favor verificar los capos en blanco," + "\n O verifique que el nombre del producto no esta repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                cargarCbx_productos();
            }
           

        }

        private void btn_muestra_Buscar_Click(object sender, EventArgs e)
        {
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            List<Productos> productoABuscar = new List<Productos>();


          
                productoABuscar = coordinadorDeProductos.getByProducto(cbx_muestraProductos.Text);


                /// producto.ID = productoAEditar.ID;
                DataTable _table = ConvertirListaToDataTable(productoABuscar);

                metroGrid1_muestra_.DataSource = _table;

                metroGrid1_muestra_.ReadOnly = true;



                if (productoABuscar.Count > 0)
                {

                    MetroMessageBox.Show(this, "Producto encontrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MetroMessageBox.Show(this, "Producto no encontrado", "," + "\n O Por favor verifique que el nombre del producto este correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarLista();
                }
            

        }
    }
    }

