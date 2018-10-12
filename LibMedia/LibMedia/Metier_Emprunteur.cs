using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Metier_Emprunteur
    {
        #region Proprietés
        private ConnexionBase uneconnexion;
        private List<Emprunteur> _desEmprunteurs;
        private DataSet _unDataSet;
        private MySqlDataReader _unReader;
        private String test;
        #endregion

        #region Constructeur

        public Metier_Emprunteur(ConnexionBase connexion_en_cours)
        {
            uneconnexion = connexion_en_cours;
            _desEmprunteurs = new List<Emprunteur>();

        }
        public Metier_Emprunteur()
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
                EmprunteurSql.CommandText = "Afficher_Emprunteur";
                EmprunteurSql.CommandType = CommandType.StoredProcedure;
                EmprunteurSql.Connection = uneconnexion.getConnexion();
                _unReader = EmprunteurSql.ExecuteReader();

               while (_unReader.Read())
                {
                    _desEmprunteurs.Add(new Emprunteur(int.Parse(_unReader["emp_num"].ToString()), _unReader["emp_nom"].ToString(), _unReader["emp_prenom"].ToString(), _unReader["emp_rue"].ToString(), _unReader["emp_code_postal"].ToString(), _unReader["emp_ville"].ToString(), DateTime.Parse(_unReader["emp_date_naiss"].ToString()), _unReader["emp_mail"].ToString(), DateTime.Parse(_unReader["emp_prem_adh"].ToString()), DateTime.Parse(_unReader["emp_ren_adh"].ToString())));
                }
                uneconnexion.closeConnexion();
            }
        }
        //test
        #region Accesseur

        public List<Emprunteur> lesEmprunteurs
        {
            get { return _desEmprunteurs; }
            set { _desEmprunteurs = value; }
        }

        #endregion

    }
}
