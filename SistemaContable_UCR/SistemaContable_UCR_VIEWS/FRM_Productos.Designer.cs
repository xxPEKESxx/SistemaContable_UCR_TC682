﻿namespace SistemaContable_UCR_VIEWS
{
    partial class FRM_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Productos));
            this.dataGrip_listaProductos = new MetroFramework.Controls.MetroGrid();
            this.txtproducto_precio = new MetroFramework.Controls.MetroTextBox();
            this.txtproducto_name = new MetroFramework.Controls.MetroTextBox();
            this.txtproducto_descriocion = new MetroFramework.Controls.MetroTextBox();
            this.cbx_tipoProducto = new System.Windows.Forms.ComboBox();
            this.producto_Buscar = new MetroFramework.Controls.MetroTile();
            this.producto_Edita = new MetroFramework.Controls.MetroTile();
            this.producto_Atras = new MetroFramework.Controls.MetroTile();
            this.producto_Eliminar = new MetroFramework.Controls.MetroTile();
            this.btn_agreagar_user = new MetroFramework.Controls.MetroTile();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrip_listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrip_listaProductos
            // 
            this.dataGrip_listaProductos.AllowUserToResizeRows = false;
            this.dataGrip_listaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrip_listaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrip_listaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrip_listaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrip_listaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrip_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrip_listaProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrip_listaProductos.EnableHeadersVisualStyles = false;
            this.dataGrip_listaProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGrip_listaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrip_listaProductos.Location = new System.Drawing.Point(23, 323);
            this.dataGrip_listaProductos.Name = "dataGrip_listaProductos";
            this.dataGrip_listaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrip_listaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrip_listaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrip_listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrip_listaProductos.Size = new System.Drawing.Size(424, 283);
            this.dataGrip_listaProductos.TabIndex = 0;
            // 
            // txtproducto_precio
            // 
            // 
            // 
            // 
            this.txtproducto_precio.CustomButton.Image = null;
            this.txtproducto_precio.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtproducto_precio.CustomButton.Name = "";
            this.txtproducto_precio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtproducto_precio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtproducto_precio.CustomButton.TabIndex = 1;
            this.txtproducto_precio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtproducto_precio.CustomButton.UseSelectable = true;
            this.txtproducto_precio.CustomButton.Visible = false;
            this.txtproducto_precio.Lines = new string[0];
            this.txtproducto_precio.Location = new System.Drawing.Point(23, 147);
            this.txtproducto_precio.MaxLength = 32767;
            this.txtproducto_precio.Name = "txtproducto_precio";
            this.txtproducto_precio.PasswordChar = '\0';
            this.txtproducto_precio.PromptText = "Precio";
            this.txtproducto_precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproducto_precio.SelectedText = "";
            this.txtproducto_precio.SelectionLength = 0;
            this.txtproducto_precio.SelectionStart = 0;
            this.txtproducto_precio.ShortcutsEnabled = true;
            this.txtproducto_precio.Size = new System.Drawing.Size(166, 23);
            this.txtproducto_precio.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.txtproducto_precio, "El precio debe ser especificamente en colones.");
            this.txtproducto_precio.UseSelectable = true;
            this.txtproducto_precio.WaterMark = "Precio";
            this.txtproducto_precio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproducto_precio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtproducto_name
            // 
            // 
            // 
            // 
            this.txtproducto_name.CustomButton.Image = null;
            this.txtproducto_name.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtproducto_name.CustomButton.Name = "";
            this.txtproducto_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtproducto_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtproducto_name.CustomButton.TabIndex = 1;
            this.txtproducto_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtproducto_name.CustomButton.UseSelectable = true;
            this.txtproducto_name.CustomButton.Visible = false;
            this.txtproducto_name.Lines = new string[0];
            this.txtproducto_name.Location = new System.Drawing.Point(23, 108);
            this.txtproducto_name.MaxLength = 32767;
            this.txtproducto_name.Name = "txtproducto_name";
            this.txtproducto_name.PasswordChar = '\0';
            this.txtproducto_name.PromptText = "Nombre Producto";
            this.txtproducto_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproducto_name.SelectedText = "";
            this.txtproducto_name.SelectionLength = 0;
            this.txtproducto_name.SelectionStart = 0;
            this.txtproducto_name.ShortcutsEnabled = true;
            this.txtproducto_name.Size = new System.Drawing.Size(166, 23);
            this.txtproducto_name.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.txtproducto_name, "El nombre del producto es unico");
            this.txtproducto_name.UseSelectable = true;
            this.txtproducto_name.WaterMark = "Nombre Producto";
            this.txtproducto_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproducto_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtproducto_descriocion
            // 
            // 
            // 
            // 
            this.txtproducto_descriocion.CustomButton.Image = null;
            this.txtproducto_descriocion.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtproducto_descriocion.CustomButton.Name = "";
            this.txtproducto_descriocion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtproducto_descriocion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtproducto_descriocion.CustomButton.TabIndex = 1;
            this.txtproducto_descriocion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtproducto_descriocion.CustomButton.UseSelectable = true;
            this.txtproducto_descriocion.CustomButton.Visible = false;
            this.txtproducto_descriocion.Lines = new string[0];
            this.txtproducto_descriocion.Location = new System.Drawing.Point(281, 108);
            this.txtproducto_descriocion.MaxLength = 32767;
            this.txtproducto_descriocion.Name = "txtproducto_descriocion";
            this.txtproducto_descriocion.PasswordChar = '\0';
            this.txtproducto_descriocion.PromptText = "Descripcion";
            this.txtproducto_descriocion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproducto_descriocion.SelectedText = "";
            this.txtproducto_descriocion.SelectionLength = 0;
            this.txtproducto_descriocion.SelectionStart = 0;
            this.txtproducto_descriocion.ShortcutsEnabled = true;
            this.txtproducto_descriocion.Size = new System.Drawing.Size(166, 23);
            this.txtproducto_descriocion.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.txtproducto_descriocion, "breve descripcion del producto");
            this.txtproducto_descriocion.UseSelectable = true;
            this.txtproducto_descriocion.WaterMark = "Descripcion";
            this.txtproducto_descriocion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproducto_descriocion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbx_tipoProducto
            // 
            this.cbx_tipoProducto.FormattingEnabled = true;
            this.cbx_tipoProducto.Items.AddRange(new object[] {
            "Ventas",
            "Compras"});
            this.cbx_tipoProducto.Location = new System.Drawing.Point(281, 147);
            this.cbx_tipoProducto.Name = "cbx_tipoProducto";
            this.cbx_tipoProducto.Size = new System.Drawing.Size(166, 21);
            this.cbx_tipoProducto.TabIndex = 2;
            this.cbx_tipoProducto.Text = "Seleccione el tipo de producto";
            // 
            // producto_Buscar
            // 
            this.producto_Buscar.ActiveControl = null;
            this.producto_Buscar.Location = new System.Drawing.Point(195, 211);
            this.producto_Buscar.Name = "producto_Buscar";
            this.producto_Buscar.Size = new System.Drawing.Size(80, 106);
            this.producto_Buscar.TabIndex = 3;
            this.producto_Buscar.Text = "BUSCAR";
            this.producto_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.producto_Buscar.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_page_search;
            this.producto_Buscar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroToolTip1.SetToolTip(this.producto_Buscar, "Para Buscar productos,  , debes \r\nllenar el campo de \"Nombre Producto\" y dar clic" +
        "k izquierdo\r\ncon tu mouse.");
            this.producto_Buscar.UseSelectable = true;
            this.producto_Buscar.UseTileImage = true;
            // 
            // producto_Edita
            // 
            this.producto_Edita.ActiveControl = null;
            this.producto_Edita.Location = new System.Drawing.Point(109, 211);
            this.producto_Edita.Name = "producto_Edita";
            this.producto_Edita.Size = new System.Drawing.Size(80, 106);
            this.producto_Edita.TabIndex = 3;
            this.producto_Edita.Text = "EDITAR";
            this.producto_Edita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.producto_Edita.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_clipboard_variant_edit;
            this.producto_Edita.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroToolTip1.SetToolTip(this.producto_Edita, "Para editar productos, mediante\r\nel nombre de producto, debes \r\nllenar el campo y" +
        " dar click izquierdo\r\ncon tu mouse.");
            this.producto_Edita.UseSelectable = true;
            this.producto_Edita.UseTileImage = true;
            // 
            // producto_Atras
            // 
            this.producto_Atras.ActiveControl = null;
            this.producto_Atras.Location = new System.Drawing.Point(367, 211);
            this.producto_Atras.Name = "producto_Atras";
            this.producto_Atras.Size = new System.Drawing.Size(80, 106);
            this.producto_Atras.TabIndex = 3;
            this.producto_Atras.Text = "ATRAS..";
            this.producto_Atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.producto_Atras.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_arrow_left;
            this.producto_Atras.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroToolTip1.SetToolTip(this.producto_Atras, "Para salir al panel principal.");
            this.producto_Atras.UseSelectable = true;
            this.producto_Atras.UseTileImage = true;
            this.producto_Atras.Click += new System.EventHandler(this.producto_Atras_Click);
            // 
            // producto_Eliminar
            // 
            this.producto_Eliminar.ActiveControl = null;
            this.producto_Eliminar.Location = new System.Drawing.Point(281, 211);
            this.producto_Eliminar.Name = "producto_Eliminar";
            this.producto_Eliminar.Size = new System.Drawing.Size(80, 106);
            this.producto_Eliminar.TabIndex = 3;
            this.producto_Eliminar.Text = "ELIMINAR";
            this.producto_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.producto_Eliminar.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_delete;
            this.producto_Eliminar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroToolTip1.SetToolTip(this.producto_Eliminar, "Para eliminar  productos,  debes \r\nllenar el campo\"Nombre Producto\" y dar click i" +
        "zquierdo\r\ncon tu mouse.");
            this.producto_Eliminar.UseSelectable = true;
            this.producto_Eliminar.UseTileImage = true;
            // 
            // btn_agreagar_user
            // 
            this.btn_agreagar_user.ActiveControl = null;
            this.btn_agreagar_user.Location = new System.Drawing.Point(23, 211);
            this.btn_agreagar_user.Name = "btn_agreagar_user";
            this.btn_agreagar_user.Size = new System.Drawing.Size(80, 106);
            this.btn_agreagar_user.TabIndex = 3;
            this.btn_agreagar_user.Text = "AGREGAR";
            this.btn_agreagar_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_agreagar_user.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_thumb_up_add;
            this.btn_agreagar_user.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroToolTip1.SetToolTip(this.btn_agreagar_user, "Agrega un producto a la \r\nlista de productos");
            this.btn_agreagar_user.UseSelectable = true;
            this.btn_agreagar_user.UseTileImage = true;
            this.btn_agreagar_user.Click += new System.EventHandler(this.btn_agreagar_user_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // FRM_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 629);
            this.Controls.Add(this.producto_Buscar);
            this.Controls.Add(this.producto_Edita);
            this.Controls.Add(this.producto_Atras);
            this.Controls.Add(this.producto_Eliminar);
            this.Controls.Add(this.btn_agreagar_user);
            this.Controls.Add(this.cbx_tipoProducto);
            this.Controls.Add(this.txtproducto_name);
            this.Controls.Add(this.txtproducto_descriocion);
            this.Controls.Add(this.txtproducto_precio);
            this.Controls.Add(this.dataGrip_listaProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Productos";
            this.Text = "Gestion de Productos";
            this.Load += new System.EventHandler(this.FRM_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrip_listaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dataGrip_listaProductos;
        private MetroFramework.Controls.MetroTextBox txtproducto_precio;
        private MetroFramework.Controls.MetroTextBox txtproducto_name;
        private MetroFramework.Controls.MetroTextBox txtproducto_descriocion;
        private System.Windows.Forms.ComboBox cbx_tipoProducto;
        private MetroFramework.Controls.MetroTile btn_agreagar_user;
        private MetroFramework.Controls.MetroTile producto_Eliminar;
        private MetroFramework.Controls.MetroTile producto_Edita;
        private MetroFramework.Controls.MetroTile producto_Buscar;
        private MetroFramework.Controls.MetroTile producto_Atras;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}