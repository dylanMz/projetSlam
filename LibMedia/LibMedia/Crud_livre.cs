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
        public Crud_livre(ConnexionBase connexion_en_cours)
        {
            _connexion = connexion_en_cours;
        }

        public Crud_livre()
        {
            _connexion = new ConnexionBase();
        }
        #endregion

        #region Livre
        // Insertion d'un livre
        public void ajout_livre(String wbdtitre, String wbdisbn, String wbdcouleur, int wbdnumtome, String wbdanneeparution, String wbdformat, int wbdpages, String wbdcommentaires, int wedicode, int wseriecode)
        {
         

                _connexion.OuvrirConnexion();
                //  ouverture de la connexion avec la base

                MySqlCommand unComdeSql = new MySqlCommand();
                    unComdeSql.CommandText = "proc_insert_livre";
                    unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                    unComdeSql.Connection = _connexion.getConnexion();

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

                    unComdeSql.Parameters.Add(new MySqlParameter("editeur", MySqlDbType.Int16));
                    unComdeSql.Parameters["editeur"].Value = wedicode;

                    unComdeSql.Parameters.Add(new MySqlParameter("serie", MySqlDbType.Int16));
                    unComdeSql.Parameters["serie"].Value = wseriecode;


                    unComdeSql.ExecuteNonQuery();

                    _connexion.closeConnexion();


                } 


        // modification livre
        public void update_livre(int wbdcode, String wbdtitre, String wbdisbn, String wbdcouleur, int wbdnumtome, String wbdanneeparution, String wbdformat, int wbdpages, String wbdcommentaires, int wedicode, int wseriecode)
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

                unComdeSql.Parameters.Add(new MySqlParameter("editeur", MySqlDbType.Int16));
                unComdeSql.Parameters["editeur"].Value = wedicode;

                unComdeSql.Parameters.Add(new MySqlParameter("serie", MySqlDbType.Int16));
                unComdeSql.Parameters["serie"].Value = wseriecode;


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


       
        #endregion





    }
}

 