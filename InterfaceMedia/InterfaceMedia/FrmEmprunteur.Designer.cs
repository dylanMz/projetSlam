namespace InterfaceMedia
{
    partial class FrmEmprunteur
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnFamille = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.BtnAnnuler = new MetroFramework.Controls.MetroButton();
            this.gridEmprunteur = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_codepostal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.txtAdresse = new MetroFramework.Controls.MetroTextBox();
            this.txtCodePostal = new MetroFramework.Controls.MetroTextBox();
            this.txtVille = new MetroFramework.Controls.MetroTextBox();
            this.txtTelephone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmprunteur)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = true;
            this.metroButton4.Location = new System.Drawing.Point(25, 95);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(169, 43);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Modifier";
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(25, 223);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(169, 43);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Rechercher";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(25, 159);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(169, 43);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Supprimer";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(25, 29);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(169, 43);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Ajouter";
            this.metroButton1.UseSelectable = true;
            // 
            // btnFamille
            // 
            this.btnFamille.Highlight = true;
            this.btnFamille.Location = new System.Drawing.Point(25, 285);
            this.btnFamille.Name = "btnFamille";
            this.btnFamille.Size = new System.Drawing.Size(169, 43);
            this.btnFamille.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnFamille.TabIndex = 11;
            this.btnFamille.Text = "Chef de Famille";
            this.btnFamille.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton5);
            this.groupBox1.Controls.Add(this.BtnAnnuler);
            this.groupBox1.Controls.Add(this.btnFamille);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(865, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 553);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // metroButton5
            // 
            this.metroButton5.Highlight = true;
            this.metroButton5.Location = new System.Drawing.Point(25, 493);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(169, 43);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton5.TabIndex = 12;
            this.metroButton5.Text = "Quitter";
            this.metroButton5.UseSelectable = true;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Highlight = true;
            this.BtnAnnuler.Location = new System.Drawing.Point(25, 345);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(169, 43);
            this.BtnAnnuler.Style = MetroFramework.MetroColorStyle.Red;
            this.BtnAnnuler.TabIndex = 13;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseSelectable = true;
            // 
            // gridEmprunteur
            // 
            this.gridEmprunteur.AllowUserToResizeRows = false;
            this.gridEmprunteur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridEmprunteur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridEmprunteur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridEmprunteur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmprunteur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmprunteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEmprunteur.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmprunteur.EnableHeadersVisualStyles = false;
            this.gridEmprunteur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridEmprunteur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridEmprunteur.Location = new System.Drawing.Point(111, 326);
            this.gridEmprunteur.Name = "gridEmprunteur";
            this.gridEmprunteur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmprunteur.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEmprunteur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridEmprunteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmprunteur.Size = new System.Drawing.Size(683, 250);
            this.gridEmprunteur.TabIndex = 27;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(60, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Nom :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(42, 176);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Prénom :";
            // 
            // metroLabel_codepostal
            // 
            this.metroLabel_codepostal.AutoSize = true;
            this.metroLabel_codepostal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_codepostal.Location = new System.Drawing.Point(255, 176);
            this.metroLabel_codepostal.Name = "metroLabel_codepostal";
            this.metroLabel_codepostal.Size = new System.Drawing.Size(88, 19);
            this.metroLabel_codepostal.TabIndex = 31;
            this.metroLabel_codepostal.Text = "Code Postal :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(302, 226);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Ville :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(64, 230);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(42, 19);
            this.metroLabel8.TabIndex = 33;
            this.metroLabel8.Text = "Mail :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(34, 270);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 34;
            this.metroLabel9.Text = "Naissance:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(652, 99);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(73, 19);
            this.metroLabel10.TabIndex = 35;
            this.metroLabel10.Text = "Adhésion :";
            // 
            // txtNom
            // 
            // 
            // 
            // 
            this.txtNom.CustomButton.Image = null;
            this.txtNom.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtNom.CustomButton.Name = "";
            this.txtNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNom.CustomButton.TabIndex = 1;
            this.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNom.CustomButton.UseSelectable = true;
            this.txtNom.CustomButton.Visible = false;
            this.txtNom.Lines = new string[0];
            this.txtNom.Location = new System.Drawing.Point(112, 130);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(137, 23);
            this.txtNom.TabIndex = 36;
            this.txtNom.UseSelectable = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdresse
            // 
            // 
            // 
            // 
            this.txtAdresse.CustomButton.Image = null;
            this.txtAdresse.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtAdresse.CustomButton.Name = "";
            this.txtAdresse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdresse.CustomButton.TabIndex = 1;
            this.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdresse.CustomButton.UseSelectable = true;
            this.txtAdresse.CustomButton.Visible = false;
            this.txtAdresse.Lines = new string[0];
            this.txtAdresse.Location = new System.Drawing.Point(349, 130);
            this.txtAdresse.MaxLength = 32767;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.SelectionLength = 0;
            this.txtAdresse.SelectionStart = 0;
            this.txtAdresse.ShortcutsEnabled = true;
            this.txtAdresse.Size = new System.Drawing.Size(137, 23);
            this.txtAdresse.TabIndex = 37;
            this.txtAdresse.UseSelectable = true;
            this.txtAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdresse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodePostal
            // 
            // 
            // 
            // 
            this.txtCodePostal.CustomButton.Image = null;
            this.txtCodePostal.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtCodePostal.CustomButton.Name = "";
            this.txtCodePostal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodePostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodePostal.CustomButton.TabIndex = 1;
            this.txtCodePostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodePostal.CustomButton.UseSelectable = true;
            this.txtCodePostal.CustomButton.Visible = false;
            this.txtCodePostal.Lines = new string[0];
            this.txtCodePostal.Location = new System.Drawing.Point(349, 176);
            this.txtCodePostal.MaxLength = 32767;
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.PasswordChar = '\0';
            this.txtCodePostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodePostal.SelectedText = "";
            this.txtCodePostal.SelectionLength = 0;
            this.txtCodePostal.SelectionStart = 0;
            this.txtCodePostal.ShortcutsEnabled = true;
            this.txtCodePostal.Size = new System.Drawing.Size(137, 23);
            this.txtCodePostal.TabIndex = 39;
            this.txtCodePostal.UseSelectable = true;
            this.txtCodePostal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodePostal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtVille
            // 
            // 
            // 
            // 
            this.txtVille.CustomButton.Image = null;
            this.txtVille.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtVille.CustomButton.Name = "";
            this.txtVille.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVille.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVille.CustomButton.TabIndex = 1;
            this.txtVille.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVille.CustomButton.UseSelectable = true;
            this.txtVille.CustomButton.Visible = false;
            this.txtVille.Lines = new string[0];
            this.txtVille.Location = new System.Drawing.Point(349, 226);
            this.txtVille.MaxLength = 32767;
            this.txtVille.Name = "txtVille";
            this.txtVille.PasswordChar = '\0';
            this.txtVille.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVille.SelectedText = "";
            this.txtVille.SelectionLength = 0;
            this.txtVille.SelectionStart = 0;
            this.txtVille.ShortcutsEnabled = true;
            this.txtVille.Size = new System.Drawing.Size(137, 23);
            this.txtVille.TabIndex = 40;
            this.txtVille.UseSelectable = true;
            this.txtVille.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVille.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelephone
            // 
            // 
            // 
            // 
            this.txtTelephone.CustomButton.Image = null;
            this.txtTelephone.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtTelephone.CustomButton.Name = "";
            this.txtTelephone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelephone.CustomButton.TabIndex = 1;
            this.txtTelephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelephone.CustomButton.UseSelectable = true;
            this.txtTelephone.CustomButton.Visible = false;
            this.txtTelephone.Lines = new string[0];
            this.txtTelephone.Location = new System.Drawing.Point(112, 222);
            this.txtTelephone.MaxLength = 32767;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.SelectionLength = 0;
            this.txtTelephone.SelectionStart = 0;
            this.txtTelephone.ShortcutsEnabled = true;
            this.txtTelephone.Size = new System.Drawing.Size(137, 23);
            this.txtTelephone.TabIndex = 41;
            this.txtTelephone.UseSelectable = true;
            this.txtTelephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(279, 130);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 45;
            this.metroLabel6.Text = "Adresse :";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(112, 176);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(137, 23);
            this.metroTextBox1.TabIndex = 46;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(112, 266);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 47;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(594, 130);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 48;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(604, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 19);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Renouvellement adhésion :";
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.Location = new System.Drawing.Point(594, 207);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime3.TabIndex = 50;
            // 
            // FrmEmprunteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 599);
            this.Controls.Add(this.metroDateTime3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel_codepostal);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.gridEmprunteur);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEmprunteur";
            this.Text = "Emprunteur";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmprunteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnFamille;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid gridEmprunteur;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel_codepostal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroTextBox txtAdresse;
        private MetroFramework.Controls.MetroTextBox txtCodePostal;
        private MetroFramework.Controls.MetroTextBox txtVille;
        private MetroFramework.Controls.MetroTextBox txtTelephone;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton BtnAnnuler;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
    }
}