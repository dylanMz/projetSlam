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
        private String CodeOut;
        #endregion

        #region constructeur
        public Crud_Auteur()
        {
            connexion = new ConnexionBase();
        }

        public List<String> CreateListPays()
        {
            List<String> ListRetour;
            ListRetour = new List<String>();

            if (connexion.OuvrirConnexion() == true)
            {
                
                unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_selection_pays_auteur";
                unComdeSql.CommandType = CommandType.StoredProcedure;
                unComdeSql.Connection = connexion.getConnexion();

                MySqlDataReader read = unComdeSql.ExecuteReader(); //Permet de lire les lignes

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        //ListRetour.Add(read.GetString(0));     
                        String liste = read.GetString(0);
                        ListRetour.Add(liste); //Instancie tout les occurences et les ajoute a la liste
                    }

                }
                else
                {
                    Console.WriteLine("Il n'y a pas d'occurence");
                }

                connexion.closeConnexion();

                
            }
            return ListRetour;
        }
        #endregion

        #region appel des procédures
        //ajout d'un auteur
        public String ajouterAuteur(Auteur unAuteur)
        {
            
            if (connexion.OuvrirConnexion() == true)
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
                ajouterAut.Parameters["wnom"].Value = unAuteur._AuteurNom;
                //Prenom
                ajouterAut.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                ajouterAut.Parameters["wprenom"].Value = unAuteur._AuteurPrenom;
                //Pseudo
                ajouterAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                ajouterAut.Parameters["wpseudo"].Value = unAuteur._AuteurPseudo;
                //dateNais
                ajouterAut.Parameters.Add(new MySqlParameter("wdateNaiss", MySqlDbType.Date));
                ajouterAut.Parameters["wdateNaiss"].Value = unAuteur._DateNaissance;
                //dateDeces
                ajouterAut.Parameters.Add(new MySqlParameter("wdeces", MySqlDbType.Date));
                ajouterAut.Parameters["wdeces"].Value = unAuteur._AuteurDeces;
                //Pays
                ajouterAut.Parameters.Add(new MySqlParameter("wpays", MySqlDbType.String));
                ajouterAut.Parameters["wpays"].Value = unAuteur._AuteurPays;
                //Biographie
                ajouterAut.Parameters.Add(new MySqlParameter("wbio", MySqlDbType.String));
                ajouterAut.Parameters["wbio"].Value = unAuteur._AuteurBiographie;

                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_retour", MySqlDbType.Int16);
                ajouterAut.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                ajouterAut.ExecuteNonQuery(); //execute la requete
                connexion.closeConnexion();
                CodeOut = PSortie_nat.Value.ToString();
            }

            return CodeOut;
        }

        //Ajouter un auteur avec une date de naissance et décès null
        public String ajouterAuteurNaissNull(Auteur unAuteur)
        {
            if (connexion.OuvrirConnexion() == true)
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
                ajouterAut.Parameters["wnom"].Value = unAuteur._AuteurNom;
                //Prenom
                ajouterAut.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                ajouterAut.Parameters["wprenom"].Value = unAuteur._AuteurPrenom;
                //Pseudo
                ajouterAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                ajouterAut.Parameters["wpseudo"].Value = unAuteur._AuteurPseudo;
                //dateNais
                ajouterAut.Parameters.Add(new MySqlParameter("wdateNaiss", MySqlDbType.Date));
                ajouterAut.Parameters["wdateNaiss"].Value = null;
                //dateDeces
                ajouterAut.Parameters.Add(new MySqlParameter("wdeces", MySqlDbType.Date));
                ajouterAut.Parameters["wdeces"].Value = null;
                //Pays
                ajouterAut.Parameters.Add(new MySqlParameter("wpays", MySqlDbType.String));
                ajouterAut.Parameters["wpays"].Value = unAuteur._AuteurPays;
                //Biographie
                ajouterAut.Parameters.Add(new MySqlParameter("wbio", MySqlDbType.String));
                ajouterAut.Parameters["wbio"].Value = unAuteur._AuteurBiographie;

                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_retour", MySqlDbType.Int16);
                ajouterAut.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                ajouterAut.ExecuteNonQuery(); //execute la requete
                connexion.closeConnexion();
                CodeOut = PSortie_nat.Value.ToString();
            }
            return CodeOut;

        }

        //ajouter un uteur avec une date de nassance mais pas de date de décès
        public String ajouterAuteurDecesNull(Auteur unAuteur)
        {
            if (connexion.OuvrirConnexion() == true)
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
                ajouterAut.Parameters["wnom"].Value = unAuteur._AuteurNom;
                //Prenom
                ajouterAut.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                ajouterAut.Parameters["wprenom"].Value = unAuteur._AuteurPrenom;
                //Pseudo
                ajouterAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                ajouterAut.Parameters["wpseudo"].Value = unAuteur._AuteurPseudo;
                //dateNais
                ajouterAut.Parameters.Add(new MySqlParameter("wdateNaiss", MySqlDbType.Date));
                ajouterAut.Parameters["wdateNaiss"].Value = unAuteur._DateNaissance;
                //dateDeces
                ajouterAut.Parameters.Add(new MySqlParameter("wdeces", MySqlDbType.Date));
                ajouterAut.Parameters["wdeces"].Value = null;
                //Pays
                ajouterAut.Parameters.Add(new MySqlParameter("wpays", MySqlDbType.String));
                ajouterAut.Parameters["wpays"].Value = unAuteur._AuteurPays;
                //Biographie
                ajouterAut.Parameters.Add(new MySqlParameter("wbio", MySqlDbType.String));
                ajouterAut.Parameters["wbio"].Value = unAuteur._AuteurBiographie;

                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_code_retour", MySqlDbType.Int16);
                ajouterAut.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                ajouterAut.ExecuteNonQuery(); //execute la requete
                connexion.closeConnexion(); // Ferme la connexion
                CodeOut = PSortie_nat.Value.ToString();
            }
            return CodeOut;
        }

        //Modifier auteur
        public void modifierAuteur(Auteur unAuteur)
        {
            if (connexion.OuvrirConnexion() == true)
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
                rechercheAut.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                rechercheAut.Parameters["wid"].Value = unAuteur._Auteurld;
                //nom
                ajouterAut.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                ajouterAut.Parameters["wnom"].Value = unAuteur._AuteurNom;
                //Prenom
                ajouterAut.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                ajouterAut.Parameters["wprenom"].Value = unAuteur._AuteurPrenom;
                //Pseudo
                ajouterAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                ajouterAut.Parameters["wpseudo"].Value = unAuteur._AuteurPseudo;
                //dateNais
                ajouterAut.Parameters.Add(new MySqlParameter("wdateNaiss", MySqlDbType.Date));
                ajouterAut.Parameters["wdateNaiss"].Value = unAuteur._DateNaissance;
                //dateDeces
                ajouterAut.Parameters.Add(new MySqlParameter("wdeces", MySqlDbType.Date));
                ajouterAut.Parameters["wdeces"].Value = unAuteur._AuteurDeces;
                //Pays
                ajouterAut.Parameters.Add(new MySqlParameter("wpays", MySqlDbType.String));
                ajouterAut.Parameters["wpays"].Value = unAuteur._AuteurPays;
                //Biographie
                ajouterAut.Parameters.Add(new MySqlParameter("wbio", MySqlDbType.String));
                ajouterAut.Parameters["wbio"].Value = unAuteur._AuteurBiographie;

                modifierAut.ExecuteNonQuery(); //execute la requete
                connexion.closeConnexion(); // Ferme la connexion
            }
                
        }

        //modification d'un auteur avec une date de naissance null
        public void modifierAuteurNaissNull(Auteur unAuteur)
        {
            if (connexion.OuvrirConnexion() == true)
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
                rechercheAut.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                rechercheAut.Parameters["wid"].Value = unAuteur._Auteurld;
                //nom
                ajouterAut.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                ajouterAut.Parameters["wnom"].Value = unAuteur._AuteurNom;
                //Prenom
                ajouterAut.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                ajouterAut.Parameters["wprenom"].Value = unAuteur._AuteurPrenom;
                //Pseudo
                ajouterAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                ajouterAut.Parameters["wpseudo"].Value = unAuteur._AuteurPseudo;
                //dateNais
                ajouterAut.Parameters.Add(new MySqlParameter("wdateNaiss", MySqlDbType.Date));
                ajouterAut.Parameters["wdateNaiss"].Value = null;
                //dateDeces
                ajouterAut.Parameters.Add(new MySqlParameter("wdeces", MySqlDbType.Date));
                ajouterAut.Parameters["wdeces"].Value = null;
                //Pays
                ajouterAut.Parameters.Add(new MySqlParameter("wpays", MySqlDbType.String));
                ajouterAut.Parameters["wpays"].Value = unAuteur._AuteurPays;
                //Biographie
                ajouterAut.Parameters.Add(new MySqlParameter("wbio", MySqlDbType.String));
                ajouterAut.Parameters["wbio"].Value = unAuteur._AuteurBiographie;

                modifierAut.ExecuteNonQuery(); //execute la requete
                connexion.closeConnexion(); // Ferme la connexion
            }

        }

        //Modification auteur avec une date de décès null
        public void modifierAuteurDecesNull(Auteur unAuteur)
        {
            if (connexion.OuvrirConnexion() == true)
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
                rechercheAut.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                rechercheAut.Parameters["wid"].Value = unAuteur._Auteurld;
                //nom
                ajouterAut.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                ajouterAut.Parameters["wnom"].Value = unAuteur._AuteurNom;
                //Prenom
                ajouterAut.Parameters.Add(new MySqlParameter("wprenom", MySqlDbType.String));
                ajouterAut.Parameters["wprenom"].Value = unAuteur._AuteurPrenom;
                //Pseudo
                ajouterAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                ajouterAut.Parameters["wpseudo"].Value = unAuteur._AuteurPseudo;
                //dateNais
                ajouterAut.Parameters.Add(new MySqlParameter("wdateNaiss", MySqlDbType.Date));
                ajouterAut.Parameters["wdateNaiss"].Value = unAuteur._DateNaissance;
                //dateDeces
                ajouterAut.Parameters.Add(new MySqlParameter("wdeces", MySqlDbType.Date));
                ajouterAut.Parameters["wdeces"].Value = null;
                //Pays
                ajouterAut.Parameters.Add(new MySqlParameter("wpays", MySqlDbType.String));
                ajouterAut.Parameters["wpays"].Value = unAuteur._AuteurPays;
                //Biographie
                ajouterAut.Parameters.Add(new MySqlParameter("wbio", MySqlDbType.String));
                ajouterAut.Parameters["wbio"].Value = unAuteur._AuteurBiographie;

                modifierAut.ExecuteNonQuery(); //execute la requete
                connexion.closeConnexion(); // Ferme la connexion
            }

        }

        //recherche_auteur
        public void rechercheAuteur(Auteur unAuteur)
        {
            if (connexion.OuvrirConnexion() == true)
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
                //id
                rechercheAut.Parameters.Add(new MySqlParameter("wid", MySqlDbType.Int32));
                rechercheAut.Parameters["wid"].Value = unAuteur._Auteurld;
                //nom
                ajouterAut.Parameters.Add(new MySqlParameter("wnom", MySqlDbType.String));
                ajouterAut.Parameters["wnom"].Value = unAuteur._AuteurNom;
                //Pseudo
                rechercheAut.Parameters.Add(new MySqlParameter("wpseudo", MySqlDbType.String));
                rechercheAut.Parameters["wpseudo"].Value = unAuteur._AuteurPseudo;

                //mise en place du paramètre de sortie
                MySqlParameter PSortie_nat = new MySqlParameter("out_type_req", MySqlDbType.Int16);
                rechercheAut.Parameters.Add(PSortie_nat);
                PSortie_nat.Direction = ParameterDirection.Output;

                rechercheAut.ExecuteNonQuery(); //execute la requete
                connexion.closeConnexion(); // Ferme la connexion
            }
            
        }

        //affiche_auteur
        public DataTable afficheAuteur()
        {
            if (connexion.OuvrirConnexion() == true)
            {
                //déclaration et instanciation
                afficheAut = new MySqlCommand();
                //associer à la property CommandText la P.stockée
                afficheAut.CommandText = "proc_affiche_auteur";
                //associer au type du command le fait que c’est une procédure stockée
                afficheAut.CommandType = CommandType.StoredProcedure;
                //associer la connection du command et celle en cours
                afficheAut.Connection = connexion.getConnexion();

            
                    unAdapter = new MySqlDataAdapter(afficheAut);
                    unDataset = new DataSet();
                    unAdapter.Fill(unDataset, "auteur");

                    connexion.closeConnexion();
                
                                
            }
            return (unDataset.Tables["auteur"]);
        }


        #endregion
    }
}
