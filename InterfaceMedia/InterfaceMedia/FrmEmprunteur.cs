using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMedia;
using MetroFramework.Forms;

namespace InterfaceMedia
{
    public partial class FrmEmprunteur : MetroForm
    {
        private Metier_Emprunteur unEmprunteur;
        private ConnexionBase uneconnexion;
        public FrmEmprunteur()
        {
            InitializeComponent();
            uneconnexion = new ConnexionBase();
            unEmprunteur = new Metier_Emprunteur(uneconnexion);
            unEmprunteur.Recup_TableEmprunteur();
            RempGridEmprunteur(unEmprunteur.lesEmprunteurs);

        }

        private void metrotileQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RempGridEmprunteur(List<Emprunteur> lesemprunteur)
        {
            GridEmprunteur.DataSource = lesemprunteur;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNom.Text = GridEmprunteur.CurrentRow.Cells["nom"].Value.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Ajouter")
            {
                groupAjouterEmp.Enabled = true;
                btnAjouter.BackColor = Color.Green;
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnFamille.Enabled = false;
                btnRechercher.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtMail.BackColor = Color.White;
                txtCodePostal.BackColor = Color.White;
                txtAdresse.BackColor = Color.White;
                txtVille.BackColor = Color.White;
                DateTimeNaissance.CalendarTitleBackColor = Color.Silver;
            }
            else if (btnAjouter.Text == "Valider")
            {
                groupAjouterEmp.Enabled = false;
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnFamille.Enabled = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnRechercher.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtMail.BackColor = Color.Silver;
                txtCodePostal.BackColor = Color.Silver;
                txtAdresse.BackColor = Color.Silver;
                txtVille.BackColor = Color.Silver;

            }
        }
    }
}
