﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Crud_Emprunteur
    {
        #region Proprietés
        private int wsql;
        private ConnexionBase uneconnexion;
        private List<Emprunteur> _desEmprunteurs;
        private MySqlDataReader _unReader;
        #endregion

        #region Constructeur

        public Crud_Emprunteur(ConnexionBase connexion_en_cours)
        {
            uneconnexion = connexion_en_cours;
            _desEmprunteurs = new List<Emprunteur>();

        }
        public Crud_Emprunteur()
        {
            uneconnexion = new ConnexionBase();
            _desEmprunteurs = new List<Emprunteur>();
        }

        #endregion

        #region Méthode

        //Exécute la procédure pour récuper la table emprunteur
        public void Recup_TableEmprunteur()
        {

            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EmprunteurSql = new MySqlCommand();
                //Nom procedure
                EmprunteurSql.CommandText = "proc_afficher_emprunteur";
                EmprunteurSql.CommandType = CommandType.StoredProcedure;
                EmprunteurSql.Connection = uneconnexion.getConnexion();
                _unReader = EmprunteurSql.ExecuteReader();
                
                while (_unReader.Read())
                {
                    _desEmprunteurs.Add(new Emprunteur(int.Parse(_unReader["emp_num"].ToString()), _unReader["emp_nom"].ToString(), _unReader["emp_prenom"].ToString(), _unReader["emp_rue"].ToString(), _unReader["emp_code_postal"].ToString(), _unReader["emp_ville"].ToString(), DateTime.Parse(_unReader["emp_date_naiss"].ToString()), _unReader["emp_mail"].ToString(), DateTime.Parse(_unReader["emp_prem_adh"].ToString()), DateTime.Parse(_unReader["emp_ren_adh"].ToString())));
                }
                _unReader.Close();
                uneconnexion.closeConnexion();
            }
        }
        //Exécute la procédure avec les paramétres pour modifier et insert
        public void connectprocedure(String nomprocedure, ref string codeErreur, Emprunteur Emprunteur)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                codeErreur = "0";
                //connexion à la procédure
                MySqlCommand unecommandeSql = new MySqlCommand();
                unecommandeSql.CommandText = nomprocedure;
                unecommandeSql.CommandType = CommandType.StoredProcedure;
                unecommandeSql.Connection = uneconnexion.getConnexion();

                //paramétre de la procédure
                
                unecommandeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unecommandeSql.Parameters["wnom"].Value = Emprunteur.Nom;
                unecommandeSql.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                unecommandeSql.Parameters["wprenom"].Value = Emprunteur.Prénom;
                unecommandeSql.Parameters.Add(new MySqlParameter("wrue", MySqlDbType.String));
                unecommandeSql.Parameters["wrue"].Value = Emprunteur.Rue;
                unecommandeSql.Parameters.Add(new MySqlParameter("wcodepostal", MySqlDbType.String));
                unecommandeSql.Parameters["wcodepostal"].Value = Emprunteur.Code_Postal;
                unecommandeSql.Parameters.Add(new MySqlParameter("wville", MySqlDbType.String));
                unecommandeSql.Parameters["wville"].Value = Emprunteur.Ville;
                unecommandeSql.Parameters.Add(new MySqlParameter("wdatenaiss", MySqlDbType.Date));
                unecommandeSql.Parameters["wdatenaiss"].Value = Emprunteur.Naissance;
                unecommandeSql.Parameters.Add(new MySqlParameter("wmail", MySqlDbType.String));
                unecommandeSql.Parameters["wmail"].Value = Emprunteur.Mail;
                unecommandeSql.Parameters.Add(new MySqlParameter("wpremadh", MySqlDbType.Date));
                unecommandeSql.Parameters["wpremadh"].Value = Emprunteur.Adhésion;
                unecommandeSql.Parameters.Add(new MySqlParameter("wrenadh", MySqlDbType.Date));
                unecommandeSql.Parameters["wrenadh"].Value = Emprunteur.Renouvellement_Adhésion;

                unecommandeSql.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                unecommandeSql.Parameters["wid"].Value = Emprunteur.Numéro;



                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_erreur", MySqlDbType.Int16);
                unecommandeSql.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                //unecommandeSql.ExecuteNonQuery();

                //gestion d'erreurs 
                try
                {
                    unecommandeSql.ExecuteNonQuery();
                }
                catch (MySqlException myException)
                {
                    codeErreur = myException.Number.ToString();
                }
                uneconnexion.closeConnexion();
            }
        }


        //connection à la procédure de recherche
        public void recherche(String nomprocedure, Emprunteur Remprunteur)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                //connexion à la procédure
                MySqlCommand unecommandeSql = new MySqlCommand();
                unecommandeSql.CommandText = nomprocedure;
                unecommandeSql.CommandType = CommandType.StoredProcedure;
                unecommandeSql.Connection = uneconnexion.getConnexion();

                //paramétre de la procédure
                unecommandeSql.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                unecommandeSql.Parameters["wid"].Value = Remprunteur.Numéro;
                unecommandeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unecommandeSql.Parameters["wnom"].Value = Remprunteur.Nom;

                //verification pour savoir si un nom ou un id est saisie
                if (Remprunteur.emp_num != 0)
                {
                    wsql = 1;
                }
                else
                {
                    wsql = 2;
                }
                unecommandeSql.Parameters.Add(new MySqlParameter("wsql", MySqlDbType.Int16));
                unecommandeSql.Parameters["wsql"].Value = wsql;
                _unReader = unecommandeSql.ExecuteReader();

                while (_unReader.Read())
                {
                    _desEmprunteurs.Add(new Emprunteur(int.Parse(_unReader["emp_num"].ToString()), _unReader["emp_nom"].ToString(), _unReader["emp_prenom"].ToString(), _unReader["emp_rue"].ToString(), _unReader["emp_code_postal"].ToString(), _unReader["emp_ville"].ToString(), DateTime.Parse(_unReader["emp_date_naiss"].ToString()), _unReader["emp_mail"].ToString(), DateTime.Parse(_unReader["emp_prem_adh"].ToString()), DateTime.Parse(_unReader["emp_ren_adh"].ToString())));
                }
               // _unReader.Close();
                uneconnexion.closeConnexion();
            }
        }

        //Exécute la procédure de suppression d"un emprunteur
        public void deleteEmprunteur(String nomprocedure, Emprunteur NumEmprunteur,String wmotif)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {

                MySqlCommand unecommandeSql = new MySqlCommand();
                unecommandeSql.CommandText = nomprocedure;
                unecommandeSql.CommandType = CommandType.StoredProcedure;
                unecommandeSql.Connection = uneconnexion.getConnexion();


                unecommandeSql.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                unecommandeSql.Parameters["wid"].Value = NumEmprunteur.Numéro;
                unecommandeSql.Parameters.Add(new MySqlParameter("wmotif", MySqlDbType.String));
                unecommandeSql.Parameters["wmotif"].Value = wmotif;
                unecommandeSql.ExecuteNonQuery();
                uneconnexion.closeConnexion();
            }
        }


        #endregion

        #region Accesseur
        //Accesseur de la liste Emprunteur
        public List<Emprunteur> lesEmprunteurs
        {
            get { return _desEmprunteurs; }
            set { _desEmprunteurs = value; }
        }
        #endregion
    }

}
