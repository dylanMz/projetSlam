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
        public Utilisateur(int wutil_id, String wutil_nom, String wutil_prenom, String wutil_pseudo, String wutil_password, String wutil_niveau)
        {
            util_id = wutil_id;
            util_nom = wutil_nom;
            util_prenom = wutil_prenom;
            util_pseudo = wutil_pseudo;
            util_password = wutil_password;
            util_niveau = wutil_niveau;
        }
        #endregion

        #region Accesseurs
        public int _util_id
        {
            get { return util_id; }
            set { util_id = value; }
        }

        public String _util_nom
        {
            get { return util_nom; }
            set { util_nom = value; }
        }

        public String _util_prenom
        {
            get { return util_prenom; }
            set { util_prenom = value; }
        }

        public String _util_pseudo
        {
            get { return util_pseudo; }
            set { util_pseudo = value; }
        }

        public String _util_password
        {
            get { return util_password; }
            set { util_password = value; }
        }

        public String _util_niveau
        {
            get { return util_niveau; }
            set { util_niveau = value; }
        }
        #endregion
    }
}
