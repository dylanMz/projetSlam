namespace InterfaceMedia
{
    partial class Frmlivre
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metrotileQuitter = new MetroFramework.Controls.MetroTile();
            this.btnAnnuler = new MetroFramework.Controls.MetroTile();
            this.btnRechercher = new MetroFramework.Controls.MetroTile();
            this.btnSupprimer = new MetroFramework.Controls.MetroTile();
            this.btnModifier = new MetroFramework.Controls.MetroTile();
            this.btnAjouter = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnexemp = new MetroFramework.Controls.MetroTile();
            this.grpboxexemp = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.codelivreexmp = new MetroFramework.Controls.MetroTextBox();
            this.txtbxreferencerexemp = new MetroFramework.Controls.MetroTextBox();
            this.rdbtnA = new System.Windows.Forms.RadioButton();
            this.rdbtnb = new System.Windows.Forms.RadioButton();
            this.rdbtntb = new System.Windows.Forms.RadioButton();
            this.rdbtnta = new System.Windows.Forms.RadioButton();
            this.lbletat = new MetroFramework.Controls.MetroLabel();
            this.lblexemp = new MetroFramework.Controls.MetroLabel();
            this.lblExemplaire = new MetroFramework.Controls.MetroLabel();
            this.cmbbxauteur = new MetroFramework.Controls.MetroComboBox();
            this.cmbbxserie = new MetroFramework.Controls.MetroComboBox();
            this.cmbbxediteur = new MetroFramework.Controls.MetroComboBox();
            this.lblauteur = new MetroFramework.Controls.MetroLabel();
            this.txtbxcommentaire = new MetroFramework.Controls.MetroTextBox();
            this.lblcommentaire = new MetroFramework.Controls.MetroLabel();
            this.txtbxauteur = new MetroFramework.Controls.MetroTextBox();
            this.lblformat = new MetroFramework.Controls.MetroLabel();
            this.txtbxformat = new MetroFramework.Controls.MetroTextBox();
            this.txtbxcouleur = new MetroFramework.Controls.MetroTextBox();
            this.txtbxisbn = new MetroFramework.Controls.MetroTextBox();
            this.lbltome = new MetroFramework.Controls.MetroLabel();
            this.lblisbn = new MetroFramework.Controls.MetroLabel();
            this.lblanneeparution = new MetroFramework.Controls.MetroLabel();
            this.txtbxtome = new MetroFramework.Controls.MetroTextBox();
            this.cmbbxannee = new MetroFramework.Controls.MetroComboBox();
            this.txtbxediteur = new MetroFramework.Controls.MetroTextBox();
            this.lblnbrpage = new MetroFramework.Controls.MetroLabel();
            this.lblediteur = new MetroFramework.Controls.MetroLabel();
            this.txtbxpage = new MetroFramework.Controls.MetroTextBox();
            this.txtbxserie = new MetroFramework.Controls.MetroTextBox();
            this.lblcouleur = new MetroFramework.Controls.MetroLabel();
            this.lblserie = new MetroFramework.Controls.MetroLabel();
            this.lblcode = new MetroFramework.Controls.MetroLabel();
            this.txtbxcode = new MetroFramework.Controls.MetroTextBox();
            this.lbltitre = new MetroFramework.Controls.MetroLabel();
            this.txtbxtitre = new MetroFramework.Controls.MetroTextBox();
            this.dtgrvLivre = new System.Windows.Forms.DataGridView();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.txtbxmotif = new MetroFramework.Controls.MetroTextBox();
            this.lblmotif = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.grpboxexemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvLivre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metrotileQuitter);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Location = new System.Drawing.Point(768, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 591);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            // 
            // metrotileQuitter
            // 
            this.metrotileQuitter.ActiveControl = null;
            this.metrotileQuitter.BackColor = System.Drawing.Color.Tomato;
            this.metrotileQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metrotileQuitter.ForeColor = System.Drawing.Color.White;
            this.metrotileQuitter.Location = new System.Drawing.Point(6, 532);
            this.metrotileQuitter.Name = "metrotileQuitter";
            this.metrotileQuitter.Size = new System.Drawing.Size(168, 44);
            this.metrotileQuitter.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotileQuitter.TabIndex = 14;
            this.metrotileQuitter.Text = "Quitter";
            this.metrotileQuitter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metrotileQuitter.TileImage = global::InterfaceMedia.Properties.Resources.Quitter5;
            this.metrotileQuitter.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metrotileQuitter.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metrotileQuitter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metrotileQuitter.UseCustomBackColor = true;
            this.metrotileQuitter.UseCustomForeColor = true;
            this.metrotileQuitter.UseSelectable = true;
            this.metrotileQuitter.UseTileImage = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.ActiveControl = null;
            this.btnAnnuler.BackColor = System.Drawing.Color.Tomato;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(11, 392);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(156, 48);
            this.btnAnnuler.TabIndex = 101;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnnuler.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAnnuler.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAnnuler.UseCustomBackColor = true;
            this.btnAnnuler.UseSelectable = true;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.ActiveControl = null;
            this.btnRechercher.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.Location = new System.Drawing.Point(11, 261);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(156, 48);
            this.btnRechercher.TabIndex = 99;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRechercher.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnRechercher.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnRechercher.UseCustomBackColor = true;
            this.btnRechercher.UseSelectable = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ActiveControl = null;
            this.btnSupprimer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Location = new System.Drawing.Point(12, 184);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(156, 48);
            this.btnSupprimer.TabIndex = 98;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSupprimer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSupprimer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSupprimer.UseCustomBackColor = true;
            this.btnSupprimer.UseSelectable = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.ActiveControl = null;
            this.btnModifier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Location = new System.Drawing.Point(11, 100);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(156, 48);
            this.btnModifier.TabIndex = 97;
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
            this.btnAjouter.Location = new System.Drawing.Point(11, 19);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(156, 48);
            this.btnAjouter.TabIndex = 96;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjouter.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAjouter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAjouter.UseCustomBackColor = true;
            this.btnAjouter.UseSelectable = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtbxmotif);
            this.metroPanel1.Controls.Add(this.lblmotif);
            this.metroPanel1.Controls.Add(this.btnexemp);
            this.metroPanel1.Controls.Add(this.grpboxexemp);
            this.metroPanel1.Controls.Add(this.cmbbxauteur);
            this.metroPanel1.Controls.Add(this.cmbbxserie);
            this.metroPanel1.Controls.Add(this.cmbbxediteur);
            this.metroPanel1.Controls.Add(this.lblauteur);
            this.metroPanel1.Controls.Add(this.txtbxcommentaire);
            this.metroPanel1.Controls.Add(this.lblcommentaire);
            this.metroPanel1.Controls.Add(this.txtbxauteur);
            this.metroPanel1.Controls.Add(this.lblformat);
            this.metroPanel1.Controls.Add(this.txtbxformat);
            this.metroPanel1.Controls.Add(this.txtbxcouleur);
            this.metroPanel1.Controls.Add(this.txtbxisbn);
            this.metroPanel1.Controls.Add(this.lbltome);
            this.metroPanel1.Controls.Add(this.lblisbn);
            this.metroPanel1.Controls.Add(this.lblanneeparution);
            this.metroPanel1.Controls.Add(this.txtbxtome);
            this.metroPanel1.Controls.Add(this.cmbbxannee);
            this.metroPanel1.Controls.Add(this.txtbxediteur);
            this.metroPanel1.Controls.Add(this.lblnbrpage);
            this.metroPanel1.Controls.Add(this.lblediteur);
            this.metroPanel1.Controls.Add(this.txtbxpage);
            this.metroPanel1.Controls.Add(this.txtbxserie);
            this.metroPanel1.Controls.Add(this.lblcouleur);
            this.metroPanel1.Controls.Add(this.lblserie);
            this.metroPanel1.Controls.Add(this.lblcode);
            this.metroPanel1.Controls.Add(this.txtbxcode);
            this.metroPanel1.Controls.Add(this.lbltitre);
            this.metroPanel1.Controls.Add(this.txtbxtitre);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(696, 330);
            this.metroPanel1.TabIndex = 103;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnexemp
            // 
            this.btnexemp.ActiveControl = null;
            this.btnexemp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnexemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexemp.Location = new System.Drawing.Point(173, 283);
            this.btnexemp.Name = "btnexemp";
            this.btnexemp.Size = new System.Drawing.Size(108, 39);
            this.btnexemp.TabIndex = 98;
            this.btnexemp.Text = "exemplaire";
            this.btnexemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnexemp.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnexemp.UseCustomBackColor = true;
            this.btnexemp.UseSelectable = true;
            this.btnexemp.UseStyleColors = true;
            this.btnexemp.Click += new System.EventHandler(this.btnexemp_Click);
            // 
            // grpboxexemp
            // 
            this.grpboxexemp.Controls.Add(this.metroLabel1);
            this.grpboxexemp.Controls.Add(this.codelivreexmp);
            this.grpboxexemp.Controls.Add(this.txtbxreferencerexemp);
            this.grpboxexemp.Controls.Add(this.rdbtnA);
            this.grpboxexemp.Controls.Add(this.rdbtnb);
            this.grpboxexemp.Controls.Add(this.rdbtntb);
            this.grpboxexemp.Controls.Add(this.rdbtnta);
            this.grpboxexemp.Controls.Add(this.lbletat);
            this.grpboxexemp.Controls.Add(this.lblexemp);
            this.grpboxexemp.Controls.Add(this.lblExemplaire);
            this.grpboxexemp.HorizontalScrollbarBarColor = true;
            this.grpboxexemp.HorizontalScrollbarHighlightOnWheel = false;
            this.grpboxexemp.HorizontalScrollbarSize = 10;
            this.grpboxexemp.Location = new System.Drawing.Point(399, 157);
            this.grpboxexemp.Name = "grpboxexemp";
            this.grpboxexemp.Size = new System.Drawing.Size(294, 170);
            this.grpboxexemp.TabIndex = 77;
            this.grpboxexemp.VerticalScrollbarBarColor = true;
            this.grpboxexemp.VerticalScrollbarHighlightOnWheel = false;
            this.grpboxexemp.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(83, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "Code  livre:";
            // 
            // codelivreexmp
            // 
            this.codelivreexmp.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.codelivreexmp.CustomButton.Image = null;
            this.codelivreexmp.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.codelivreexmp.CustomButton.Name = "";
            this.codelivreexmp.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.codelivreexmp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codelivreexmp.CustomButton.TabIndex = 1;
            this.codelivreexmp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codelivreexmp.CustomButton.UseSelectable = true;
            this.codelivreexmp.CustomButton.Visible = false;
            this.codelivreexmp.Enabled = false;
            this.codelivreexmp.Lines = new string[0];
            this.codelivreexmp.Location = new System.Drawing.Point(176, 88);
            this.codelivreexmp.MaxLength = 32767;
            this.codelivreexmp.Name = "codelivreexmp";
            this.codelivreexmp.PasswordChar = '\0';
            this.codelivreexmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codelivreexmp.SelectedText = "";
            this.codelivreexmp.SelectionLength = 0;
            this.codelivreexmp.SelectionStart = 0;
            this.codelivreexmp.ShortcutsEnabled = true;
            this.codelivreexmp.Size = new System.Drawing.Size(77, 25);
            this.codelivreexmp.TabIndex = 74;
            this.codelivreexmp.UseCustomBackColor = true;
            this.codelivreexmp.UseSelectable = true;
            this.codelivreexmp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codelivreexmp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbxreferencerexemp
            // 
            this.txtbxreferencerexemp.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxreferencerexemp.CustomButton.Image = null;
            this.txtbxreferencerexemp.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txtbxreferencerexemp.CustomButton.Name = "";
            this.txtbxreferencerexemp.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxreferencerexemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxreferencerexemp.CustomButton.TabIndex = 1;
            this.txtbxreferencerexemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxreferencerexemp.CustomButton.UseSelectable = true;
            this.txtbxreferencerexemp.CustomButton.Visible = false;
            this.txtbxreferencerexemp.Enabled = false;
            this.txtbxreferencerexemp.Lines = new string[0];
            this.txtbxreferencerexemp.Location = new System.Drawing.Point(176, 55);
            this.txtbxreferencerexemp.MaxLength = 32767;
            this.txtbxreferencerexemp.Name = "txtbxreferencerexemp";
            this.txtbxreferencerexemp.PasswordChar = '\0';
            this.txtbxreferencerexemp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxreferencerexemp.SelectedText = "";
            this.txtbxreferencerexemp.SelectionLength = 0;
            this.txtbxreferencerexemp.SelectionStart = 0;
            this.txtbxreferencerexemp.ShortcutsEnabled = true;
            this.txtbxreferencerexemp.Size = new System.Drawing.Size(100, 25);
            this.txtbxreferencerexemp.TabIndex = 59;
            this.txtbxreferencerexemp.UseCustomBackColor = true;
            this.txtbxreferencerexemp.UseSelectable = true;
            this.txtbxreferencerexemp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxreferencerexemp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rdbtnA
            // 
            this.rdbtnA.AutoSize = true;
            this.rdbtnA.Enabled = false;
            this.rdbtnA.Location = new System.Drawing.Point(199, 125);
            this.rdbtnA.Name = "rdbtnA";
            this.rdbtnA.Size = new System.Drawing.Size(57, 17);
            this.rdbtnA.TabIndex = 63;
            this.rdbtnA.TabStop = true;
            this.rdbtnA.Text = "Abimé ";
            this.rdbtnA.UseVisualStyleBackColor = true;
            // 
            // rdbtnb
            // 
            this.rdbtnb.AutoSize = true;
            this.rdbtnb.Enabled = false;
            this.rdbtnb.Location = new System.Drawing.Point(117, 148);
            this.rdbtnb.Name = "rdbtnb";
            this.rdbtnb.Size = new System.Drawing.Size(44, 17);
            this.rdbtnb.TabIndex = 62;
            this.rdbtnb.TabStop = true;
            this.rdbtnb.Text = "Bon";
            this.rdbtnb.UseVisualStyleBackColor = true;
            // 
            // rdbtntb
            // 
            this.rdbtntb.AutoSize = true;
            this.rdbtntb.BackColor = System.Drawing.Color.White;
            this.rdbtntb.Enabled = false;
            this.rdbtntb.Location = new System.Drawing.Point(117, 125);
            this.rdbtntb.Name = "rdbtntb";
            this.rdbtntb.Size = new System.Drawing.Size(67, 17);
            this.rdbtntb.TabIndex = 61;
            this.rdbtntb.TabStop = true;
            this.rdbtntb.Text = "Très bon";
            this.rdbtntb.UseVisualStyleBackColor = false;
            // 
            // rdbtnta
            // 
            this.rdbtnta.AutoSize = true;
            this.rdbtnta.Enabled = false;
            this.rdbtnta.Location = new System.Drawing.Point(199, 148);
            this.rdbtnta.Name = "rdbtnta";
            this.rdbtnta.Size = new System.Drawing.Size(77, 17);
            this.rdbtnta.TabIndex = 65;
            this.rdbtnta.TabStop = true;
            this.rdbtnta.Text = "Très abimé";
            this.rdbtnta.UseVisualStyleBackColor = true;
            // 
            // lbletat
            // 
            this.lbletat.AutoSize = true;
            this.lbletat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbletat.Location = new System.Drawing.Point(3, 126);
            this.lbletat.Name = "lbletat";
            this.lbletat.Size = new System.Drawing.Size(86, 19);
            this.lbletat.TabIndex = 67;
            this.lbletat.Text = "Etat            :";
            // 
            // lblexemp
            // 
            this.lblexemp.AutoSize = true;
            this.lblexemp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblexemp.Location = new System.Drawing.Point(2, 57);
            this.lblexemp.Name = "lblexemp";
            this.lblexemp.Size = new System.Drawing.Size(168, 19);
            this.lblexemp.TabIndex = 73;
            this.lblexemp.Text = "Reference exemplaire  :";
            // 
            // lblExemplaire
            // 
            this.lblExemplaire.AutoSize = true;
            this.lblExemplaire.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblExemplaire.ForeColor = System.Drawing.Color.Black;
            this.lblExemplaire.Location = new System.Drawing.Point(104, 18);
            this.lblExemplaire.Name = "lblExemplaire";
            this.lblExemplaire.Size = new System.Drawing.Size(84, 19);
            this.lblExemplaire.TabIndex = 71;
            this.lblExemplaire.Text = "Exemplaire";
            // 
            // cmbbxauteur
            // 
            this.cmbbxauteur.BackColor = System.Drawing.Color.Silver;
            this.cmbbxauteur.Enabled = false;
            this.cmbbxauteur.FormattingEnabled = true;
            this.cmbbxauteur.ItemHeight = 23;
            this.cmbbxauteur.Location = new System.Drawing.Point(233, 248);
            this.cmbbxauteur.Name = "cmbbxauteur";
            this.cmbbxauteur.Size = new System.Drawing.Size(121, 29);
            this.cmbbxauteur.TabIndex = 76;
            this.cmbbxauteur.UseCustomBackColor = true;
            this.cmbbxauteur.UseSelectable = true;
            // 
            // cmbbxserie
            // 
            this.cmbbxserie.BackColor = System.Drawing.Color.Silver;
            this.cmbbxserie.Enabled = false;
            this.cmbbxserie.FormattingEnabled = true;
            this.cmbbxserie.ItemHeight = 23;
            this.cmbbxserie.Location = new System.Drawing.Point(233, 208);
            this.cmbbxserie.Name = "cmbbxserie";
            this.cmbbxserie.Size = new System.Drawing.Size(121, 29);
            this.cmbbxserie.TabIndex = 75;
            this.cmbbxserie.UseCustomBackColor = true;
            this.cmbbxserie.UseSelectable = true;
            // 
            // cmbbxediteur
            // 
            this.cmbbxediteur.BackColor = System.Drawing.Color.Silver;
            this.cmbbxediteur.Enabled = false;
            this.cmbbxediteur.FormattingEnabled = true;
            this.cmbbxediteur.ItemHeight = 23;
            this.cmbbxediteur.Location = new System.Drawing.Point(233, 169);
            this.cmbbxediteur.Name = "cmbbxediteur";
            this.cmbbxediteur.Size = new System.Drawing.Size(121, 29);
            this.cmbbxediteur.TabIndex = 74;
            this.cmbbxediteur.UseCustomBackColor = true;
            this.cmbbxediteur.UseSelectable = true;
            // 
            // lblauteur
            // 
            this.lblauteur.AutoSize = true;
            this.lblauteur.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblauteur.Location = new System.Drawing.Point(15, 246);
            this.lblauteur.Name = "lblauteur";
            this.lblauteur.Size = new System.Drawing.Size(62, 19);
            this.lblauteur.TabIndex = 72;
            this.lblauteur.Text = "Auteur :";
            // 
            // txtbxcommentaire
            // 
            this.txtbxcommentaire.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxcommentaire.CustomButton.Image = null;
            this.txtbxcommentaire.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtbxcommentaire.CustomButton.Name = "";
            this.txtbxcommentaire.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxcommentaire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxcommentaire.CustomButton.TabIndex = 1;
            this.txtbxcommentaire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxcommentaire.CustomButton.UseSelectable = true;
            this.txtbxcommentaire.CustomButton.Visible = false;
            this.txtbxcommentaire.Enabled = false;
            this.txtbxcommentaire.Lines = new string[0];
            this.txtbxcommentaire.Location = new System.Drawing.Point(471, 131);
            this.txtbxcommentaire.MaxLength = 32767;
            this.txtbxcommentaire.Name = "txtbxcommentaire";
            this.txtbxcommentaire.PasswordChar = '\0';
            this.txtbxcommentaire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxcommentaire.SelectedText = "";
            this.txtbxcommentaire.SelectionLength = 0;
            this.txtbxcommentaire.SelectionStart = 0;
            this.txtbxcommentaire.ShortcutsEnabled = true;
            this.txtbxcommentaire.Size = new System.Drawing.Size(222, 23);
            this.txtbxcommentaire.TabIndex = 54;
            this.txtbxcommentaire.UseCustomBackColor = true;
            this.txtbxcommentaire.UseSelectable = true;
            this.txtbxcommentaire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxcommentaire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblcommentaire
            // 
            this.lblcommentaire.AutoSize = true;
            this.lblcommentaire.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblcommentaire.Location = new System.Drawing.Point(354, 135);
            this.lblcommentaire.Name = "lblcommentaire";
            this.lblcommentaire.Size = new System.Drawing.Size(100, 19);
            this.lblcommentaire.TabIndex = 70;
            this.lblcommentaire.Text = "Commentaire";
            // 
            // txtbxauteur
            // 
            this.txtbxauteur.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxauteur.CustomButton.Image = null;
            this.txtbxauteur.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtbxauteur.CustomButton.Name = "";
            this.txtbxauteur.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxauteur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxauteur.CustomButton.TabIndex = 1;
            this.txtbxauteur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxauteur.CustomButton.UseSelectable = true;
            this.txtbxauteur.CustomButton.Visible = false;
            this.txtbxauteur.Enabled = false;
            this.txtbxauteur.Lines = new string[0];
            this.txtbxauteur.Location = new System.Drawing.Point(90, 252);
            this.txtbxauteur.MaxLength = 32767;
            this.txtbxauteur.Name = "txtbxauteur";
            this.txtbxauteur.PasswordChar = '\0';
            this.txtbxauteur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxauteur.SelectedText = "";
            this.txtbxauteur.SelectionLength = 0;
            this.txtbxauteur.SelectionStart = 0;
            this.txtbxauteur.ShortcutsEnabled = true;
            this.txtbxauteur.Size = new System.Drawing.Size(121, 25);
            this.txtbxauteur.TabIndex = 58;
            this.txtbxauteur.UseCustomBackColor = true;
            this.txtbxauteur.UseSelectable = true;
            this.txtbxauteur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxauteur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblformat
            // 
            this.lblformat.AutoSize = true;
            this.lblformat.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblformat.Location = new System.Drawing.Point(348, 90);
            this.lblformat.Name = "lblformat";
            this.lblformat.Size = new System.Drawing.Size(108, 19);
            this.lblformat.TabIndex = 69;
            this.lblformat.Text = "Format / Style ";
            // 
            // txtbxformat
            // 
            this.txtbxformat.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxformat.CustomButton.Image = null;
            this.txtbxformat.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtbxformat.CustomButton.Name = "";
            this.txtbxformat.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxformat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxformat.CustomButton.TabIndex = 1;
            this.txtbxformat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxformat.CustomButton.UseSelectable = true;
            this.txtbxformat.CustomButton.Visible = false;
            this.txtbxformat.Enabled = false;
            this.txtbxformat.Lines = new string[0];
            this.txtbxformat.Location = new System.Drawing.Point(471, 90);
            this.txtbxformat.MaxLength = 32767;
            this.txtbxformat.Name = "txtbxformat";
            this.txtbxformat.PasswordChar = '\0';
            this.txtbxformat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxformat.SelectedText = "";
            this.txtbxformat.SelectionLength = 0;
            this.txtbxformat.SelectionStart = 0;
            this.txtbxformat.ShortcutsEnabled = true;
            this.txtbxformat.Size = new System.Drawing.Size(121, 25);
            this.txtbxformat.TabIndex = 50;
            this.txtbxformat.UseCustomBackColor = true;
            this.txtbxformat.UseSelectable = true;
            this.txtbxformat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxformat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbxcouleur
            // 
            this.txtbxcouleur.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxcouleur.CustomButton.Image = null;
            this.txtbxcouleur.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtbxcouleur.CustomButton.Name = "";
            this.txtbxcouleur.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxcouleur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxcouleur.CustomButton.TabIndex = 1;
            this.txtbxcouleur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxcouleur.CustomButton.UseSelectable = true;
            this.txtbxcouleur.CustomButton.Visible = false;
            this.txtbxcouleur.Enabled = false;
            this.txtbxcouleur.Lines = new string[0];
            this.txtbxcouleur.Location = new System.Drawing.Point(348, 50);
            this.txtbxcouleur.MaxLength = 32767;
            this.txtbxcouleur.Name = "txtbxcouleur";
            this.txtbxcouleur.PasswordChar = '\0';
            this.txtbxcouleur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxcouleur.SelectedText = "";
            this.txtbxcouleur.SelectionLength = 0;
            this.txtbxcouleur.SelectionStart = 0;
            this.txtbxcouleur.ShortcutsEnabled = true;
            this.txtbxcouleur.Size = new System.Drawing.Size(121, 25);
            this.txtbxcouleur.TabIndex = 47;
            this.txtbxcouleur.UseCustomBackColor = true;
            this.txtbxcouleur.UseSelectable = true;
            this.txtbxcouleur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxcouleur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbxisbn
            // 
            this.txtbxisbn.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxisbn.CustomButton.Image = null;
            this.txtbxisbn.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtbxisbn.CustomButton.Name = "";
            this.txtbxisbn.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxisbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxisbn.CustomButton.TabIndex = 1;
            this.txtbxisbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxisbn.CustomButton.UseSelectable = true;
            this.txtbxisbn.CustomButton.Visible = false;
            this.txtbxisbn.Enabled = false;
            this.txtbxisbn.Lines = new string[0];
            this.txtbxisbn.Location = new System.Drawing.Point(83, 50);
            this.txtbxisbn.MaxLength = 32767;
            this.txtbxisbn.Name = "txtbxisbn";
            this.txtbxisbn.PasswordChar = '\0';
            this.txtbxisbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxisbn.SelectedText = "";
            this.txtbxisbn.SelectionLength = 0;
            this.txtbxisbn.SelectionStart = 0;
            this.txtbxisbn.ShortcutsEnabled = true;
            this.txtbxisbn.Size = new System.Drawing.Size(157, 25);
            this.txtbxisbn.TabIndex = 46;
            this.txtbxisbn.UseCustomBackColor = true;
            this.txtbxisbn.UseSelectable = true;
            this.txtbxisbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxisbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbltome
            // 
            this.lbltome.AutoSize = true;
            this.lbltome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbltome.Location = new System.Drawing.Point(486, 56);
            this.lbltome.Name = "lbltome";
            this.lbltome.Size = new System.Drawing.Size(70, 19);
            this.lbltome.TabIndex = 53;
            this.lbltome.Text = "N° Tome:";
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblisbn.Location = new System.Drawing.Point(6, 50);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(60, 19);
            this.lblisbn.TabIndex = 51;
            this.lblisbn.Text = "N° Isbn:";
            // 
            // lblanneeparution
            // 
            this.lblanneeparution.AutoSize = true;
            this.lblanneeparution.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblanneeparution.Location = new System.Drawing.Point(4, 90);
            this.lblanneeparution.Name = "lblanneeparution";
            this.lblanneeparution.Size = new System.Drawing.Size(141, 19);
            this.lblanneeparution.TabIndex = 56;
            this.lblanneeparution.Text = "Annee de parution :";
            // 
            // txtbxtome
            // 
            this.txtbxtome.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxtome.CustomButton.Image = null;
            this.txtbxtome.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtbxtome.CustomButton.Name = "";
            this.txtbxtome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxtome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxtome.CustomButton.TabIndex = 1;
            this.txtbxtome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxtome.CustomButton.UseSelectable = true;
            this.txtbxtome.CustomButton.Visible = false;
            this.txtbxtome.Enabled = false;
            this.txtbxtome.Lines = new string[0];
            this.txtbxtome.Location = new System.Drawing.Point(631, 50);
            this.txtbxtome.MaxLength = 32767;
            this.txtbxtome.Name = "txtbxtome";
            this.txtbxtome.PasswordChar = '\0';
            this.txtbxtome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxtome.SelectedText = "";
            this.txtbxtome.SelectionLength = 0;
            this.txtbxtome.SelectionStart = 0;
            this.txtbxtome.ShortcutsEnabled = true;
            this.txtbxtome.Size = new System.Drawing.Size(62, 25);
            this.txtbxtome.TabIndex = 48;
            this.txtbxtome.UseCustomBackColor = true;
            this.txtbxtome.UseSelectable = true;
            this.txtbxtome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxtome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbbxannee
            // 
            this.cmbbxannee.BackColor = System.Drawing.Color.Silver;
            this.cmbbxannee.Enabled = false;
            this.cmbbxannee.FormattingEnabled = true;
            this.cmbbxannee.ItemHeight = 23;
            this.cmbbxannee.Location = new System.Drawing.Point(146, 84);
            this.cmbbxannee.Name = "cmbbxannee";
            this.cmbbxannee.Size = new System.Drawing.Size(121, 29);
            this.cmbbxannee.TabIndex = 49;
            this.cmbbxannee.UseCustomBackColor = true;
            this.cmbbxannee.UseSelectable = true;
            // 
            // txtbxediteur
            // 
            this.txtbxediteur.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxediteur.CustomButton.Image = null;
            this.txtbxediteur.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtbxediteur.CustomButton.Name = "";
            this.txtbxediteur.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxediteur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxediteur.CustomButton.TabIndex = 1;
            this.txtbxediteur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxediteur.CustomButton.UseSelectable = true;
            this.txtbxediteur.CustomButton.Visible = false;
            this.txtbxediteur.Enabled = false;
            this.txtbxediteur.Lines = new string[0];
            this.txtbxediteur.Location = new System.Drawing.Point(90, 169);
            this.txtbxediteur.MaxLength = 32767;
            this.txtbxediteur.Name = "txtbxediteur";
            this.txtbxediteur.PasswordChar = '\0';
            this.txtbxediteur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxediteur.SelectedText = "";
            this.txtbxediteur.SelectionLength = 0;
            this.txtbxediteur.SelectionStart = 0;
            this.txtbxediteur.ShortcutsEnabled = true;
            this.txtbxediteur.Size = new System.Drawing.Size(121, 25);
            this.txtbxediteur.TabIndex = 55;
            this.txtbxediteur.UseCustomBackColor = true;
            this.txtbxediteur.UseSelectable = true;
            this.txtbxediteur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxediteur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblnbrpage
            // 
            this.lblnbrpage.AutoSize = true;
            this.lblnbrpage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblnbrpage.Location = new System.Drawing.Point(23, 129);
            this.lblnbrpage.Name = "lblnbrpage";
            this.lblnbrpage.Size = new System.Drawing.Size(117, 19);
            this.lblnbrpage.TabIndex = 68;
            this.lblnbrpage.Text = "Nombre Pages :";
            // 
            // lblediteur
            // 
            this.lblediteur.AutoSize = true;
            this.lblediteur.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblediteur.Location = new System.Drawing.Point(13, 169);
            this.lblediteur.Name = "lblediteur";
            this.lblediteur.Size = new System.Drawing.Size(64, 19);
            this.lblediteur.TabIndex = 60;
            this.lblediteur.Text = "Editeur :";
            // 
            // txtbxpage
            // 
            this.txtbxpage.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxpage.CustomButton.Image = null;
            this.txtbxpage.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtbxpage.CustomButton.Name = "";
            this.txtbxpage.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxpage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxpage.CustomButton.TabIndex = 1;
            this.txtbxpage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxpage.CustomButton.UseSelectable = true;
            this.txtbxpage.CustomButton.Visible = false;
            this.txtbxpage.Enabled = false;
            this.txtbxpage.Lines = new string[0];
            this.txtbxpage.Location = new System.Drawing.Point(146, 129);
            this.txtbxpage.MaxLength = 32767;
            this.txtbxpage.Name = "txtbxpage";
            this.txtbxpage.PasswordChar = '\0';
            this.txtbxpage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxpage.SelectedText = "";
            this.txtbxpage.SelectionLength = 0;
            this.txtbxpage.SelectionStart = 0;
            this.txtbxpage.ShortcutsEnabled = true;
            this.txtbxpage.Size = new System.Drawing.Size(121, 25);
            this.txtbxpage.TabIndex = 52;
            this.txtbxpage.UseCustomBackColor = true;
            this.txtbxpage.UseSelectable = true;
            this.txtbxpage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxpage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbxserie
            // 
            this.txtbxserie.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxserie.CustomButton.Image = null;
            this.txtbxserie.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtbxserie.CustomButton.Name = "";
            this.txtbxserie.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxserie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxserie.CustomButton.TabIndex = 1;
            this.txtbxserie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxserie.CustomButton.UseSelectable = true;
            this.txtbxserie.CustomButton.Visible = false;
            this.txtbxserie.Enabled = false;
            this.txtbxserie.Lines = new string[0];
            this.txtbxserie.Location = new System.Drawing.Point(88, 208);
            this.txtbxserie.MaxLength = 32767;
            this.txtbxserie.Name = "txtbxserie";
            this.txtbxserie.PasswordChar = '\0';
            this.txtbxserie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxserie.SelectedText = "";
            this.txtbxserie.SelectionLength = 0;
            this.txtbxserie.SelectionStart = 0;
            this.txtbxserie.ShortcutsEnabled = true;
            this.txtbxserie.Size = new System.Drawing.Size(121, 25);
            this.txtbxserie.TabIndex = 57;
            this.txtbxserie.UseCustomBackColor = true;
            this.txtbxserie.UseSelectable = true;
            this.txtbxserie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxserie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblcouleur
            // 
            this.lblcouleur.AutoSize = true;
            this.lblcouleur.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblcouleur.Location = new System.Drawing.Point(284, 56);
            this.lblcouleur.Name = "lblcouleur";
            this.lblcouleur.Size = new System.Drawing.Size(69, 19);
            this.lblcouleur.TabIndex = 66;
            this.lblcouleur.Text = "Couleur :";
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblserie.Location = new System.Drawing.Point(15, 208);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(67, 19);
            this.lblserie.TabIndex = 64;
            this.lblserie.Text = "Serie     :";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblcode.Location = new System.Drawing.Point(6, 14);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(52, 19);
            this.lblcode.TabIndex = 30;
            this.lblcode.Text = "Code :";
            // 
            // txtbxcode
            // 
            this.txtbxcode.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxcode.CustomButton.Image = null;
            this.txtbxcode.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtbxcode.CustomButton.Name = "";
            this.txtbxcode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxcode.CustomButton.TabIndex = 1;
            this.txtbxcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxcode.CustomButton.UseSelectable = true;
            this.txtbxcode.CustomButton.Visible = false;
            this.txtbxcode.Enabled = false;
            this.txtbxcode.Lines = new string[0];
            this.txtbxcode.Location = new System.Drawing.Point(85, 14);
            this.txtbxcode.MaxLength = 32767;
            this.txtbxcode.Name = "txtbxcode";
            this.txtbxcode.PasswordChar = '\0';
            this.txtbxcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxcode.SelectedText = "";
            this.txtbxcode.SelectionLength = 0;
            this.txtbxcode.SelectionStart = 0;
            this.txtbxcode.ShortcutsEnabled = true;
            this.txtbxcode.Size = new System.Drawing.Size(77, 25);
            this.txtbxcode.TabIndex = 1;
            this.txtbxcode.UseCustomBackColor = true;
            this.txtbxcode.UseSelectable = true;
            this.txtbxcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbltitre.Location = new System.Drawing.Point(226, 14);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(72, 19);
            this.lbltitre.TabIndex = 8;
            this.lbltitre.Text = "Titre       :";
            // 
            // txtbxtitre
            // 
            this.txtbxtitre.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.txtbxtitre.CustomButton.Image = null;
            this.txtbxtitre.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.txtbxtitre.CustomButton.Name = "";
            this.txtbxtitre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbxtitre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxtitre.CustomButton.TabIndex = 1;
            this.txtbxtitre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxtitre.CustomButton.UseSelectable = true;
            this.txtbxtitre.CustomButton.Visible = false;
            this.txtbxtitre.Enabled = false;
            this.txtbxtitre.Lines = new string[0];
            this.txtbxtitre.Location = new System.Drawing.Point(303, 14);
            this.txtbxtitre.MaxLength = 32767;
            this.txtbxtitre.Name = "txtbxtitre";
            this.txtbxtitre.PasswordChar = '\0';
            this.txtbxtitre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxtitre.SelectedText = "";
            this.txtbxtitre.SelectionLength = 0;
            this.txtbxtitre.SelectionStart = 0;
            this.txtbxtitre.ShortcutsEnabled = true;
            this.txtbxtitre.Size = new System.Drawing.Size(390, 25);
            this.txtbxtitre.TabIndex = 2;
            this.txtbxtitre.UseCustomBackColor = true;
            this.txtbxtitre.UseSelectable = true;
            this.txtbxtitre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxtitre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtgrvLivre
            // 
            this.dtgrvLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvLivre.Location = new System.Drawing.Point(22, 399);
            this.dtgrvLivre.Name = "dtgrvLivre";
            this.dtgrvLivre.Size = new System.Drawing.Size(697, 196);
            this.dtgrvLivre.TabIndex = 102;
            // 
            // picHome
            // 
            this.picHome.Image = global::InterfaceMedia.Properties.Resources.maxresdefault;
            this.picHome.Location = new System.Drawing.Point(88, 16);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(75, 41);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 104;
            this.picHome.TabStop = false;
            // 
            // txtbxmotif
            // 
            this.txtbxmotif.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtbxmotif.CustomButton.Image = null;
            this.txtbxmotif.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtbxmotif.CustomButton.Name = "";
            this.txtbxmotif.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxmotif.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxmotif.CustomButton.TabIndex = 1;
            this.txtbxmotif.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxmotif.CustomButton.UseSelectable = true;
            this.txtbxmotif.CustomButton.Visible = false;
            this.txtbxmotif.Lines = new string[0];
            this.txtbxmotif.Location = new System.Drawing.Point(471, 131);
            this.txtbxmotif.MaxLength = 32767;
            this.txtbxmotif.Name = "txtbxmotif";
            this.txtbxmotif.PasswordChar = '\0';
            this.txtbxmotif.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxmotif.SelectedText = "";
            this.txtbxmotif.SelectionLength = 0;
            this.txtbxmotif.SelectionStart = 0;
            this.txtbxmotif.ShortcutsEnabled = true;
            this.txtbxmotif.Size = new System.Drawing.Size(222, 23);
            this.txtbxmotif.TabIndex = 99;
            this.txtbxmotif.UseCustomBackColor = true;
            this.txtbxmotif.UseSelectable = true;
            this.txtbxmotif.Visible = false;
            this.txtbxmotif.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxmotif.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblmotif
            // 
            this.lblmotif.AutoSize = true;
            this.lblmotif.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmotif.Location = new System.Drawing.Point(353, 135);
            this.lblmotif.Name = "lblmotif";
            this.lblmotif.Size = new System.Drawing.Size(112, 19);
            this.lblmotif.TabIndex = 100;
            this.lblmotif.Text = "Motif du retrait";
            this.lblmotif.Visible = false;
            // 
            // Frmlivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(972, 630);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dtgrvLivre);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmlivre";
            this.Text = "Livre";
            this.groupBox1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.grpboxexemp.ResumeLayout(false);
            this.grpboxexemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvLivre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btnAnnuler;
        private MetroFramework.Controls.MetroTile btnRechercher;
        private MetroFramework.Controls.MetroTile btnSupprimer;
        private MetroFramework.Controls.MetroTile btnModifier;
        private MetroFramework.Controls.MetroTile btnAjouter;
        private MetroFramework.Controls.MetroTile metrotileQuitter;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.RadioButton rdbtnta;
        private MetroFramework.Controls.MetroLabel lblexemp;
        private MetroFramework.Controls.MetroTextBox txtbxreferencerexemp;
        private MetroFramework.Controls.MetroLabel lblExemplaire;
        private MetroFramework.Controls.MetroLabel lblauteur;
        private MetroFramework.Controls.MetroTextBox txtbxcommentaire;
        private MetroFramework.Controls.MetroLabel lblcommentaire;
        private MetroFramework.Controls.MetroTextBox txtbxauteur;
        private MetroFramework.Controls.MetroLabel lblformat;
        private MetroFramework.Controls.MetroLabel lbletat;
        private System.Windows.Forms.RadioButton rdbtntb;
        private MetroFramework.Controls.MetroTextBox txtbxformat;
        private System.Windows.Forms.RadioButton rdbtnb;
        private System.Windows.Forms.RadioButton rdbtnA;
        private MetroFramework.Controls.MetroTextBox txtbxcouleur;
        private MetroFramework.Controls.MetroTextBox txtbxisbn;
        private MetroFramework.Controls.MetroLabel lbltome;
        private MetroFramework.Controls.MetroLabel lblisbn;
        private MetroFramework.Controls.MetroLabel lblanneeparution;
        private MetroFramework.Controls.MetroTextBox txtbxtome;
        private MetroFramework.Controls.MetroComboBox cmbbxannee;
        private MetroFramework.Controls.MetroTextBox txtbxediteur;
        private MetroFramework.Controls.MetroLabel lblnbrpage;
        private MetroFramework.Controls.MetroLabel lblediteur;
        private MetroFramework.Controls.MetroTextBox txtbxpage;
        private MetroFramework.Controls.MetroTextBox txtbxserie;
        private MetroFramework.Controls.MetroLabel lblcouleur;
        private MetroFramework.Controls.MetroLabel lblserie;
        private MetroFramework.Controls.MetroLabel lblcode;
        private MetroFramework.Controls.MetroTextBox txtbxcode;
        private MetroFramework.Controls.MetroLabel lbltitre;
        private MetroFramework.Controls.MetroTextBox txtbxtitre;
        private System.Windows.Forms.DataGridView dtgrvLivre;
        private MetroFramework.Controls.MetroComboBox cmbbxauteur;
        private MetroFramework.Controls.MetroComboBox cmbbxserie;
        private MetroFramework.Controls.MetroComboBox cmbbxediteur;
        private System.Windows.Forms.PictureBox picHome;
        private MetroFramework.Controls.MetroPanel grpboxexemp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox codelivreexmp;
        private MetroFramework.Controls.MetroTile btnexemp;
        private MetroFramework.Controls.MetroTextBox txtbxmotif;
        private MetroFramework.Controls.MetroLabel lblmotif;
    }
}