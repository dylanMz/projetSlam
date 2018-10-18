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
            uneCmdSql.Parameters.Add(new MySqlParameter("dateRetPrev", MySqlDbType.Date));
            uneCmdSql.Parameters["dateRetPrev"].Value = unEmprunt.dateRetourPrevu;
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

        public void afficheEmprunt(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_affiche_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();

            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion
        }


        public void modifDate_Retour(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_modif_date_retour";  //Nom de la rpocédure sur MySql
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

        public void rechercheDate_Emprunt(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_recherche_date_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("dateEmp", MySqlDbType.Date));
            uneCmdSql.Parameters["dateEmp"].Value = unEmprunt.dateEmp;
            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion
        }

        public void rechercheEmprunt(Emprunt unEmprunt)
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
            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion
        }

        

        public void rechercheNonRendu(Emprunt unEmprunt)
        {
            laConnexion.OuvrirConnexion();
            uneCmdSql = new MySqlCommand();
            uneCmdSql.CommandText = "proc_recherche_non_rendu_emprunt";  //Nom de la rpocédure sur MySql
            uneCmdSql.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            uneCmdSql.Connection = laConnexion.getConnexion();
            uneCmdSql.Parameters.Add(new MySqlParameter("dateD", MySqlDbType.Int16));  // c'est deux ligne pour chaque parametre de la procedure
            uneCmdSql.Parameters["dateD"].Value = unEmprunt.dateRetourPrevu;
            uneCmdSql.ExecuteNonQuery();       //Execute la requete
            laConnexion.closeConnexion();       //Ferme la connexion
        }




        #endregion

    }
}
