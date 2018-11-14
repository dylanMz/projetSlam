using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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
        private Boolean uneVar;
        private DataSet unDataset;
        private String unNiveau;
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

        //Verifie si les identifiants de l'utilisateur sont dans la base de données.
        public String recup_connexion(String wpseudo, String wpassword)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand UtilisateurSql = new MySqlCommand();
                UtilisateurSql.CommandText = "proc_recup_utilisateur";
                UtilisateurSql.CommandType = CommandType.StoredProcedure;
                UtilisateurSql.Connection = uneconnexion.getConnexion();

                UtilisateurSql.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                UtilisateurSql.Parameters["wpseudo"].Value = wpseudo;

                MD5 md5HashAlgo = MD5.Create();

                // Place le texte à hacher dans un tableau d'octets 
                byte[] byteArrayToHash = Encoding.UTF8.GetBytes(wpassword);

                // Hash le texte et place le résulat dans un tableau d'octets 
                byte[] hashResult = md5HashAlgo.ComputeHash(byteArrayToHash);

                StringBuilder result = new StringBuilder();

                for (int i = 0; i < hashResult.Length; i++)
                {
                    // Affiche le Hash en hexadecimal 
                    result.Append(hashResult[i].ToString("X2"));
                }
                
                //Crypte le mot de passe en md5 pour qu'il corresponde à celui present dans la base de données.
                String motdepassehache = result.ToString().ToLower();

                UtilisateurSql.Parameters.Add(new MySqlParameter("wmdp", MySqlDbType.String));
                UtilisateurSql.Parameters["wmdp"].Value = motdepassehache;

                MySqlDataAdapter unAdapter = new MySqlDataAdapter(UtilisateurSql);
                DataTable dt = new DataTable();
                unAdapter.Fill(dt);
               
                if (dt.Rows[0][0].ToString() == "1")
                {
                    uneVar = true;
                    
                }
                else
                {
                    uneVar = false;
                }

                MySqlCommand UtilisateurSqlNiveau = new MySqlCommand();
                UtilisateurSqlNiveau.CommandText = "proc_recup_niveau_utilisateur";
                UtilisateurSqlNiveau.CommandType = CommandType.StoredProcedure;
                UtilisateurSqlNiveau.Connection = uneconnexion.getConnexion();

                UtilisateurSqlNiveau.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                UtilisateurSqlNiveau.Parameters["wpseudo"].Value = wpseudo;

                _unReader = UtilisateurSqlNiveau.ExecuteReader();

                while (_unReader.Read())
                {
                    unNiveau = _unReader["util_niveau"].ToString();
                }
                _unReader.Close();

                uneconnexion.closeConnexion();

                
            }

            return unNiveau;
        }

        //Ajout d'un utilisateur
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

                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_erreur", MySqlDbType.Int16);
                unComdeSql.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                unComdeSql.ExecuteNonQuery();

                uneconnexion.closeConnexion();
            }
        }

        //Modification d'un utilisateur
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
        
        //Suppression d'un utilisateur
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

        public Boolean myVar
        {
            get { return uneVar; }
            set { uneVar = value; }
        }

        #endregion
    }
}
