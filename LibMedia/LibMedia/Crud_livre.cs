using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibMedia
{
    public class Crud_livre
    {

        #region propriété
        private MySqlCommand cmdsql;
 
        private MySqlDataAdapter unAdapter;
        private DataSet unDataset;
        private ConnexionBase _connexion;

        #endregion

        #region constructeur
       

        public Crud_livre()
        {
            _connexion = new ConnexionBase();
        }
        #endregion

        #region Livre
        // Insertion d'un livre

        public void ajout_livre(Livre unlivre,String wEd,String WSer )
        {
         

                _connexion.OuvrirConnexion();
                //  ouverture de la connexion avec la base

                MySqlCommand unComdeSql = new MySqlCommand();
                    unComdeSql.CommandText = "proc_insert_livre";
                    unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                    unComdeSql.Connection = _connexion.getConnexion();

                    unComdeSql.Parameters.Add(new MySqlParameter("titre", MySqlDbType.String));
                    unComdeSql.Parameters["titre"].Value = unlivre.wbd_titre;

                    unComdeSql.Parameters.Add(new MySqlParameter("nisbn", MySqlDbType.String));
                    unComdeSql.Parameters["nisbn"].Value = unlivre.wisbn;

                    unComdeSql.Parameters.Add(new MySqlParameter("couleur", MySqlDbType.String));
                    unComdeSql.Parameters["couleur"].Value = unlivre.wcouleur;

                    unComdeSql.Parameters.Add(new MySqlParameter("ntome", MySqlDbType.Int32));
                    unComdeSql.Parameters["ntome"].Value = unlivre.Wbd_num_tome;

                    unComdeSql.Parameters.Add(new MySqlParameter("anneparution", MySqlDbType.String));
                    unComdeSql.Parameters["anneparution"].Value = unlivre.wbd_annee_parution;

                    unComdeSql.Parameters.Add(new MySqlParameter("format", MySqlDbType.String));
                    unComdeSql.Parameters["format"].Value = unlivre.wFormat;

                    unComdeSql.Parameters.Add(new MySqlParameter("nbrpage", MySqlDbType.String));
                    unComdeSql.Parameters["nbrpage"].Value = unlivre.wpages;

                    unComdeSql.Parameters.Add(new MySqlParameter("commetaire", MySqlDbType.String));
                    unComdeSql.Parameters["commetaire"].Value = unlivre.wcommentaires;

                    unComdeSql.Parameters.Add(new MySqlParameter("wediteur", MySqlDbType.String));
                    unComdeSql.Parameters["wediteur"].Value = wEd;

                    unComdeSql.Parameters.Add(new MySqlParameter("wserie", MySqlDbType.String));
                   unComdeSql.Parameters["wserie"].Value = WSer;


                    unComdeSql.ExecuteNonQuery();

                    _connexion.closeConnexion();


                }

        // insertion participer
        public void insert_participer(String wlauteur  ,int letype)
        {

            _connexion.OuvrirConnexion();

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_insert_Participer";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

       
            unComdeSql.Parameters.Add(new MySqlParameter("wauteur", MySqlDbType.String));
            unComdeSql.Parameters["wauteur"].Value = wlauteur;
            unComdeSql.Parameters.Add(new MySqlParameter("wtype", MySqlDbType.Int16));
            unComdeSql.Parameters["wtype"].Value = letype;

            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();
        }

        // modification livre
        public void update_livre(int wbdcode, String wbdtitre, String wbdisbn, String wbdcouleur, int wbdnumtome, String wbdanneeparution, String wbdformat, int wbdpages, String wbdcommentaires, String wedicode, String wseriecode)
        {
          

                _connexion.OuvrirConnexion();
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_update_livre";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = _connexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wcode", MySqlDbType.Int16));
                unComdeSql.Parameters["wcode"].Value = wbdcode;

                unComdeSql.Parameters.Add(new MySqlParameter("titre", MySqlDbType.String));
                unComdeSql.Parameters["titre"].Value = wbdtitre;

                unComdeSql.Parameters.Add(new MySqlParameter("nisbn", MySqlDbType.String));
                unComdeSql.Parameters["nisbn"].Value = wbdisbn;

                unComdeSql.Parameters.Add(new MySqlParameter("couleur", MySqlDbType.String));
                unComdeSql.Parameters["couleur"].Value = wbdcouleur;

                unComdeSql.Parameters.Add(new MySqlParameter("ntome", MySqlDbType.String));
                unComdeSql.Parameters["ntome"].Value = wbdnumtome;

                unComdeSql.Parameters.Add(new MySqlParameter("anneparution", MySqlDbType.String));
                unComdeSql.Parameters["anneparution"].Value = wbdanneeparution;

                unComdeSql.Parameters.Add(new MySqlParameter("format", MySqlDbType.String));
                unComdeSql.Parameters["format"].Value = wbdformat;

                unComdeSql.Parameters.Add(new MySqlParameter("nbrpage", MySqlDbType.String));
                unComdeSql.Parameters["nbrpage"].Value = wbdpages;

                unComdeSql.Parameters.Add(new MySqlParameter("commetaire", MySqlDbType.String));
                unComdeSql.Parameters["commetaire"].Value = wbdcommentaires;

                unComdeSql.Parameters.Add(new MySqlParameter("wediteur", MySqlDbType.String));
                unComdeSql.Parameters["wediteur"].Value = wedicode;

                unComdeSql.Parameters.Add(new MySqlParameter("wserie", MySqlDbType.String));
                unComdeSql.Parameters["wserie"].Value = wseriecode;


                unComdeSql.ExecuteNonQuery();

                _connexion.closeConnexion();


        }
        //supprime Livre

        public void Delete_livre(int leCode)
        {
          
                _connexion.OuvrirConnexion();

                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_delete_livre";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = _connexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wcode", MySqlDbType.Int16));
                unComdeSql.Parameters["wcode"].Value = leCode;

                unComdeSql.ExecuteNonQuery();

                _connexion.closeConnexion();
        }
        // ajout d'un motif dans archivage en meme temps que la sup
        public void delet_motif(String wmotif, int leCode)
        {
            _connexion.OuvrirConnexion();

            MySqlCommand unComdeSql = new MySqlCommand();
            unComdeSql.CommandText = "proc_upadate/insert_motif_ret_bd";
            unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
            unComdeSql.Connection = _connexion.getConnexion();

            unComdeSql.Parameters.Add(new MySqlParameter("wmotifret", MySqlDbType.String));
            unComdeSql.Parameters["wmotifret"].Value = leCode;
            unComdeSql.Parameters.Add(new MySqlParameter("wcode", MySqlDbType.Int16));
            unComdeSql.Parameters["wcode"].Value = leCode;
            unComdeSql.ExecuteNonQuery();

            _connexion.closeConnexion();
        }



            public DataTable afficherlivre()
        {
            //déclaration et instanciation
            cmdsql = new MySqlCommand();
            //On associe le nom de notre procedure a cmdsql de type MySqlCommand
            cmdsql.CommandText = "proc_affiche_livre";
            cmdsql.CommandType = CommandType.StoredProcedure;
         
            cmdsql.Connection = _connexion.getConnexion();

            

                unAdapter = new MySqlDataAdapter(cmdsql);
                unDataset = new DataSet();
                unAdapter.Fill(unDataset, "bd");
                _connexion.closeConnexion();
          

        
            return (unDataset.Tables["bd"]);
          
        }







        public DataTable recherche_livre(String wbdtitre,String wbdanneeparution)
        {
            //déclaration et instanciation
            cmdsql = new MySqlCommand();
            //On associe le nom de notre procedure a cmdsql de type MySqlCommand
            cmdsql.CommandText = "proc_recherche_livre";
            cmdsql.CommandType = System.Data.CommandType.StoredProcedure;
            cmdsql.Connection = _connexion.getConnexion();

            cmdsql.Parameters.Add(new MySqlParameter("wtitre", MySqlDbType.String));
            cmdsql.Parameters["wtitre"].Value = wbdtitre;
            cmdsql.Parameters.Add(new MySqlParameter("wparution", MySqlDbType.String));
            cmdsql.Parameters["wparution"].Value = wbdanneeparution;

         
                unAdapter = new MySqlDataAdapter(cmdsql);
                unDataset = new DataSet();
                unAdapter.Fill(unDataset, "bd");
                _connexion.closeConnexion();
        
            return (unDataset.Tables["bd"]);
        
        }
        #region procedure pour remplir les combo box
public List<String> affiche_nomauteur()
        {
            List<String> ListRetourauteur;
            ListRetourauteur = new List<String>();
            _connexion.OuvrirConnexion();

            cmdsql = new MySqlCommand();
            cmdsql.CommandText = "proc_affiche_nomauteur";
            cmdsql.CommandType = CommandType.StoredProcedure;
            cmdsql.Connection = _connexion.getConnexion();

            MySqlDataReader read = cmdsql.ExecuteReader(); //Permet de lire les lignes

            if (read.HasRows)
            {
                while (read.Read())
                {
                    string L1 = read.GetString(0);
                    ListRetourauteur.Add(L1);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas d'occurence");
            }
            _connexion.closeConnexion();
            return ListRetourauteur;
           
        }


        public List<String> affiche_nomediteur()
        {
            List<String> ListRetourediteur;
            ListRetourediteur = new List<String>();
            _connexion.OuvrirConnexion();

            cmdsql = new MySqlCommand();
            cmdsql.CommandText = "proc_affiche_nomediteur";
            cmdsql.CommandType = CommandType.StoredProcedure;
            cmdsql.Connection = _connexion.getConnexion();

            MySqlDataReader read = cmdsql.ExecuteReader(); //Permet de lire les lignes

            if (read.HasRows)
            {
                while (read.Read())
                {
                    string L1 = read.GetString(0);
                    ListRetourediteur.Add(L1);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas d'occurence");
            }
            _connexion.closeConnexion();
            return ListRetourediteur;

        }

        public List<String> affiche_nomserie()
        {
            List<String> ListRetourserie;
            ListRetourserie = new List<String>();
            _connexion.OuvrirConnexion();

            cmdsql = new MySqlCommand();
            cmdsql.CommandText = "proc_affiche_nomserie";
            cmdsql.CommandType = CommandType.StoredProcedure;
            cmdsql.Connection = _connexion.getConnexion();

            MySqlDataReader read = cmdsql.ExecuteReader(); //Permet de lire les lignes

            if (read.HasRows)
            {
                while (read.Read())
                {
                    string L1 = read.GetString(0);
                    ListRetourserie.Add(L1);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas d'occurence");
            }
            _connexion.closeConnexion();
            return ListRetourserie;

        }

        #endregion




        #endregion






    }
}

 