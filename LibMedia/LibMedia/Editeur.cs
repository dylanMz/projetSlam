using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace LibMedia
{
    public class Editeur
    {
        #region Proprietés
        private int EditeurNum;
        private String EditeurNom;
        private int EditeurCreation;
        private String EditeurAdresse;
        private String EditeurCP;
        private String EditeurVille;
        private String EditeurTel;
        private String EditeurFax;
        private String EditeurMail;
        private String AncienNom;
        #endregion

        #region Constructeur.s
        public Editeur(int wEditeurNum, String wEditeurNom, int wEditeurCreation, String wEditeurAdresse, String wEditeurCP, String wEditeurVille, String wEditeurTel, String wEditeurFax, String wEditeurMail)
        {
            EditeurNum = wEditeurNum;
            EditeurNom = wEditeurNom;
            EditeurCreation = wEditeurCreation;
            EditeurAdresse = wEditeurAdresse;
            EditeurCP = wEditeurCP;
            EditeurVille = wEditeurVille;
            EditeurTel = wEditeurTel;
            EditeurFax = wEditeurFax;
            EditeurMail = wEditeurMail;
        }

        public Editeur(String wEditeurNom)
        {
            EditeurNom = wEditeurNom;
        }

        public Editeur(int wEditeurNum, String wEditeurNom, int wEditeurCreation, String wEditeurAdresse, String wEditeurCP, String wEditeurVille, String wEditeurTel, String wEditeurFax, String wEditeurMail, String wunAncienNom)
        {
            EditeurNum = wEditeurNum;
            EditeurNom = wEditeurNom;
            EditeurCreation = wEditeurCreation;
            EditeurAdresse = wEditeurAdresse;
            EditeurCP = wEditeurCP;
            EditeurVille = wEditeurVille;
            EditeurTel = wEditeurTel;
            EditeurFax = wEditeurFax;
            EditeurMail = wEditeurMail;
            AncienNom = wunAncienNom;
        }

        public Editeur(String wEditeurNom, int wEditeurCreation, String wEditeurAdresse, String wEditeurCP, String wEditeurVille, String wEditeurTel, String wEditeurFax, String wEditeurMail)
        {
            EditeurNom = wEditeurNom;
            EditeurCreation = wEditeurCreation;
            EditeurAdresse = wEditeurAdresse;
            EditeurCP = wEditeurCP;
            EditeurVille = wEditeurVille;
            EditeurTel = wEditeurTel;
            EditeurFax = wEditeurFax;
            EditeurMail = wEditeurMail;
        }
        #endregion

        #region Accesseurs

        public int Numéro
        {
            get { return EditeurNum; }
            set { EditeurNum = value; }
        }

        public string Nom
        {
            get { return EditeurNom; }
            set { EditeurNom = value; }
        }


        public int Création
        {
            get { return EditeurCreation; }
            set { EditeurCreation = value; }
        }


        public string Adresse
        {
            get { return EditeurAdresse; }
            set { EditeurAdresse = value; }
        }

        public String Code_postal
        {
            get { return EditeurCP; }
            set { EditeurCP = value; }
        }

        public String Ville
        {
            get { return EditeurVille; }
            set { EditeurVille = value; }
        }


        public String Téléphone
        {
            get { return EditeurTel; }
            set { EditeurTel = value; }
        }

        public String Fax
        {
            get { return EditeurFax; }
            set { EditeurFax = value; }
        }

        public String Mail
        {
            get { return EditeurMail; }
            set { EditeurMail = value; }
        }

        public String _AncienNom
        {
            get { return AncienNom; }
            set { AncienNom = value; }
        }

    
        #endregion

    }
}
