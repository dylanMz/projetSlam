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

        public void ajout_utilisateur(String wprenom, String wnom, String wpseudo, String wpassword, String wniveau)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_insert_utilisateur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                unComdeSql.Parameters["wprenom"].Value = wprenom;

                unComdeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unComdeSql.Parameters["wnom"].Value = wnom;

                unComdeSql.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                unComdeSql.Parameters["wpseudo"].Value = wpseudo;

                unComdeSql.Parameters.Add(new MySqlParameter("wpassword", MySqlDbType.String));
                unComdeSql.Parameters["wpassword"].Value = wpassword;

                unComdeSql.Parameters.Add(new MySqlParameter("wniveau", MySqlDbType.String));
                unComdeSql.Parameters["wniveau"].Value = wniveau;

                unComdeSql.ExecuteNonQuery();

                uneconnexion.closeConnexion();
            }
        }

        public void modification_utilisateur(int wnum, String wprenom, String wnom, String wpseudo, String wpassword, String wniveau)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_update_utilisateur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                unComdeSql.Parameters["wprenom"].Value = wprenom;

                unComdeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unComdeSql.Parameters["wnom"].Value = wnom;

                unComdeSql.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                unComdeSql.Parameters["wpseudo"].Value = wpseudo;

                unComdeSql.Parameters.Add(new MySqlParameter("wpassword", MySqlDbType.String));
                unComdeSql.Parameters["wpassword"].Value = wpassword;

                unComdeSql.Parameters.Add(new MySqlParameter("wniveau", MySqlDbType.String));
                unComdeSql.Parameters["wniveau"].Value = wniveau;

                unComdeSql.Parameters.Add(new MySqlParameter("wnum", MySqlDbType.Int16));
                unComdeSql.Parameters["wnum"].Value = wnum;

                unComdeSql.ExecuteNonQuery();

                uneconnexion.closeConnexion();
            }
        }

        public void suppression_utilisateur(int unNum)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_delete_utilisateur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wnum", MySqlDbType.Int16));
                unComdeSql.Parameters["wnum"].Value = unNum;

                unComdeSql.ExecuteNonQuery();

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
