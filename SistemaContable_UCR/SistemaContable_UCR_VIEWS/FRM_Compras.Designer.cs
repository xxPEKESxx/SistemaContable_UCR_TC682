﻿namespace SistemaContable_UCR_VIEWS
{
    partial class FRM_Compras
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
            this.btn_agreagar_compra = new MetroFramework.Controls.MetroTile();
            this.dataGrip_listaProductos = new MetroFramework.Controls.MetroGrid();
            this.txtproducto = new MetroFramework.Controls.MetroTextBox();
            this.TXTCantidadP_Compras = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrip_listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // producto_Edita
            // 
            this.producto_Edita.ActiveControl = null;
            this.producto_Edita.Location = new System.Drawing.Point(169, 156);
            this.producto_Edita.Name = "producto_Edita";
            this.producto_Edita.Size = new System.Drawing.Size(101, 106);
            this.producto_Edita.Style = MetroFramework.MetroColorStyle.Green;
            this.producto_Edita.TabIndex = 15;
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
            this.producto_Atras.Location = new System.Drawing.Point(324, 156);
            this.producto_Atras.Name = "producto_Atras";
            this.producto_Atras.Size = new System.Drawing.Size(110, 106);
            this.producto_Atras.Style = MetroFramework.MetroColorStyle.Green;
            this.producto_Atras.TabIndex = 16;
            this.producto_Atras.Text = "ATRAS..";
            this.producto_Atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.producto_Atras.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_arrow_left;
            this.producto_Atras.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.producto_Atras.UseSelectable = true;
            this.producto_Atras.UseStyleColors = true;
            this.producto_Atras.UseTileImage = true;
            this.producto_Atras.Click += new System.EventHandler(this.producto_Atras_Click);
            // 
            // btn_agreagar_compra
            // 
            this.btn_agreagar_compra.ActiveControl = null;
            this.btn_agreagar_compra.Location = new System.Drawing.Point(23, 156);
            this.btn_agreagar_compra.Name = "btn_agreagar_compra";
            this.btn_agreagar_compra.Size = new System.Drawing.Size(90, 106);
            this.btn_agreagar_compra.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_agreagar_compra.TabIndex = 17;
            this.btn_agreagar_compra.Text = "AGREGAR.";
            this.btn_agreagar_compra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_agreagar_compra.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_thumb_up_add;
            this.btn_agreagar_compra.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_agreagar_compra.UseSelectable = true;
            this.btn_agreagar_compra.UseTileImage = true;
            this.btn_agreagar_compra.Click += new System.EventHandler(this.btn_agreagar_compra_Click);
            // 
            // dataGrip_listaProductos
            // 
            this.dataGrip_listaProductos.AllowUserToResizeRows = false;
            this.dataGrip_listaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrip_listaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrip_listaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrip_listaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrip_listaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrip_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrip_listaProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrip_listaProductos.EnableHeadersVisualStyles = false;
            this.dataGrip_listaProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGrip_listaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGrip_listaProductos.Location = new System.Drawing.Point(23, 268);
            this.dataGrip_listaProductos.Name = "dataGrip_listaProductos";
            this.dataGrip_listaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrip_listaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrip_listaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrip_listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrip_listaProductos.Size = new System.Drawing.Size(411, 276);
            this.dataGrip_listaProductos.Style = MetroFramework.MetroColorStyle.Green;
            this.dataGrip_listaProductos.TabIndex = 14;
            this.dataGrip_listaProductos.UseStyleColors = true;
            this.dataGrip_listaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrip_listaProductos_CellContentClick);
            // 
            // txtproducto
            // 
            // 
            // 
            // 
            this.txtproducto.CustomButton.Image = null;
            this.txtproducto.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtproducto.CustomButton.Name = "";
            this.txtproducto.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtproducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtproducto.CustomButton.TabIndex = 1;
            this.txtproducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtproducto.CustomButton.UseSelectable = true;
            this.txtproducto.CustomButton.Visible = false;
            this.txtproducto.Lines = new string[0];
            this.txtproducto.Location = new System.Drawing.Point(23, 87);
            this.txtproducto.MaxLength = 32767;
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.PasswordChar = '\0';
            this.txtproducto.PromptText = "PRODUCTO";
            this.txtproducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproducto.SelectedText = "";
            this.txtproducto.SelectionLength = 0;
            this.txtproducto.SelectionStart = 0;
            this.txtproducto.ShortcutsEnabled = true;
            this.txtproducto.Size = new System.Drawing.Size(169, 35);
            this.txtproducto.TabIndex = 18;
            this.txtproducto.UseSelectable = true;
            this.txtproducto.WaterMark = "PRODUCTO";
            this.txtproducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXTCantidadP_Compras
            // 
            // 
            // 
            // 
            this.TXTCantidadP_Compras.CustomButton.Image = null;
            this.TXTCantidadP_Compras.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.TXTCantidadP_Compras.CustomButton.Name = "";
            this.TXTCantidadP_Compras.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TXTCantidadP_Compras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTCantidadP_Compras.CustomButton.TabIndex = 1;
            this.TXTCantidadP_Compras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTCantidadP_Compras.CustomButton.UseSelectable = true;
            this.TXTCantidadP_Compras.CustomButton.Visible = false;
            this.TXTCantidadP_Compras.Lines = new string[0];
            this.TXTCantidadP_Compras.Location = new System.Drawing.Point(265, 87);
            this.TXTCantidadP_Compras.MaxLength = 32767;
            this.TXTCantidadP_Compras.Name = "TXTCantidadP_Compras";
            this.TXTCantidadP_Compras.PasswordChar = '\0';
            this.TXTCantidadP_Compras.PromptText = "CANTIDAD";
            this.TXTCantidadP_Compras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTCantidadP_Compras.SelectedText = "";
            this.TXTCantidadP_Compras.SelectionLength = 0;
            this.TXTCantidadP_Compras.SelectionStart = 0;
            this.TXTCantidadP_Compras.ShortcutsEnabled = true;
            this.TXTCantidadP_Compras.Size = new System.Drawing.Size(169, 35);
            this.TXTCantidadP_Compras.TabIndex = 18;
            this.TXTCantidadP_Compras.UseSelectable = true;
            this.TXTCantidadP_Compras.WaterMark = "CANTIDAD";
            this.TXTCantidadP_Compras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTCantidadP_Compras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FRM_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 567);
            this.Controls.Add(this.TXTCantidadP_Compras);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.producto_Edita);
            this.Controls.Add(this.producto_Atras);
            this.Controls.Add(this.btn_agreagar_compra);
            this.Controls.Add(this.dataGrip_listaProductos);
            this.Name = "FRM_Compras";
            this.Text = "Compras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Compras_FormClosed);
            this.Load += new System.EventHandler(this.FRM_backup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrip_listaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile producto_Edita;
        private MetroFramework.Controls.MetroTile producto_Atras;
        private MetroFramework.Controls.MetroTile btn_agreagar_compra;
        private MetroFramework.Controls.MetroGrid dataGrip_listaProductos;
        private MetroFramework.Controls.MetroTextBox txtproducto;
        private MetroFramework.Controls.MetroTextBox TXTCantidadP_Compras;
    }
}