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
            this.lblNumEmp = new MetroFramework.Controls.MetroLabel();
            this.txtbxNumEmp = new MetroFramework.Controls.MetroTextBox();
            this.txtbxRefEx = new MetroFramework.Controls.MetroTextBox();
            this.lblRefEx = new MetroFramework.Controls.MetroLabel();
            this.GridEmprunt = new MetroFramework.Controls.MetroGrid();
            this.lblDateEmp = new MetroFramework.Controls.MetroLabel();
            this.lblDateRetourPrev = new MetroFramework.Controls.MetroLabel();
            this.lblDateRetourRéel = new MetroFramework.Controls.MetroLabel();
            this.gpbxChoix = new System.Windows.Forms.GroupBox();
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.rbLivreEmprunter = new MetroFramework.Controls.MetroRadioButton();
            this.rbLivreNonRendu = new MetroFramework.Controls.MetroRadioButton();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.GroupSaisie = new System.Windows.Forms.GroupBox();
            this.dtRetour = new MetroFramework.Controls.MetroDateTime();
            this.dtRetourPrevu = new MetroFramework.Controls.MetroDateTime();
            this.dtEmprunt = new MetroFramework.Controls.MetroDateTime();
            this.GroupBouton = new System.Windows.Forms.GroupBox();
            this.btnSearchEmp = new MetroFramework.Controls.MetroTile();
            this.btnLivre = new MetroFramework.Controls.MetroTile();
            this.btnAnnuler = new MetroFramework.Controls.MetroTile();
            this.btnAjRetour = new MetroFramework.Controls.MetroTile();
            this.btnSupprimer = new MetroFramework.Controls.MetroTile();
            this.btnModifier = new MetroFramework.Controls.MetroTile();
            this.btnAjouter = new MetroFramework.Controls.MetroTile();
            this.groupQuitter = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new MetroFramework.Controls.MetroTile();
            this.picHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprunt)).BeginInit();
            this.gpbxChoix.SuspendLayout();
            this.GroupSaisie.SuspendLayout();
            this.GroupBouton.SuspendLayout();
            this.groupQuitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumEmp
            // 
            this.lblNumEmp.AutoSize = true;
            this.lblNumEmp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumEmp.Enabled = false;
            this.lblNumEmp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNumEmp.Location = new System.Drawing.Point(18, 25);
            this.lblNumEmp.Name = "lblNumEmp";
            this.lblNumEmp.Size = new System.Drawing.Size(143, 19);
            this.lblNumEmp.TabIndex = 8;
            this.lblNumEmp.Text = "Numéro emprunteur :";
            this.lblNumEmp.UseCustomBackColor = true;
            // 
            // txtbxNumEmp
            // 
            this.txtbxNumEmp.BackColor = System.Drawing.Color.Silver;
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
            this.txtbxNumEmp.Enabled = false;
            this.txtbxNumEmp.Lines = new string[0];
            this.txtbxNumEmp.Location = new System.Drawing.Point(176, 25);
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
            this.txtbxNumEmp.UseCustomBackColor = true;
            this.txtbxNumEmp.UseSelectable = true;
            this.txtbxNumEmp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxNumEmp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbxRefEx
            // 
            this.txtbxRefEx.BackColor = System.Drawing.Color.Silver;
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
            this.txtbxRefEx.Enabled = false;
            this.txtbxRefEx.Lines = new string[0];
            this.txtbxRefEx.Location = new System.Drawing.Point(501, 25);
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
            this.txtbxRefEx.UseCustomBackColor = true;
            this.txtbxRefEx.UseSelectable = true;
            this.txtbxRefEx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxRefEx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblRefEx
            // 
            this.lblRefEx.AutoSize = true;
            this.lblRefEx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRefEx.Enabled = false;
            this.lblRefEx.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRefEx.Location = new System.Drawing.Point(343, 25);
            this.lblRefEx.Name = "lblRefEx";
            this.lblRefEx.Size = new System.Drawing.Size(144, 19);
            this.lblRefEx.TabIndex = 10;
            this.lblRefEx.Text = "Référence exemplaire :";
            this.lblRefEx.UseCustomBackColor = true;
            // 
            // GridEmprunt
            // 
            this.GridEmprunt.AllowUserToAddRows = false;
            this.GridEmprunt.AllowUserToDeleteRows = false;
            this.GridEmprunt.AllowUserToResizeRows = false;
            this.GridEmprunt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEmprunt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.GridEmprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.GridEmprunt.Location = new System.Drawing.Point(12, 374);
            this.GridEmprunt.Name = "GridEmprunt";
            this.GridEmprunt.ReadOnly = true;
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
            this.GridEmprunt.Size = new System.Drawing.Size(714, 180);
            this.GridEmprunt.TabIndex = 12;
            this.GridEmprunt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmprunt_CellClick);
            // 
            // lblDateEmp
            // 
            this.lblDateEmp.AutoSize = true;
            this.lblDateEmp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateEmp.Enabled = false;
            this.lblDateEmp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDateEmp.Location = new System.Drawing.Point(18, 93);
            this.lblDateEmp.Name = "lblDateEmp";
            this.lblDateEmp.Size = new System.Drawing.Size(102, 19);
            this.lblDateEmp.TabIndex = 13;
            this.lblDateEmp.Text = "Date emprunt :";
            this.lblDateEmp.UseCustomBackColor = true;
            // 
            // lblDateRetourPrev
            // 
            this.lblDateRetourPrev.AutoSize = true;
            this.lblDateRetourPrev.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateRetourPrev.Enabled = false;
            this.lblDateRetourPrev.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDateRetourPrev.Location = new System.Drawing.Point(343, 93);
            this.lblDateRetourPrev.Name = "lblDateRetourPrev";
            this.lblDateRetourPrev.Size = new System.Drawing.Size(145, 19);
            this.lblDateRetourPrev.TabIndex = 15;
            this.lblDateRetourPrev.Text = "Date de retour prévu :";
            this.lblDateRetourPrev.UseCustomBackColor = true;
            // 
            // lblDateRetourRéel
            // 
            this.lblDateRetourRéel.AutoSize = true;
            this.lblDateRetourRéel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateRetourRéel.Enabled = false;
            this.lblDateRetourRéel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDateRetourRéel.Location = new System.Drawing.Point(18, 156);
            this.lblDateRetourRéel.Name = "lblDateRetourRéel";
            this.lblDateRetourRéel.Size = new System.Drawing.Size(113, 19);
            this.lblDateRetourRéel.TabIndex = 17;
            this.lblDateRetourRéel.Text = "Date retour réel :";
            this.lblDateRetourRéel.UseCustomBackColor = true;
            // 
            // gpbxChoix
            // 
            this.gpbxChoix.Controls.Add(this.dtDate);
            this.gpbxChoix.Controls.Add(this.rbLivreEmprunter);
            this.gpbxChoix.Controls.Add(this.rbLivreNonRendu);
            this.gpbxChoix.Controls.Add(this.lblDate);
            this.gpbxChoix.Location = new System.Drawing.Point(18, 87);
            this.gpbxChoix.Name = "gpbxChoix";
            this.gpbxChoix.Size = new System.Drawing.Size(676, 164);
            this.gpbxChoix.TabIndex = 19;
            this.gpbxChoix.TabStop = false;
            this.gpbxChoix.Visible = false;
            // 
            // dtDate
            // 
            this.dtDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtDate.Enabled = false;
            this.dtDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(158, 16);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(137, 25);
            this.dtDate.TabIndex = 21;
            this.dtDate.UseCustomBackColor = true;
            // 
            // rbLivreEmprunter
            // 
            this.rbLivreEmprunter.AutoSize = true;
            this.rbLivreEmprunter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbLivreEmprunter.Location = new System.Drawing.Point(336, 29);
            this.rbLivreEmprunter.Name = "rbLivreEmprunter";
            this.rbLivreEmprunter.Size = new System.Drawing.Size(270, 15);
            this.rbLivreEmprunter.TabIndex = 20;
            this.rbLivreEmprunter.Text = "Afficher les livres empruntés à une date précise";
            this.rbLivreEmprunter.UseCustomBackColor = true;
            this.rbLivreEmprunter.UseSelectable = true;
            // 
            // rbLivreNonRendu
            // 
            this.rbLivreNonRendu.AutoSize = true;
            this.rbLivreNonRendu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbLivreNonRendu.Location = new System.Drawing.Point(336, 62);
            this.rbLivreNonRendu.Name = "rbLivreNonRendu";
            this.rbLivreNonRendu.Size = new System.Drawing.Size(276, 15);
            this.rbLivreNonRendu.TabIndex = 19;
            this.rbLivreNonRendu.Text = "Afficher les livres non rendus à une date donnée";
            this.rbLivreNonRendu.UseCustomBackColor = true;
            this.rbLivreNonRendu.UseSelectable = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(11, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date :";
            this.lblDate.UseCustomBackColor = true;
            // 
            // GroupSaisie
            // 
            this.GroupSaisie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupSaisie.Controls.Add(this.gpbxChoix);
            this.GroupSaisie.Controls.Add(this.dtRetour);
            this.GroupSaisie.Controls.Add(this.lblNumEmp);
            this.GroupSaisie.Controls.Add(this.dtRetourPrevu);
            this.GroupSaisie.Controls.Add(this.txtbxNumEmp);
            this.GroupSaisie.Controls.Add(this.dtEmprunt);
            this.GroupSaisie.Controls.Add(this.lblRefEx);
            this.GroupSaisie.Controls.Add(this.txtbxRefEx);
            this.GroupSaisie.Controls.Add(this.lblDateRetourRéel);
            this.GroupSaisie.Controls.Add(this.lblDateEmp);
            this.GroupSaisie.Controls.Add(this.lblDateRetourPrev);
            this.GroupSaisie.Location = new System.Drawing.Point(12, 83);
            this.GroupSaisie.Name = "GroupSaisie";
            this.GroupSaisie.Size = new System.Drawing.Size(714, 274);
            this.GroupSaisie.TabIndex = 30;
            this.GroupSaisie.TabStop = false;
            // 
            // dtRetour
            // 
            this.dtRetour.Enabled = false;
            this.dtRetour.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtRetour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRetour.Location = new System.Drawing.Point(176, 150);
            this.dtRetour.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtRetour.Name = "dtRetour";
            this.dtRetour.Size = new System.Drawing.Size(137, 25);
            this.dtRetour.TabIndex = 25;
            // 
            // dtRetourPrevu
            // 
            this.dtRetourPrevu.Enabled = false;
            this.dtRetourPrevu.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtRetourPrevu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRetourPrevu.Location = new System.Drawing.Point(501, 87);
            this.dtRetourPrevu.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtRetourPrevu.Name = "dtRetourPrevu";
            this.dtRetourPrevu.Size = new System.Drawing.Size(137, 25);
            this.dtRetourPrevu.TabIndex = 23;
            // 
            // dtEmprunt
            // 
            this.dtEmprunt.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtEmprunt.Enabled = false;
            this.dtEmprunt.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtEmprunt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmprunt.Location = new System.Drawing.Point(176, 87);
            this.dtEmprunt.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtEmprunt.Name = "dtEmprunt";
            this.dtEmprunt.Size = new System.Drawing.Size(137, 25);
            this.dtEmprunt.TabIndex = 24;
            this.dtEmprunt.UseCustomBackColor = true;
            this.dtEmprunt.UseCustomForeColor = true;
            this.dtEmprunt.UseStyleColors = true;
            // 
            // GroupBouton
            // 
            this.GroupBouton.BackColor = System.Drawing.Color.Transparent;
            this.GroupBouton.Controls.Add(this.btnSearchEmp);
            this.GroupBouton.Controls.Add(this.btnLivre);
            this.GroupBouton.Controls.Add(this.btnAnnuler);
            this.GroupBouton.Controls.Add(this.btnAjRetour);
            this.GroupBouton.Controls.Add(this.btnSupprimer);
            this.GroupBouton.Controls.Add(this.btnModifier);
            this.GroupBouton.Controls.Add(this.btnAjouter);
            this.GroupBouton.Controls.Add(this.groupQuitter);
            this.GroupBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBouton.Location = new System.Drawing.Point(732, 32);
            this.GroupBouton.Name = "GroupBouton";
            this.GroupBouton.Size = new System.Drawing.Size(223, 522);
            this.GroupBouton.TabIndex = 29;
            this.GroupBouton.TabStop = false;
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.ActiveControl = null;
            this.btnSearchEmp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchEmp.Location = new System.Drawing.Point(18, 267);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(190, 49);
            this.btnSearchEmp.TabIndex = 30;
            this.btnSearchEmp.Text = "Rechercher emprunt";
            this.btnSearchEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchEmp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSearchEmp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSearchEmp.UseCustomBackColor = true;
            this.btnSearchEmp.UseSelectable = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // btnLivre
            // 
            this.btnLivre.ActiveControl = null;
            this.btnLivre.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLivre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivre.Location = new System.Drawing.Point(18, 322);
            this.btnLivre.Name = "btnLivre";
            this.btnLivre.Size = new System.Drawing.Size(190, 49);
            this.btnLivre.TabIndex = 31;
            this.btnLivre.Text = "Rechercher livre";
            this.btnLivre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLivre.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnLivre.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnLivre.UseCustomBackColor = true;
            this.btnLivre.UseSelectable = true;
            this.btnLivre.Click += new System.EventHandler(this.btnLivre_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.ActiveControl = null;
            this.btnAnnuler.BackColor = System.Drawing.Color.Tomato;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(18, 397);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(190, 49);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnnuler.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAnnuler.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAnnuler.UseCustomBackColor = true;
            this.btnAnnuler.UseSelectable = true;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjRetour
            // 
            this.btnAjRetour.ActiveControl = null;
            this.btnAjRetour.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjRetour.Location = new System.Drawing.Point(18, 212);
            this.btnAjRetour.Name = "btnAjRetour";
            this.btnAjRetour.Size = new System.Drawing.Size(190, 49);
            this.btnAjRetour.TabIndex = 13;
            this.btnAjRetour.Text = "Ajouter un retour";
            this.btnAjRetour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjRetour.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAjRetour.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAjRetour.UseCustomBackColor = true;
            this.btnAjRetour.UseSelectable = true;
            this.btnAjRetour.Click += new System.EventHandler(this.btnAjRetour_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ActiveControl = null;
            this.btnSupprimer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Location = new System.Drawing.Point(18, 125);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(190, 49);
            this.btnSupprimer.TabIndex = 12;
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
            this.btnModifier.Location = new System.Drawing.Point(18, 70);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(190, 49);
            this.btnModifier.TabIndex = 11;
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
            this.btnAjouter.Location = new System.Drawing.Point(18, 15);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(190, 49);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjouter.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAjouter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAjouter.UseCustomBackColor = true;
            this.btnAjouter.UseSelectable = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // groupQuitter
            // 
            this.groupQuitter.Controls.Add(this.btnQuitter);
            this.groupQuitter.Location = new System.Drawing.Point(0, 452);
            this.groupQuitter.Name = "groupQuitter";
            this.groupQuitter.Size = new System.Drawing.Size(223, 71);
            this.groupQuitter.TabIndex = 8;
            this.groupQuitter.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.ActiveControl = null;
            this.btnQuitter.BackColor = System.Drawing.Color.Tomato;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Location = new System.Drawing.Point(18, 15);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(190, 44);
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
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = global::InterfaceMedia.Properties.Resources.maxresdefault;
            this.picHome.Location = new System.Drawing.Point(119, 16);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(75, 41);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 31;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // FrmEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 566);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.GroupSaisie);
            this.Controls.Add(this.GroupBouton);
            this.Controls.Add(this.GridEmprunt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmEmprunt";
            this.Text = "Emprunt";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprunt)).EndInit();
            this.gpbxChoix.ResumeLayout(false);
            this.gpbxChoix.PerformLayout();
            this.GroupSaisie.ResumeLayout(false);
            this.GroupSaisie.PerformLayout();
            this.GroupBouton.ResumeLayout(false);
            this.groupQuitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private MetroFramework.Controls.MetroDateTime dtDate;
        private MetroFramework.Controls.MetroRadioButton rbLivreEmprunter;
        private MetroFramework.Controls.MetroRadioButton rbLivreNonRendu;
        private MetroFramework.Controls.MetroDateTime dtRetourPrevu;
        private MetroFramework.Controls.MetroDateTime dtEmprunt;
        private System.Windows.Forms.GroupBox GroupBouton;
        private MetroFramework.Controls.MetroTile btnSearchEmp;
        private MetroFramework.Controls.MetroTile btnLivre;
        private MetroFramework.Controls.MetroTile btnAnnuler;
        private MetroFramework.Controls.MetroTile btnAjRetour;
        private MetroFramework.Controls.MetroTile btnSupprimer;
        private MetroFramework.Controls.MetroTile btnModifier;
        private MetroFramework.Controls.MetroTile btnAjouter;
        private System.Windows.Forms.GroupBox groupQuitter;
        private MetroFramework.Controls.MetroTile btnQuitter;
        private System.Windows.Forms.GroupBox GroupSaisie;
        private MetroFramework.Controls.MetroDateTime dtRetour;
        private System.Windows.Forms.PictureBox picHome;
    }
}