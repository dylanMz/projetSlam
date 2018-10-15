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
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnChercher = new MetroFramework.Controls.MetroButton();
            this.btnSauvegarder = new MetroFramework.Controls.MetroButton();
            this.btnAnnuler = new MetroFramework.Controls.MetroButton();
            this.btnSupprimer = new MetroFramework.Controls.MetroButton();
            this.btnRechercher = new MetroFramework.Controls.MetroButton();
            this.btnModifier = new MetroFramework.Controls.MetroButton();
            this.btnAjouter = new MetroFramework.Controls.MetroButton();
            this.lblSeparation = new MetroFramework.Controls.MetroLabel();
            this.pnlAuteur = new MetroFramework.Controls.MetroPanel();
            this.grpBxAuteur = new System.Windows.Forms.GroupBox();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.grpBxQuitter = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new MetroFramework.Controls.MetroButton();
            this.grpBoxMenu.SuspendLayout();
            this.pnlAuteur.SuspendLayout();
            this.grpBxAuteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuteur)).BeginInit();
            this.grpBxQuitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxMenu.Controls.Add(this.btnChercher);
            this.grpBoxMenu.Controls.Add(this.btnSauvegarder);
            this.grpBoxMenu.Controls.Add(this.btnAnnuler);
            this.grpBoxMenu.Controls.Add(this.btnRechercher);
            this.grpBoxMenu.Controls.Add(this.btnModifier);
            this.grpBoxMenu.Controls.Add(this.btnAjouter);
            this.grpBoxMenu.Controls.Add(this.btnSupprimer);
            this.grpBoxMenu.Location = new System.Drawing.Point(737, 63);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Size = new System.Drawing.Size(216, 519);
            this.grpBoxMenu.TabIndex = 1;
            this.grpBoxMenu.TabStop = false;
            // 
            // btnChercher
            // 
            this.btnChercher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChercher.Highlight = true;
            this.btnChercher.Location = new System.Drawing.Point(24, 393);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(169, 43);
            this.btnChercher.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnChercher.TabIndex = 13;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseSelectable = true;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSauvegarder.Enabled = false;
            this.btnSauvegarder.Highlight = true;
            this.btnSauvegarder.Location = new System.Drawing.Point(24, 255);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(169, 43);
            this.btnSauvegarder.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSauvegarder.TabIndex = 11;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseSelectable = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnnuler.Enabled = false;
            this.btnAnnuler.Highlight = true;
            this.btnAnnuler.Location = new System.Drawing.Point(24, 458);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(169, 43);
            this.btnAnnuler.Style = MetroFramework.MetroColorStyle.Red;
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseSelectable = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Highlight = true;
            this.btnSupprimer.Location = new System.Drawing.Point(24, 183);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(169, 43);
            this.btnSupprimer.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseSelectable = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRechercher.Highlight = true;
            this.btnRechercher.Location = new System.Drawing.Point(24, 323);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(169, 43);
            this.btnRechercher.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseSelectable = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModifier.Highlight = true;
            this.btnModifier.Location = new System.Drawing.Point(24, 105);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(169, 43);
            this.btnModifier.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseSelectable = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAjouter.Highlight = true;
            this.btnAjouter.Location = new System.Drawing.Point(24, 28);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(169, 43);
            this.btnAjouter.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseSelectable = true;
            // 
            // lblSeparation
            // 
            this.lblSeparation.AutoSize = true;
            this.lblSeparation.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSeparation.Location = new System.Drawing.Point(110, 14);
            this.lblSeparation.Name = "lblSeparation";
            this.lblSeparation.Size = new System.Drawing.Size(14, 38);
            this.lblSeparation.TabIndex = 2;
            this.lblSeparation.Text = "|\r\n|";
            // 
            // pnlAuteur
            // 
            this.pnlAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuteur.Controls.Add(this.grpBxAuteur);
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
            // grpBxAuteur
            // 
            this.grpBxAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxAuteur.Controls.Add(this.metroComboBox1);
            this.grpBxAuteur.Controls.Add(this.metroRadioButton2);
            this.grpBxAuteur.Controls.Add(this.metroRadioButton1);
            this.grpBxAuteur.Controls.Add(this.metroLabel3);
            this.grpBxAuteur.Controls.Add(this.metroLabel2);
            this.grpBxAuteur.Controls.Add(this.metroTextBox1);
            this.grpBxAuteur.Controls.Add(this.metroDateTime1);
            this.grpBxAuteur.Controls.Add(this.metroLabel1);
            this.grpBxAuteur.Controls.Add(this.dtDateNaiss);
            this.grpBxAuteur.Controls.Add(this.metroLabel5);
            this.grpBxAuteur.Controls.Add(this.lblCode);
            this.grpBxAuteur.Controls.Add(this.txtBio);
            this.grpBxAuteur.Controls.Add(this.lblNom);
            this.grpBxAuteur.Controls.Add(this.lblDateNais);
            this.grpBxAuteur.Controls.Add(this.txtPrenom);
            this.grpBxAuteur.Controls.Add(this.lblPrenom);
            this.grpBxAuteur.Controls.Add(this.txtCode);
            this.grpBxAuteur.Controls.Add(this.txtNom);
            this.grpBxAuteur.Location = new System.Drawing.Point(3, 3);
            this.grpBxAuteur.Name = "grpBxAuteur";
            this.grpBxAuteur.Size = new System.Drawing.Size(718, 379);
            this.grpBxAuteur.TabIndex = 13;
            this.grpBxAuteur.TabStop = false;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(585, 163);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(62, 15);
            this.metroRadioButton2.TabIndex = 8;
            this.metroRadioButton2.Text = "Décédé";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(472, 163);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(56, 15);
            this.metroRadioButton1.TabIndex = 7;
            this.metroRadioButton1.Text = "Vivant";
            this.metroRadioButton1.UseSelectable = true;
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(141, 102);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(169, 23);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Enabled = false;
            this.metroDateTime1.Location = new System.Drawing.Point(472, 194);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 15;
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
            this.dtDateNaiss.Enabled = false;
            this.dtDateNaiss.Location = new System.Drawing.Point(141, 149);
            this.dtDateNaiss.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateNaiss.Name = "dtDateNaiss";
            this.dtDateNaiss.Size = new System.Drawing.Size(200, 29);
            this.dtDateNaiss.TabIndex = 6;
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
            this.txtBio.TabIndex = 11;
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
            this.txtPrenom.TabIndex = 4;
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
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNom
            // 
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
            this.dgvAuteur.TabIndex = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(141, 194);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(169, 29);
            this.metroComboBox1.TabIndex = 22;
            this.metroComboBox1.UseSelectable = true;
            // 
            // grpBxQuitter
            // 
            this.grpBxQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxQuitter.Controls.Add(this.btnQuitter);
            this.grpBxQuitter.Location = new System.Drawing.Point(737, 588);
            this.grpBxQuitter.Name = "grpBxQuitter";
            this.grpBxQuitter.Size = new System.Drawing.Size(216, 83);
            this.grpBxQuitter.TabIndex = 7;
            this.grpBxQuitter.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Enabled = false;
            this.btnQuitter.Highlight = true;
            this.btnQuitter.Location = new System.Drawing.Point(24, 20);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(169, 43);
            this.btnQuitter.Style = MetroFramework.MetroColorStyle.Red;
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseSelectable = true;
            // 
            // FrmAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 694);
            this.Controls.Add(this.grpBxQuitter);
            this.Controls.Add(this.pnlAuteur);
            this.Controls.Add(this.lblSeparation);
            this.Controls.Add(this.grpBoxMenu);
            this.Name = "FrmAuteur";
            this.Text = "Auteur";
            this.grpBoxMenu.ResumeLayout(false);
            this.pnlAuteur.ResumeLayout(false);
            this.grpBxAuteur.ResumeLayout(false);
            this.grpBxAuteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuteur)).EndInit();
            this.grpBxQuitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMenu;
        private MetroFramework.Controls.MetroButton btnAnnuler;
        private MetroFramework.Controls.MetroButton btnSupprimer;
        private MetroFramework.Controls.MetroButton btnRechercher;
        private MetroFramework.Controls.MetroButton btnModifier;
        private MetroFramework.Controls.MetroButton btnAjouter;
        private MetroFramework.Controls.MetroLabel lblSeparation;
        private MetroFramework.Controls.MetroButton btnSauvegarder;
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
        private System.Windows.Forms.GroupBox grpBxAuteur;
        private MetroFramework.Controls.MetroDateTime dtDateNaiss;
        private MetroFramework.Controls.MetroButton btnChercher;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.GroupBox grpBxQuitter;
        private MetroFramework.Controls.MetroButton btnQuitter;
    }
}