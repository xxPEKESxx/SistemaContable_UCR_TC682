namespace SistemaContable_UCR_VIEWS
{
    partial class FRM_Ventas
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
            this.producto_Edita = new MetroFramework.Controls.MetroTile();
            this.producto_Atras = new MetroFramework.Controls.MetroTile();
            this.btn_agreagar_user = new MetroFramework.Controls.MetroTile();
            this.dataGrip_listaProductos = new MetroFramework.Controls.MetroGrid();
            this.txtVentas_Name = new MetroFramework.Controls.MetroTextBox();
            this.txtVentas_Cantidad = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtventa_Total = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrip_listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // producto_Edita
            // 
            this.producto_Edita.ActiveControl = null;
            this.producto_Edita.Location = new System.Drawing.Point(221, 170);
            this.producto_Edita.Name = "producto_Edita";
            this.producto_Edita.Size = new System.Drawing.Size(80, 106);
            this.producto_Edita.Style = MetroFramework.MetroColorStyle.Lime;
            this.producto_Edita.TabIndex = 10;
            this.producto_Edita.Text = "EDITAR";
            this.producto_Edita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.producto_Edita.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_clipboard_variant_edit;
            this.producto_Edita.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.producto_Edita.UseSelectable = true;
            this.producto_Edita.UseStyleColors = true;
            this.producto_Edita.UseTileImage = true;
            // 
            // producto_Atras
            // 
            this.producto_Atras.ActiveControl = null;
            this.producto_Atras.Location = new System.Drawing.Point(362, 170);
            this.producto_Atras.Name = "producto_Atras";
            this.producto_Atras.Size = new System.Drawing.Size(135, 106);
            this.producto_Atras.Style = MetroFramework.MetroColorStyle.Lime;
            this.producto_Atras.TabIndex = 11;
            this.producto_Atras.Text = "ATRAS..";
            this.producto_Atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.producto_Atras.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_arrow_left;
            this.producto_Atras.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.producto_Atras.UseSelectable = true;
            this.producto_Atras.UseStyleColors = true;
            this.producto_Atras.UseTileImage = true;
            // 
            // btn_agreagar_user
            // 
            this.btn_agreagar_user.ActiveControl = null;
            this.btn_agreagar_user.Location = new System.Drawing.Point(23, 170);
            this.btn_agreagar_user.Name = "btn_agreagar_user";
            this.btn_agreagar_user.Size = new System.Drawing.Size(135, 106);
            this.btn_agreagar_user.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_agreagar_user.TabIndex = 13;
            this.btn_agreagar_user.Text = "AGREGAR VENTA";
            this.btn_agreagar_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_agreagar_user.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_thumb_up_add;
            this.btn_agreagar_user.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_agreagar_user.UseSelectable = true;
            this.btn_agreagar_user.UseTileImage = true;
            this.btn_agreagar_user.Click += new System.EventHandler(this.btn_agreagar_user_Click);
            // 
            // dataGrip_listaProductos
            // 
            this.dataGrip_listaProductos.AllowUserToResizeRows = false;
            this.dataGrip_listaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrip_listaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrip_listaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrip_listaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrip_listaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrip_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrip_listaProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrip_listaProductos.EnableHeadersVisualStyles = false;
            this.dataGrip_listaProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGrip_listaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrip_listaProductos.Location = new System.Drawing.Point(23, 282);
            this.dataGrip_listaProductos.Name = "dataGrip_listaProductos";
            this.dataGrip_listaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrip_listaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrip_listaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrip_listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrip_listaProductos.Size = new System.Drawing.Size(474, 227);
            this.dataGrip_listaProductos.Style = MetroFramework.MetroColorStyle.Lime;
            this.dataGrip_listaProductos.TabIndex = 4;
            this.dataGrip_listaProductos.UseStyleColors = true;
            this.dataGrip_listaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrip_listaProductos_CellContentClick);
            // 
            // txtVentas_Name
            // 
            // 
            // 
            // 
            this.txtVentas_Name.CustomButton.Image = null;
            this.txtVentas_Name.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtVentas_Name.CustomButton.Name = "";
            this.txtVentas_Name.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtVentas_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVentas_Name.CustomButton.TabIndex = 1;
            this.txtVentas_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVentas_Name.CustomButton.UseSelectable = true;
            this.txtVentas_Name.CustomButton.Visible = false;
            this.txtVentas_Name.Lines = new string[0];
            this.txtVentas_Name.Location = new System.Drawing.Point(23, 88);
            this.txtVentas_Name.MaxLength = 32767;
            this.txtVentas_Name.Name = "txtVentas_Name";
            this.txtVentas_Name.PasswordChar = '\0';
            this.txtVentas_Name.PromptText = "PRODUCTO";
            this.txtVentas_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVentas_Name.SelectedText = "";
            this.txtVentas_Name.SelectionLength = 0;
            this.txtVentas_Name.SelectionStart = 0;
            this.txtVentas_Name.ShortcutsEnabled = true;
            this.txtVentas_Name.Size = new System.Drawing.Size(199, 42);
            this.txtVentas_Name.TabIndex = 14;
            this.txtVentas_Name.UseSelectable = true;
            this.txtVentas_Name.WaterMark = "PRODUCTO";
            this.txtVentas_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVentas_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtVentas_Cantidad
            // 
            // 
            // 
            // 
            this.txtVentas_Cantidad.CustomButton.Image = null;
            this.txtVentas_Cantidad.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.txtVentas_Cantidad.CustomButton.Name = "";
            this.txtVentas_Cantidad.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtVentas_Cantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVentas_Cantidad.CustomButton.TabIndex = 1;
            this.txtVentas_Cantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVentas_Cantidad.CustomButton.UseSelectable = true;
            this.txtVentas_Cantidad.CustomButton.Visible = false;
            this.txtVentas_Cantidad.Lines = new string[0];
            this.txtVentas_Cantidad.Location = new System.Drawing.Point(299, 88);
            this.txtVentas_Cantidad.MaxLength = 32767;
            this.txtVentas_Cantidad.Name = "txtVentas_Cantidad";
            this.txtVentas_Cantidad.PasswordChar = '\0';
            this.txtVentas_Cantidad.PromptText = "CANTIDAD DE PRODUCTO";
            this.txtVentas_Cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVentas_Cantidad.SelectedText = "";
            this.txtVentas_Cantidad.SelectionLength = 0;
            this.txtVentas_Cantidad.SelectionStart = 0;
            this.txtVentas_Cantidad.ShortcutsEnabled = true;
            this.txtVentas_Cantidad.Size = new System.Drawing.Size(198, 42);
            this.txtVentas_Cantidad.TabIndex = 14;
            this.txtVentas_Cantidad.UseSelectable = true;
            this.txtVentas_Cantidad.WaterMark = "CANTIDAD DE PRODUCTO";
            this.txtVentas_Cantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVentas_Cantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "TOTAL DE VENTAS:";
            // 
            // txtventa_Total
            // 
            // 
            // 
            // 
            this.txtventa_Total.CustomButton.Image = null;
            this.txtventa_Total.CustomButton.Location = new System.Drawing.Point(71, 2);
            this.txtventa_Total.CustomButton.Name = "";
            this.txtventa_Total.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtventa_Total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtventa_Total.CustomButton.TabIndex = 1;
            this.txtventa_Total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtventa_Total.CustomButton.UseSelectable = true;
            this.txtventa_Total.CustomButton.Visible = false;
            this.txtventa_Total.Enabled = false;
            this.txtventa_Total.Lines = new string[0];
            this.txtventa_Total.Location = new System.Drawing.Point(374, 515);
            this.txtventa_Total.MaxLength = 32767;
            this.txtventa_Total.Multiline = true;
            this.txtventa_Total.Name = "txtventa_Total";
            this.txtventa_Total.PasswordChar = '\0';
            this.txtventa_Total.PromptText = "TOTAL";
            this.txtventa_Total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtventa_Total.SelectedText = "";
            this.txtventa_Total.SelectionLength = 0;
            this.txtventa_Total.SelectionStart = 0;
            this.txtventa_Total.ShortcutsEnabled = true;
            this.txtventa_Total.Size = new System.Drawing.Size(111, 42);
            this.txtventa_Total.TabIndex = 14;
            this.txtventa_Total.UseSelectable = true;
            this.txtventa_Total.WaterMark = "TOTAL";
            this.txtventa_Total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtventa_Total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FRM_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVentas_Cantidad);
            this.Controls.Add(this.txtventa_Total);
            this.Controls.Add(this.txtVentas_Name);
            this.Controls.Add(this.producto_Edita);
            this.Controls.Add(this.producto_Atras);
            this.Controls.Add(this.btn_agreagar_user);
            this.Controls.Add(this.dataGrip_listaProductos);
            this.Name = "FRM_Ventas";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrip_listaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile producto_Edita;
        private MetroFramework.Controls.MetroTile producto_Atras;
        private MetroFramework.Controls.MetroTile btn_agreagar_user;
        private MetroFramework.Controls.MetroGrid dataGrip_listaProductos;
        private MetroFramework.Controls.MetroTextBox txtVentas_Name;
        private MetroFramework.Controls.MetroTextBox txtVentas_Cantidad;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtventa_Total;
    }
}