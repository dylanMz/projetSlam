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

            unComdeSql.Parameters.Add(new MySqlParameter("Id", MySqlDbType.Int16));
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
            unComdeSql.CommandText = "proc_update_exemplaire";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("refexemp", MySqlDbType.String));
            unComdeSql.Parameters["refexemp"].Value = WExempRef;

            unComdeSql.Parameters.Add(new MySqlParameter("etat", MySqlDbType.String));
            unComdeSql.Parameters["etat"].Value = WExempEtat;

            unComdeSql.Parameters.Add(new MySqlParameter("wcode", MySqlDbType.Int16));
            unComdeSql.Parameters["wcode"].Value = wbdcode;

            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();


        }


        // recherche exemplaire avec l'état

        public void recherche_exemplaire_etat( String WExempEtat)
        {


            _connexion.OuvrirConnexion();
            //  ouverture de la connexion avec la base

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc__exemplaire_recherche_etat";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("etat", MySqlDbType.String));
            unComdeSql.Parameters["etat"].Value = WExempEtat;

           

            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();


        }
        // recherche exemplaire avec la reference exemplaire
        public void recherche_exemplaire_ref(String WExempRef)
        {


            _connexion.OuvrirConnexion();
            //  ouverture de la connexion avec la base

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_recherche_exemp_refexemp";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("refexemp", MySqlDbType.String));
            unComdeSql.Parameters["refexemp"].Value = WExempRef;



            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();


        }
        // recherche exemplaire avec code livre
        public void recherche_exemplaire_code(int wbdcode)
        {


            _connexion.OuvrirConnexion();
            //  ouverture de la connexion avec la base

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_recherche_exemp_codelivre";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("wcode", MySqlDbType.Int16));
            unComdeSql.Parameters["wcode"].Value = wbdcode;



            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();


        }


        // supprimer un exemplaire 
        public void delete_exemplaire(String WExempRef)
        {


            _connexion.OuvrirConnexion();
            //  ouverture de la connexion avec la base

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_delete_exemplaire";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("refexemp", MySqlDbType.String));
            unComdeSql.Parameters["refexemp"].Value = WExempRef;



            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();


        }

        // ajoute un motif a l'archivage 
        public void delete_motif(String WExempReff, String wmotifexemp)
        {


            _connexion.OuvrirConnexion();
            //  ouverture de la connexion avec la base

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_update/insert_motif_ret_exemp";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("wexempref", MySqlDbType.String));
            unComdeSql.Parameters["wexempref"].Value = WExempReff;
            unComdeSql.Parameters.Add(new MySqlParameter("wmotifret", MySqlDbType.String));
            unComdeSql.Parameters["wmotifret"].Value = wmotifexemp;


            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();


        }




    }

}
