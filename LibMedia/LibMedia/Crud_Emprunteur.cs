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
        private ConnexionBase uneconnexion;
        private List<Emprunteur> _desEmprunteurs;
        private DataSet _unDataSet;
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

        public void Recup_TableEmprunteur()
        {

            if(uneconnexion.OuvrirConnexion() == true)
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

        public void connectprocedure(String nomprocedure, ref string codeErreur, List<KeyValuePair<String, Object>> parametresString, List<KeyValuePair<DateTime, Object>> parametresDateTime)
        {
            codeErreur = "0";
            MySqlCommand unecommandeSql = new MySqlCommand();
            unecommandeSql.CommandText = nomprocedure;
            unecommandeSql.CommandType = CommandType.StoredProcedure;
            unecommandeSql.Connection = uneconnexion.getConnexion();

            foreach(KeyValuePair<String, Object> unParametre in parametresString)
            {
                unecommandeSql.Parameters.Add(new MySqlParameter(unParametre.Key, MySqlDbType.String));
                unecommandeSql.Parameters[unParametre.Key].Value = unParametre.Value;
            }

            //gestion d'erreurs 
            try
            {
                unecommandeSql.ExecuteNonQuery();
            }
            catch (MySqlException myException)
            {
                codeErreur = myException.Number.ToString();
            }

        }
        
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
