namespace SistemaContable_UCR_VIEWS
{
    partial class FRM_Balance
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
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCompras = new MetroFramework.Controls.MetroLabel();
            this.metroLabelVentas = new MetroFramework.Controls.MetroLabel();
            this.metroLabelUtilidad = new MetroFramework.Controls.MetroLabel();
            this.metroTileAtrasEditar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(59, 88);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroDateTime1.TabIndex = 0;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(433, 367);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(92, 93);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Generar";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(59, 204);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Total de Compras:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(296, 204);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Total de Ventas:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(537, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Total de Utilidad:";
            // 
            // metroLabelCompras
            // 
            this.metroLabelCompras.AutoSize = true;
            this.metroLabelCompras.Location = new System.Drawing.Point(83, 278);
            this.metroLabelCompras.Name = "metroLabelCompras";
            this.metroLabelCompras.Size = new System.Drawing.Size(38, 19);
            this.metroLabelCompras.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabelCompras.TabIndex = 5;
            this.metroLabelCompras.Text = "Valor";
            // 
            // metroLabelVentas
            // 
            this.metroLabelVentas.AutoSize = true;
            this.metroLabelVentas.Location = new System.Drawing.Point(326, 278);
            this.metroLabelVentas.Name = "metroLabelVentas";
            this.metroLabelVentas.Size = new System.Drawing.Size(38, 19);
            this.metroLabelVentas.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabelVentas.TabIndex = 6;
            this.metroLabelVentas.Text = "Valor";
            // 
            // metroLabelUtilidad
            // 
            this.metroLabelUtilidad.AutoSize = true;
            this.metroLabelUtilidad.Location = new System.Drawing.Point(562, 278);
            this.metroLabelUtilidad.Name = "metroLabelUtilidad";
            this.metroLabelUtilidad.Size = new System.Drawing.Size(38, 19);
            this.metroLabelUtilidad.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabelUtilidad.TabIndex = 7;
            this.metroLabelUtilidad.Text = "Valor";
            // 
            // metroTileAtrasEditar
            // 
            this.metroTileAtrasEditar.ActiveControl = null;
            this.metroTileAtrasEditar.Location = new System.Drawing.Point(550, 367);
            this.metroTileAtrasEditar.Name = "metroTileAtrasEditar";
            this.metroTileAtrasEditar.Size = new System.Drawing.Size(94, 93);
            this.metroTileAtrasEditar.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileAtrasEditar.TabIndex = 22;
            this.metroTileAtrasEditar.Text = "ATRAS";
            this.metroTileAtrasEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileAtrasEditar.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.appbar_arrow_left;
            this.metroTileAtrasEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAtrasEditar.UseSelectable = true;
            this.metroTileAtrasEditar.UseTileImage = true;
            this.metroTileAtrasEditar.Click += new System.EventHandler(this.metroTileAtrasEditar_Click);
            // 
            // FRM_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 483);
            this.Controls.Add(this.metroTileAtrasEditar);
            this.Controls.Add(this.metroLabelUtilidad);
            this.Controls.Add(this.metroLabelVentas);
            this.Controls.Add(this.metroLabelCompras);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroDateTime1);
            this.Name = "FRM_Balance";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabelCompras;
        private MetroFramework.Controls.MetroLabel metroLabelVentas;
        private MetroFramework.Controls.MetroLabel metroLabelUtilidad;
        private MetroFramework.Controls.MetroTile metroTileAtrasEditar;
    }
}