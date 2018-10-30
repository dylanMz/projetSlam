using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class CRUD_Exemplaire
    {

        #region propriété
        private MySqlCommand cmdsql;

        private MySqlDataAdapter unAdapter;
        private DataSet unDataset;
        private ConnexionBase _connexion;
        #endregion

        #region constructeur
        public CRUD_Exemplaire(ConnexionBase connexion_en_cours)
        {
            _connexion = connexion_en_cours;
        }

        public CRUD_Exemplaire()
        {
            _connexion = new ConnexionBase();
        }
        #endregion

        // Insertion d'un exemplaire
        public void ajout_exemplaire(String WExempRef, String WExempEtat, int wbdcode)
        {


            _connexion.OuvrirConnexion();
            //  ouverture de la connexion avec la base

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_insert_exemplaire";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("refexemp", MySqlDbType.String));
            unComdeSql.Parameters["refexemp"].Value = WExempRef;

            unComdeSql.Parameters.Add(new MySqlParameter("etat", MySqlDbType.String));
            unComdeSql.Parameters["etat"].Value = WExempEtat;

            unComdeSql.Parameters.Add(new MySqlParameter("Id", MySqlDbType.String));
            unComdeSql.Parameters["Id"].Value = wbdcode;

            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();


        }


        // modification d'un exemplaire
        public void update_exemplaire(String WExempRef, String WExempEtat, int wbdcode)
        {


            _connexion.OuvrirConnexion();
            //  ouverture de la connexion avec la base

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_insert_exemplaire";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("refexemp", MySqlDbType.String));
            unComdeSql.Parameters["refexemp"].Value = WExempRef;

            unComdeSql.Parameters.Add(new MySqlParameter("etat", MySqlDbType.String));
            unComdeSql.Parameters["etat"].Value = WExempEtat;

            unComdeSql.Parameters.Add(new MySqlParameter("wcode", MySqlDbType.String));
            unComdeSql.Parameters["wcode"].Value = wbdcode;

            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();


        }












    }

}
