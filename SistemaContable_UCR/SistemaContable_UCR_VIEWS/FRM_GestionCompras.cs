﻿using System;
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

                if (coordinadorDeTransacciones.Save(transacciones))
                {

                    MetroMessageBox.Show(this, "COMPRA REGISTRADA CON EXITO.", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    cargarGridCompras();
                }
                else
                {

                    MetroMessageBox.Show(this, "ERROR DE REGISTROS ", "NO SE REGISTRO LA COMPRA!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }



            }
            else
            {

                MetroMessageBox.Show(this, "LLENE EL CAMPO DE CANTIDAD.", "ES NECESARIO LLENAR EL CAMPO DE CANTIDADES!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void metroTileEditar_Click(object sender, EventArgs e)
        {
            if (IDCompra!=0)
            {
                metroTabCompras.TabPages.Add(metroTabPageEditar);
                metroTabCompras.TabPages.Remove(metroTabPageAgregar);
                metroTabCompras.TabPages.Remove(metroTabPageFiltrar);
                metroTabCompras.TabPages.Remove(metroTabPageHistorial);
                this.metroTabCompras.SelectedTab = metroTabPageEditar;
            }
            else
            {
                MetroMessageBox.Show(this, "DEBE DE SELECCIONAR UN PRODUCTO.","!AVISO¡", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void metroGridCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Transacciones pr = new Transacciones();
            Productos productos = new Productos();
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
                CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
                productos = coordinadorDeProductos.getById(pr.IdProducto);
            }


            metroLabelNombreProducto.Text = productos.Producto;
            metroTextBoxEditarTab.Text = (pr.Cantidad.ToString());
        }

        private void metroTileEliminar_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTransacciones = new CoordinadorDeTransacciones();
            Transacciones transaccionAEliminar = coordinadorDeTransacciones.getById(IDCompra);

           

            DialogResult result=  MetroMessageBox.Show(this, "Realmente desea eliminar la compra seleccionada ??", "Eliminar Compra", MessageBoxButtons.YesNo);


            if (result==DialogResult.Yes) {
                if (coordinadorDeTransacciones.Delete(transaccionAEliminar.ID))
                {

                    MetroMessageBox.Show(this, "Compra eliminada con exito", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGridCompras();
                }
                else
                {
                    MetroMessageBox.Show(this, "Compra no eliminada", "Por favor verificar los capos en blanco," + "\n ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGridCompras();
                }
            }

          
            
        }

        private void metroTileBuscar_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTransacciones = new CoordinadorDeTransacciones();
            List<Transacciones> transaccionABuscar = new List<Transacciones>();

            transaccionABuscar = coordinadorDeTransacciones.getComprasByProductName(txtBuscar.Text);

            DataTable _table = ConvertirListaToDataTable(transaccionABuscar);

            metroGridCompras.DataSource = _table;

            metroGridCompras.ReadOnly = true;
        }

        private void metroTileFiltrar_Click(object sender, EventArgs e)
        {
            CoordinadorDeTransacciones coordinadorDeTransacciones = new CoordinadorDeTransacciones();
            List<Transacciones> transaccionAFiltrar = new List<Transacciones>();

            transaccionAFiltrar = coordinadorDeTransacciones.getComprasByDate(metroDateTimeDesde.Value, metroDateTimeHasta.Value);

            DataTable _table = ConvertirListaToDataTable(transaccionAFiltrar);

            metroGridFiltrar.DataSource = _table;

            metroGridFiltrar.ReadOnly = true;


        }

        private void FRM_GestionCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Operation__Center oc = new Operation__Center();
            oc.Visible = true;

            this.Visible = false;


        }

        public void limpiarCampos()
        {
            txtBuscar.Text = "";
            txtVentas_Cantidad.Text = "";
            metroTextBoxEditarTab.Text = "";
            

        }

        private void metroTileAtrasHistorial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;
        }

        private void btn_Atras_Agregar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;
        }

        private void metroTileAtrasEditar_Click(object sender, EventArgs e)
        {
            metroTabCompras.TabPages.Remove(metroTabPageEditar);
            metroTabCompras.TabPages.Add(metroTabPageAgregar);
            metroTabCompras.TabPages.Add(metroTabPageFiltrar);
            metroTabCompras.TabPages.Add(metroTabPageHistorial);

            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Operation__Center oc = new Operation__Center();

            oc.Visible = true;
        }

        private void metroTileAgregarProducto_Click(object sender, EventArgs e)
        {
            Operation__Center center = new Operation__Center();
            center.Visible = true;

            this.Visible = false;
        }

        private void metroTileEditarTap_Click(object sender, EventArgs e)
        {
            Transacciones transaccionABuscar = new Transacciones();

            CoordinadorDeTransacciones coordinadorDeTransacciones = new CoordinadorDeTransacciones();

            transaccionABuscar = coordinadorDeTransacciones.getById(IDCompra);

            if (metroTextBoxEditarTab.Text != "")
            {
                transaccionABuscar.Cantidad = int.Parse(metroTextBoxEditarTab.Text);
                if (coordinadorDeTransacciones.Update(transaccionABuscar))
                {
                    metroTabCompras.TabPages.Remove(metroTabPageEditar);
                    metroTabCompras.TabPages.Add(metroTabPageHistorial);
                    metroTabCompras.TabPages.Add(metroTabPageAgregar);
                    metroTabCompras.TabPages.Add(metroTabPageFiltrar);
                    cargarGridCompras();
                    MetroMessageBox.Show(this, "EDICION REGISTRADA CON EXITO.", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    this.metroTabCompras.SelectedTab = metroTabPageHistorial;

                }

                else
                {

                    MetroMessageBox.Show(this, "ERROR DE REGISTROS ", "NO SE EDITO LA COMPRA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
            }
            else
            {

                MetroMessageBox.Show(this, "LLENE EL CAMPO DE CANTIDAD.", "ES NECESARIO LLENAR EL CAMPO DE CANTIDADES!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void txtVentas_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "CAMPOS NUMERICOS", "," + "\n NO SE PERMITEN LETRAS..", MessageBoxButtons.OK, MessageBoxIcon.Information);

                e.Handled = true;
                return;
            }
        }

        private void metroTextBoxEditarTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "CAMPOS NUMERICOS", "," + "\n NO SE PERMITEN LETRAS..", MessageBoxButtons.OK, MessageBoxIcon.Information);

                e.Handled = true;
                return;
            }
        }

        private void metroTabPageEditar_Click(object sender, EventArgs e)
        {

        }

        private void FRM_GestionCompras_Load(object sender, EventArgs e)
        {
            metroTabCompras.TabPages.Remove(metroTabPageEditar);
        }

        private void btn_gastos_atras_Click(object sender, EventArgs e)
        {
            Operation__Center oc = new Operation__Center();
            oc.Visible = true;
            this.Visible = false;

        }
    }
}
