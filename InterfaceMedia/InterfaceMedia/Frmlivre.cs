using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace InterfaceMedia
{
    public partial class Frmlivre : MetroForm
    {
        public Frmlivre()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (btnAjouter.Text.Equals("Ajouter"))
            {
                // modification de couleur du bouton ajouter + le passe en "valider" et afficher annuler
                btnAjouter.BackColor = Color.Green;
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;

                //desactiver les autres boutons 
                btnRechercher.Enabled = false;
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
                if (btnexemp.Text.Equals("Livre"))
                {

                    // textbox activer pour l'insertion

                    txtbxtitre.Enabled = true;
                    txtbxisbn.Enabled = true;
                    txtbxcouleur.Enabled = true;
                    txtbxtome.Enabled = true;
                    cmbbxannee.Enabled = true;
                    txtbxformat.Enabled = true;
                    txtbxpage.Enabled = true;
                    txtbxcommentaire.Enabled = true;
                    txtbxediteur.Enabled = true;
                    txtbxserie.Enabled = true;
                    txtbxauteur.Enabled = true;
                    cmbbxauteur.Enabled = true;
                    cmbbxediteur.Enabled = true;
                    cmbbxserie.Enabled = true;

                    // modification des couleur 

                    txtbxtitre.BackColor = Color.White;
                    txtbxisbn.BackColor = Color.White;
                    txtbxcouleur.BackColor = Color.White;
                    txtbxtome.BackColor = Color.White;
                    cmbbxannee.BackColor = Color.White;
                    txtbxformat.BackColor = Color.White;
                    txtbxpage.BackColor = Color.White;
                    txtbxcommentaire.BackColor = Color.White;
                    txtbxediteur.BackColor = Color.White;
                    txtbxserie.BackColor = Color.White;
                    txtbxauteur.BackColor = Color.White;
                    cmbbxauteur.BackColor = Color.White;
                    cmbbxediteur.BackColor = Color.White;
                    cmbbxserie.BackColor = Color.White;




                }
                if (btnexemp.Text.Equals("exemplaire"))
                {


                    txtbxreferencerexemp.Enabled = true;
                    codelivreexmp.Enabled = true;
                    rdbtnA.Enabled = true;
                    rdbtnb.Enabled = true;
                    rdbtnta.Enabled = true;
                    rdbtntb.Enabled = true;

                    // modification des couleur 

                    txtbxreferencerexemp.BackColor = Color.White;
                    codelivreexmp.BackColor = Color.White;
                }

            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                // repasse le bouton ajouter en "ajouter" + modification couleur + desactive le bouton annuler
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //reactivation des autres boutons 
                btnRechercher.Enabled = true;
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;

                // textbox desactiver pour l'insertion
                txtbxtitre.Enabled = false;
                txtbxisbn.Enabled = false;
                txtbxcouleur.Enabled = false;
                txtbxtome.Enabled = false;
                cmbbxannee.Enabled = false;
                txtbxformat.Enabled = false;
                txtbxpage.Enabled = false;
                txtbxcommentaire.Enabled = false;
                txtbxediteur.Enabled = false;
                txtbxserie.Enabled = false;
                txtbxauteur.Enabled = false;
                txtbxreferencerexemp.Enabled = false;
                rdbtnA.Enabled = false;
                rdbtnb.Enabled = false;
                rdbtnta.Enabled = false;
                rdbtntb.Enabled = false;
                codelivreexmp.Enabled = false;
                cmbbxauteur.Enabled = false;
                cmbbxediteur.Enabled = false;
                cmbbxserie.Enabled = false;

                // modification des couleur 
                txtbxcode.BackColor = Color.Silver;
                txtbxtitre.BackColor = Color.Silver;
                txtbxisbn.BackColor = Color.Silver;
                txtbxcouleur.BackColor = Color.Silver;
                txtbxtome.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;
                txtbxformat.BackColor = Color.Silver;
                txtbxpage.BackColor = Color.Silver;
                txtbxcommentaire.BackColor = Color.Silver;
                txtbxediteur.BackColor = Color.Silver;
                txtbxserie.BackColor = Color.Silver;
                txtbxauteur.BackColor = Color.Silver;
                txtbxreferencerexemp.BackColor = Color.Silver;
                codelivreexmp.BackColor = Color.Silver;
                cmbbxauteur.BackColor = Color.Silver;
                cmbbxediteur.BackColor = Color.Silver;
                cmbbxserie.BackColor = Color.Silver;


            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // remise par defaut
            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnRechercher.Enabled = true;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnSupprimer.Text = "Supprimer";
            btnRechercher.Text = "Rechercher";

            // enleve le bouton annuler
            btnAnnuler.Visible = false;

            // remet la couleur de bleu
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnSupprimer.BackColor = Color.SteelBlue;
            btnRechercher.BackColor = Color.SteelBlue;

            // textbox activer pour l'insertion
            txtbxcode.Enabled = false;
            txtbxtitre.Enabled = false;
            txtbxisbn.Enabled = false;
            txtbxcouleur.Enabled = false;
            txtbxtome.Enabled = false;
            cmbbxannee.Enabled = false;
            txtbxformat.Enabled = false;
            txtbxpage.Enabled = false;
            txtbxcommentaire.Enabled = false;
            txtbxediteur.Enabled = false;
            txtbxserie.Enabled = false;
            txtbxauteur.Enabled = false;
            txtbxreferencerexemp.Enabled = false;
            rdbtnA.Enabled = false;
            rdbtnb.Enabled = false;
            rdbtnta.Enabled = false;
            rdbtntb.Enabled = false;
            cmbbxauteur.Enabled = false;
            cmbbxediteur.Enabled = false;
            cmbbxserie.Enabled = false;
            codelivreexmp.Enabled = false;
            txtbxmotif.Visible = false;
            lblmotif.Visible = false;
            lblcommentaire.Visible = true;
            txtbxcommentaire.Visible = true;
            // modification des couleur 
            txtbxcode.BackColor = Color.Silver;
            txtbxtitre.BackColor = Color.Silver;
            txtbxisbn.BackColor = Color.Silver;
            txtbxcouleur.BackColor = Color.Silver;
            txtbxtome.BackColor = Color.Silver;
            cmbbxannee.BackColor = Color.Silver;
            txtbxformat.BackColor = Color.Silver;
            txtbxpage.BackColor = Color.Silver;
            txtbxcommentaire.BackColor = Color.Silver;
            txtbxediteur.BackColor = Color.Silver;
            txtbxserie.BackColor = Color.Silver;
            txtbxauteur.BackColor = Color.Silver;
            txtbxreferencerexemp.BackColor = Color.Silver;
            cmbbxauteur.BackColor = Color.Silver;
            cmbbxediteur.BackColor = Color.Silver;
            cmbbxserie.BackColor = Color.Silver;
            codelivreexmp.BackColor = Color.Silver;


        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (btnRechercher.Text.Equals("Rechercher"))
            {
                btnRechercher.BackColor = Color.Green;
                btnRechercher.Text = "Valider";
                btnAnnuler.Visible = true;


                //desactive les autres boutons
              
                    btnSupprimer.Enabled = false;
                    btnModifier.Enabled = false;
                    btnAjouter.Enabled = false;
                if (btnexemp.Text.Equals("Livre"))
                {

                    txtbxtitre.Enabled = true;
                    cmbbxannee.Enabled = true;

                    txtbxtitre.BackColor = Color.White;
                    cmbbxannee.BackColor = Color.White;
                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {
                    codelivreexmp.Enabled = true;

                    codelivreexmp.BackColor = Color.White;
                }
            }
            else if (btnRechercher.Text.Equals("Valider"))
            {

                btnRechercher.BackColor = Color.SteelBlue;
                btnRechercher.Text = "Rechercher";
                btnAnnuler.Visible = false;

                //active les autres boutons

                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
                btnAjouter.Enabled = true;

                // desactive les boutons    
                txtbxtitre.Enabled = false;
                cmbbxannee.Enabled = false;

                // change la couleur 
                txtbxtitre.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;

            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text.Equals("Supprimer"))
            {
                btnSupprimer.BackColor = Color.Green;
                btnSupprimer.Text = "Valider";
                btnAnnuler.Visible = true;

                btnRechercher.Enabled = false;
                btnModifier.Enabled = false;
                btnAjouter.Enabled = false;

                if (btnexemp.Text.Equals("Livre"))
                {
                    // textbox activer pour l'insertion

                   txtbxcode.Enabled = true;
                   
                    txtbxmotif.Visible = true;
                    lblmotif.Visible = true;
                    lblcommentaire.Visible = false;
                    txtbxcommentaire.Visible = false;

                    // modification des couleur 

                    txtbxcode.BackColor = Color.White;


                    


                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {
                    // textbox activer pour l'insertion

                  

                    txtbxreferencerexemp.Enabled = true;
                    txtbxmotif.Visible = true;
                    lblmotif.Visible = true;
                    lblcommentaire.Visible = false;
                    txtbxcommentaire.Visible = false;

                    // modification des couleur 

                   


                    txtbxreferencerexemp.BackColor = Color.White;
                }
            }
            else if (btnSupprimer.Text.Equals("Valider"))
            {

                btnSupprimer.BackColor = Color.SteelBlue;
                btnSupprimer.Text = "Supprimer";
                btnAnnuler.Visible = false;

                //active les autres boutons

                btnRechercher.Enabled = true;
                btnModifier.Enabled = true;
                btnAjouter.Enabled = true;

                // desactive les boutons    
                txtbxcode.Enabled = false;
                txtbxreferencerexemp.Enabled = false;
                txtbxmotif.Visible = false;
                lblmotif.Visible = false;
                lblcommentaire.Visible = true;
                txtbxcommentaire.Visible = true;
                // change la couleur 
                txtbxcode.BackColor = Color.Silver;
               
                txtbxreferencerexemp.BackColor = Color.Silver;

            }
            }

        
        private void btnModifier_Click(object sender, EventArgs e)
        {

            if (btnModifier.Text.Equals("Modifier"))
            {

                // modification de couleur du bouton ajouter + le passe en "valider" et afficher annuler
                btnModifier.BackColor = Color.Green;
                btnModifier.Text = "Valider";
                btnAnnuler.Visible = true;

                //desactiver les autres boutons 
                btnRechercher.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjouter.Enabled = false;
                if (btnexemp.Text.Equals("Livre"))
                {
                    // textbox activer pour l'insertion

                    txtbxtitre.Enabled = true;
                    txtbxisbn.Enabled = true;
                    txtbxcouleur.Enabled = true;
                    txtbxtome.Enabled = true;
                    cmbbxannee.Enabled = true;
                    txtbxformat.Enabled = true;
                    txtbxpage.Enabled = true;
                    txtbxcommentaire.Enabled = true;
                    txtbxediteur.Enabled = true;
                    txtbxserie.Enabled = true;
                    txtbxauteur.Enabled = true;

                    cmbbxauteur.Enabled = true;
                    cmbbxediteur.Enabled = true;
                    cmbbxserie.Enabled = true;


                    // modification des couleur 

                    txtbxtitre.BackColor = Color.White;
                    txtbxisbn.BackColor = Color.White;
                    txtbxcouleur.BackColor = Color.White;
                    txtbxtome.BackColor = Color.White;
                    cmbbxannee.BackColor = Color.White;
                    txtbxformat.BackColor = Color.White;
                    txtbxpage.BackColor = Color.White;
                    txtbxcommentaire.BackColor = Color.White;
                    txtbxediteur.BackColor = Color.White;
                    txtbxserie.BackColor = Color.White;
                    txtbxauteur.BackColor = Color.White;

                    cmbbxauteur.BackColor = Color.White;
                    cmbbxediteur.BackColor = Color.White;
                    cmbbxserie.BackColor = Color.White;

                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {
                    // textbox activer pour l'insertion
                    codelivreexmp.Enabled = true;
                    txtbxreferencerexemp.Enabled = true;
                    rdbtnA.Enabled = true;
                    rdbtnb.Enabled = true;
                    rdbtnta.Enabled = true;
                    rdbtntb.Enabled = true;



                    // modification des couleur 


                    txtbxreferencerexemp.BackColor = Color.White;

                    codelivreexmp.BackColor = Color.White;
                }
            }
            else if (btnModifier.Text.Equals("Valider"))
            {
                // repasse le bouton ajouter en "ajouter" + modification couleur + desactive le bouton annuler
                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //reactivation des autres boutons 
                btnRechercher.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjouter.Enabled = true;

                // textbox desactiver pour l'insertion
                txtbxtitre.Enabled = false;
                txtbxisbn.Enabled = false;
                txtbxcouleur.Enabled = false;
                txtbxtome.Enabled = false;
                cmbbxannee.Enabled = false;
                txtbxformat.Enabled = false;
                txtbxpage.Enabled = false;
                txtbxcommentaire.Enabled = false;
                txtbxediteur.Enabled = false;
                txtbxserie.Enabled = false;
                txtbxauteur.Enabled = false;
                txtbxreferencerexemp.Enabled = false;
                rdbtnA.Enabled = false;
                rdbtnb.Enabled = false;
                rdbtnta.Enabled = false;
                rdbtntb.Enabled = false;
                codelivreexmp.Enabled = false;
                cmbbxauteur.Enabled = false;
                cmbbxediteur.Enabled = false;
                cmbbxserie.Enabled = false;

                // modification des couleur 
                txtbxcode.BackColor = Color.Silver;
                txtbxtitre.BackColor = Color.Silver;
                txtbxisbn.BackColor = Color.Silver;
                txtbxcouleur.BackColor = Color.Silver;
                txtbxtome.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;
                txtbxformat.BackColor = Color.Silver;
                txtbxpage.BackColor = Color.Silver;
                txtbxcommentaire.BackColor = Color.Silver;
                txtbxediteur.BackColor = Color.Silver;
                txtbxserie.BackColor = Color.Silver;
                txtbxauteur.BackColor = Color.Silver;
                txtbxreferencerexemp.BackColor = Color.Silver;
                codelivreexmp.BackColor = Color.Silver;
                cmbbxauteur.BackColor = Color.Silver;
                cmbbxediteur.BackColor = Color.Silver;
                cmbbxserie.BackColor = Color.Silver;
                txtbxcode.BackColor = Color.Silver;
            }
        }

        private void btnexemp_Click(object sender, EventArgs e)
        {
            #region remet par defaut 
            // textbox desactiver pour l'insertion
            txtbxtitre.Enabled = false;
            txtbxisbn.Enabled = false;
            txtbxcouleur.Enabled = false;
            txtbxtome.Enabled = false;
            cmbbxannee.Enabled = false;
            txtbxformat.Enabled = false;
            txtbxpage.Enabled = false;
            txtbxcommentaire.Enabled = false;
            txtbxediteur.Enabled = false;
            txtbxserie.Enabled = false;
            txtbxauteur.Enabled = false;
            txtbxreferencerexemp.Enabled = false;
            rdbtnA.Enabled = false;
            rdbtnb.Enabled = false;
            rdbtnta.Enabled = false;
            rdbtntb.Enabled = false;
            codelivreexmp.Enabled = false;
            cmbbxauteur.Enabled = false;
            cmbbxediteur.Enabled = false;
            cmbbxserie.Enabled = false;

            // modification des couleur 
            txtbxcode.BackColor = Color.Silver;
            txtbxtitre.BackColor = Color.Silver;
            txtbxisbn.BackColor = Color.Silver;
            txtbxcouleur.BackColor = Color.Silver;
            txtbxtome.BackColor = Color.Silver;
            cmbbxannee.BackColor = Color.Silver;
            txtbxformat.BackColor = Color.Silver;
            txtbxpage.BackColor = Color.Silver;
            txtbxcommentaire.BackColor = Color.Silver;
            txtbxediteur.BackColor = Color.Silver;
            txtbxserie.BackColor = Color.Silver;
            txtbxauteur.BackColor = Color.Silver;
            txtbxreferencerexemp.BackColor = Color.Silver;
            codelivreexmp.BackColor = Color.Silver;
            cmbbxauteur.BackColor = Color.Silver;
            cmbbxediteur.BackColor = Color.Silver;
            cmbbxserie.BackColor = Color.Silver;
            #endregion

            if (btnexemp.Text.Equals("Livre") & btnAjouter.Text.Equals("Valider"))
            {
                btnexemp.Text = "exemplaire";


                txtbxreferencerexemp.Enabled = true;
                rdbtnA.Enabled = true;
                rdbtnb.Enabled = true;
                rdbtnta.Enabled = true;
                rdbtntb.Enabled = true;
                
                codelivreexmp.Enabled = true;

                // modification des couleur 
     
                txtbxreferencerexemp.BackColor = Color.White;
                codelivreexmp.BackColor = Color.White;
    

            }


            else if (btnexemp.Text.Equals("exemplaire") & btnAjouter.Text.Equals("Valider"))
            {
                btnexemp.Text = "Livre";



                // textbox activer pour l'insertion

                txtbxtitre.Enabled = true;
                txtbxisbn.Enabled = true;
                txtbxcouleur.Enabled = true;
                txtbxtome.Enabled = true;
                cmbbxannee.Enabled = true;
                txtbxformat.Enabled = true;
                txtbxpage.Enabled = true;
                txtbxcommentaire.Enabled = true;
                txtbxediteur.Enabled = true;
                txtbxserie.Enabled = true;
                txtbxauteur.Enabled = true;
            
       
                cmbbxauteur.Enabled = true;
                cmbbxediteur.Enabled = true;
                cmbbxserie.Enabled = true;
        
                txtbxcode.Enabled = false;
                txtbxcode.Enabled = true;
                // modification des couleur 
              
                txtbxtitre.BackColor = Color.White;
                txtbxisbn.BackColor = Color.White;
                txtbxcouleur.BackColor = Color.White;
                txtbxtome.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
                txtbxformat.BackColor = Color.White;
                txtbxpage.BackColor = Color.White;
                txtbxcommentaire.BackColor = Color.White;
                txtbxediteur.BackColor = Color.White;
                txtbxserie.BackColor = Color.White;
                txtbxauteur.BackColor = Color.White;

      
                cmbbxauteur.BackColor = Color.White;
                cmbbxediteur.BackColor = Color.White;
                cmbbxserie.BackColor = Color.White;
            }

            if (btnexemp.Text.Equals("Livre") & btnModifier.Text.Equals("Valider"))
            {
                btnexemp.Text = "exemplaire";


               
                txtbxreferencerexemp.Enabled = true;
                codelivreexmp.Enabled = true;
                rdbtnA.Enabled = true;
                rdbtnb.Enabled = true;
                rdbtnta.Enabled = true;
                rdbtntb.Enabled = true;
                // modification des couleur 
              
                txtbxreferencerexemp.BackColor = Color.White;
                codelivreexmp.BackColor = Color.White;
             
            }


            else if (btnexemp.Text.Equals("exemplaire") & btnModifier.Text.Equals("Valider"))
            {
                btnexemp.Text = "Livre";



                // textbox activer pour l'insertion

                txtbxtitre.Enabled = true;
                txtbxisbn.Enabled = true;
                txtbxcouleur.Enabled = true;
                txtbxtome.Enabled = true;
                cmbbxannee.Enabled = true;
                txtbxformat.Enabled = true;
                txtbxpage.Enabled = true;
                txtbxcommentaire.Enabled = true;
                txtbxediteur.Enabled = true;
                txtbxserie.Enabled = true;
                txtbxauteur.Enabled = true;
      
                cmbbxauteur.Enabled = true;
                cmbbxediteur.Enabled = true;
                cmbbxserie.Enabled = true;

                // modification des couleur 
                txtbxcode.BackColor = Color.White;
                txtbxtitre.BackColor = Color.White;
                txtbxisbn.BackColor = Color.White;
                txtbxcouleur.BackColor = Color.White;
                txtbxtome.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
                txtbxformat.BackColor = Color.White;
                txtbxpage.BackColor = Color.White;
                txtbxcommentaire.BackColor = Color.White;
                txtbxediteur.BackColor = Color.White;
                txtbxserie.BackColor = Color.White;
                txtbxauteur.BackColor = Color.White;

                
                cmbbxauteur.BackColor = Color.White;
                cmbbxediteur.BackColor = Color.White;
                cmbbxserie.BackColor = Color.White;

            }
            if (btnexemp.Text.Equals("Livre") & btnSupprimer.Text.Equals("Valider"))
            {
                btnexemp.Text = "exemplaire";

                // textbox activer pour l'insertion

                txtbxcode.Enabled = true;

                txtbxmotif.Visible = true;
                lblmotif.Visible = true;
                lblcommentaire.Visible = false;
                txtbxcommentaire.Visible = false;

                // modification des couleur 

                txtbxcode.BackColor = Color.White;





            }
            else if (btnexemp.Text.Equals("exemplaire") & btnSupprimer.Text.Equals("Valider"))
            {
                btnexemp.Text = "Livre";

                // textbox activer pour l'insertion



                txtbxreferencerexemp.Enabled = true;
                txtbxmotif.Visible = true;
                lblmotif.Visible = true;
                lblcommentaire.Visible = false;
                txtbxcommentaire.Visible = false;

                // modification des couleur 




                txtbxreferencerexemp.BackColor = Color.White;

            }
            if (btnexemp.Text.Equals("exemplaire") & btnRechercher.Text.Equals("Valider"))
            {
                btnexemp.Text = "Livre";
        

                txtbxtitre.Enabled = true;
                cmbbxannee.Enabled = true;

                txtbxtitre.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
            }
           else  if (btnexemp.Text.Equals("Livre") & btnRechercher.Text.Equals("Valider"))
            {
                btnexemp.Text = "exemplaire";
                codelivreexmp.Enabled = true;

                codelivreexmp.BackColor = Color.White;
            }

        }  
    }
}
