namespace InterfaceMedia
{
    partial class FrmConnexion
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIdentifiant = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnConnexion = new MetroFramework.Controls.MetroButton();
            this.lblMdpOublie = new MetroFramework.Controls.MetroLabel();
            this.btnQuitter = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(188, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Connexion";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(36, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Identifiant ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(36, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Mot de passe ";
            // 
            // txtIdentifiant
            // 
            // 
            // 
            // 
            this.txtIdentifiant.CustomButton.Image = null;
            this.txtIdentifiant.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtIdentifiant.CustomButton.Name = "";
            this.txtIdentifiant.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdentifiant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdentifiant.CustomButton.TabIndex = 1;
            this.txtIdentifiant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdentifiant.CustomButton.UseSelectable = true;
            this.txtIdentifiant.CustomButton.Visible = false;
            this.txtIdentifiant.Lines = new string[0];
            this.txtIdentifiant.Location = new System.Drawing.Point(154, 102);
            this.txtIdentifiant.MaxLength = 32767;
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.PasswordChar = '\0';
            this.txtIdentifiant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdentifiant.SelectedText = "";
            this.txtIdentifiant.SelectionLength = 0;
            this.txtIdentifiant.SelectionStart = 0;
            this.txtIdentifiant.ShortcutsEnabled = true;
            this.txtIdentifiant.Size = new System.Drawing.Size(172, 23);
            this.txtIdentifiant.TabIndex = 3;
            this.txtIdentifiant.UseSelectable = true;
            this.txtIdentifiant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdentifiant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(154, 150);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(172, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnConnexion.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(23, 242);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(146, 42);
            this.btnConnexion.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseCustomBackColor = true;
            this.btnConnexion.UseCustomForeColor = true;
            this.btnConnexion.UseSelectable = true;
            this.btnConnexion.UseStyleColors = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblMdpOublie
            // 
            this.lblMdpOublie.AutoSize = true;
            this.lblMdpOublie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMdpOublie.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMdpOublie.Location = new System.Drawing.Point(154, 192);
            this.lblMdpOublie.Name = "lblMdpOublie";
            this.lblMdpOublie.Size = new System.Drawing.Size(138, 19);
            this.lblMdpOublie.TabIndex = 7;
            this.lblMdpOublie.Text = "Mot de passe oublié ?";
            this.lblMdpOublie.UseCustomForeColor = true;
            this.lblMdpOublie.UseStyleColors = true;
            this.lblMdpOublie.Click += new System.EventHandler(this.lblMdpOublie_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Tomato;
            this.btnQuitter.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(265, 242);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(146, 42);
            this.btnQuitter.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseCustomBackColor = true;
            this.btnQuitter.UseCustomForeColor = true;
            this.btnQuitter.UseSelectable = true;
            this.btnQuitter.UseStyleColors = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 307);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblMdpOublie);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtIdentifiant);
            this.Name = "FrmConnexion";
            this.Text = "LesMotsTordus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIdentifiant;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnConnexion;
        private MetroFramework.Controls.MetroLabel lblMdpOublie;
        private MetroFramework.Controls.MetroButton btnQuitter;
    }
}