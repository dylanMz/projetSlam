using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Crud_Utilisateur
    {
        #region Propriétés
        private ConnexionBase uneconnexion;
        private MySqlDataReader _unReader;
        private List<Utilisateur> _desUtilisateurs;
        #endregion

        #region Constructeur.s
        public Crud_Utilisateur(ConnexionBase connexion_en_cours)
        {
            uneconnexion = connexion_en_cours;
            _desUtilisateurs = new List<Utilisateur>();
        }

        public Crud_Utilisateur()
        {
            uneconnexion = new ConnexionBase();
            _desUtilisateurs = new List<Utilisateur>();
        }
        #endregion

        #region Méthodes
        //Affiche la table utilisateur.
        public void Recup_Table_Utilisateur()
        {

            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand UtilisateurSql = new MySqlCommand();
                UtilisateurSql.CommandText = "proc_affiche_utilisateur";
                UtilisateurSql.CommandType = CommandType.StoredProcedure;
                UtilisateurSql.Connection = uneconnexion.getConnexion();
                _unReader = UtilisateurSql.ExecuteReader();

                while (_unReader.Read())
                {
                    _desUtilisateurs.Add(new Utilisateur(int.Parse(_unReader["util_id"].ToString()), _unReader["util_prenom"].ToString(), _unReader["util_nom"].ToString(), _unReader["util_pseudo"].ToString(),_unReader["util_password"].ToString(), _unReader["util_niveau"].ToString()));
                }
                _unReader.Close();
                uneconnexion.closeConnexion();
            }
        }
        #endregion

        #region Accesseurs
        //Accesseur de la liste utilisateur
        public List<Utilisateur> lesUtilisateurs
        {
            get { return _desUtilisateurs; }
            set { _desUtilisateurs = value; }
        }
        #endregion
    }
}
