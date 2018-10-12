using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Metier_Editeur
    {
        #region Propriétés
        private ConnexionBase uneconnexion;
        private MySqlDataAdapter _unAdapter;
        private DataSet _unDataset;
        
        #endregion

        #region Constructeur.s
        public Metier_Editeur(ConnexionBase connexion_en_cours)
        {
            uneconnexion = connexion_en_cours;

        }

        public Metier_Editeur()
        {
            uneconnexion = new ConnexionBase();
        }
        #endregion

        #region Méthode

        //Affiche la table Vendeur.
        public void Recup_Table_Editeur()
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                String wTable = "editeur";
                MySqlCommand EditeurMysql = new MySqlCommand();
                EditeurMysql.CommandText = "proc_affiche_editeur";
                EditeurMysql.CommandType = CommandType.StoredProcedure;
                EditeurMysql.Connection = uneconnexion.getConnexion();
                _unAdapter = new MySqlDataAdapter(EditeurMysql);
                _unDataset = new DataSet();
                _unAdapter.Fill(_unDataset, wTable);
            }
        }

       public void modifier_ajouter_editeur(String nomProc, String wEditeurNom, int wEditeurCreation, String wEditeurAdresse, String wEditeurCP, String wEditeurVille, String wEditeurTel, String wEditeurFax, String wEditeurMail)
        {
            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = nomProc;
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = uneconnexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("EditeurNom", MySqlDbType.String));
            unComdeSql.Parameters["EditeurNom"].Value = wEditeurNom;

            unComdeSql.Parameters.Add(new MySqlParameter("EditeurCreation", MySqlDbType.Int16));
            unComdeSql.Parameters["EditeurCreation"].Value = wEditeurCreation;

            unComdeSql.Parameters.Add(new MySqlParameter("EditeurAdresse", MySqlDbType.String));
            unComdeSql.Parameters["EditeurAdresse"].Value = wEditeurAdresse;

            unComdeSql.Parameters.Add(new MySqlParameter("EditeurCP", MySqlDbType.String));
            unComdeSql.Parameters["EditeurCP"].Value = wEditeurCP;

            unComdeSql.Parameters.Add(new MySqlParameter("EditeurVille", MySqlDbType.String));
            unComdeSql.Parameters["EditeurVille"].Value = wEditeurVille;

            unComdeSql.Parameters.Add(new MySqlParameter("EditeurTel", MySqlDbType.String));
            unComdeSql.Parameters["EditeurTel"].Value = wEditeurTel;

            unComdeSql.Parameters.Add(new MySqlParameter("EditeurFax", MySqlDbType.String));
            unComdeSql.Parameters["EditeurFax"].Value = wEditeurFax;

            unComdeSql.Parameters.Add(new MySqlParameter("EditeurMail", MySqlDbType.String));
            unComdeSql.Parameters["EditeurMail"].Value = wEditeurMail;
        }
        #endregion
    }
}
