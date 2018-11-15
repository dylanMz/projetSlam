using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Utilisateur
    {
        #region Proprietés
        private int util_id;
        private String util_nom;
        private String util_prenom;
        private String util_pseudo;
        private String util_password;
        private String util_niveau;
        #endregion

        #region Constructeur.s

        //Constructeur pour la modification
        public Utilisateur(int wutil_id, String wutil_prenom, String wutil_nom, String wutil_pseudo, String wutil_password, String wutil_niveau)
        {
            util_id = wutil_id;
            util_prenom = wutil_prenom;
            util_nom = wutil_nom;
            util_pseudo = wutil_pseudo;
            util_password = wutil_password;
            util_niveau = wutil_niveau;
        }

        //Constructeur pour l'ajout
        public Utilisateur(String wutil_prenom, String wutil_nom, String wutil_pseudo, String wutil_password, String wutil_niveau)
        {
            util_prenom = wutil_prenom;
            util_nom = wutil_nom;
            util_pseudo = wutil_pseudo;
            util_password = wutil_password;
            util_niveau = wutil_niveau;
        }

        //Constructeur pour la suppression
        public Utilisateur(int wutil_id)
        {
            util_id = wutil_id;

        }
        #endregion

        #region Accesseurs
        public int Numéro
        {
            get { return util_id; }
            set { util_id = value; }
        }

        public String Nom
        {
            get { return util_nom; }
            set { util_nom = value; }
        }

        public String Prénom
        {
            get { return util_prenom; }
            set { util_prenom = value; }
        }

        public String Pseudo
        {
            get { return util_pseudo; }
            set { util_pseudo = value; }
        }

        public String Mot_de_passe
        {
            get { return util_password; }
            set { util_password = value; }
        }

        public String Niveau
        {
            get { return util_niveau; }
            set { util_niveau = value; }
        }
        #endregion
    }
}
