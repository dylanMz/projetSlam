﻿using MySql.Data.MySqlClient;
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
        private MySqlDataAdapter _unAdapter;
        private DataSet _unDataset;
        
        #endregion

        #region Constructeur.s
        public Crud_Editeur(ConnexionBase connexion_en_cours)
        {
            uneconnexion = connexion_en_cours;

        }

        public Crud_Editeur()
        {
            uneconnexion = new ConnexionBase();
        }
        #endregion

        #region Méthode

        //Affiche la table Vendeur.
        public DataTable Recup_Table_Editeur(String nomProc, String wTable)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EditeurMysql = new MySqlCommand();
                EditeurMysql.CommandText = nomProc;
                EditeurMysql.CommandType = CommandType.StoredProcedure;
                EditeurMysql.Connection = uneconnexion.getConnexion();
                _unAdapter = new MySqlDataAdapter(EditeurMysql);
                _unDataset = new DataSet();
                _unAdapter.Fill(_unDataset, wTable);
                uneconnexion.closeConnexion();
            }
            return (_unDataset.Tables[wTable]);
        }

        //Ajout d'un editeur
        public void ajout_editeur(String nomProc, String wEditeurNom, String wEditeurAdresse, String wEditeurCP, String wEditeurVille, String wEditeurMail, String wEditeurFax, String wEditeurTel, int wEditeurCreation, String wUnCodeSortie)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = nomProc;
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
        public void modification_editeur(String wEditeurNum, String wEditeurNom, String wEditeurAdresse, String wEditeurCP, String wEditeurVille, String wEditeurMail, String wEditeurFax, String wEditeurTel, int wEditeurCreation)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_update_editeur";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = uneconnexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wnum", MySqlDbType.String));
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
        public void recherche_editeur(String wNomEditeur)
        {
        }
        #endregion
    }
}
