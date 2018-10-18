namespace InterfaceMedia
{
    partial class FrmEmprunt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbxMenu = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new MetroFramework.Controls.MetroButton();
            this.btnAnnuler = new MetroFramework.Controls.MetroButton();
            this.btnRechercheLivre = new MetroFramework.Controls.MetroButton();
            this.btnRecherEmp = new MetroFramework.Controls.MetroButton();
            this.btnSupprEmp = new MetroFramework.Controls.MetroButton();
            this.btnAjoutRetour = new MetroFramework.Controls.MetroButton();
            this.btnModifier = new MetroFramework.Controls.MetroButton();
            this.btnAjoutEmp = new MetroFramework.Controls.MetroButton();
            this.lblNumEmp = new MetroFramework.Controls.MetroLabel();
            this.txtbxNumEmp = new MetroFramework.Controls.MetroTextBox();
            this.txtbxRefEx = new MetroFramework.Controls.MetroTextBox();
            this.lblRefEx = new MetroFramework.Controls.MetroLabel();
            this.GridEmprunt = new MetroFramework.Controls.MetroGrid();
            this.lblDateEmp = new MetroFramework.Controls.MetroLabel();
            this.lblDateRetourPrev = new MetroFramework.Controls.MetroLabel();
            this.lblDateRetourRéel = new MetroFramework.Controls.MetroLabel();
            this.gpbxChoix = new System.Windows.Forms.GroupBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime4 = new MetroFramework.Controls.MetroDateTime();
            this.gpbxMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprunt)).BeginInit();
            this.gpbxChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxMenu
            // 
            this.gpbxMenu.BackColor = System.Drawing.Color.Transparent;
            this.gpbxMenu.Controls.Add(this.groupBox1);
            this.gpbxMenu.Controls.Add(this.btnAnnuler);
            this.gpbxMenu.Controls.Add(this.btnRechercheLivre);
            this.gpbxMenu.Controls.Add(this.btnRecherEmp);
            this.gpbxMenu.Controls.Add(this.btnSupprEmp);
            this.gpbxMenu.Controls.Add(this.btnAjoutRetour);
            this.gpbxMenu.Controls.Add(this.btnModifier);
            this.gpbxMenu.Controls.Add(this.btnAjoutEmp);
            this.gpbxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbxMenu.Location = new System.Drawing.Point(736, 9);
            this.gpbxMenu.Name = "gpbxMenu";
            this.gpbxMenu.Size = new System.Drawing.Size(216, 533);
            this.gpbxMenu.TabIndex = 5;
            this.gpbxMenu.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Location = new System.Drawing.Point(0, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Highlight = true;
            this.btnQuitter.Location = new System.Drawing.Point(25, 15);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(169, 43);
            this.btnQuitter.Style = MetroFramework.MetroColorStyle.Red;
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseSelectable = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Highlight = true;
            this.btnAnnuler.Location = new System.Drawing.Point(25, 420);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(169, 43);
            this.btnAnnuler.Style = MetroFramework.MetroColorStyle.Red;
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseSelectable = true;
            // 
            // btnRechercheLivre
            // 
            this.btnRechercheLivre.Highlight = true;
            this.btnRechercheLivre.Location = new System.Drawing.Point(25, 288);
            this.btnRechercheLivre.Name = "btnRechercheLivre";
            this.btnRechercheLivre.Size = new System.Drawing.Size(169, 43);
            this.btnRechercheLivre.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRechercheLivre.TabIndex = 5;
            this.btnRechercheLivre.Text = "Rechercher livre ";
            this.btnRechercheLivre.UseSelectable = true;
            this.btnRechercheLivre.Click += new System.EventHandler(this.btnRechercheLivre_Click);
            // 
            // btnRecherEmp
            // 
            this.btnRecherEmp.Highlight = true;
            this.btnRecherEmp.Location = new System.Drawing.Point(25, 239);
            this.btnRecherEmp.Name = "btnRecherEmp";
            this.btnRecherEmp.Size = new System.Drawing.Size(169, 43);
            this.btnRecherEmp.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRecherEmp.TabIndex = 4;
            this.btnRecherEmp.Text = "Rechercher emprunt";
            this.btnRecherEmp.UseSelectable = true;
            // 
            // btnSupprEmp
            // 
            this.btnSupprEmp.Highlight = true;
            this.btnSupprEmp.Location = new System.Drawing.Point(25, 117);
            this.btnSupprEmp.Name = "btnSupprEmp";
            this.btnSupprEmp.Size = new System.Drawing.Size(169, 43);
            this.btnSupprEmp.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSupprEmp.TabIndex = 3;
            this.btnSupprEmp.Text = "Supprimer";
            this.btnSupprEmp.UseSelectable = true;
            // 
            // btnAjoutRetour
            // 
            this.btnAjoutRetour.Highlight = true;
            this.btnAjoutRetour.Location = new System.Drawing.Point(25, 190);
            this.btnAjoutRetour.Name = "btnAjoutRetour";
            this.btnAjoutRetour.Size = new System.Drawing.Size(169, 43);
            this.btnAjoutRetour.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAjoutRetour.TabIndex = 2;
            this.btnAjoutRetour.Text = "Ajouter un retour";
            this.btnAjoutRetour.UseSelectable = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Highlight = true;
            this.btnModifier.Location = new System.Drawing.Point(25, 68);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(169, 43);
            this.btnModifier.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseSelectable = true;
            // 
            // btnAjoutEmp
            // 
            this.btnAjoutEmp.Highlight = true;
            this.btnAjoutEmp.Location = new System.Drawing.Point(25, 19);
            this.btnAjoutEmp.Name = "btnAjoutEmp";
            this.btnAjoutEmp.Size = new System.Drawing.Size(169, 43);
            this.btnAjoutEmp.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAjoutEmp.TabIndex = 0;
            this.btnAjoutEmp.Text = "Ajouter";
            this.btnAjoutEmp.UseSelectable = true;
            this.btnAjoutEmp.Click += new System.EventHandler(this.btnAjoutEmp_Click);
            // 
            // lblNumEmp
            // 
            this.lblNumEmp.AutoSize = true;
            this.lblNumEmp.Location = new System.Drawing.Point(23, 117);
            this.lblNumEmp.Name = "lblNumEmp";
            this.lblNumEmp.Size = new System.Drawing.Size(131, 19);
            this.lblNumEmp.TabIndex = 8;
            this.lblNumEmp.Text = "Numéro emprunteur";
            // 
            // txtbxNumEmp
            // 
            // 
            // 
            // 
            this.txtbxNumEmp.CustomButton.Image = null;
            this.txtbxNumEmp.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.txtbxNumEmp.CustomButton.Name = "";
            this.txtbxNumEmp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxNumEmp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxNumEmp.CustomButton.TabIndex = 1;
            this.txtbxNumEmp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxNumEmp.CustomButton.UseSelectable = true;
            this.txtbxNumEmp.CustomButton.Visible = false;
            this.txtbxNumEmp.Lines = new string[0];
            this.txtbxNumEmp.Location = new System.Drawing.Point(181, 117);
            this.txtbxNumEmp.MaxLength = 32767;
            this.txtbxNumEmp.Name = "txtbxNumEmp";
            this.txtbxNumEmp.PasswordChar = '\0';
            this.txtbxNumEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxNumEmp.SelectedText = "";
            this.txtbxNumEmp.SelectionLength = 0;
            this.txtbxNumEmp.SelectionStart = 0;
            this.txtbxNumEmp.ShortcutsEnabled = true;
            this.txtbxNumEmp.Size = new System.Drawing.Size(71, 23);
            this.txtbxNumEmp.TabIndex = 9;
            this.txtbxNumEmp.UseSelectable = true;
            this.txtbxNumEmp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxNumEmp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbxRefEx
            // 
            // 
            // 
            // 
            this.txtbxRefEx.CustomButton.Image = null;
            this.txtbxRefEx.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.txtbxRefEx.CustomButton.Name = "";
            this.txtbxRefEx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxRefEx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxRefEx.CustomButton.TabIndex = 1;
            this.txtbxRefEx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxRefEx.CustomButton.UseSelectable = true;
            this.txtbxRefEx.CustomButton.Visible = false;
            this.txtbxRefEx.Lines = new string[0];
            this.txtbxRefEx.Location = new System.Drawing.Point(506, 117);
            this.txtbxRefEx.MaxLength = 32767;
            this.txtbxRefEx.Name = "txtbxRefEx";
            this.txtbxRefEx.PasswordChar = '\0';
            this.txtbxRefEx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxRefEx.SelectedText = "";
            this.txtbxRefEx.SelectionLength = 0;
            this.txtbxRefEx.SelectionStart = 0;
            this.txtbxRefEx.ShortcutsEnabled = true;
            this.txtbxRefEx.Size = new System.Drawing.Size(79, 23);
            this.txtbxRefEx.TabIndex = 11;
            this.txtbxRefEx.UseSelectable = true;
            this.txtbxRefEx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxRefEx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRefEx
            // 
            this.lblRefEx.AutoSize = true;
            this.lblRefEx.Location = new System.Drawing.Point(348, 117);
            this.lblRefEx.Name = "lblRefEx";
            this.lblRefEx.Size = new System.Drawing.Size(136, 19);
            this.lblRefEx.TabIndex = 10;
            this.lblRefEx.Text = "Référence exemplaire";
            // 
            // GridEmprunt
            // 
            this.GridEmprunt.AllowUserToResizeRows = false;
            this.GridEmprunt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridEmprunt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridEmprunt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridEmprunt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmprunt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEmprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEmprunt.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridEmprunt.EnableHeadersVisualStyles = false;
            this.GridEmprunt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridEmprunt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridEmprunt.Location = new System.Drawing.Point(23, 373);
            this.GridEmprunt.Name = "GridEmprunt";
            this.GridEmprunt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmprunt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridEmprunt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridEmprunt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmprunt.Size = new System.Drawing.Size(695, 150);
            this.GridEmprunt.TabIndex = 12;
            // 
            // lblDateEmp
            // 
            this.lblDateEmp.AutoSize = true;
            this.lblDateEmp.Location = new System.Drawing.Point(23, 185);
            this.lblDateEmp.Name = "lblDateEmp";
            this.lblDateEmp.Size = new System.Drawing.Size(90, 19);
            this.lblDateEmp.TabIndex = 13;
            this.lblDateEmp.Text = "Date emprunt";
            // 
            // lblDateRetourPrev
            // 
            this.lblDateRetourPrev.AutoSize = true;
            this.lblDateRetourPrev.Location = new System.Drawing.Point(348, 185);
            this.lblDateRetourPrev.Name = "lblDateRetourPrev";
            this.lblDateRetourPrev.Size = new System.Drawing.Size(132, 19);
            this.lblDateRetourPrev.TabIndex = 15;
            this.lblDateRetourPrev.Text = "Date de retour prévu";
            // 
            // lblDateRetourRéel
            // 
            this.lblDateRetourRéel.AutoSize = true;
            this.lblDateRetourRéel.Location = new System.Drawing.Point(23, 248);
            this.lblDateRetourRéel.Name = "lblDateRetourRéel";
            this.lblDateRetourRéel.Size = new System.Drawing.Size(102, 19);
            this.lblDateRetourRéel.TabIndex = 17;
            this.lblDateRetourRéel.Text = "Date retour réel";
            // 
            // gpbxChoix
            // 
            this.gpbxChoix.Controls.Add(this.metroDateTime1);
            this.gpbxChoix.Controls.Add(this.metroRadioButton2);
            this.gpbxChoix.Controls.Add(this.metroRadioButton1);
            this.gpbxChoix.Controls.Add(this.lblDate);
            this.gpbxChoix.Enabled = false;
            this.gpbxChoix.Location = new System.Drawing.Point(23, 234);
            this.gpbxChoix.Name = "gpbxChoix";
            this.gpbxChoix.Size = new System.Drawing.Size(695, 100);
            this.gpbxChoix.TabIndex = 19;
            this.gpbxChoix.TabStop = false;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTime1.Location = new System.Drawing.Point(158, 19);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(137, 25);
            this.metroDateTime1.TabIndex = 21;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(336, 27);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(270, 15);
            this.metroRadioButton2.TabIndex = 20;
            this.metroRadioButton2.Text = "Afficher les livres empruntés à une date précise";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(336, 60);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(276, 15);
            this.metroRadioButton1.TabIndex = 19;
            this.metroRadioButton1.Text = "Afficher les livres non rendus à une date donnée";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(54, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 19);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTime3.Location = new System.Drawing.Point(506, 185);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(137, 25);
            this.metroDateTime3.TabIndex = 23;
            // 
            // metroDateTime4
            // 
            this.metroDateTime4.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTime4.Location = new System.Drawing.Point(181, 185);
            this.metroDateTime4.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTime4.Name = "metroDateTime4";
            this.metroDateTime4.Size = new System.Drawing.Size(137, 25);
            this.metroDateTime4.TabIndex = 24;
            // 
            // FrmEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::InterfaceMedia.Properties.Resources._31;
            this.ClientSize = new System.Drawing.Size(957, 546);
            this.Controls.Add(this.metroDateTime3);
            this.Controls.Add(this.metroDateTime4);
            this.Controls.Add(this.gpbxChoix);
            this.Controls.Add(this.lblDateRetourRéel);
            this.Controls.Add(this.lblDateRetourPrev);
            this.Controls.Add(this.lblDateEmp);
            this.Controls.Add(this.GridEmprunt);
            this.Controls.Add(this.txtbxRefEx);
            this.Controls.Add(this.lblRefEx);
            this.Controls.Add(this.txtbxNumEmp);
            this.Controls.Add(this.lblNumEmp);
            this.Controls.Add(this.gpbxMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmEmprunt";
            this.Text = "Emprunt";
            this.gpbxMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprunt)).EndInit();
            this.gpbxChoix.ResumeLayout(false);
            this.gpbxChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbxMenu;
        private MetroFramework.Controls.MetroButton btnAnnuler;
        private MetroFramework.Controls.MetroButton btnRechercheLivre;
        private MetroFramework.Controls.MetroButton btnRecherEmp;
        private MetroFramework.Controls.MetroButton btnSupprEmp;
        private MetroFramework.Controls.MetroButton btnAjoutRetour;
        private MetroFramework.Controls.MetroButton btnModifier;
        private MetroFramework.Controls.MetroButton btnAjoutEmp;
        private MetroFramework.Controls.MetroLabel lblNumEmp;
        private MetroFramework.Controls.MetroTextBox txtbxNumEmp;
        private MetroFramework.Controls.MetroTextBox txtbxRefEx;
        private MetroFramework.Controls.MetroLabel lblRefEx;
        private MetroFramework.Controls.MetroGrid GridEmprunt;
        private MetroFramework.Controls.MetroLabel lblDateEmp;
        private MetroFramework.Controls.MetroLabel lblDateRetourPrev;
        private MetroFramework.Controls.MetroLabel lblDateRetourRéel;
        private System.Windows.Forms.GroupBox gpbxChoix;
        private MetroFramework.Controls.MetroLabel lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnQuitter;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private MetroFramework.Controls.MetroDateTime metroDateTime4;
    }
}