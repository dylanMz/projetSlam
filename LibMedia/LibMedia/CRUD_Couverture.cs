using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibMedia
{
    public class CRUD_Couverture
    {
        private MySqlCommand commande;
        private ConnexionBase _connexion;
        private List<Couverture> bibliotheque;
        private bool retour;

        public CRUD_Couverture(ConnexionBase uneConnexion)
        {
            _connexion = new ConnexionBase();
        }

        public void ajouter(Couverture uneCouverture)
        {
            _connexion.OuvrirConnexion();
            commande = new MySqlCommand();
            commande.CommandText = "proc_insert_update_couverture";
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.Connection = _connexion.getConnexion();
            commande.Parameters.Add(new MySqlParameter("unCode", MySqlDbType.Int16));
            commande.Parameters["unCode"].Value = uneCouverture.getCodeBd();
            commande.Parameters.Add(new MySqlParameter("uneCouv", MySqlDbType.String));
            commande.Parameters["uneCouv"].Value = uneCouverture.getImageBd();
            commande.ExecuteNonQuery();
            _connexion.closeConnexion();
        }

        public void modifier(Couverture uneCouverture)
        {
            _connexion.OuvrirConnexion();
            commande = new MySqlCommand();
            commande.CommandText = "proc_insert_update_couverture";
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.Connection = _connexion.getConnexion();
            commande.Parameters.Add(new MySqlParameter("unCode", MySqlDbType.Int16));
            commande.Parameters["unCode"].Value = uneCouverture.getCodeBd(); ;
            commande.Parameters.Add(new MySqlParameter("uneCouv", MySqlDbType.String));
            commande.Parameters["uneCouv"].Value = uneCouverture.getImageBd();
            commande.ExecuteNonQuery();
            _connexion.closeConnexion();
        }

        public void Supprimer(Couverture uneCouverture)
        {
            _connexion.OuvrirConnexion();
            commande = new MySqlCommand();
            commande.CommandText = "proc_delete_couverture";
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.Connection = _connexion.getConnexion();
            commande.Parameters.Add(new MySqlParameter("unCode", MySqlDbType.Int16));
            commande.Parameters["unCode"].Value = uneCouverture.getCodeBd();
            commande.ExecuteNonQuery();
            _connexion.closeConnexion();
        }

        public DataTable recupCouverture()
        {
            _connexion.OuvrirConnexion();
            commande = new MySqlCommand();
            commande.CommandText = "proc_afficher_couverture";  //Nom de la rpocédure sur MySql
            commande.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            commande.Connection = _connexion.getConnexion();

            MySqlDataAdapter unAdapter = new MySqlDataAdapter(commande);
            DataSet unDataset = new DataSet();
            DataTable uneTable;
            uneTable = new DataTable();
            unAdapter.Fill(unDataset, "couverture");
            uneTable = unDataset.Tables["couverture"];

            _connexion.closeConnexion();

            return uneTable;
        }

        public DataTable rechercher(Couverture uneCouverture)
        {
            _connexion.OuvrirConnexion();
            commande = new MySqlCommand();
            commande.CommandText = "proc_rechercher_couverture";  //Nom de la rpocédure sur MySql
            commande.CommandType = CommandType.StoredProcedure;  //Indique que c'est une procedure
            commande.Connection = _connexion.getConnexion();
            commande.Parameters.Add(new MySqlParameter("unCode", MySqlDbType.Int16));
            commande.Parameters["unCode"].Value = uneCouverture.getCodeBd();
            commande.Parameters.Add(new MySqlParameter("unTitre", MySqlDbType.String));
            commande.Parameters["unTitre"].Value = uneCouverture.getTitreBd();
            commande.Parameters.Add(new MySqlParameter("unTome", MySqlDbType.Int16));
            commande.Parameters["unTome"].Value = uneCouverture.getTomeBd();
            commande.Parameters.Add(new MySqlParameter("uneDate", MySqlDbType.String));
            commande.Parameters["uneDate"].Value = uneCouverture.getAnneeParution();

            MySqlDataAdapter unAdapter = new MySqlDataAdapter(commande);
            DataSet unDataset = new DataSet();
            DataTable uneRecherche;
            uneRecherche = new DataTable();
            unAdapter.Fill(unDataset, "couverture");
            uneRecherche = unDataset.Tables["couverture"];

            _connexion.closeConnexion();

            return uneRecherche;
        }

        public string recupImage (Couverture uneCouverture)
        {
            _connexion.OuvrirConnexion();
            commande = new MySqlCommand();
            commande.CommandText = "proc_image_couverture";
            commande.CommandType = CommandType.StoredProcedure;  
            commande.Connection = _connexion.getConnexion();
            commande.Parameters.Add(new MySqlParameter("unCode", MySqlDbType.Int16));
            commande.Parameters["unCode"].Value = uneCouverture.getCodeBd();
            IDataReader reader = commande.ExecuteReader();
            reader.Read();
            string titre = reader.GetString(0);
            reader.Close();
            _connexion.closeConnexion();
            return titre;
        }

        public List<Couverture> lesCouvertures
        {
            get { return bibliotheque; }
            set { bibliotheque = value; }
        }

        public int getCode(Couverture uneCouverture)
        {
            _connexion.OuvrirConnexion();
            commande = new MySqlCommand();
            commande.CommandText = "proc_code_couverture";
            commande.CommandType = CommandType.StoredProcedure;
            commande.Connection = _connexion.getConnexion();
            commande.Parameters.Add(new MySqlParameter("unTitre", MySqlDbType.String));
            commande.Parameters["unTitre"].Value = uneCouverture.getTitreBd();
            IDataReader reader = commande.ExecuteReader();
            reader.Read();
            int unCode = reader.GetInt16(0);
            reader.Close();
            _connexion.closeConnexion();
            return unCode;
        }

        public bool getExist(Couverture uneCouverture)
        {
            _connexion.OuvrirConnexion();
            commande = new MySqlCommand();
            commande.CommandText = "proc_exist_couverture";
            commande.CommandType = CommandType.StoredProcedure;
            commande.Connection = _connexion.getConnexion();
            commande.Parameters.Add(new MySqlParameter("unTitre", MySqlDbType.String));
            commande.Parameters["unTitre"].Value = uneCouverture.getTitreBd();
            MySqlParameter PSortie_nat = new MySqlParameter("ret", MySqlDbType.String);
            commande.Parameters.Add(PSortie_nat);
            PSortie_nat.Direction = ParameterDirection.Output;
            IDataReader reader = commande.ExecuteReader();
            reader.Read();

           
            int unCode = reader.GetInt16(0);
            if(unCode == 1)
            {
                retour = true;
            }
            else
            {
                retour = false;
            }
            reader.Close();
            _connexion.closeConnexion();
            return retour;
        }
    }
}


