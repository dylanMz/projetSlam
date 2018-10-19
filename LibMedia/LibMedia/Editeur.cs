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
        #endregion

        #region Accesseurs

        public int _EditeurNum
        {
            get { return EditeurNum; }
            set { EditeurNum = value; }
        }

        public string _EditeurNom
        {
            get { return EditeurNom; }
            set { EditeurNom = value; }
        }


        public int _EditeurCreation
        {
            get { return EditeurCreation; }
            set { EditeurCreation = value; }
        }


        public string _EditeurAdresse
        {
            get { return EditeurAdresse; }
            set { EditeurAdresse = value; }
        }

        public String _EditeurCP
        {
            get { return EditeurCP; }
            set { EditeurCP = value; }
        }

        public String _EditeurVille
        {
            get { return EditeurVille; }
            set { EditeurVille = value; }
        }


        public String _EditeurTel
        {
            get { return EditeurTel; }
            set { EditeurTel = value; }
        }

        public String _EditeurFax
        {
            get { return EditeurFax; }
            set { EditeurFax = value; }
        }

        public String _EditeurMail
        {
            get { return EditeurMail; }
            set { EditeurMail = value; }
        }
        #endregion

    }
}
