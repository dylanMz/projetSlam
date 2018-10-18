using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibMedia.LaibrairieClasses;
using MySql.Data.MySqlClient;

namespace LibMedia
{
    public class CRUD_Couverture
    {
        private MySqlCommand cmdAjouter;
        private MySqlCommand cmdModifier;
        private MySqlCommand cmdSupprimer;
        private MySqlCommand cmdLire;
        private ConnexionBase _connexion;
        private List<Couverture> bibliotheque;
        private Couverture uneCouverture;

        public CRUD_Couverture(ConnexionBase uneConnexion)
        {
            _connexion = new ConnexionBase();
        }

        public void ajouter(int unCodeBd, string uneImageBd)
        {
            cmdAjouter = new MySqlCommand();
            cmdAjouter.CommandText = "proc_insert_update_couverture";
            cmdAjouter.CommandType = System.Data.CommandType.StoredProcedure;
            cmdAjouter.Connection = _connexion.getConnexion();
            cmdAjouter.Parameters.Add(new MySqlParameter("unCode", MySqlDbType.Int16));
            cmdAjouter.Parameters["unCode"].Value = unCodeBd;
            cmdAjouter.Parameters.Add(new MySqlParameter("uneCouv", MySqlDbType.String));
            cmdAjouter.Parameters["uneCouv"].Value = uneImageBd;
            cmdAjouter.ExecuteNonQuery();
            _connexion.closeConnexion();
        }

        public void modifier(int unCodeBd, string uneImageBd)
        {
            cmdModifier = new MySqlCommand();
            cmdModifier.CommandText = "proc_insert_update_couverture";
            cmdModifier.CommandType = System.Data.CommandType.StoredProcedure;
            cmdModifier.Connection = _connexion.getConnexion();
            cmdModifier.Parameters.Add(new MySqlParameter("unCode", MySqlDbType.Int16));
            cmdModifier.Parameters["unCode"].Value = unCodeBd;
            cmdModifier.Parameters.Add(new MySqlParameter("uneCouv", MySqlDbType.String));
            cmdModifier.Parameters["uneCouv"].Value = uneImageBd;
            cmdModifier.ExecuteNonQuery();
            _connexion.closeConnexion();
        }

        public void Supprimer(int unCodeBd)
        {
            cmdSupprimer = new MySqlCommand();
            cmdSupprimer.CommandText = "proc_delete_couverture";
            cmdSupprimer.CommandType = System.Data.CommandType.StoredProcedure;
            cmdSupprimer.Connection = _connexion.getConnexion();
            cmdSupprimer.Parameters.Add(new MySqlParameter("unCode", MySqlDbType.Int16));
            cmdSupprimer.Parameters["unCode"].Value = unCodeBd;
            cmdSupprimer.ExecuteNonQuery();
            _connexion.closeConnexion();
        }

       /* public List<Couverture> recupCouverture()
        {

            bibliotheque = new List<Couverture>();
            cmdLire = new MySqlCommand();
            cmdLire.CommandText = "LireBdd";
            cmdLire.CommandType = System.Data.CommandType.StoredProcedure;
            cmdLire.Connection = _connexion.getConnexion();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmdLire);
            DataSet dts = new DataSet("ListeDonnéesRecupérées");
            dataAdapter.Fill(dts, "ListeDonnéesRecupérées");*/
            

            /*if(_connexion.OuvrirConnexion() == true)
            {
            _connexion.OuvrirConnexion();
            cmdLire = new MySqlCommand();
                cmdLire.CommandText = "proc_afficher_couverture";
                cmdLire.CommandType = System.Data.CommandType.StoredProcedure;
                cmdLire.Connection = _connexion.getConnexion();
                MySqlDataReader reader = cmdLire.ExecuteReader();

                while (reader.Read())
                {
                    bibliotheque.Add(new Livre(int.Parse(reader["BdId"].ToString()), reader["BdTitre"].ToString(), reader["BdIsbn"].ToString(), int.Parse(reader["BdTome"].ToString()), DateTime.Parse(reader["BdParution"].ToString()), int.Parse(reader["BdNbPages"].ToString()), reader["BdImage"].ToString(), reader["BdCouleur"].ToString(), reader["BdCommentaires"].ToString(), reader["BdFormat"].ToString(), int.Parse(reader["NumSerie"].ToString()), int.Parse(reader["NumEditeur"].ToString())));
            }
                reader.Close();
            }
            _connexion.closeConnexion();
            return bibliotheque;*/
        }
    }
}
