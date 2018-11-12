using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Crud_Editeur
    {
        #region Propriétés
        private ConnexionBase uneconnexion;
        private MySqlDataReader _unReader;
        private List<Editeur> _desEditeurs;
        #endregion

        #region Constructeur.s
        public Crud_Editeur(ConnexionBase connexion_en_cours)
        {
            uneconnexion = connexion_en_cours;
            _desEditeurs = new List<Editeur>();
        }

        public Crud_Editeur()
        {
            uneconnexion = new ConnexionBase();
            _desEditeurs = new List<Editeur>();
        }
        #endregion

        #region Méthode

        //Affiche la table editeur.
        public void Recup_Table_Editeur()
        {

            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EditeurSql = new MySqlCommand();
                EditeurSql.CommandText = "proc_affiche_editeur";
                EditeurSql.CommandType = CommandType.StoredProcedure;
                EditeurSql.Connection = uneconnexion.getConnexion();
                _unReader = EditeurSql.ExecuteReader();

                while (_unReader.Read())
                {
                    _desEditeurs.Add(new Editeur(int.Parse(_unReader["EditeurNum"].ToString()), _unReader["EditeurNom"].ToString(), int.Parse(_unReader["EditeurCreation"].ToString()), _unReader["EditeurAdresse"].ToString(), _unReader["EditeurCP"].ToString(), _unReader["EditeurVille"].ToString(), _unReader["EditeurTel"].ToString(), _unReader["EditeurFax"].ToString(), _unReader["EditeurMail"].ToString()));
                }
                _unReader.Close();
                uneconnexion.closeConnexion();
            }
        }

        //Ajout d'un editeur
        public void ajout_editeur(String wEditeurNom, String wEditeurAdresse, String wEditeurCP, String wEditeurVille, String wEditeurMail, String wEditeurFax, String wEditeurTel, int wEditeurCreation)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_insert_editeur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unComdeSql.Parameters["wnom"].Value = wEditeurNom;

                unComdeSql.Parameters.Add(new MySqlParameter("wadresse", MySqlDbType.String));
                unComdeSql.Parameters["wadresse"].Value = wEditeurAdresse;

                unComdeSql.Parameters.Add(new MySqlParameter("wcp", MySqlDbType.String));
                unComdeSql.Parameters["wcp"].Value = wEditeurCP;

                unComdeSql.Parameters.Add(new MySqlParameter("wville", MySqlDbType.String));
                unComdeSql.Parameters["wville"].Value = wEditeurVille;

                unComdeSql.Parameters.Add(new MySqlParameter("wmail", MySqlDbType.String));
                unComdeSql.Parameters["wmail"].Value = wEditeurMail;

                unComdeSql.Parameters.Add(new MySqlParameter("wfax", MySqlDbType.String));
                unComdeSql.Parameters["wfax"].Value = wEditeurFax;

                unComdeSql.Parameters.Add(new MySqlParameter("wtel", MySqlDbType.String));
                unComdeSql.Parameters["wtel"].Value = wEditeurTel;

                unComdeSql.Parameters.Add(new MySqlParameter("wcreation", MySqlDbType.Int16));
                unComdeSql.Parameters["wcreation"].Value = wEditeurCreation;


                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_erreur", MySqlDbType.Int16);
                unComdeSql.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                unComdeSql.ExecuteNonQuery();

                uneconnexion.closeConnexion();


            }
        }

        //Modification d'un editeur
        public void modification_editeur(int wEditeurNum, String wEditeurNom, String wEditeurAdresse, String wEditeurCP, String wEditeurVille, String wEditeurMail, String wEditeurFax, String wEditeurTel, int wEditeurCreation)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_update_editeur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wnum", MySqlDbType.Int16));
                unComdeSql.Parameters["wnum"].Value = wEditeurNum;

                unComdeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unComdeSql.Parameters["wnom"].Value = wEditeurNom;

                unComdeSql.Parameters.Add(new MySqlParameter("wadresse", MySqlDbType.String));
                unComdeSql.Parameters["wadresse"].Value = wEditeurAdresse;

                unComdeSql.Parameters.Add(new MySqlParameter("wcp", MySqlDbType.String));
                unComdeSql.Parameters["wcp"].Value = wEditeurCP;

                unComdeSql.Parameters.Add(new MySqlParameter("wville", MySqlDbType.String));
                unComdeSql.Parameters["wville"].Value = wEditeurVille;

                unComdeSql.Parameters.Add(new MySqlParameter("wmail", MySqlDbType.String));
                unComdeSql.Parameters["wmail"].Value = wEditeurMail;

                unComdeSql.Parameters.Add(new MySqlParameter("wfax", MySqlDbType.String));
                unComdeSql.Parameters["wfax"].Value = wEditeurFax;

                unComdeSql.Parameters.Add(new MySqlParameter("wtel", MySqlDbType.String));
                unComdeSql.Parameters["wtel"].Value = wEditeurTel;

                unComdeSql.Parameters.Add(new MySqlParameter("wcreation", MySqlDbType.Int16));
                unComdeSql.Parameters["wcreation"].Value = wEditeurCreation;


                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_erreur", MySqlDbType.Int16);
                unComdeSql.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                unComdeSql.ExecuteNonQuery();

                uneconnexion.closeConnexion();


            }
        }

        //Recherche d'un editeur
        public void recherche_editeur(String wEditeurNom)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EditeurSql = new MySqlCommand();
                EditeurSql.CommandText = "proc_recherche_editeur";
                EditeurSql.CommandType = CommandType.StoredProcedure;
                EditeurSql.Connection = uneconnexion.getConnexion();

                EditeurSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                EditeurSql.Parameters["wnom"].Value = wEditeurNom;
                _unReader = EditeurSql.ExecuteReader();

                while (_unReader.Read())
                {
                    _desEditeurs.Add(new Editeur(int.Parse(_unReader["EditeurNum"].ToString()), _unReader["EditeurNom"].ToString(), int.Parse(_unReader["EditeurCreation"].ToString()), _unReader["EditeurAdresse"].ToString(), _unReader["EditeurCP"].ToString(), _unReader["EditeurVille"].ToString(), _unReader["EditeurTel"].ToString(), _unReader["EditeurFax"].ToString(), _unReader["EditeurMail"].ToString()));
                }
                _unReader.Close();
                uneconnexion.closeConnexion();
            }

        }
        #endregion

        #region Accesseurs
        //Accesseur de la liste editeur
        public List<Editeur> lesEditeurs
        {
            get { return _desEditeurs; }
            set { _desEditeurs = value; }
        }
        #endregion
    }
}
