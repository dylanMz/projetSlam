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
            this.txtPrenom = new MetroFramework.Controls.MetroTextBox();
            this.unId = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.txtPseudo = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioPersonnel = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioSecteur = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioAdmin = new MetroFramework.Controls.MetroRadioButton();
            this.gridUtilisateur = new MetroFramework.Controls.MetroGrid();
            this.btnAnnuler = new MetroFramework.Controls.MetroTile();
            this.btnSupprimer = new MetroFramework.Controls.MetroTile();
            this.btnModifier = new MetroFramework.Controls.MetroTile();
            this.btnAjouter = new MetroFramework.Controls.MetroTile();
            this.btnQuitter = new MetroFramework.Controls.MetroTile();
            this.gpbxMenu = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxRang = new System.Windows.Forms.GroupBox();
            this.metroRadioStock = new MetroFramework.Controls.MetroRadioButton();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lblRang = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtilisateur)).BeginInit();
            this.gpbxMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxRang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(266, 109);
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
            this.metroLabel5.Location = new System.Drawing.Point(76, 71);
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
            this.metroLabel4.Location = new System.Drawing.Point(59, 109);
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
            this.metroLabel2.Location = new System.Drawing.Point(304, 70);
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
            this.metroLabel3.Location = new System.Drawing.Point(95, 31);
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
            this.groupBox1.Controls.Add(this.unId);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtPseudo);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Location = new System.Drawing.Point(14, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 150);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
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
            this.txtPrenom.Location = new System.Drawing.Point(129, 109);
            this.txtPrenom.MaxLength = 32767;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.SelectionLength = 0;
            this.txtPrenom.SelectionStart = 0;
            this.txtPrenom.ShortcutsEnabled = true;
            this.txtPrenom.Size = new System.Drawing.Size(100, 22);
            this.txtPrenom.TabIndex = 41;
            this.txtPrenom.UseCustomBackColor = true;
            this.txtPrenom.UseSelectable = true;
            this.txtPrenom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrenom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // unId
            // 
            this.unId.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.unId.CustomButton.Image = null;
            this.unId.CustomButton.Location = new System.Drawing.Point(37, 2);
            this.unId.CustomButton.Name = "";
            this.unId.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.unId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unId.CustomButton.TabIndex = 1;
            this.unId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unId.CustomButton.UseSelectable = true;
            this.unId.CustomButton.Visible = false;
            this.unId.Enabled = false;
            this.unId.Lines = new string[0];
            this.unId.Location = new System.Drawing.Point(129, 31);
            this.unId.MaxLength = 32767;
            this.unId.Name = "unId";
            this.unId.PasswordChar = '\0';
            this.unId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unId.SelectedText = "";
            this.unId.SelectionLength = 0;
            this.unId.SelectionStart = 0;
            this.unId.ShortcutsEnabled = true;
            this.unId.Size = new System.Drawing.Size(57, 22);
            this.unId.TabIndex = 45;
            this.unId.UseCustomBackColor = true;
            this.unId.UseSelectable = true;
            this.unId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtPassword.Location = new System.Drawing.Point(367, 109);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(139, 22);
            this.txtPassword.TabIndex = 43;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNom.Location = new System.Drawing.Point(129, 69);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 40;
            this.txtNom.UseCustomBackColor = true;
            this.txtNom.UseSelectable = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtPseudo.Location = new System.Drawing.Point(367, 70);
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
            // metroRadioPersonnel
            // 
            this.metroRadioPersonnel.AutoSize = true;
            this.metroRadioPersonnel.Enabled = false;
            this.metroRadioPersonnel.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioPersonnel.Location = new System.Drawing.Point(565, 9);
            this.metroRadioPersonnel.Name = "metroRadioPersonnel";
            this.metroRadioPersonnel.Size = new System.Drawing.Size(84, 19);
            this.metroRadioPersonnel.TabIndex = 46;
            this.metroRadioPersonnel.Text = "Personnel";
            this.metroRadioPersonnel.UseCustomBackColor = true;
            this.metroRadioPersonnel.UseSelectable = true;
            // 
            // metroRadioSecteur
            // 
            this.metroRadioSecteur.AutoSize = true;
            this.metroRadioSecteur.Enabled = false;
            this.metroRadioSecteur.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioSecteur.Location = new System.Drawing.Point(196, 9);
            this.metroRadioSecteur.Name = "metroRadioSecteur";
            this.metroRadioSecteur.Size = new System.Drawing.Size(149, 19);
            this.metroRadioSecteur.TabIndex = 47;
            this.metroRadioSecteur.Text = "Responsable secteur";
            this.metroRadioSecteur.UseCustomBackColor = true;
            this.metroRadioSecteur.UseSelectable = true;
            // 
            // metroRadioAdmin
            // 
            this.metroRadioAdmin.AutoSize = true;
            this.metroRadioAdmin.Enabled = false;
            this.metroRadioAdmin.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioAdmin.Location = new System.Drawing.Point(48, 9);
            this.metroRadioAdmin.Name = "metroRadioAdmin";
            this.metroRadioAdmin.Size = new System.Drawing.Size(116, 19);
            this.metroRadioAdmin.TabIndex = 48;
            this.metroRadioAdmin.Text = "Administrateur";
            this.metroRadioAdmin.UseCustomBackColor = true;
            this.metroRadioAdmin.UseSelectable = true;
            // 
            // gridUtilisateur
            // 
            this.gridUtilisateur.AllowUserToAddRows = false;
            this.gridUtilisateur.AllowUserToDeleteRows = false;
            this.gridUtilisateur.AllowUserToResizeRows = false;
            this.gridUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.gridUtilisateur.Location = new System.Drawing.Point(14, 272);
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
            this.gridUtilisateur.Size = new System.Drawing.Size(677, 258);
            this.gridUtilisateur.TabIndex = 49;
            this.gridUtilisateur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUtilisateur_CellClick);
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
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ActiveControl = null;
            this.btnSupprimer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Enabled = false;
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
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.ActiveControl = null;
            this.btnModifier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Enabled = false;
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
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            this.gpbxMenu.Controls.Add(this.btnSupprimer);
            this.gpbxMenu.Controls.Add(this.btnModifier);
            this.gpbxMenu.Controls.Add(this.btnAjouter);
            this.gpbxMenu.Controls.Add(this.groupBox2);
            this.gpbxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbxMenu.Location = new System.Drawing.Point(709, 30);
            this.gpbxMenu.Name = "gpbxMenu";
            this.gpbxMenu.Size = new System.Drawing.Size(203, 500);
            this.gpbxMenu.TabIndex = 50;
            this.gpbxMenu.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitter);
            this.groupBox2.Location = new System.Drawing.Point(0, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 109);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBoxRang
            // 
            this.groupBoxRang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxRang.Controls.Add(this.metroRadioStock);
            this.groupBoxRang.Controls.Add(this.metroRadioAdmin);
            this.groupBoxRang.Controls.Add(this.metroRadioSecteur);
            this.groupBoxRang.Controls.Add(this.metroRadioPersonnel);
            this.groupBoxRang.Location = new System.Drawing.Point(14, 229);
            this.groupBoxRang.Name = "groupBoxRang";
            this.groupBoxRang.Size = new System.Drawing.Size(677, 37);
            this.groupBoxRang.TabIndex = 51;
            this.groupBoxRang.TabStop = false;
            this.groupBoxRang.Text = "Rang";
            // 
            // metroRadioStock
            // 
            this.metroRadioStock.AutoSize = true;
            this.metroRadioStock.Enabled = false;
            this.metroRadioStock.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioStock.Location = new System.Drawing.Point(389, 9);
            this.metroRadioStock.Name = "metroRadioStock";
            this.metroRadioStock.Size = new System.Drawing.Size(137, 19);
            this.metroRadioStock.TabIndex = 49;
            this.metroRadioStock.Text = "Responsable stock";
            this.metroRadioStock.UseCustomBackColor = true;
            this.metroRadioStock.UseSelectable = true;
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
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(253, 30);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(53, 19);
            this.lblRang.TabIndex = 53;
            this.lblRang.Text = "lblRang";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 546);
            this.Controls.Add(this.lblRang);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.groupBoxRang);
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
            this.groupBoxRang.ResumeLayout(false);
            this.groupBoxRang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton metroRadioPersonnel;
        private MetroFramework.Controls.MetroRadioButton metroRadioSecteur;
        private MetroFramework.Controls.MetroRadioButton metroRadioAdmin;
        private MetroFramework.Controls.MetroGrid gridUtilisateur;
        private MetroFramework.Controls.MetroTile btnAnnuler;
        private MetroFramework.Controls.MetroTile btnSupprimer;
        private MetroFramework.Controls.MetroTile btnModifier;
        private MetroFramework.Controls.MetroTile btnAjouter;
        private MetroFramework.Controls.MetroTile btnQuitter;
        private System.Windows.Forms.GroupBox gpbxMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxRang;
        private System.Windows.Forms.PictureBox picHome;
        private MetroFramework.Controls.MetroTextBox txtPrenom;
        private MetroFramework.Controls.MetroTextBox unId;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroTextBox txtPseudo;
        private MetroFramework.Controls.MetroLabel lblRang;
        private MetroFramework.Controls.MetroRadioButton metroRadioStock;
    }
}