using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Crud_Famille
    {
        #region Proprietés
        private int chef;
        private ConnexionBase uneconnexion;
        private List<Famille> _desfamilles;
        private MySqlDataReader _unReader;
        #endregion

        #region Constructeur

        public Crud_Famille(ConnexionBase connexion_en_cours)
        {
            uneconnexion = connexion_en_cours;
            _desfamilles = new List<Famille>();

        }
        public Crud_Famille()
        {
            uneconnexion = new ConnexionBase();
            _desfamilles = new List<Famille>();
        }

        #endregion


        #region methodes
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
        public int cheffamille(Famille numFamille)
        {
            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EmprunteurSql = new MySqlCommand();
                //Nom procedure
                EmprunteurSql.CommandText = "proc_affiche_famille";
                EmprunteurSql.CommandType = CommandType.StoredProcedure;
                EmprunteurSql.Connection = uneconnexion.getConnexion();
                EmprunteurSql.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                EmprunteurSql.Parameters["wid"].Value = numFamille.Numéro;
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

        //Exécute la procédure pour récuperer la famille de l'emprunteur 
        public void Recup_Toutelafamille(Famille lafamille)
        {

            if (uneconnexion.OuvrirConnexion() == true)
            {
                MySqlCommand EmprunteurSql = new MySqlCommand();
                //Nom procedure
                EmprunteurSql.CommandText = "proc_afficher_famillecomplet";
                EmprunteurSql.CommandType = CommandType.StoredProcedure;
                EmprunteurSql.Connection = uneconnexion.getConnexion();
                EmprunteurSql.Parameters.Add(new MySqlParameter("widres", MySqlDbType.Int32));
                EmprunteurSql.Parameters["widres"].Value = lafamille.Numéro;
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

        //Accesseur de la liste Famille
        public List<Famille> lesfamilles
        {
            get { return _desfamilles; }
            set { _desfamilles = value; }
        }
        #endregion
    }
}
