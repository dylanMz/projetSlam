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
        private int CodeOut;
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

        //Affiche la table editeur archive.
        public void Recup_Table_Editeur_archive()
        {

            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EditeurSql = new MySqlCommand();
                EditeurSql.CommandText = "proc_affiche_editeur_archive";
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
        public int ajout_editeur(Editeur unEditeur)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_insert_editeur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unComdeSql.Parameters["wnom"].Value = unEditeur.Nom;

                unComdeSql.Parameters.Add(new MySqlParameter("wadresse", MySqlDbType.String));
                unComdeSql.Parameters["wadresse"].Value = unEditeur.Adresse;

                unComdeSql.Parameters.Add(new MySqlParameter("wcp", MySqlDbType.String));
                unComdeSql.Parameters["wcp"].Value = unEditeur.Code_postal;

                unComdeSql.Parameters.Add(new MySqlParameter("wville", MySqlDbType.String));
                unComdeSql.Parameters["wville"].Value = unEditeur.Ville;

                unComdeSql.Parameters.Add(new MySqlParameter("wmail", MySqlDbType.String));
                unComdeSql.Parameters["wmail"].Value = unEditeur.Mail;

                unComdeSql.Parameters.Add(new MySqlParameter("wfax", MySqlDbType.String));
                unComdeSql.Parameters["wfax"].Value = unEditeur.Fax;

                unComdeSql.Parameters.Add(new MySqlParameter("wtel", MySqlDbType.String));
                unComdeSql.Parameters["wtel"].Value = unEditeur.Téléphone;

                unComdeSql.Parameters.Add(new MySqlParameter("wcreation", MySqlDbType.Int16));
                unComdeSql.Parameters["wcreation"].Value = unEditeur.Création;


                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_erreur", MySqlDbType.Int16);
                unComdeSql.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                unComdeSql.ExecuteNonQuery(); // Execute la requête

                uneconnexion.closeConnexion(); // Ferme la connexion

                CodeOut = Convert.ToInt32(PSortie_nat.Value); 

            }

            return CodeOut;

        }

        //Modification d'un editeur
        public void modification_editeur(Editeur unEditeur, String wAncienNom)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_update_editeur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wnum", MySqlDbType.Int16));
                unComdeSql.Parameters["wnum"].Value = unEditeur.Numéro;

                unComdeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unComdeSql.Parameters["wnom"].Value = unEditeur.Nom;

                unComdeSql.Parameters.Add(new MySqlParameter("wadresse", MySqlDbType.String));
                unComdeSql.Parameters["wadresse"].Value = unEditeur.Adresse;

                unComdeSql.Parameters.Add(new MySqlParameter("wcp", MySqlDbType.String));
                unComdeSql.Parameters["wcp"].Value = unEditeur.Code_postal;

                unComdeSql.Parameters.Add(new MySqlParameter("wville", MySqlDbType.String));
                unComdeSql.Parameters["wville"].Value = unEditeur.Ville;

                unComdeSql.Parameters.Add(new MySqlParameter("wmail", MySqlDbType.String));
                unComdeSql.Parameters["wmail"].Value = unEditeur.Mail;

                unComdeSql.Parameters.Add(new MySqlParameter("wfax", MySqlDbType.String));
                unComdeSql.Parameters["wfax"].Value = unEditeur.Fax;

                unComdeSql.Parameters.Add(new MySqlParameter("wtel", MySqlDbType.String));
                unComdeSql.Parameters["wtel"].Value = unEditeur.Téléphone;

                unComdeSql.Parameters.Add(new MySqlParameter("wcreation", MySqlDbType.Int16));
                unComdeSql.Parameters["wcreation"].Value = unEditeur.Création;

                unComdeSql.Parameters.Add(new MySqlParameter("wAncienNom", MySqlDbType.String));
                unComdeSql.Parameters["wAncienNom"].Value = wAncienNom;


                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_erreur", MySqlDbType.Int16);
                unComdeSql.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                unComdeSql.ExecuteNonQuery();

                uneconnexion.closeConnexion();


            }
        }

        //Suppression d'un editeur
        public void suppression_editeur(Editeur unEditeur)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_delete_editeur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unComdeSql.Parameters["wnom"].Value = unEditeur.Nom;

                unComdeSql.ExecuteNonQuery();

                uneconnexion.closeConnexion();

            }
        }

        //Recherche d'un editeur
        public void recherche_editeur(Editeur unEditeur)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EditeurSql = new MySqlCommand();
                EditeurSql.CommandText = "proc_recherche_editeur";
                EditeurSql.CommandType = CommandType.StoredProcedure;
                EditeurSql.Connection = uneconnexion.getConnexion();

                EditeurSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                EditeurSql.Parameters["wnom"].Value = unEditeur.Nom;
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
