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
        #endregion


       // Insertion d'un livre
        public void ajout_livre(String wTitre, String wIsbn, String wCouleur, int wTome, String wParution, String wFormat, int wNbpage, String wCommentaire, int wedinum, int wserienum)
        {
            if (_connexion.OuvrirConnexion() == true) {
                

                    //  ouverture de la connexion avec la base

                    MySqlCommand unComdeSql = new MySqlCommand();
                    unComdeSql.CommandText = "proc_insert_livre";
                    unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                    unComdeSql.Connection = _connexion.getConnexion();

                    unComdeSql.Parameters.Add(new MySqlParameter("titre", MySqlDbType.String));
                    unComdeSql.Parameters["titre"].Value = wTitre;

                    unComdeSql.Parameters.Add(new MySqlParameter("nisbn", MySqlDbType.String));
                    unComdeSql.Parameters["nisbn"].Value = wIsbn;

                    unComdeSql.Parameters.Add(new MySqlParameter("couleur", MySqlDbType.String));
                    unComdeSql.Parameters["couleur"].Value = wCouleur;

                    unComdeSql.Parameters.Add(new MySqlParameter("ntome", MySqlDbType.String));
                    unComdeSql.Parameters["ntome"].Value = wTome;

                    unComdeSql.Parameters.Add(new MySqlParameter("anneparution", MySqlDbType.String));
                    unComdeSql.Parameters["anneparution"].Value = wParution;

                    unComdeSql.Parameters.Add(new MySqlParameter("format", MySqlDbType.String));
                    unComdeSql.Parameters["format"].Value = wFormat;

                    unComdeSql.Parameters.Add(new MySqlParameter("nbrpage", MySqlDbType.String));
                    unComdeSql.Parameters["nbrpage"].Value = wNbpage;

                    unComdeSql.Parameters.Add(new MySqlParameter("commetaire", MySqlDbType.String));
                    unComdeSql.Parameters["commetaire"].Value = wCommentaire;

                    unComdeSql.Parameters.Add(new MySqlParameter("editeur", MySqlDbType.Int16));
                    unComdeSql.Parameters["editeur"].Value = wedinum;

                    unComdeSql.Parameters.Add(new MySqlParameter("serie", MySqlDbType.Int16));
                    unComdeSql.Parameters["serie"].Value = wserienum;


                    unComdeSql.ExecuteNonQuery();

                    _connexion.closeConnexion();


                } }


        // modification livre
        public void update_livre(int leCode, String wTitre, String wIsbn, String wCouleur, int wTome, String wParution, String wFormat, int wNbpage, String wCommentaire, int wedinum, int wserienum)
        {
            if (_connexion.OuvrirConnexion() == true)
            {

                _connexion.OuvrirConnexion();
                MySqlCommand unComdeSql = new MySqlCommand();
                unComdeSql.CommandText = "proc_update_livre";
                unComdeSql.CommandType = System.Data.CommandType.StoredProcedure;
                unComdeSql.Connection = _connexion.getConnexion();

                unComdeSql.Parameters.Add(new MySqlParameter("wcode", MySqlDbType.Int16));
                unComdeSql.Parameters["wcode"].Value = wserienum;

                unComdeSql.Parameters.Add(new MySqlParameter("titre", MySqlDbType.String));
                unComdeSql.Parameters["titre"].Value = wTitre;

                unComdeSql.Parameters.Add(new MySqlParameter("nisbn", MySqlDbType.String));
                unComdeSql.Parameters["nisbn"].Value = wIsbn;

                unComdeSql.Parameters.Add(new MySqlParameter("couleur", MySqlDbType.String));
                unComdeSql.Parameters["couleur"].Value = wCouleur;

                unComdeSql.Parameters.Add(new MySqlParameter("ntome", MySqlDbType.String));
                unComdeSql.Parameters["ntome"].Value = wTome;

                unComdeSql.Parameters.Add(new MySqlParameter("anneparution", MySqlDbType.String));
                unComdeSql.Parameters["anneparution"].Value = wParution;

                unComdeSql.Parameters.Add(new MySqlParameter("format", MySqlDbType.String));
                unComdeSql.Parameters["format"].Value = wFormat;

                unComdeSql.Parameters.Add(new MySqlParameter("nbrpage", MySqlDbType.String));
                unComdeSql.Parameters["nbrpage"].Value = wNbpage;

                unComdeSql.Parameters.Add(new MySqlParameter("commetaire", MySqlDbType.String));
                unComdeSql.Parameters["commetaire"].Value = wCommentaire;

                unComdeSql.Parameters.Add(new MySqlParameter("editeur", MySqlDbType.Int16));
                unComdeSql.Parameters["editeur"].Value = wedinum;

                unComdeSql.Parameters.Add(new MySqlParameter("serie", MySqlDbType.Int16));
                unComdeSql.Parameters["serie"].Value = wserienum;


                unComdeSql.ExecuteNonQuery();

                _connexion.closeConnexion();


            }
        }
        //affiche Livre
        public DataTable afficherlivre()
        {
            //déclaration et instanciation
            cmdsql = new MySqlCommand();
            //On associe le nom de notre procedure a cmdsql de type MySqlCommand
            cmdsql.CommandText = "proc_affiche_livre";
            cmdsql.CommandType = CommandType.StoredProcedure;
         
            cmdsql.Connection = _connexion.getConnexion();

            if (_connexion.OuvrirConnexion() == true)
            {
                unAdapter = new MySqlDataAdapter(cmdsql);
                unDataset = new DataSet();
                unAdapter.Fill(unDataset, "bd");
                _connexion.closeConnexion();
            }
            return (unDataset.Tables["bd"]);
        }


        
    }
}

 