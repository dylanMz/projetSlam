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
                groupAjouterEmp.Visible = true;
                btnAjouter.BackColor = Color.Green;
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = false;
            }else if (btnAjouter.Text == "Valider")
            {
                groupAjouterEmp.Visible = false;
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnRechercher.Enabled = true;

            }
        }
    }
}
