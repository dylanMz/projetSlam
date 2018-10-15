namespace InterfaceMedia
{
    partial class FrmEditeur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new MetroFramework.Controls.MetroButton();
            this.btnAjouter = new MetroFramework.Controls.MetroButton();
            this.btnSupprimer = new MetroFramework.Controls.MetroButton();
            this.btnRechercher = new MetroFramework.Controls.MetroButton();
            this.btnModifier = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
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
            this.txtFax = new MetroFramework.Controls.MetroTextBox();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btnQuitter = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Location = new System.Drawing.Point(732, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 525);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Highlight = true;
            this.btnAnnuler.Location = new System.Drawing.Point(25, 288);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(169, 43);
            this.btnAnnuler.Style = MetroFramework.MetroColorStyle.Red;
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseSelectable = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Highlight = true;
            this.btnAjouter.Location = new System.Drawing.Point(25, 29);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(169, 43);
            this.btnAjouter.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseSelectable = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Highlight = true;
            this.btnSupprimer.Location = new System.Drawing.Point(25, 159);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(169, 43);
            this.btnSupprimer.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseSelectable = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Highlight = true;
            this.btnRechercher.Location = new System.Drawing.Point(25, 223);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(169, 43);
            this.btnRechercher.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseSelectable = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Highlight = true;
            this.btnModifier.Location = new System.Drawing.Point(25, 95);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(169, 43);
            this.btnModifier.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 260);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(683, 274);
            this.metroGrid1.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(25, 147);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Nom :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(262, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Adresse :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(5, 205);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Création :";
            // 
            // metroLabel_codepostal
            // 
            this.metroLabel_codepostal.AutoSize = true;
            this.metroLabel_codepostal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_codepostal.Location = new System.Drawing.Point(240, 94);
            this.metroLabel_codepostal.Name = "metroLabel_codepostal";
            this.metroLabel_codepostal.Size = new System.Drawing.Size(88, 19);
            this.metroLabel_codepostal.TabIndex = 12;
            this.metroLabel_codepostal.Text = "Code Postal :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(287, 147);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Ville :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(479, 204);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(78, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Téléphone :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(521, 94);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(36, 19);
            this.metroLabel9.TabIndex = 15;
            this.metroLabel9.Text = "Fax :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(515, 147);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(42, 19);
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Mail :";
            // 
            // txtNom
            // 
            // 
            // 
            // 
            this.txtNom.CustomButton.Image = null;
            this.txtNom.CustomButton.Location = new System.Drawing.Point(26, 1);
            this.txtNom.CustomButton.Name = "";
            this.txtNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNom.CustomButton.TabIndex = 1;
            this.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNom.CustomButton.UseSelectable = true;
            this.txtNom.CustomButton.Visible = false;
            this.txtNom.Lines = new string[0];
            this.txtNom.Location = new System.Drawing.Point(87, 93);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(48, 23);
            this.txtNom.TabIndex = 17;
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
            this.txtAdresse.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtAdresse.CustomButton.Name = "";
            this.txtAdresse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdresse.CustomButton.TabIndex = 1;
            this.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdresse.CustomButton.UseSelectable = true;
            this.txtAdresse.CustomButton.Visible = false;
            this.txtAdresse.Lines = new string[0];
            this.txtAdresse.Location = new System.Drawing.Point(87, 147);
            this.txtAdresse.MaxLength = 32767;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.SelectionLength = 0;
            this.txtAdresse.SelectionStart = 0;
            this.txtAdresse.ShortcutsEnabled = true;
            this.txtAdresse.Size = new System.Drawing.Size(145, 23);
            this.txtAdresse.TabIndex = 18;
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
            this.txtCodePostal.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtCodePostal.CustomButton.Name = "";
            this.txtCodePostal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodePostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodePostal.CustomButton.TabIndex = 1;
            this.txtCodePostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodePostal.CustomButton.UseSelectable = true;
            this.txtCodePostal.CustomButton.Visible = false;
            this.txtCodePostal.Lines = new string[0];
            this.txtCodePostal.Location = new System.Drawing.Point(334, 93);
            this.txtCodePostal.MaxLength = 32767;
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.PasswordChar = '\0';
            this.txtCodePostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodePostal.SelectedText = "";
            this.txtCodePostal.SelectionLength = 0;
            this.txtCodePostal.SelectionStart = 0;
            this.txtCodePostal.ShortcutsEnabled = true;
            this.txtCodePostal.Size = new System.Drawing.Size(117, 23);
            this.txtCodePostal.TabIndex = 20;
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
            this.txtVille.Location = new System.Drawing.Point(334, 147);
            this.txtVille.MaxLength = 32767;
            this.txtVille.Name = "txtVille";
            this.txtVille.PasswordChar = '\0';
            this.txtVille.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVille.SelectedText = "";
            this.txtVille.SelectionLength = 0;
            this.txtVille.SelectionStart = 0;
            this.txtVille.ShortcutsEnabled = true;
            this.txtVille.Size = new System.Drawing.Size(137, 23);
            this.txtVille.TabIndex = 21;
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
            this.txtTelephone.Location = new System.Drawing.Point(334, 201);
            this.txtTelephone.MaxLength = 32767;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.SelectionLength = 0;
            this.txtTelephone.SelectionStart = 0;
            this.txtTelephone.ShortcutsEnabled = true;
            this.txtTelephone.Size = new System.Drawing.Size(137, 23);
            this.txtTelephone.TabIndex = 22;
            this.txtTelephone.UseSelectable = true;
            this.txtTelephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFax
            // 
            // 
            // 
            // 
            this.txtFax.CustomButton.Image = null;
            this.txtFax.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtFax.CustomButton.Name = "";
            this.txtFax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFax.CustomButton.TabIndex = 1;
            this.txtFax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFax.CustomButton.UseSelectable = true;
            this.txtFax.CustomButton.Visible = false;
            this.txtFax.Lines = new string[0];
            this.txtFax.Location = new System.Drawing.Point(569, 93);
            this.txtFax.MaxLength = 32767;
            this.txtFax.Name = "txtFax";
            this.txtFax.PasswordChar = '\0';
            this.txtFax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFax.SelectedText = "";
            this.txtFax.SelectionLength = 0;
            this.txtFax.SelectionStart = 0;
            this.txtFax.ShortcutsEnabled = true;
            this.txtFax.Size = new System.Drawing.Size(137, 23);
            this.txtFax.TabIndex = 23;
            this.txtFax.UseSelectable = true;
            this.txtFax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(569, 147);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(137, 23);
            this.txtMail.TabIndex = 24;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBox1.Location = new System.Drawing.Point(569, 204);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(137, 23);
            this.metroTextBox1.TabIndex = 25;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(25, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Code :";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(87, 198);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(145, 29);
            this.metroDateTime1.TabIndex = 27;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Highlight = true;
            this.btnQuitter.Location = new System.Drawing.Point(25, 469);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(169, 43);
            this.btnQuitter.Style = MetroFramework.MetroColorStyle.Red;
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseSelectable = true;
            // 
            // FrmEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 546);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtFax);
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
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditeur";
            this.Text = "Editeur";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSupprimer;
        private MetroFramework.Controls.MetroButton btnRechercher;
        private MetroFramework.Controls.MetroButton btnModifier;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnAjouter;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
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
        private MetroFramework.Controls.MetroTextBox txtFax;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroButton btnAnnuler;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroButton btnQuitter;
    }
}