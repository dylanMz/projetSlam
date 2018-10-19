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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridEmprunteur = new MetroFramework.Controls.MetroGrid();
            this.DateTimeRenouvellement = new MetroFramework.Controls.MetroDateTime();
            this.lblrenouvellement = new MetroFramework.Controls.MetroLabel();
            this.DateTimeAdhesion = new MetroFramework.Controls.MetroDateTime();
            this.DateTimeNaissance = new MetroFramework.Controls.MetroDateTime();
            this.txtPrenom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.txtVille = new MetroFramework.Controls.MetroTextBox();
            this.txtCodePostal = new MetroFramework.Controls.MetroTextBox();
            this.txtAdresse = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.lblAdhesion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_codepostal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new MetroFramework.Controls.MetroTile();
            this.btnFamille = new MetroFramework.Controls.MetroTile();
            this.btnRechercher = new MetroFramework.Controls.MetroTile();
            this.btnSupprimer = new MetroFramework.Controls.MetroTile();
            this.btnModifier = new MetroFramework.Controls.MetroTile();
            this.btnAjouter = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metrotileQuitter = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.groupAjouterEmp = new System.Windows.Forms.GroupBox();
            this.ActiverAdh = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprunteur)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupAjouterEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEmprunteur
            // 
            this.GridEmprunteur.AllowUserToAddRows = false;
            this.GridEmprunteur.AllowUserToDeleteRows = false;
            this.GridEmprunteur.AllowUserToResizeRows = false;
            this.GridEmprunteur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridEmprunteur.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.GridEmprunteur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEmprunteur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridEmprunteur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmprunteur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridEmprunteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEmprunteur.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridEmprunteur.EnableHeadersVisualStyles = false;
            this.GridEmprunteur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridEmprunteur.GridColor = System.Drawing.Color.Gray;
            this.GridEmprunteur.Location = new System.Drawing.Point(23, 316);
            this.GridEmprunteur.Name = "GridEmprunteur";
            this.GridEmprunteur.ReadOnly = true;
            this.GridEmprunteur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmprunteur.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridEmprunteur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridEmprunteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmprunteur.Size = new System.Drawing.Size(929, 240);
            this.GridEmprunteur.TabIndex = 89;
            this.GridEmprunteur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // DateTimeRenouvellement
            // 
            this.DateTimeRenouvellement.CustomFormat = "";
            this.DateTimeRenouvellement.Location = new System.Drawing.Point(649, 124);
            this.DateTimeRenouvellement.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeRenouvellement.Name = "DateTimeRenouvellement";
            this.DateTimeRenouvellement.Size = new System.Drawing.Size(200, 29);
            this.DateTimeRenouvellement.TabIndex = 88;
            this.DateTimeRenouvellement.UseCustomBackColor = true;
            // 
            // lblrenouvellement
            // 
            this.lblrenouvellement.AutoSize = true;
            this.lblrenouvellement.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblrenouvellement.Location = new System.Drawing.Point(659, 93);
            this.lblrenouvellement.Name = "lblrenouvellement";
            this.lblrenouvellement.Size = new System.Drawing.Size(173, 19);
            this.lblrenouvellement.TabIndex = 87;
            this.lblrenouvellement.Text = "Renouvellement adhésion :";
            this.lblrenouvellement.UseCustomBackColor = true;
            // 
            // DateTimeAdhesion
            // 
            this.DateTimeAdhesion.Location = new System.Drawing.Point(649, 47);
            this.DateTimeAdhesion.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeAdhesion.Name = "DateTimeAdhesion";
            this.DateTimeAdhesion.Size = new System.Drawing.Size(200, 29);
            this.DateTimeAdhesion.TabIndex = 86;
            this.DateTimeAdhesion.UseCustomBackColor = true;
            // 
            // DateTimeNaissance
            // 
            this.DateTimeNaissance.CalendarTitleBackColor = System.Drawing.Color.Silver;
            this.DateTimeNaissance.CustomFormat = "JJ/MM/YYYY";
            this.DateTimeNaissance.Location = new System.Drawing.Point(106, 183);
            this.DateTimeNaissance.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeNaissance.Name = "DateTimeNaissance";
            this.DateTimeNaissance.Size = new System.Drawing.Size(200, 29);
            this.DateTimeNaissance.TabIndex = 85;
            this.DateTimeNaissance.UseCustomBackColor = true;
            // 
            // txtPrenom
            // 
            // 
            // 
            // 
            this.txtPrenom.CustomButton.Image = null;
            this.txtPrenom.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtPrenom.CustomButton.Name = "";
            this.txtPrenom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrenom.CustomButton.TabIndex = 1;
            this.txtPrenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrenom.CustomButton.UseSelectable = true;
            this.txtPrenom.CustomButton.Visible = false;
            this.txtPrenom.Lines = new string[0];
            this.txtPrenom.Location = new System.Drawing.Point(106, 93);
            this.txtPrenom.MaxLength = 32767;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.SelectionLength = 0;
            this.txtPrenom.SelectionStart = 0;
            this.txtPrenom.ShortcutsEnabled = true;
            this.txtPrenom.Size = new System.Drawing.Size(137, 23);
            this.txtPrenom.TabIndex = 84;
            this.txtPrenom.UseCustomBackColor = true;
            this.txtPrenom.UseSelectable = true;
            this.txtPrenom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrenom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(334, 47);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 83;
            this.metroLabel6.Text = "Adresse :";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(106, 139);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(170, 23);
            this.txtMail.TabIndex = 82;
            this.txtMail.UseCustomBackColor = true;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtVille.Location = new System.Drawing.Point(404, 143);
            this.txtVille.MaxLength = 32767;
            this.txtVille.Name = "txtVille";
            this.txtVille.PasswordChar = '\0';
            this.txtVille.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVille.SelectedText = "";
            this.txtVille.SelectionLength = 0;
            this.txtVille.SelectionStart = 0;
            this.txtVille.ShortcutsEnabled = true;
            this.txtVille.Size = new System.Drawing.Size(137, 23);
            this.txtVille.TabIndex = 81;
            this.txtVille.UseCustomBackColor = true;
            this.txtVille.UseSelectable = true;
            this.txtVille.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVille.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodePostal
            // 
            // 
            // 
            // 
            this.txtCodePostal.CustomButton.Image = null;
            this.txtCodePostal.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.txtCodePostal.CustomButton.Name = "";
            this.txtCodePostal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodePostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodePostal.CustomButton.TabIndex = 1;
            this.txtCodePostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodePostal.CustomButton.UseSelectable = true;
            this.txtCodePostal.CustomButton.Visible = false;
            this.txtCodePostal.Lines = new string[0];
            this.txtCodePostal.Location = new System.Drawing.Point(404, 93);
            this.txtCodePostal.MaxLength = 32767;
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.PasswordChar = '\0';
            this.txtCodePostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodePostal.SelectedText = "";
            this.txtCodePostal.SelectionLength = 0;
            this.txtCodePostal.SelectionStart = 0;
            this.txtCodePostal.ShortcutsEnabled = true;
            this.txtCodePostal.Size = new System.Drawing.Size(84, 23);
            this.txtCodePostal.TabIndex = 80;
            this.txtCodePostal.UseCustomBackColor = true;
            this.txtCodePostal.UseSelectable = true;
            this.txtCodePostal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodePostal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdresse
            // 
            // 
            // 
            // 
            this.txtAdresse.CustomButton.Image = null;
            this.txtAdresse.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtAdresse.CustomButton.Name = "";
            this.txtAdresse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdresse.CustomButton.TabIndex = 1;
            this.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdresse.CustomButton.UseSelectable = true;
            this.txtAdresse.CustomButton.Visible = false;
            this.txtAdresse.Lines = new string[0];
            this.txtAdresse.Location = new System.Drawing.Point(404, 47);
            this.txtAdresse.MaxLength = 32767;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.SelectionLength = 0;
            this.txtAdresse.SelectionStart = 0;
            this.txtAdresse.ShortcutsEnabled = true;
            this.txtAdresse.Size = new System.Drawing.Size(169, 23);
            this.txtAdresse.TabIndex = 79;
            this.txtAdresse.UseCustomBackColor = true;
            this.txtAdresse.UseSelectable = true;
            this.txtAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdresse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNom.Location = new System.Drawing.Point(106, 47);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(137, 23);
            this.txtNom.TabIndex = 78;
            this.txtNom.UseCustomBackColor = true;
            this.txtNom.UseSelectable = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdhesion
            // 
            this.lblAdhesion.AutoSize = true;
            this.lblAdhesion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAdhesion.Location = new System.Drawing.Point(707, 16);
            this.lblAdhesion.Name = "lblAdhesion";
            this.lblAdhesion.Size = new System.Drawing.Size(73, 19);
            this.lblAdhesion.TabIndex = 77;
            this.lblAdhesion.Text = "Adhésion :";
            this.lblAdhesion.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(-111, 199);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 76;
            this.metroLabel9.Text = "Naissance:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(-81, 159);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(42, 19);
            this.metroLabel8.TabIndex = 75;
            this.metroLabel8.Text = "Mail :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(357, 143);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 74;
            this.metroLabel7.Text = "Ville :";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel_codepostal
            // 
            this.metroLabel_codepostal.AutoSize = true;
            this.metroLabel_codepostal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_codepostal.Location = new System.Drawing.Point(310, 93);
            this.metroLabel_codepostal.Name = "metroLabel_codepostal";
            this.metroLabel_codepostal.Size = new System.Drawing.Size(88, 19);
            this.metroLabel_codepostal.TabIndex = 73;
            this.metroLabel_codepostal.Text = "Code Postal :";
            this.metroLabel_codepostal.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(-103, 105);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 72;
            this.metroLabel4.Text = "Prénom :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(-85, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnFamille);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1018, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 535);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.ActiveControl = null;
            this.btnAnnuler.BackColor = System.Drawing.Color.Tomato;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(12, 403);
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
            // btnFamille
            // 
            this.btnFamille.ActiveControl = null;
            this.btnFamille.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFamille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamille.Location = new System.Drawing.Point(12, 272);
            this.btnFamille.Name = "btnFamille";
            this.btnFamille.Size = new System.Drawing.Size(156, 48);
            this.btnFamille.TabIndex = 100;
            this.btnFamille.Text = "Chef de famille";
            this.btnFamille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFamille.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnFamille.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnFamille.UseCustomBackColor = true;
            this.btnFamille.UseSelectable = true;
            this.btnFamille.Click += new System.EventHandler(this.btnFamille_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.ActiveControl = null;
            this.btnRechercher.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.Location = new System.Drawing.Point(12, 209);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(156, 48);
            this.btnRechercher.TabIndex = 99;
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
            this.btnSupprimer.Location = new System.Drawing.Point(12, 148);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(156, 48);
            this.btnSupprimer.TabIndex = 98;
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
            this.btnModifier.Location = new System.Drawing.Point(12, 83);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metrotileQuitter);
            this.groupBox2.Location = new System.Drawing.Point(1, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // metrotileQuitter
            // 
            this.metrotileQuitter.ActiveControl = null;
            this.metrotileQuitter.BackColor = System.Drawing.Color.Tomato;
            this.metrotileQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metrotileQuitter.ForeColor = System.Drawing.Color.White;
            this.metrotileQuitter.Location = new System.Drawing.Point(6, 19);
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
            this.metrotileQuitter.Click += new System.EventHandler(this.metrotileQuitter_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(36, 93);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 92;
            this.metroLabel5.Text = "Prénom :";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(58, 139);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(42, 19);
            this.metroLabel11.TabIndex = 93;
            this.metroLabel11.Text = "Mail :";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(24, 183);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(76, 19);
            this.metroLabel12.TabIndex = 94;
            this.metroLabel12.Text = "Naissance :";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // groupAjouterEmp
            // 
            this.groupAjouterEmp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupAjouterEmp.Controls.Add(this.ActiverAdh);
            this.groupAjouterEmp.Controls.Add(this.metroLabel12);
            this.groupAjouterEmp.Controls.Add(this.metroLabel11);
            this.groupAjouterEmp.Controls.Add(this.metroLabel5);
            this.groupAjouterEmp.Controls.Add(this.metroLabel2);
            this.groupAjouterEmp.Controls.Add(this.DateTimeRenouvellement);
            this.groupAjouterEmp.Controls.Add(this.lblrenouvellement);
            this.groupAjouterEmp.Controls.Add(this.DateTimeAdhesion);
            this.groupAjouterEmp.Controls.Add(this.DateTimeNaissance);
            this.groupAjouterEmp.Controls.Add(this.txtPrenom);
            this.groupAjouterEmp.Controls.Add(this.metroLabel6);
            this.groupAjouterEmp.Controls.Add(this.txtMail);
            this.groupAjouterEmp.Controls.Add(this.txtVille);
            this.groupAjouterEmp.Controls.Add(this.txtCodePostal);
            this.groupAjouterEmp.Controls.Add(this.txtAdresse);
            this.groupAjouterEmp.Controls.Add(this.txtNom);
            this.groupAjouterEmp.Controls.Add(this.lblAdhesion);
            this.groupAjouterEmp.Controls.Add(this.metroLabel7);
            this.groupAjouterEmp.Controls.Add(this.metroLabel_codepostal);
            this.groupAjouterEmp.Enabled = false;
            this.groupAjouterEmp.Location = new System.Drawing.Point(23, 68);
            this.groupAjouterEmp.Name = "groupAjouterEmp";
            this.groupAjouterEmp.Size = new System.Drawing.Size(929, 224);
            this.groupAjouterEmp.TabIndex = 95;
            this.groupAjouterEmp.TabStop = false;
            // 
            // ActiverAdh
            // 
            this.ActiverAdh.AutoSize = true;
            this.ActiverAdh.Location = new System.Drawing.Point(621, 19);
            this.ActiverAdh.Name = "ActiverAdh";
            this.ActiverAdh.Size = new System.Drawing.Size(80, 17);
            this.ActiverAdh.TabIndex = 95;
            this.ActiverAdh.Text = "Off";
            this.ActiverAdh.UseSelectable = true;
            this.ActiverAdh.CheckedChanged += new System.EventHandler(this.ActiverAdh_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(54, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 91;
            this.metroLabel2.Text = "Nom :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // picHome
            // 
            this.picHome.Image = global::InterfaceMedia.Properties.Resources.maxresdefault;
            this.picHome.Location = new System.Drawing.Point(146, 21);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(75, 41);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 96;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(927, 293);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 97;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FrmEmprunteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 579);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.groupAjouterEmp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridEmprunteur);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.MaximizeBox = false;
            this.Name = "FrmEmprunteur";
            this.Resizable = false;
            this.Text = "Emprunteur";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprunteur)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupAjouterEmp.ResumeLayout(false);
            this.groupAjouterEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GridEmprunteur;
        private MetroFramework.Controls.MetroDateTime DateTimeRenouvellement;
        private MetroFramework.Controls.MetroLabel lblrenouvellement;
        private MetroFramework.Controls.MetroDateTime DateTimeAdhesion;
        private MetroFramework.Controls.MetroDateTime DateTimeNaissance;
        private MetroFramework.Controls.MetroTextBox txtPrenom;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroTextBox txtVille;
        private MetroFramework.Controls.MetroTextBox txtCodePostal;
        private MetroFramework.Controls.MetroTextBox txtAdresse;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroLabel lblAdhesion;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel_codepostal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTile metrotileQuitter;
        private System.Windows.Forms.GroupBox groupAjouterEmp;
        private MetroFramework.Controls.MetroTile btnAjouter;
        private MetroFramework.Controls.MetroTile btnFamille;
        private MetroFramework.Controls.MetroTile btnRechercher;
        private MetroFramework.Controls.MetroTile btnSupprimer;
        private MetroFramework.Controls.MetroTile btnModifier;
        private MetroFramework.Controls.MetroTile btnAnnuler;
        private System.Windows.Forms.PictureBox picHome;
        private MetroFramework.Controls.MetroToggle ActiverAdh;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}