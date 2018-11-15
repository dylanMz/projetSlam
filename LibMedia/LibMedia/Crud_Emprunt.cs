using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibMedia
{
    public class Crud_Emprunt
    {

        private ConnexionBase laConnexion;
        private MySqlCommand uneCmdSql;

        public Crud_Emprunt()
        {
            laConnexion = new ConnexionBase();
        }

        public ConnexionBase getConnect()
        {
            return laConnexion;
        }

        #region Methodes

        public String verifEmprunt(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "verif_exist_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("numEmp", MySqlDbType.Int16));  // c'est deux ligne pour chaque parametre de la procedure
            uneCmdSql.Parameters["numEmp"].Value = unEmprunt.numEmp;
            uneCmdSql.Parameters.Add(new MySqlParameter("refEx", MySqlDbType.String));
            uneCmdSql.Parameters["refEx"].Value = unEmprunt.refEx;
            MySqlParameter PSortie_nat = new MySqlParameter("ret", MySqlDbType.String);
            uneCmdSql.Parameters.Add(PSortie_nat);
            PSortie_nat.Direction = ParameterDirection.Output;
            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion

            return PSortie_nat.Value.ToString();
        }

        public void insertEmprunt(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_insert_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("NumEmp", MySqlDbType.Int16));  // c'est deux ligne pour chaque parametre de la procedure
            uneCmdSql.Parameters["NumEmp"].Value = unEmprunt.numEmp;
            uneCmdSql.Parameters.Add(new MySqlParameter("RefEx", MySqlDbType.String));
            uneCmdSql.Parameters["RefEx"].Value = unEmprunt.refEx;
            uneCmdSql.Parameters.Add(new MySqlParameter("dateEmp", MySqlDbType.Date));
            uneCmdSql.Parameters["dateEmp"].Value = unEmprunt.dateEmp;
            uneCmdSql.Parameters.Add(new MySqlParameter("dateRetPrev", MySqlDbType.Date));
            uneCmdSql.Parameters["dateRetPrev"].Value = unEmprunt.dateRetourPrevu;
            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion

        }

        public void updateEmprunt(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_update_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("numEmp", MySqlDbType.Int16));  // c'est deux ligne pour chaque parametre de la procedure
            uneCmdSql.Parameters["numEmp"].Value = unEmprunt.numEmp;
            uneCmdSql.Parameters.Add(new MySqlParameter("refEx", MySqlDbType.String));
            uneCmdSql.Parameters["refEx"].Value = unEmprunt.refEx;
            uneCmdSql.Parameters.Add(new MySqlParameter("dateEmp", MySqlDbType.Date));
            uneCmdSql.Parameters["dateEmp"].Value = unEmprunt.dateEmp;
            uneCmdSql.Parameters.Add(new MySqlParameter("dateRet", MySqlDbType.Date));
            uneCmdSql.Parameters["dateRet"].Value = unEmprunt.dateRetour;
            uneCmdSql.Parameters.Add(new MySqlParameter("dateRetPrevu", MySqlDbType.Date));
            uneCmdSql.Parameters["dateRetPrevu"].Value = unEmprunt.dateRetourPrevu; 
            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion
        }

        public void deleteEmprunt(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_delete_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("numEmp", MySqlDbType.Int16));  // c'est deux ligne pour chaque parametre de la procedure
            uneCmdSql.Parameters["numEmp"].Value = unEmprunt.numEmp;
            uneCmdSql.Parameters.Add(new MySqlParameter("refEx", MySqlDbType.String));
            uneCmdSql.Parameters["refEx"].Value = unEmprunt.refEx;
            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion
        }

        public DataTable afficheEmprunt()
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_affiche_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();

            MySqlDataAdapter unAdapter = new MySqlDataAdapter(uneCmdSql);
            DataSet unDataset = new DataSet();
            DataTable uneTable;
            uneTable = new DataTable();
            unAdapter.Fill(unDataset, "emprunter");
            uneTable = unDataset.Tables["emprunter"];

            laConnexion.closeConnexion();

            return uneTable;

        }


        public void modifDate_Retour(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_modif_date_retour_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("numEmp", MySqlDbType.Int16));  // c'est deux ligne pour chaque parametre de la procedure
            uneCmdSql.Parameters["numEmp"].Value = unEmprunt.numEmp;
            uneCmdSql.Parameters.Add(new MySqlParameter("refEx", MySqlDbType.String));
            uneCmdSql.Parameters["refEx"].Value = unEmprunt.refEx;
            uneCmdSql.Parameters.Add(new MySqlParameter("dateRet", MySqlDbType.Date));
            uneCmdSql.Parameters["dateRet"].Value = unEmprunt.dateRetour;
            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion
        }

        public DataTable rechercheDate_Emprunt(DateTime uneDate)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_recherche_date_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("dateEmp", MySqlDbType.Date));
            uneCmdSql.Parameters["dateEmp"].Value = uneDate;

            MySqlDataAdapter unAdapter = new MySqlDataAdapter(uneCmdSql);
            DataSet unDataset = new DataSet();
            DataTable uneTable;
            uneTable = new DataTable();
            unAdapter.Fill(unDataset, "date_emprunt");
            uneTable = unDataset.Tables["date_emprunt"];

            laConnexion.closeConnexion();

            return uneTable;
        }

        public DataTable rechercheEmprunt(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_recherche_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("RefExemp", MySqlDbType.String));  // c'est deux ligne pour chaque parametre de la procedure
            uneCmdSql.Parameters["RefExemp"].Value = unEmprunt.refEx;
            uneCmdSql.Parameters.Add(new MySqlParameter("NumEmp", MySqlDbType.String));
            uneCmdSql.Parameters["NumEmp"].Value = unEmprunt.numEmp;

            MySqlDataAdapter unAdapter = new MySqlDataAdapter(uneCmdSql);
            DataSet unDataset = new DataSet();
            DataTable uneTable;
            uneTable = new DataTable();
            unAdapter.Fill(unDataset, "Emprunt");
            uneTable = unDataset.Tables["Emprunt"];

            laConnexion.closeConnexion();

            return uneTable;
        }

        

        public DataTable rechercheNonRendu(DateTime uneDate)
        {

            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_recherche_non_rendu_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("dateD", MySqlDbType.Date));  // c'est deux ligne pour chaque parametre de la procedure
            uneCmdSql.Parameters["dateD"].Value = uneDate;

            MySqlDataAdapter unAdapter = new MySqlDataAdapter(uneCmdSql);
            DataSet unDataset = new DataSet();
            DataTable uneTable;
            uneTable = new DataTable();
            unAdapter.Fill(unDataset, "NonRendu");
            uneTable = unDataset.Tables["NonRendu"];

            laConnexion.closeConnexion();

            return uneTable;
        }




        #endregion

    }
}
