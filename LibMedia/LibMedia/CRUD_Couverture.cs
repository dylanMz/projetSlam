using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibMedia.LaibrairieClasses;
using MySql.Data.MySqlClient;

namespace LibMedia
{
    class CRUD_Couverture
    {
        private MySqlCommand cmdAjouter;
        private MySqlCommand cmdModifier;
        private MySqlCommand cmdSupprimer;
        private MySqlCommand cmdLire;
        private ConnexionBase _connexion;
        private List<Livre> bibliotheque;
        private Livre unLivre;

        public CRUD_Couverture()
        {
            _connexion = new ConnexionBase();
            _connexion.OuvrirConnexion();
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

        public List<Livre> Lire()
        {
            bibliotheque = new List<Livre>();
            cmdLire = new MySqlCommand();
            cmdLire.CommandText = "proc_afficher_couverture";
            cmdLire.CommandType = System.Data.CommandType.StoredProcedure;
            cmdLire.Connection = _connexion.getConnexion();
            MySqlDataReader reader = cmdLire.ExecuteReader();
            reader.Read();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    unLivre = new Livre(reader.GetInt16(1), reader.GetString(2), reader.GetInt16(3), reader.GetInt16(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    bibliotheque.Add(unLivre);

                }
            }
            return bibliotheque;
        }
    }
}
