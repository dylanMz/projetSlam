using MySql.Data.MySqlClient;
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
        private int chef;
        private ConnexionBase uneconnexion;
        private List<Emprunteur> _desEmprunteurs;
        private List<Famille> _desfamilles;
        private MySqlDataReader _unReader;
        #endregion

        #region Constructeur

        public Crud_Emprunteur(ConnexionBase connexion_en_cours)
        {
            uneconnexion = connexion_en_cours;
            _desEmprunteurs = new List<Emprunteur>();
            _desfamilles = new List<Famille>();

        }
        public Crud_Emprunteur()
        {
            uneconnexion = new ConnexionBase();
            _desEmprunteurs = new List<Emprunteur>();
            _desfamilles = new List<Famille>();
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
        public void connectprocedure(String nomprocedure, ref string codeErreur, List<KeyValuePair<String, Object>> parametresString, List<KeyValuePair<String, Object>> parametresDate, int wid)
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
                foreach (KeyValuePair<String, Object> unParametre in parametresString)
                {
                    unecommandeSql.Parameters.Add(new MySqlParameter(unParametre.Key, MySqlDbType.String));
                    unecommandeSql.Parameters[unParametre.Key].Value = unParametre.Value;
                }

                foreach (KeyValuePair<String, Object> unParametre in parametresDate)
                {
                    unecommandeSql.Parameters.Add(new MySqlParameter(unParametre.Key, MySqlDbType.Date));
                    unecommandeSql.Parameters[unParametre.Key].Value = unParametre.Value;
                }
                unecommandeSql.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                unecommandeSql.Parameters["wid"].Value = wid;

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
        public void recherche(String nomprocedure, string wnom, int wid)
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
                unecommandeSql.Parameters["wid"].Value = wid;
                unecommandeSql.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                unecommandeSql.Parameters["wnom"].Value = wnom;

                if (wnom.Equals(""))
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
        public void deleteEmprunteur(String nomprocedure, int wid,String wmotif)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {

                MySqlCommand unecommandeSql = new MySqlCommand();
                unecommandeSql.CommandText = nomprocedure;
                unecommandeSql.CommandType = CommandType.StoredProcedure;
                unecommandeSql.Connection = uneconnexion.getConnexion();


                unecommandeSql.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                unecommandeSql.Parameters["wid"].Value = wid;
                unecommandeSql.Parameters.Add(new MySqlParameter("wmotif", MySqlDbType.String));
                unecommandeSql.Parameters["wmotif"].Value = wmotif;
                unecommandeSql.ExecuteNonQuery();
                uneconnexion.closeConnexion();
            }
        }


        //Exécute la procédure d'ajout d'un chef de famille
        public void InsertFamille(String nomprocedure, int widres, int widdep)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {

                MySqlCommand unecommandeSql = new MySqlCommand();
                unecommandeSql.CommandText = nomprocedure;
                unecommandeSql.CommandType = CommandType.StoredProcedure;
                unecommandeSql.Connection = uneconnexion.getConnexion();


                unecommandeSql.Parameters.Add(new MySqlParameter("widres", MySqlDbType.Int32));
                unecommandeSql.Parameters["widres"].Value = widres;
                unecommandeSql.Parameters.Add(new MySqlParameter("widdep", MySqlDbType.Int32));
                unecommandeSql.Parameters["widdep"].Value = widdep;
                unecommandeSql.ExecuteNonQuery();
                uneconnexion.closeConnexion();
            }
        }

        //Exécute la procédure de modification d'un chef de famille
        public void UpdateFamille(String nomprocedure, int widres, int widdep, int ancienresp)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {

                MySqlCommand unecommandeSql = new MySqlCommand();
                unecommandeSql.CommandText = nomprocedure;
                unecommandeSql.CommandType = CommandType.StoredProcedure;
                unecommandeSql.Connection = uneconnexion.getConnexion();

                //Les paramétres
                unecommandeSql.Parameters.Add(new MySqlParameter("widres", MySqlDbType.Int32));
                unecommandeSql.Parameters["widres"].Value = widres;
                unecommandeSql.Parameters.Add(new MySqlParameter("widdep", MySqlDbType.Int16));
                unecommandeSql.Parameters["widdep"].Value = widdep;
                unecommandeSql.Parameters.Add(new MySqlParameter("wancienresp", MySqlDbType.Int16));
                unecommandeSql.Parameters["wancienresp"].Value = ancienresp;
                unecommandeSql.ExecuteNonQuery();
                uneconnexion.closeConnexion();
            }
        }

        //Exécute la procédure pour récuperer le responsable famille
        public int cheffamille(int wid)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EmprunteurSql = new MySqlCommand();
                //Nom procedure
                EmprunteurSql.CommandText = "proc_affiche_famille";
                EmprunteurSql.CommandType = CommandType.StoredProcedure;
                EmprunteurSql.Connection = uneconnexion.getConnexion();
                EmprunteurSql.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                EmprunteurSql.Parameters["wid"].Value = wid;
                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("wafamille", MySqlDbType.Int16);
                EmprunteurSql.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;
                //aunefamille = Convert.ToInt16(PSortie_nat.Value.ToString());
                //EmprunteurSql.ExecuteNonQuery();
                _unReader = EmprunteurSql.ExecuteReader();

                

                while (_unReader.Read())
                {
                    chef = int.Parse(_unReader["fam_emp_resp"].ToString()); ;
                }
                _unReader.Close();
                uneconnexion.closeConnexion();
            }
           return chef;
        }

        //Exécute la procédure pour récuper la table emprunteur
        public void Recup_Toutelafamille(int wid)
        {

            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EmprunteurSql = new MySqlCommand();
                //Nom procedure
                EmprunteurSql.CommandText = "proc_afficher_famillecomplet";
                EmprunteurSql.CommandType = CommandType.StoredProcedure;
                EmprunteurSql.Connection = uneconnexion.getConnexion();
                EmprunteurSql.Parameters.Add(new MySqlParameter("widres", MySqlDbType.Int32));
                EmprunteurSql.Parameters["widres"].Value = wid;
                _unReader = EmprunteurSql.ExecuteReader();

                while (_unReader.Read())
                {
                    _desfamilles.Add(new Famille(int.Parse(_unReader["emp_num"].ToString()), _unReader["emp_nom"].ToString(), _unReader["emp_prenom"].ToString(), _unReader["emp_rue"].ToString(), _unReader["emp_code_postal"].ToString(), _unReader["emp_ville"].ToString(), DateTime.Parse(_unReader["emp_date_naiss"].ToString()), _unReader["emp_mail"].ToString(), int.Parse(_unReader["fam_emp_resp"].ToString())));
                }
                _unReader.Close();
                uneconnexion.closeConnexion();
            }
        }


        //Exécute la procédure de modification d'un chef de famille
        public void DeleteMembreFamille(String nomprocedure, int wid)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {

                MySqlCommand unecommandeSql = new MySqlCommand();
                unecommandeSql.CommandText = nomprocedure;
                unecommandeSql.CommandType = CommandType.StoredProcedure;
                unecommandeSql.Connection = uneconnexion.getConnexion();

                //Les paramétres
                unecommandeSql.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                unecommandeSql.Parameters["wid"].Value = wid;
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

        //Accesseur de la liste Emprunteur
        public List<Famille> lesfamilles
        {
            get { return _desfamilles; }
            set { _desfamilles = value; }
        }
        #endregion
    }

}
