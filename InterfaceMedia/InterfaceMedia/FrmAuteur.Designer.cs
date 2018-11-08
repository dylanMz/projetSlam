namespace InterfaceMedia
{
    partial class FrmAuteur
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
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnModifier = new MetroFramework.Controls.MetroTile();
            this.grpQuitter = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new MetroFramework.Controls.MetroTile();
            this.btnAjouter = new MetroFramework.Controls.MetroTile();
            this.btnRechercher = new MetroFramework.Controls.MetroTile();
            this.btnAnnuler = new MetroFramework.Controls.MetroTile();
            this.pnlAuteur = new MetroFramework.Controls.MetroPanel();
            this.dgvAuteur = new MetroFramework.Controls.MetroGrid();
            this.grpAuteur = new System.Windows.Forms.GroupBox();
            this.grpStatut = new System.Windows.Forms.GroupBox();
            this.rdoVivant = new MetroFramework.Controls.MetroRadioButton();
            this.dtStatut = new MetroFramework.Controls.MetroDateTime();
            this.rdoDecede = new MetroFramework.Controls.MetroRadioButton();
            this.cmbPays = new MetroFramework.Controls.MetroComboBox();
            this.lblPays = new MetroFramework.Controls.MetroLabel();
            this.lblPseudo = new MetroFramework.Controls.MetroLabel();
            this.txtPseudo = new MetroFramework.Controls.MetroTextBox();
            this.lblStatut = new MetroFramework.Controls.MetroLabel();
            this.dtDateNaiss = new MetroFramework.Controls.MetroDateTime();
            this.lblBio = new MetroFramework.Controls.MetroLabel();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.txtBio = new MetroFramework.Controls.MetroTextBox();
            this.lblNom = new MetroFramework.Controls.MetroLabel();
            this.lblDateNais = new MetroFramework.Controls.MetroLabel();
            this.txtPrenom = new MetroFramework.Controls.MetroTextBox();
            this.lblPrenom = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.chkNouvPays = new MetroFramework.Controls.MetroCheckBox();
            this.txtPays = new MetroFramework.Controls.MetroTextBox();
            this.grpMenu.SuspendLayout();
            this.grpQuitter.SuspendLayout();
            this.pnlAuteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuteur)).BeginInit();
            this.grpAuteur.SuspendLayout();
            this.grpStatut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.Controls.Add(this.btnModifier);
            this.grpMenu.Controls.Add(this.grpQuitter);
            this.grpMenu.Controls.Add(this.btnAjouter);
            this.grpMenu.Controls.Add(this.btnRechercher);
            this.grpMenu.Controls.Add(this.btnAnnuler);
            this.grpMenu.Location = new System.Drawing.Point(737, 33);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(216, 638);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.TabStop = false;
            // 
            // btnModifier
            // 
            this.btnModifier.ActiveControl = null;
            this.btnModifier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Location = new System.Drawing.Point(24, 105);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(169, 43);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnModifier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnModifier.UseCustomBackColor = true;
            this.btnModifier.UseSelectable = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // grpQuitter
            // 
            this.grpQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQuitter.Controls.Add(this.btnQuitter);
            this.grpQuitter.Location = new System.Drawing.Point(6, 555);
            this.grpQuitter.Name = "grpQuitter";
            this.grpQuitter.Size = new System.Drawing.Size(204, 83);
            this.grpQuitter.TabIndex = 7;
            this.grpQuitter.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.ActiveControl = null;
            this.btnQuitter.BackColor = System.Drawing.Color.Tomato;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Location = new System.Drawing.Point(18, 19);
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
            // btnAjouter
            // 
            this.btnAjouter.ActiveControl = null;
            this.btnAjouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.Location = new System.Drawing.Point(24, 19);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(169, 43);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjouter.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAjouter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAjouter.UseCustomBackColor = true;
            this.btnAjouter.UseSelectable = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.ActiveControl = null;
            this.btnRechercher.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.Location = new System.Drawing.Point(24, 197);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(169, 43);
            this.btnRechercher.TabIndex = 13;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRechercher.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnRechercher.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnRechercher.UseCustomBackColor = true;
            this.btnRechercher.UseSelectable = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.ActiveControl = null;
            this.btnAnnuler.BackColor = System.Drawing.Color.Tomato;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(24, 463);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(169, 43);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnnuler.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAnnuler.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAnnuler.UseCustomBackColor = true;
            this.btnAnnuler.UseSelectable = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // pnlAuteur
            // 
            this.pnlAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuteur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAuteur.Controls.Add(this.dgvAuteur);
            this.pnlAuteur.Controls.Add(this.grpAuteur);
            this.pnlAuteur.HorizontalScrollbarBarColor = true;
            this.pnlAuteur.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAuteur.HorizontalScrollbarSize = 10;
            this.pnlAuteur.Location = new System.Drawing.Point(7, 63);
            this.pnlAuteur.Name = "pnlAuteur";
            this.pnlAuteur.Size = new System.Drawing.Size(724, 608);
            this.pnlAuteur.TabIndex = 6;
            this.pnlAuteur.UseCustomBackColor = true;
            this.pnlAuteur.UseCustomForeColor = true;
            this.pnlAuteur.UseStyleColors = true;
            this.pnlAuteur.VerticalScrollbarBarColor = true;
            this.pnlAuteur.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAuteur.VerticalScrollbarSize = 10;
            // 
            // dgvAuteur
            // 
            this.dgvAuteur.AllowUserToAddRows = false;
            this.dgvAuteur.AllowUserToDeleteRows = false;
            this.dgvAuteur.AllowUserToResizeRows = false;
            this.dgvAuteur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAuteur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAuteur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAuteur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuteur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAuteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuteur.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAuteur.EnableHeadersVisualStyles = false;
            this.dgvAuteur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAuteur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvAuteur.Location = new System.Drawing.Point(12, 386);
            this.dgvAuteur.MultiSelect = false;
            this.dgvAuteur.Name = "dgvAuteur";
            this.dgvAuteur.ReadOnly = true;
            this.dgvAuteur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuteur.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAuteur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAuteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuteur.Size = new System.Drawing.Size(703, 219);
            this.dgvAuteur.TabIndex = 16;
            this.dgvAuteur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuteur_CellClick);
            // 
            // grpAuteur
            // 
            this.grpAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAuteur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpAuteur.Controls.Add(this.txtPays);
            this.grpAuteur.Controls.Add(this.chkNouvPays);
            this.grpAuteur.Controls.Add(this.grpStatut);
            this.grpAuteur.Controls.Add(this.cmbPays);
            this.grpAuteur.Controls.Add(this.lblPays);
            this.grpAuteur.Controls.Add(this.lblPseudo);
            this.grpAuteur.Controls.Add(this.txtPseudo);
            this.grpAuteur.Controls.Add(this.lblStatut);
            this.grpAuteur.Controls.Add(this.dtDateNaiss);
            this.grpAuteur.Controls.Add(this.lblBio);
            this.grpAuteur.Controls.Add(this.lblCode);
            this.grpAuteur.Controls.Add(this.txtBio);
            this.grpAuteur.Controls.Add(this.lblNom);
            this.grpAuteur.Controls.Add(this.lblDateNais);
            this.grpAuteur.Controls.Add(this.txtPrenom);
            this.grpAuteur.Controls.Add(this.lblPrenom);
            this.grpAuteur.Controls.Add(this.txtCode);
            this.grpAuteur.Controls.Add(this.txtNom);
            this.grpAuteur.Location = new System.Drawing.Point(3, 3);
            this.grpAuteur.Name = "grpAuteur";
            this.grpAuteur.Size = new System.Drawing.Size(718, 379);
            this.grpAuteur.TabIndex = 13;
            this.grpAuteur.TabStop = false;
            // 
            // grpStatut
            // 
            this.grpStatut.Controls.Add(this.rdoVivant);
            this.grpStatut.Controls.Add(this.dtStatut);
            this.grpStatut.Controls.Add(this.rdoDecede);
            this.grpStatut.Location = new System.Drawing.Point(460, 137);
            this.grpStatut.Name = "grpStatut";
            this.grpStatut.Size = new System.Drawing.Size(212, 100);
            this.grpStatut.TabIndex = 17;
            this.grpStatut.TabStop = false;
            // 
            // rdoVivant
            // 
            this.rdoVivant.AutoSize = true;
            this.rdoVivant.BackColor = System.Drawing.Color.Silver;
            this.rdoVivant.Enabled = false;
            this.rdoVivant.Location = new System.Drawing.Point(18, 26);
            this.rdoVivant.Name = "rdoVivant";
            this.rdoVivant.Size = new System.Drawing.Size(56, 15);
            this.rdoVivant.TabIndex = 6;
            this.rdoVivant.Text = "Vivant";
            this.rdoVivant.UseCustomBackColor = true;
            this.rdoVivant.UseSelectable = true;
            this.rdoVivant.CheckedChanged += new System.EventHandler(this.rdoVivant_CheckedChanged);
            // 
            // dtStatut
            // 
            this.dtStatut.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.dtStatut.Enabled = false;
            this.dtStatut.Location = new System.Drawing.Point(6, 57);
            this.dtStatut.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStatut.Name = "dtStatut";
            this.dtStatut.Size = new System.Drawing.Size(200, 29);
            this.dtStatut.TabIndex = 8;
            this.dtStatut.UseCustomBackColor = true;
            this.dtStatut.Visible = false;
            // 
            // rdoDecede
            // 
            this.rdoDecede.AutoSize = true;
            this.rdoDecede.BackColor = System.Drawing.Color.Silver;
            this.rdoDecede.Enabled = false;
            this.rdoDecede.Location = new System.Drawing.Point(125, 26);
            this.rdoDecede.Name = "rdoDecede";
            this.rdoDecede.Size = new System.Drawing.Size(62, 15);
            this.rdoDecede.TabIndex = 7;
            this.rdoDecede.Text = "Décédé";
            this.rdoDecede.UseCustomBackColor = true;
            this.rdoDecede.UseSelectable = true;
            this.rdoDecede.CheckedChanged += new System.EventHandler(this.rdoDecede_CheckedChanged);
            // 
            // cmbPays
            // 
            this.cmbPays.BackColor = System.Drawing.Color.Silver;
            this.cmbPays.Enabled = false;
            this.cmbPays.FormattingEnabled = true;
            this.cmbPays.ItemHeight = 23;
            this.cmbPays.Location = new System.Drawing.Point(141, 194);
            this.cmbPays.Name = "cmbPays";
            this.cmbPays.Size = new System.Drawing.Size(169, 29);
            this.cmbPays.TabIndex = 9;
            this.cmbPays.UseCustomBackColor = true;
            this.cmbPays.UseSelectable = true;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPays.Location = new System.Drawing.Point(20, 194);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(44, 19);
            this.lblPays.TabIndex = 18;
            this.lblPays.Text = "Pays :";
            this.lblPays.UseCustomBackColor = true;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPseudo.Location = new System.Drawing.Point(20, 106);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(95, 19);
            this.lblPseudo.TabIndex = 16;
            this.lblPseudo.Text = "Pseudonyme :";
            this.lblPseudo.UseCustomBackColor = true;
            // 
            // txtPseudo
            // 
            this.txtPseudo.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtPseudo.CustomButton.Image = null;
            this.txtPseudo.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPseudo.CustomButton.Name = "";
            this.txtPseudo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPseudo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPseudo.CustomButton.TabIndex = 1;
            this.txtPseudo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPseudo.CustomButton.UseSelectable = true;
            this.txtPseudo.CustomButton.Visible = false;
            this.txtPseudo.Enabled = false;
            this.txtPseudo.Lines = new string[0];
            this.txtPseudo.Location = new System.Drawing.Point(141, 102);
            this.txtPseudo.MaxLength = 32767;
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.PasswordChar = '\0';
            this.txtPseudo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPseudo.SelectedText = "";
            this.txtPseudo.SelectionLength = 0;
            this.txtPseudo.SelectionStart = 0;
            this.txtPseudo.ShortcutsEnabled = true;
            this.txtPseudo.Size = new System.Drawing.Size(169, 23);
            this.txtPseudo.TabIndex = 4;
            this.txtPseudo.UseCustomBackColor = true;
            this.txtPseudo.UseSelectable = true;
            this.txtPseudo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPseudo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatut.Location = new System.Drawing.Point(357, 159);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(53, 19);
            this.lblStatut.TabIndex = 14;
            this.lblStatut.Text = "Statut :";
            this.lblStatut.UseCustomBackColor = true;
            // 
            // dtDateNaiss
            // 
            this.dtDateNaiss.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.dtDateNaiss.Enabled = false;
            this.dtDateNaiss.Location = new System.Drawing.Point(141, 149);
            this.dtDateNaiss.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateNaiss.Name = "dtDateNaiss";
            this.dtDateNaiss.Size = new System.Drawing.Size(200, 29);
            this.dtDateNaiss.TabIndex = 5;
            this.dtDateNaiss.UseCustomBackColor = true;
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBio.Location = new System.Drawing.Point(20, 241);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(81, 19);
            this.lblBio.TabIndex = 12;
            this.lblBio.Text = "Biographie :";
            this.lblBio.UseCustomBackColor = true;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCode.Location = new System.Drawing.Point(20, 25);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(48, 19);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code :";
            this.lblCode.UseCustomBackColor = true;
            this.lblCode.UseCustomForeColor = true;
            this.lblCode.UseStyleColors = true;
            // 
            // txtBio
            // 
            this.txtBio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBio.CustomButton.Image = null;
            this.txtBio.CustomButton.Location = new System.Drawing.Point(595, 2);
            this.txtBio.CustomButton.Name = "";
            this.txtBio.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.txtBio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBio.CustomButton.TabIndex = 1;
            this.txtBio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBio.CustomButton.UseSelectable = true;
            this.txtBio.CustomButton.Visible = false;
            this.txtBio.Enabled = false;
            this.txtBio.Lines = new string[0];
            this.txtBio.Location = new System.Drawing.Point(9, 263);
            this.txtBio.MaxLength = 32767;
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.PasswordChar = '\0';
            this.txtBio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBio.SelectedText = "";
            this.txtBio.SelectionLength = 0;
            this.txtBio.SelectionStart = 0;
            this.txtBio.ShortcutsEnabled = true;
            this.txtBio.Size = new System.Drawing.Size(703, 110);
            this.txtBio.TabIndex = 10;
            this.txtBio.UseSelectable = true;
            this.txtBio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNom.Location = new System.Drawing.Point(20, 64);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(46, 19);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom :";
            this.lblNom.UseCustomBackColor = true;
            // 
            // lblDateNais
            // 
            this.lblDateNais.AutoSize = true;
            this.lblDateNais.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDateNais.Location = new System.Drawing.Point(20, 159);
            this.lblDateNais.Name = "lblDateNais";
            this.lblDateNais.Size = new System.Drawing.Size(107, 19);
            this.lblDateNais.TabIndex = 4;
            this.lblDateNais.Text = "Date naissance :";
            this.lblDateNais.UseCustomBackColor = true;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtPrenom.CustomButton.Image = null;
            this.txtPrenom.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPrenom.CustomButton.Name = "";
            this.txtPrenom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrenom.CustomButton.TabIndex = 1;
            this.txtPrenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrenom.CustomButton.UseSelectable = true;
            this.txtPrenom.CustomButton.Visible = false;
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Lines = new string[0];
            this.txtPrenom.Location = new System.Drawing.Point(478, 64);
            this.txtPrenom.MaxLength = 32767;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.SelectionLength = 0;
            this.txtPrenom.SelectionStart = 0;
            this.txtPrenom.ShortcutsEnabled = true;
            this.txtPrenom.Size = new System.Drawing.Size(169, 23);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.UseCustomBackColor = true;
            this.txtPrenom.UseSelectable = true;
            this.txtPrenom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrenom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPrenom.Location = new System.Drawing.Point(357, 64);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(64, 19);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom :";
            this.lblPrenom.UseCustomBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Enabled = false;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(141, 25);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(169, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtNom.CustomButton.Image = null;
            this.txtNom.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtNom.CustomButton.Name = "";
            this.txtNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNom.CustomButton.TabIndex = 1;
            this.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNom.CustomButton.UseSelectable = true;
            this.txtNom.CustomButton.Visible = false;
            this.txtNom.Enabled = false;
            this.txtNom.Lines = new string[0];
            this.txtNom.Location = new System.Drawing.Point(141, 64);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(169, 23);
            this.txtNom.TabIndex = 2;
            this.txtNom.UseCustomBackColor = true;
            this.txtNom.UseSelectable = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // picHome
            // 
            this.picHome.Image = global::InterfaceMedia.Properties.Resources.maxresdefault;
            this.picHome.Location = new System.Drawing.Point(111, 16);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(75, 41);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 30;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // chkNouvPays
            // 
            this.chkNouvPays.AutoSize = true;
            this.chkNouvPays.Enabled = false;
            this.chkNouvPays.Location = new System.Drawing.Point(316, 198);
            this.chkNouvPays.Name = "chkNouvPays";
            this.chkNouvPays.Size = new System.Drawing.Size(96, 30);
            this.chkNouvPays.TabIndex = 19;
            this.chkNouvPays.Text = "Ajouter un \r\nnouveau pays";
            this.chkNouvPays.UseSelectable = true;
            this.chkNouvPays.CheckedChanged += new System.EventHandler(this.chkNouvPays_CheckedChanged);
            // 
            // txtPays
            // 
            // 
            // 
            // 
            this.txtPays.CustomButton.Image = null;
            this.txtPays.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPays.CustomButton.Name = "";
            this.txtPays.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPays.CustomButton.TabIndex = 1;
            this.txtPays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPays.CustomButton.UseSelectable = true;
            this.txtPays.CustomButton.Visible = false;
            this.txtPays.Lines = new string[0];
            this.txtPays.Location = new System.Drawing.Point(141, 194);
            this.txtPays.MaxLength = 32767;
            this.txtPays.Name = "txtPays";
            this.txtPays.PasswordChar = '\0';
            this.txtPays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPays.SelectedText = "";
            this.txtPays.SelectionLength = 0;
            this.txtPays.SelectionStart = 0;
            this.txtPays.ShortcutsEnabled = true;
            this.txtPays.Size = new System.Drawing.Size(169, 23);
            this.txtPays.TabIndex = 20;
            this.txtPays.UseSelectable = true;
            this.txtPays.Visible = false;
            this.txtPays.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPays.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 694);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.pnlAuteur);
            this.Controls.Add(this.grpMenu);
            this.Name = "FrmAuteur";
            this.Text = "Auteur";
            this.grpMenu.ResumeLayout(false);
            this.grpQuitter.ResumeLayout(false);
            this.pnlAuteur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuteur)).EndInit();
            this.grpAuteur.ResumeLayout(false);
            this.grpAuteur.PerformLayout();
            this.grpStatut.ResumeLayout(false);
            this.grpStatut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenu;
        private MetroFramework.Controls.MetroPanel pnlAuteur;
        private MetroFramework.Controls.MetroLabel lblBio;
        private MetroFramework.Controls.MetroTextBox txtBio;
        private MetroFramework.Controls.MetroTextBox txtPrenom;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel lblPrenom;
        private MetroFramework.Controls.MetroLabel lblDateNais;
        private MetroFramework.Controls.MetroLabel lblNom;
        private MetroFramework.Controls.MetroLabel lblCode;
        private System.Windows.Forms.GroupBox grpAuteur;
        private MetroFramework.Controls.MetroDateTime dtDateNaiss;
        private MetroFramework.Controls.MetroLabel lblPays;
        private MetroFramework.Controls.MetroLabel lblPseudo;
        private MetroFramework.Controls.MetroTextBox txtPseudo;
        private MetroFramework.Controls.MetroDateTime dtStatut;
        private MetroFramework.Controls.MetroLabel lblStatut;
        private MetroFramework.Controls.MetroRadioButton rdoVivant;
        private MetroFramework.Controls.MetroRadioButton rdoDecede;
        private MetroFramework.Controls.MetroComboBox cmbPays;
        private System.Windows.Forms.GroupBox grpQuitter;
        private MetroFramework.Controls.MetroTile btnQuitter;
        private System.Windows.Forms.PictureBox picHome;
        private MetroFramework.Controls.MetroTile btnAnnuler;
        private MetroFramework.Controls.MetroTile btnRechercher;
        private MetroFramework.Controls.MetroTile btnAjouter;
        private MetroFramework.Controls.MetroTile btnModifier;
        private System.Windows.Forms.GroupBox grpStatut;
        private MetroFramework.Controls.MetroGrid dgvAuteur;
        private MetroFramework.Controls.MetroTextBox txtPays;
        private MetroFramework.Controls.MetroCheckBox chkNouvPays;
    }
}