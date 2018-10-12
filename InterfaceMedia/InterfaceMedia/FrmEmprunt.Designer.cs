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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblAcceuil = new MetroFramework.Controls.MetroLabel();
            this.gpbxMenu = new System.Windows.Forms.GroupBox();
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
            this.txtbxdateEmp = new MetroFramework.Controls.MetroTextBox();
            this.lblDateEmp = new MetroFramework.Controls.MetroLabel();
            this.txtbxDateRetourPrev = new MetroFramework.Controls.MetroTextBox();
            this.lblDateRetourPrev = new MetroFramework.Controls.MetroLabel();
            this.txtbxDateRetour = new MetroFramework.Controls.MetroTextBox();
            this.lblDateRetourRéel = new MetroFramework.Controls.MetroLabel();
            this.gpbxChoix = new System.Windows.Forms.GroupBox();
            this.cbxNotRendu = new MetroFramework.Controls.MetroCheckBox();
            this.cbxLivreEmp = new MetroFramework.Controls.MetroCheckBox();
            this.txtbxDate = new MetroFramework.Controls.MetroTextBox();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.gpbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprunt)).BeginInit();
            this.gpbxChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Aqua;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel2.Location = new System.Drawing.Point(123, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 50);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "|\r\n|";
            // 
            // lblAcceuil
            // 
            this.lblAcceuil.AutoSize = true;
            this.lblAcceuil.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAcceuil.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAcceuil.Location = new System.Drawing.Point(147, 27);
            this.lblAcceuil.Name = "lblAcceuil";
            this.lblAcceuil.Size = new System.Drawing.Size(67, 25);
            this.lblAcceuil.TabIndex = 6;
            this.lblAcceuil.Text = "Acceuil";
            // 
            // gpbxMenu
            // 
            this.gpbxMenu.BackColor = System.Drawing.Color.Transparent;
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
            // btnAnnuler
            // 
            this.btnAnnuler.Highlight = true;
            this.btnAnnuler.Location = new System.Drawing.Point(25, 462);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(169, 43);
            this.btnAnnuler.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseSelectable = true;
            // 
            // btnRechercheLivre
            // 
            this.btnRechercheLivre.Highlight = true;
            this.btnRechercheLivre.Location = new System.Drawing.Point(25, 395);
            this.btnRechercheLivre.Name = "btnRechercheLivre";
            this.btnRechercheLivre.Size = new System.Drawing.Size(169, 43);
            this.btnRechercheLivre.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRechercheLivre.TabIndex = 5;
            this.btnRechercheLivre.Text = "Rechercher livre ";
            this.btnRechercheLivre.UseSelectable = true;
            // 
            // btnRecherEmp
            // 
            this.btnRecherEmp.Highlight = true;
            this.btnRecherEmp.Location = new System.Drawing.Point(25, 326);
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
            this.btnSupprEmp.Location = new System.Drawing.Point(25, 249);
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
            this.btnAjoutRetour.Location = new System.Drawing.Point(25, 180);
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
            this.btnModifier.Location = new System.Drawing.Point(25, 108);
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
            this.btnAjoutEmp.Location = new System.Drawing.Point(25, 38);
            this.btnAjoutEmp.Name = "btnAjoutEmp";
            this.btnAjoutEmp.Size = new System.Drawing.Size(169, 43);
            this.btnAjoutEmp.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAjoutEmp.TabIndex = 0;
            this.btnAjoutEmp.Text = "Ajouter un emprunt";
            this.btnAjoutEmp.UseSelectable = true;
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
            this.txtbxNumEmp.CustomButton.Location = new System.Drawing.Point(91, 1);
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
            this.txtbxNumEmp.Size = new System.Drawing.Size(113, 23);
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
            this.txtbxRefEx.CustomButton.Location = new System.Drawing.Point(101, 1);
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
            this.txtbxRefEx.Size = new System.Drawing.Size(123, 23);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmprunt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridEmprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEmprunt.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridEmprunt.EnableHeadersVisualStyles = false;
            this.GridEmprunt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridEmprunt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridEmprunt.Location = new System.Drawing.Point(23, 373);
            this.GridEmprunt.Name = "GridEmprunt";
            this.GridEmprunt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmprunt.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridEmprunt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridEmprunt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmprunt.Size = new System.Drawing.Size(695, 150);
            this.GridEmprunt.TabIndex = 12;
            // 
            // txtbxdateEmp
            // 
            // 
            // 
            // 
            this.txtbxdateEmp.CustomButton.Image = null;
            this.txtbxdateEmp.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtbxdateEmp.CustomButton.Name = "";
            this.txtbxdateEmp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxdateEmp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxdateEmp.CustomButton.TabIndex = 1;
            this.txtbxdateEmp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxdateEmp.CustomButton.UseSelectable = true;
            this.txtbxdateEmp.CustomButton.Visible = false;
            this.txtbxdateEmp.Lines = new string[0];
            this.txtbxdateEmp.Location = new System.Drawing.Point(181, 185);
            this.txtbxdateEmp.MaxLength = 32767;
            this.txtbxdateEmp.Name = "txtbxdateEmp";
            this.txtbxdateEmp.PasswordChar = '\0';
            this.txtbxdateEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxdateEmp.SelectedText = "";
            this.txtbxdateEmp.SelectionLength = 0;
            this.txtbxdateEmp.SelectionStart = 0;
            this.txtbxdateEmp.ShortcutsEnabled = true;
            this.txtbxdateEmp.Size = new System.Drawing.Size(113, 23);
            this.txtbxdateEmp.TabIndex = 14;
            this.txtbxdateEmp.UseSelectable = true;
            this.txtbxdateEmp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxdateEmp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // txtbxDateRetourPrev
            // 
            // 
            // 
            // 
            this.txtbxDateRetourPrev.CustomButton.Image = null;
            this.txtbxDateRetourPrev.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtbxDateRetourPrev.CustomButton.Name = "";
            this.txtbxDateRetourPrev.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxDateRetourPrev.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxDateRetourPrev.CustomButton.TabIndex = 1;
            this.txtbxDateRetourPrev.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxDateRetourPrev.CustomButton.UseSelectable = true;
            this.txtbxDateRetourPrev.CustomButton.Visible = false;
            this.txtbxDateRetourPrev.Lines = new string[0];
            this.txtbxDateRetourPrev.Location = new System.Drawing.Point(506, 185);
            this.txtbxDateRetourPrev.MaxLength = 32767;
            this.txtbxDateRetourPrev.Name = "txtbxDateRetourPrev";
            this.txtbxDateRetourPrev.PasswordChar = '\0';
            this.txtbxDateRetourPrev.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxDateRetourPrev.SelectedText = "";
            this.txtbxDateRetourPrev.SelectionLength = 0;
            this.txtbxDateRetourPrev.SelectionStart = 0;
            this.txtbxDateRetourPrev.ShortcutsEnabled = true;
            this.txtbxDateRetourPrev.Size = new System.Drawing.Size(123, 23);
            this.txtbxDateRetourPrev.TabIndex = 16;
            this.txtbxDateRetourPrev.UseSelectable = true;
            this.txtbxDateRetourPrev.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxDateRetourPrev.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // txtbxDateRetour
            // 
            // 
            // 
            // 
            this.txtbxDateRetour.CustomButton.Image = null;
            this.txtbxDateRetour.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtbxDateRetour.CustomButton.Name = "";
            this.txtbxDateRetour.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxDateRetour.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxDateRetour.CustomButton.TabIndex = 1;
            this.txtbxDateRetour.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxDateRetour.CustomButton.UseSelectable = true;
            this.txtbxDateRetour.CustomButton.Visible = false;
            this.txtbxDateRetour.Lines = new string[0];
            this.txtbxDateRetour.Location = new System.Drawing.Point(181, 248);
            this.txtbxDateRetour.MaxLength = 32767;
            this.txtbxDateRetour.Name = "txtbxDateRetour";
            this.txtbxDateRetour.PasswordChar = '\0';
            this.txtbxDateRetour.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxDateRetour.SelectedText = "";
            this.txtbxDateRetour.SelectionLength = 0;
            this.txtbxDateRetour.SelectionStart = 0;
            this.txtbxDateRetour.ShortcutsEnabled = true;
            this.txtbxDateRetour.Size = new System.Drawing.Size(113, 23);
            this.txtbxDateRetour.TabIndex = 18;
            this.txtbxDateRetour.UseSelectable = true;
            this.txtbxDateRetour.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxDateRetour.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.gpbxChoix.Controls.Add(this.cbxNotRendu);
            this.gpbxChoix.Controls.Add(this.cbxLivreEmp);
            this.gpbxChoix.Controls.Add(this.txtbxDate);
            this.gpbxChoix.Controls.Add(this.lblDate);
            this.gpbxChoix.Location = new System.Drawing.Point(23, 233);
            this.gpbxChoix.Name = "gpbxChoix";
            this.gpbxChoix.Size = new System.Drawing.Size(695, 100);
            this.gpbxChoix.TabIndex = 19;
            this.gpbxChoix.TabStop = false;
            // 
            // cbxNotRendu
            // 
            this.cbxNotRendu.AutoSize = true;
            this.cbxNotRendu.Location = new System.Drawing.Point(339, 69);
            this.cbxNotRendu.Name = "cbxNotRendu";
            this.cbxNotRendu.Size = new System.Drawing.Size(276, 15);
            this.cbxNotRendu.TabIndex = 18;
            this.cbxNotRendu.Text = "Afficher les livres non rendus à une date donnée";
            this.cbxNotRendu.UseSelectable = true;
            // 
            // cbxLivreEmp
            // 
            this.cbxLivreEmp.AutoSize = true;
            this.cbxLivreEmp.Location = new System.Drawing.Point(336, 25);
            this.cbxLivreEmp.Name = "cbxLivreEmp";
            this.cbxLivreEmp.Size = new System.Drawing.Size(270, 15);
            this.cbxLivreEmp.TabIndex = 17;
            this.cbxLivreEmp.Text = "Afficher les livres empruntés à une date précise";
            this.cbxLivreEmp.UseSelectable = true;
            // 
            // txtbxDate
            // 
            // 
            // 
            // 
            this.txtbxDate.CustomButton.Image = null;
            this.txtbxDate.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtbxDate.CustomButton.Name = "";
            this.txtbxDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbxDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbxDate.CustomButton.TabIndex = 1;
            this.txtbxDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbxDate.CustomButton.UseSelectable = true;
            this.txtbxDate.CustomButton.Visible = false;
            this.txtbxDate.Lines = new string[0];
            this.txtbxDate.Location = new System.Drawing.Point(158, 19);
            this.txtbxDate.MaxLength = 32767;
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.PasswordChar = '\0';
            this.txtbxDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbxDate.SelectedText = "";
            this.txtbxDate.SelectionLength = 0;
            this.txtbxDate.SelectionStart = 0;
            this.txtbxDate.ShortcutsEnabled = true;
            this.txtbxDate.Size = new System.Drawing.Size(113, 23);
            this.txtbxDate.TabIndex = 16;
            this.txtbxDate.UseSelectable = true;
            this.txtbxDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbxDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // FrmEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 546);
            this.Controls.Add(this.gpbxChoix);
            this.Controls.Add(this.txtbxDateRetour);
            this.Controls.Add(this.lblDateRetourRéel);
            this.Controls.Add(this.txtbxDateRetourPrev);
            this.Controls.Add(this.lblDateRetourPrev);
            this.Controls.Add(this.txtbxdateEmp);
            this.Controls.Add(this.lblDateEmp);
            this.Controls.Add(this.GridEmprunt);
            this.Controls.Add(this.txtbxRefEx);
            this.Controls.Add(this.lblRefEx);
            this.Controls.Add(this.txtbxNumEmp);
            this.Controls.Add(this.lblNumEmp);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblAcceuil);
            this.Controls.Add(this.gpbxMenu);
            this.Name = "FrmEmprunt";
            this.Text = "Emprunt";
            this.gpbxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmprunt)).EndInit();
            this.gpbxChoix.ResumeLayout(false);
            this.gpbxChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblAcceuil;
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
        private MetroFramework.Controls.MetroTextBox txtbxdateEmp;
        private MetroFramework.Controls.MetroLabel lblDateEmp;
        private MetroFramework.Controls.MetroTextBox txtbxDateRetourPrev;
        private MetroFramework.Controls.MetroLabel lblDateRetourPrev;
        private MetroFramework.Controls.MetroTextBox txtbxDateRetour;
        private MetroFramework.Controls.MetroLabel lblDateRetourRéel;
        private System.Windows.Forms.GroupBox gpbxChoix;
        private MetroFramework.Controls.MetroCheckBox cbxNotRendu;
        private MetroFramework.Controls.MetroCheckBox cbxLivreEmp;
        private MetroFramework.Controls.MetroTextBox txtbxDate;
        private MetroFramework.Controls.MetroLabel lblDate;
    }
}