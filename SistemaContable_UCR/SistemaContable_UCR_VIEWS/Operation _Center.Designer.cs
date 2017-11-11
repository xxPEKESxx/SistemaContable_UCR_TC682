namespace SistemaContable_UCR_VIEWS
{
    partial class Operation__Center
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
            this.metroPanel_Information = new MetroFramework.Controls.MetroPanel();
            this.metroPanel_Menu = new MetroFramework.Controls.MetroPanel();
            this.metroPanel_Administration = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroPanel_Information
            // 
            this.metroPanel_Information.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroPanel_Information.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel_Information.HorizontalScrollbarBarColor = true;
            this.metroPanel_Information.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_Information.HorizontalScrollbarSize = 10;
            this.metroPanel_Information.Location = new System.Drawing.Point(20, 60);
            this.metroPanel_Information.Name = "metroPanel_Information";
            this.metroPanel_Information.Size = new System.Drawing.Size(1287, 100);
            this.metroPanel_Information.TabIndex = 0;
            this.metroPanel_Information.UseCustomBackColor = true;
            this.metroPanel_Information.VerticalScrollbarBarColor = true;
            this.metroPanel_Information.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_Information.VerticalScrollbarSize = 10;
            // 
            // metroPanel_Menu
            // 
            this.metroPanel_Menu.BackColor = System.Drawing.Color.Gray;
            this.metroPanel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel_Menu.HorizontalScrollbarBarColor = true;
            this.metroPanel_Menu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_Menu.HorizontalScrollbarSize = 10;
            this.metroPanel_Menu.Location = new System.Drawing.Point(20, 160);
            this.metroPanel_Menu.Name = "metroPanel_Menu";
            this.metroPanel_Menu.Size = new System.Drawing.Size(200, 572);
            this.metroPanel_Menu.Style = MetroFramework.MetroColorStyle.Custom;
            this.metroPanel_Menu.TabIndex = 1;
            this.metroPanel_Menu.UseCustomBackColor = true;
            this.metroPanel_Menu.VerticalScrollbarBarColor = true;
            this.metroPanel_Menu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_Menu.VerticalScrollbarSize = 10;
            // 
            // metroPanel_Administration
            // 
            this.metroPanel_Administration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel_Administration.HorizontalScrollbarBarColor = true;
            this.metroPanel_Administration.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_Administration.HorizontalScrollbarSize = 10;
            this.metroPanel_Administration.Location = new System.Drawing.Point(220, 160);
            this.metroPanel_Administration.Name = "metroPanel_Administration";
            this.metroPanel_Administration.Size = new System.Drawing.Size(1087, 572);
            this.metroPanel_Administration.TabIndex = 2;
            this.metroPanel_Administration.VerticalScrollbarBarColor = true;
            this.metroPanel_Administration.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_Administration.VerticalScrollbarSize = 10;
            this.metroPanel_Administration.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel_Administration_Paint);
            // 
            // Operation__Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 752);
            this.Controls.Add(this.metroPanel_Administration);
            this.Controls.Add(this.metroPanel_Menu);
            this.Controls.Add(this.metroPanel_Information);
            this.Name = "Operation__Center";
            this.Text = "Sistema Contable UCR (tc682)";
            this.Load += new System.EventHandler(this.Operation__Center_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel_Information;
        private MetroFramework.Controls.MetroPanel metroPanel_Menu;
        private MetroFramework.Controls.MetroPanel metroPanel_Administration;
    }
}