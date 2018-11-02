namespace InterfaceMedia
{
    partial class FrmAdmin
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.gridUtilisateur = new MetroFramework.Controls.MetroGrid();
            this.btnAnnuler = new MetroFramework.Controls.MetroTile();
            this.btnRechercher = new MetroFramework.Controls.MetroTile();
            this.btnSupprimer = new MetroFramework.Controls.MetroTile();
            this.btnModifier = new MetroFramework.Controls.MetroTile();
            this.btnAjouter = new MetroFramework.Controls.MetroTile();
            this.btnQuitter = new MetroFramework.Controls.MetroTile();
            this.gpbxMenu = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.txtPseudo = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.txtPrenom = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtilisateur)).BeginInit();
            this.gpbxMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(24, 106);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(99, 19);
            this.metroLabel6.TabIndex = 41;
            this.metroLabel6.Text = "Mot de passe :";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(80, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 40;
            this.metroLabel5.Text = "Nom :";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(337, 73);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 39;
            this.metroLabel4.Text = "Prenom :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(66, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Pseudo :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(373, 34);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(28, 19);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Id :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.metroTextBox3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtPseudo);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Location = new System.Drawing.Point(23, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 150);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton1.Location = new System.Drawing.Point(69, 9);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(59, 19);
            this.metroRadioButton1.TabIndex = 46;
            this.metroRadioButton1.Text = "Invité";
            this.metroRadioButton1.UseCustomBackColor = true;
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton2.Location = new System.Drawing.Point(235, 9);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(87, 19);
            this.metroRadioButton2.TabIndex = 47;
            this.metroRadioButton2.Text = "Utilisateur";
            this.metroRadioButton2.UseCustomBackColor = true;
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton3.Location = new System.Drawing.Point(393, 9);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(116, 19);
            this.metroRadioButton3.TabIndex = 48;
            this.metroRadioButton3.Text = "Administrateur";
            this.metroRadioButton3.UseCustomBackColor = true;
            this.metroRadioButton3.UseSelectable = true;
            // 
            // gridUtilisateur
            // 
            this.gridUtilisateur.AllowUserToAddRows = false;
            this.gridUtilisateur.AllowUserToDeleteRows = false;
            this.gridUtilisateur.AllowUserToResizeRows = false;
            this.gridUtilisateur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridUtilisateur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUtilisateur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUtilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUtilisateur.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUtilisateur.EnableHeadersVisualStyles = false;
            this.gridUtilisateur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridUtilisateur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridUtilisateur.Location = new System.Drawing.Point(23, 272);
            this.gridUtilisateur.MultiSelect = false;
            this.gridUtilisateur.Name = "gridUtilisateur";
            this.gridUtilisateur.ReadOnly = true;
            this.gridUtilisateur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUtilisateur.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUtilisateur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUtilisateur.Size = new System.Drawing.Size(557, 262);
            this.gridUtilisateur.TabIndex = 49;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.ActiveControl = null;
            this.btnAnnuler.BackColor = System.Drawing.Color.Tomato;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(18, 376);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(169, 49);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnnuler.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAnnuler.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAnnuler.UseCustomBackColor = true;
            this.btnAnnuler.UseSelectable = true;
            this.btnAnnuler.Visible = false;
            // 
            // btnRechercher
            // 
            this.btnRechercher.ActiveControl = null;
            this.btnRechercher.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.Location = new System.Drawing.Point(18, 219);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(169, 49);
            this.btnRechercher.TabIndex = 13;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRechercher.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnRechercher.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnRechercher.UseCustomBackColor = true;
            this.btnRechercher.UseSelectable = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ActiveControl = null;
            this.btnSupprimer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Location = new System.Drawing.Point(18, 152);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(169, 49);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSupprimer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSupprimer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSupprimer.UseCustomBackColor = true;
            this.btnSupprimer.UseSelectable = true;
            // 
            // btnModifier
            // 
            this.btnModifier.ActiveControl = null;
            this.btnModifier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Location = new System.Drawing.Point(18, 87);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(169, 49);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnModifier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnModifier.UseCustomBackColor = true;
            this.btnModifier.UseSelectable = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.ActiveControl = null;
            this.btnAjouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.Location = new System.Drawing.Point(18, 21);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(169, 49);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjouter.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAjouter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAjouter.UseCustomBackColor = true;
            this.btnAjouter.UseSelectable = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.ActiveControl = null;
            this.btnQuitter.BackColor = System.Drawing.Color.Tomato;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Location = new System.Drawing.Point(18, 21);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(169, 44);
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitter.TileImage = global::InterfaceMedia.Properties.Resources.QuitterIcone;
            this.btnQuitter.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnQuitter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnQuitter.UseCustomBackColor = true;
            this.btnQuitter.UseSelectable = true;
            this.btnQuitter.UseTileImage = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // gpbxMenu
            // 
            this.gpbxMenu.BackColor = System.Drawing.Color.Transparent;
            this.gpbxMenu.Controls.Add(this.btnAnnuler);
            this.gpbxMenu.Controls.Add(this.btnRechercher);
            this.gpbxMenu.Controls.Add(this.btnSupprimer);
            this.gpbxMenu.Controls.Add(this.btnModifier);
            this.gpbxMenu.Controls.Add(this.btnAjouter);
            this.gpbxMenu.Controls.Add(this.groupBox2);
            this.gpbxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbxMenu.Location = new System.Drawing.Point(586, 21);
            this.gpbxMenu.Name = "gpbxMenu";
            this.gpbxMenu.Size = new System.Drawing.Size(203, 513);
            this.gpbxMenu.TabIndex = 50;
            this.gpbxMenu.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitter);
            this.groupBox2.Location = new System.Drawing.Point(0, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 102);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.metroRadioButton3);
            this.groupBox3.Controls.Add(this.metroRadioButton2);
            this.groupBox3.Controls.Add(this.metroRadioButton1);
            this.groupBox3.Location = new System.Drawing.Point(25, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 37);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rang";
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = global::InterfaceMedia.Properties.Resources.maxresdefault;
            this.picHome.Location = new System.Drawing.Point(172, 17);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(75, 41);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 52;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // txtPseudo
            // 
            this.txtPseudo.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtPseudo.CustomButton.Image = null;
            this.txtPseudo.CustomButton.Location = new System.Drawing.Point(80, 2);
            this.txtPseudo.CustomButton.Name = "";
            this.txtPseudo.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtPseudo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPseudo.CustomButton.TabIndex = 1;
            this.txtPseudo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPseudo.CustomButton.UseSelectable = true;
            this.txtPseudo.CustomButton.Visible = false;
            this.txtPseudo.Enabled = false;
            this.txtPseudo.Lines = new string[0];
            this.txtPseudo.Location = new System.Drawing.Point(133, 35);
            this.txtPseudo.MaxLength = 32767;
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.PasswordChar = '\0';
            this.txtPseudo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPseudo.SelectedText = "";
            this.txtPseudo.SelectionLength = 0;
            this.txtPseudo.SelectionStart = 0;
            this.txtPseudo.ShortcutsEnabled = true;
            this.txtPseudo.Size = new System.Drawing.Size(100, 22);
            this.txtPseudo.TabIndex = 42;
            this.txtPseudo.UseCustomBackColor = true;
            this.txtPseudo.UseSelectable = true;
            this.txtPseudo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPseudo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtNom.CustomButton.Image = null;
            this.txtNom.CustomButton.Location = new System.Drawing.Point(80, 2);
            this.txtNom.CustomButton.Name = "";
            this.txtNom.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNom.CustomButton.TabIndex = 1;
            this.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNom.CustomButton.UseSelectable = true;
            this.txtNom.CustomButton.Visible = false;
            this.txtNom.Enabled = false;
            this.txtNom.Lines = new string[0];
            this.txtNom.Location = new System.Drawing.Point(133, 72);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 43;
            this.txtNom.UseCustomBackColor = true;
            this.txtNom.UseSelectable = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(119, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Enabled = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(133, 106);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(139, 22);
            this.txtPassword.TabIndex = 44;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(37, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Enabled = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(407, 34);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(57, 22);
            this.metroTextBox3.TabIndex = 45;
            this.metroTextBox3.UseCustomBackColor = true;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtPrenom.CustomButton.Image = null;
            this.txtPrenom.CustomButton.Location = new System.Drawing.Point(80, 2);
            this.txtPrenom.CustomButton.Name = "";
            this.txtPrenom.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtPrenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrenom.CustomButton.TabIndex = 1;
            this.txtPrenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrenom.CustomButton.UseSelectable = true;
            this.txtPrenom.CustomButton.Visible = false;
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Lines = new string[0];
            this.txtPrenom.Location = new System.Drawing.Point(407, 72);
            this.txtPrenom.MaxLength = 32767;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.SelectionLength = 0;
            this.txtPrenom.SelectionStart = 0;
            this.txtPrenom.ShortcutsEnabled = true;
            this.txtPrenom.Size = new System.Drawing.Size(100, 22);
            this.txtPrenom.TabIndex = 46;
            this.txtPrenom.UseCustomBackColor = true;
            this.txtPrenom.UseSelectable = true;
            this.txtPrenom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrenom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 546);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpbxMenu);
            this.Controls.Add(this.gridUtilisateur);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmAdmin";
            this.Text = "Administration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtilisateur)).EndInit();
            this.gpbxMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroGrid gridUtilisateur;
        private MetroFramework.Controls.MetroTile btnAnnuler;
        private MetroFramework.Controls.MetroTile btnRechercher;
        private MetroFramework.Controls.MetroTile btnSupprimer;
        private MetroFramework.Controls.MetroTile btnModifier;
        private MetroFramework.Controls.MetroTile btnAjouter;
        private MetroFramework.Controls.MetroTile btnQuitter;
        private System.Windows.Forms.GroupBox gpbxMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picHome;
        private MetroFramework.Controls.MetroTextBox txtPrenom;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroTextBox txtPseudo;
    }
}