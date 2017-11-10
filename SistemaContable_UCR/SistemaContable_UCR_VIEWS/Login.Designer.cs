namespace SistemaContable_UCR_VIEWS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroTile_Register = new MetroFramework.Controls.MetroTile();
            this.metroTile_Entrar = new MetroFramework.Controls.MetroTile();
            this.metroTextBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.idUser = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroTile_Register
            // 
            this.metroTile_Register.ActiveControl = null;
            this.metroTile_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroTile_Register.Location = new System.Drawing.Point(23, 455);
            this.metroTile_Register.MaximumSize = new System.Drawing.Size(177, 104);
            this.metroTile_Register.MinimumSize = new System.Drawing.Size(177, 104);
            this.metroTile_Register.Name = "metroTile_Register";
            this.metroTile_Register.Size = new System.Drawing.Size(177, 104);
            this.metroTile_Register.Style = MetroFramework.MetroColorStyle.Custom;
            this.metroTile_Register.TabIndex = 0;
            this.metroTile_Register.Text = "Registrarse";
            this.metroTile_Register.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Register.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.icons8_Add_User_Male_48;
            this.metroTile_Register.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Register.UseCustomBackColor = true;
            this.metroTile_Register.UseSelectable = true;
            this.metroTile_Register.UseTileImage = true;
            // 
            // metroTile_Entrar
            // 
            this.metroTile_Entrar.ActiveControl = null;
            this.metroTile_Entrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTile_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroTile_Entrar.Location = new System.Drawing.Point(259, 455);
            this.metroTile_Entrar.Name = "metroTile_Entrar";
            this.metroTile_Entrar.Size = new System.Drawing.Size(177, 103);
            this.metroTile_Entrar.Style = MetroFramework.MetroColorStyle.Custom;
            this.metroTile_Entrar.TabIndex = 0;
            this.metroTile_Entrar.Text = "ENTRAR";
            this.metroTile_Entrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Entrar.TileImage = global::SistemaContable_UCR_VIEWS.Properties.Resources.icons8_Checked_48;
            this.metroTile_Entrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Entrar.UseCustomBackColor = true;
            this.metroTile_Entrar.UseSelectable = true;
            this.metroTile_Entrar.UseTileImage = true;
            this.metroTile_Entrar.Click += new System.EventHandler(this.metroTile_Entrar_Click);
            // 
            // metroTextBox_Password
            // 
            // 
            // 
            // 
            this.metroTextBox_Password.CustomButton.Image = null;
            this.metroTextBox_Password.CustomButton.Location = new System.Drawing.Point(379, 2);
            this.metroTextBox_Password.CustomButton.Name = "";
            this.metroTextBox_Password.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBox_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Password.CustomButton.TabIndex = 1;
            this.metroTextBox_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Password.CustomButton.UseSelectable = true;
            this.metroTextBox_Password.CustomButton.Visible = false;
            this.metroTextBox_Password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox_Password.Lines = new string[0];
            this.metroTextBox_Password.Location = new System.Drawing.Point(23, 291);
            this.metroTextBox_Password.Margin = new System.Windows.Forms.Padding(60);
            this.metroTextBox_Password.MaxLength = 32767;
            this.metroTextBox_Password.Name = "metroTextBox_Password";
            this.metroTextBox_Password.PasswordChar = '●';
            this.metroTextBox_Password.PromptText = "CONTRASEÑA";
            this.metroTextBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Password.SelectedText = "";
            this.metroTextBox_Password.SelectionLength = 0;
            this.metroTextBox_Password.SelectionStart = 0;
            this.metroTextBox_Password.ShortcutsEnabled = true;
            this.metroTextBox_Password.Size = new System.Drawing.Size(413, 36);
            this.metroTextBox_Password.TabIndex = 20;
            this.metroTextBox_Password.Tag = "";
            this.metroTextBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox_Password.UseSelectable = true;
            this.metroTextBox_Password.UseSystemPasswordChar = true;
            this.metroTextBox_Password.WaterMark = "CONTRASEÑA";
            this.metroTextBox_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Password.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // idUser
            // 
            // 
            // 
            // 
            this.idUser.CustomButton.Image = null;
            this.idUser.CustomButton.Location = new System.Drawing.Point(379, 1);
            this.idUser.CustomButton.Name = "";
            this.idUser.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.idUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idUser.CustomButton.TabIndex = 1;
            this.idUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idUser.CustomButton.UseSelectable = true;
            this.idUser.CustomButton.Visible = false;
            this.idUser.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.idUser.Lines = new string[0];
            this.idUser.Location = new System.Drawing.Point(23, 181);
            this.idUser.MaxLength = 32767;
            this.idUser.Multiline = true;
            this.idUser.Name = "idUser";
            this.idUser.PasswordChar = '\0';
            this.idUser.PromptText = "CEDULA";
            this.idUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idUser.SelectedText = "";
            this.idUser.SelectionLength = 0;
            this.idUser.SelectionStart = 0;
            this.idUser.ShortcutsEnabled = true;
            this.idUser.Size = new System.Drawing.Size(413, 35);
            this.idUser.TabIndex = 1;
            this.idUser.Tag = "";
            this.idUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idUser.UseSelectable = true;
            this.idUser.WaterMark = "CEDULA";
            this.idUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idUser.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(29, 375);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(87, 15);
            this.metroCheckBox1.TabIndex = 21;
            this.metroCheckBox1.Text = "Recordarme";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 596);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.metroTextBox_Password);
            this.Controls.Add(this.metroTile_Register);
            this.Controls.Add(this.metroTile_Entrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Inicio de Sesión";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile_Entrar;
        private MetroFramework.Controls.MetroTile metroTile_Register;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Password;
        private MetroFramework.Controls.MetroTextBox idUser;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}

