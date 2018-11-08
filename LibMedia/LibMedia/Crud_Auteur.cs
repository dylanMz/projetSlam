using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Crud_Auteur
    {
        #region propriété
        private MySqlCommand ajouterAut;
        private MySqlCommand modifierAut;
        private MySqlCommand rechercheAut;
        private MySqlCommand paysAut;
        private MySqlCommand afficheAut;
        private MySqlCommand unComdeSql;
        private MySqlDataAdapter unAdapter;
        private DataSet unDataset;
        private ConnexionBase connexion;
        #endregion

        #region constructeur
        public Crud_Auteur(ConnexionBase connexion_en_cours)
        {
            connexion = connexion_en_cours;
        }

        public List<String> CreateListPays()
        {
            List<String> ListRetour;
            ListRetour = new List<String>();
            connexion.OuvrirConnexion();
            unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_selection_pays_auteur";
            unComdeSql.CommandType = CommandType.StoredProcedure;
            unComdeSql.Connection = connexion.getConnexion();

        //    MySqlDataReader read = unComdeSql.ExecuteReader(); //Permet de lire les lignes

        //    if (read.HasRows)
        //    {
        //        while (read.Read())
        //        {
        //            ListRetour.Add(read.GetString(0));     //Instancie tout les occurences et les ajoute a la liste
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Il n'y a pas d'occurence");
        //    }

        //    return ListRetour;
        //}
        #endregion

        #region appel des procédures
        //ajout d'un auteur
        public void ajouterAuteur(String unNom, String unPrenom, String unPseudo, DateTime uneDateNaiss, DateTime uneDateDeces, String unPays, String uneBiographie)
        {
            //déclaration et instanciation
            ajouterAut = new MySqlCommand();
            //associer à la property CommandText la P.stockée
            ajouterAut.CommandText = "Proc_insert_auteur";
            //associer au type du command le fait que c’est une procédure stockée
            ajouterAut.CommandType = CommandType.StoredProcedure;
            //associer la connection du command et celle en cours
            ajouterAut.Connection = connexion.getConnexion();

            //mise en place des paramètres
            //nom
            ajouterAut.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
            ajouterAut.Parameters["wnom"].Value = unNom;
            //Prenom
            ajouterAut.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
            ajouterAut.Parameters["wprenom"].Value = unPrenom;
            //Pseudo
            ajouterAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
            ajouterAut.Parameters["wpseudo"].Value = unPseudo;
            //dateNais
            ajouterAut.Parameters.Add(new MySqlParameter("wdateNaiss", MySqlDbType.Date));
            ajouterAut.Parameters["wdateNaiss"].Value = uneDateNaiss;
            //dateDeces
            ajouterAut.Parameters.Add(new MySqlParameter("wdeces", MySqlDbType.Date));
            ajouterAut.Parameters["wdeces"].Value = uneDateDeces;
            //Pays
            ajouterAut.Parameters.Add(new MySqlParameter("wpays", MySqlDbType.String));
            ajouterAut.Parameters["wpays"].Value = unPays;
            //Biographie
            ajouterAut.Parameters.Add(new MySqlParameter("wbio", MySqlDbType.String));
            ajouterAut.Parameters["wbio"].Value = uneBiographie;
        }

        //Modifier auteur
        public void modifierAuteur(int unAuteurld, String unNom, String unPrenom, String unPseudo, DateTime uneDateNaiss, DateTime uneDateDeces, String unPays, String uneBiographie)
        {
            //déclaration et instanciation
            modifierAut = new MySqlCommand();
            //associer à la property CommandText la P.stockée
            modifierAut.CommandText = "Proc_modif_auteur";
            //associer au type du command le fait que c’est une procédure stockée
            modifierAut.CommandType = CommandType.StoredProcedure;
            //associer la connection du command et celle en cours
            modifierAut.Connection = connexion.getConnexion();

            //mise en place des paramètres
            //id
            modifierAut.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
            modifierAut.Parameters["wid"].Value = unAuteurld;
            //nom
            modifierAut.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
            modifierAut.Parameters["wnom"].Value = unNom;
            //Prenom
            modifierAut.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
            modifierAut.Parameters["wprenom"].Value = unPrenom;
            //Pseudo
            modifierAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
            modifierAut.Parameters["wpseudo"].Value = unPseudo;
            //dateNais
            modifierAut.Parameters.Add(new MySqlParameter("wdateNaiss", MySqlDbType.Date));
            modifierAut.Parameters["wdateNaiss"].Value = uneDateNaiss;
            //dateDeces
            modifierAut.Parameters.Add(new MySqlParameter("wdeces", MySqlDbType.Date));
            modifierAut.Parameters["wdeces"].Value = uneDateDeces;
            //Pays
            modifierAut.Parameters.Add(new MySqlParameter("wpays", MySqlDbType.String));
            modifierAut.Parameters["wpays"].Value = unPays;
            //Biographie
            modifierAut.Parameters.Add(new MySqlParameter("wbio", MySqlDbType.String));
            modifierAut.Parameters["wbio"].Value = uneBiographie;
        }

        //recherche_auteur
        public void rechercheAuteur(int unAuteurld, String unNom, String unPseudo)
        {
            //déclaration et instanciation
            rechercheAut = new MySqlCommand();
            //associer à la property CommandText la P.stockée
            rechercheAut.CommandText = "proc_recherche_auteur";
            //associer au type du command le fait que c’est une procédure stockée
            rechercheAut.CommandType = CommandType.StoredProcedure;
            //associer la connection du command et celle en cours
            rechercheAut.Connection = connexion.getConnexion();

            //mise en place des paramètres
            //id
            modifierAut.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
            modifierAut.Parameters["wid"].Value = unAuteurld;
            //nom
            modifierAut.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
            modifierAut.Parameters["wnom"].Value = unNom;
            //Pseudo
            modifierAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
            modifierAut.Parameters["wpseudo"].Value = unPseudo;
        }

        //pays_auteur
        public void paysAuteur()
        {
            //déclaration et instanciation
            paysAut = new MySqlCommand();
            //associer à la property CommandText la P.stockée
            paysAut.CommandText = "proc_selection_pays_auteur";
            //associer au type du command le fait que c’est une procédure stockée
            paysAut.CommandType = CommandType.StoredProcedure;
            //associer la connection du command et celle en cours
            paysAut.Connection = connexion.getConnexion();
        }

        //affiche_auteur
        public DataTable afficheAuteur()
        {
            //déclaration et instanciation
            afficheAut = new MySqlCommand();
            //associer à la property CommandText la P.stockée
            afficheAut.CommandText = "proc_affiche_auteur";
            //associer au type du command le fait que c’est une procédure stockée
            afficheAut.CommandType = CommandType.StoredProcedure;
            //associer la connection du command et celle en cours
            afficheAut.Connection = connexion.getConnexion();

            if (connexion.OuvrirConnexion() == true)
            {
                unAdapter = new MySqlDataAdapter(afficheAut);
                unDataset = new DataSet();
                unAdapter.Fill(unDataset,"auteur");
                connexion.closeConnexion();
            }
            return (unDataset.Tables["auteur"]);
        }


        #endregion
    }
}
