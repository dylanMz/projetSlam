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
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnModifier = new MetroFramework.Controls.MetroTile();
            this.btnAjouter = new MetroFramework.Controls.MetroTile();
            this.btnRechercher = new MetroFramework.Controls.MetroTile();
            this.btnAnnuler = new MetroFramework.Controls.MetroTile();
            this.pnlAuteur = new MetroFramework.Controls.MetroPanel();
            this.grpAuteur = new System.Windows.Forms.GroupBox();
            this.cmbPays = new MetroFramework.Controls.MetroComboBox();
            this.rdoDecede = new MetroFramework.Controls.MetroRadioButton();
            this.rdoVivant = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPseudo = new MetroFramework.Controls.MetroTextBox();
            this.dtStatut = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtDateNaiss = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.txtBio = new MetroFramework.Controls.MetroTextBox();
            this.lblNom = new MetroFramework.Controls.MetroLabel();
            this.lblDateNais = new MetroFramework.Controls.MetroLabel();
            this.txtPrenom = new MetroFramework.Controls.MetroTextBox();
            this.lblPrenom = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.dgvAuteur = new System.Windows.Forms.DataGridView();
            this.grpQuitter = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new MetroFramework.Controls.MetroTile();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.grpStatut = new System.Windows.Forms.GroupBox();
            this.grpMenu.SuspendLayout();
            this.pnlAuteur.SuspendLayout();
            this.grpAuteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuteur)).BeginInit();
            this.grpQuitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.grpStatut.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.Controls.Add(this.btnModifier);
            this.grpMenu.Controls.Add(this.btnAjouter);
            this.grpMenu.Controls.Add(this.btnRechercher);
            this.grpMenu.Controls.Add(this.btnAnnuler);
            this.grpMenu.Location = new System.Drawing.Point(737, 63);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(216, 519);
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
            this.btnRechercher.TabIndex = 15;
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
            this.btnAnnuler.TabIndex = 16;
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
            this.pnlAuteur.Controls.Add(this.grpAuteur);
            this.pnlAuteur.Controls.Add(this.dgvAuteur);
            this.pnlAuteur.HorizontalScrollbarBarColor = true;
            this.pnlAuteur.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAuteur.HorizontalScrollbarSize = 10;
            this.pnlAuteur.Location = new System.Drawing.Point(7, 63);
            this.pnlAuteur.Name = "pnlAuteur";
            this.pnlAuteur.Size = new System.Drawing.Size(724, 608);
            this.pnlAuteur.TabIndex = 6;
            this.pnlAuteur.VerticalScrollbarBarColor = true;
            this.pnlAuteur.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAuteur.VerticalScrollbarSize = 10;
            // 
            // grpAuteur
            // 
            this.grpAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAuteur.Controls.Add(this.grpStatut);
            this.grpAuteur.Controls.Add(this.cmbPays);
            this.grpAuteur.Controls.Add(this.metroLabel3);
            this.grpAuteur.Controls.Add(this.metroLabel2);
            this.grpAuteur.Controls.Add(this.txtPseudo);
            this.grpAuteur.Controls.Add(this.metroLabel1);
            this.grpAuteur.Controls.Add(this.dtDateNaiss);
            this.grpAuteur.Controls.Add(this.metroLabel5);
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
            this.cmbPays.SelectedIndexChanged += new System.EventHandler(this.cmbPays_SelectedIndexChanged);
            // 
            // rdoDecede
            // 
            this.rdoDecede.AutoSize = true;
            this.rdoDecede.BackColor = System.Drawing.Color.Silver;
            this.rdoDecede.Enabled = false;
            this.rdoDecede.Location = new System.Drawing.Point(119, 26);
            this.rdoDecede.Name = "rdoDecede";
            this.rdoDecede.Size = new System.Drawing.Size(62, 15);
            this.rdoDecede.TabIndex = 7;
            this.rdoDecede.Text = "Décédé";
            this.rdoDecede.UseCustomBackColor = true;
            this.rdoDecede.UseSelectable = true;
            this.rdoDecede.CheckedChanged += new System.EventHandler(this.rdoDecede_CheckedChanged);
            // 
            // rdoVivant
            // 
            this.rdoVivant.AutoSize = true;
            this.rdoVivant.BackColor = System.Drawing.Color.Silver;
            this.rdoVivant.Enabled = false;
            this.rdoVivant.Location = new System.Drawing.Point(6, 26);
            this.rdoVivant.Name = "rdoVivant";
            this.rdoVivant.Size = new System.Drawing.Size(56, 15);
            this.rdoVivant.TabIndex = 6;
            this.rdoVivant.Text = "Vivant";
            this.rdoVivant.UseCustomBackColor = true;
            this.rdoVivant.UseSelectable = true;
            this.rdoVivant.CheckedChanged += new System.EventHandler(this.rdoVivant_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(20, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Pays :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(20, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Pseudonyme :";
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(357, 159);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Statut :";
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(20, 241);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Biographie :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCode.Location = new System.Drawing.Point(20, 25);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(52, 19);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code :";
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
            this.txtBio.CustomButton.Location = new System.Drawing.Point(598, 2);
            this.txtBio.CustomButton.Name = "";
            this.txtBio.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.txtBio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBio.CustomButton.TabIndex = 1;
            this.txtBio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBio.CustomButton.UseSelectable = true;
            this.txtBio.CustomButton.Visible = false;
            this.txtBio.Enabled = false;
            this.txtBio.Lines = new string[0];
            this.txtBio.Location = new System.Drawing.Point(6, 263);
            this.txtBio.MaxLength = 32767;
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.PasswordChar = '\0';
            this.txtBio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBio.SelectedText = "";
            this.txtBio.SelectionLength = 0;
            this.txtBio.SelectionStart = 0;
            this.txtBio.ShortcutsEnabled = true;
            this.txtBio.Size = new System.Drawing.Size(706, 110);
            this.txtBio.TabIndex = 10;
            this.txtBio.UseSelectable = true;
            this.txtBio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNom.Location = new System.Drawing.Point(20, 64);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 19);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom :";
            // 
            // lblDateNais
            // 
            this.lblDateNais.AutoSize = true;
            this.lblDateNais.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDateNais.Location = new System.Drawing.Point(20, 159);
            this.lblDateNais.Name = "lblDateNais";
            this.lblDateNais.Size = new System.Drawing.Size(115, 19);
            this.lblDateNais.TabIndex = 4;
            this.lblDateNais.Text = "Date naissance :";
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
            this.lblPrenom.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPrenom.Location = new System.Drawing.Point(357, 64);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(70, 19);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom :";
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
            // dgvAuteur
            // 
            this.dgvAuteur.AllowUserToAddRows = false;
            this.dgvAuteur.AllowUserToDeleteRows = false;
            this.dgvAuteur.AllowUserToOrderColumns = true;
            this.dgvAuteur.AllowUserToResizeRows = false;
            this.dgvAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuteur.Location = new System.Drawing.Point(12, 382);
            this.dgvAuteur.MultiSelect = false;
            this.dgvAuteur.Name = "dgvAuteur";
            this.dgvAuteur.ReadOnly = true;
            this.dgvAuteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuteur.Size = new System.Drawing.Size(703, 205);
            this.dgvAuteur.TabIndex = 18;
            // 
            // grpQuitter
            // 
            this.grpQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQuitter.Controls.Add(this.btnQuitter);
            this.grpQuitter.Location = new System.Drawing.Point(737, 588);
            this.grpQuitter.Name = "grpQuitter";
            this.grpQuitter.Size = new System.Drawing.Size(216, 83);
            this.grpQuitter.TabIndex = 7;
            this.grpQuitter.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.ActiveControl = null;
            this.btnQuitter.BackColor = System.Drawing.Color.Tomato;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Location = new System.Drawing.Point(24, 19);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(169, 44);
            this.btnQuitter.TabIndex = 17;
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
            // grpStatut
            // 
            this.grpStatut.Controls.Add(this.rdoVivant);
            this.grpStatut.Controls.Add(this.dtStatut);
            this.grpStatut.Controls.Add(this.rdoDecede);
            this.grpStatut.Location = new System.Drawing.Point(447, 137);
            this.grpStatut.Name = "grpStatut";
            this.grpStatut.Size = new System.Drawing.Size(212, 100);
            this.grpStatut.TabIndex = 17;
            this.grpStatut.TabStop = false;
            // 
            // FrmAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 694);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.grpQuitter);
            this.Controls.Add(this.pnlAuteur);
            this.Controls.Add(this.grpMenu);
            this.Name = "FrmAuteur";
            this.Text = "Auteur";
            this.grpMenu.ResumeLayout(false);
            this.pnlAuteur.ResumeLayout(false);
            this.grpAuteur.ResumeLayout(false);
            this.grpAuteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuteur)).EndInit();
            this.grpQuitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.grpStatut.ResumeLayout(false);
            this.grpStatut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenu;
        private MetroFramework.Controls.MetroPanel pnlAuteur;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtBio;
        private System.Windows.Forms.DataGridView dgvAuteur;
        private MetroFramework.Controls.MetroTextBox txtPrenom;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel lblPrenom;
        private MetroFramework.Controls.MetroLabel lblDateNais;
        private MetroFramework.Controls.MetroLabel lblNom;
        private MetroFramework.Controls.MetroLabel lblCode;
        private System.Windows.Forms.GroupBox grpAuteur;
        private MetroFramework.Controls.MetroDateTime dtDateNaiss;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPseudo;
        private MetroFramework.Controls.MetroDateTime dtStatut;
        private MetroFramework.Controls.MetroLabel metroLabel1;
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
    }
}