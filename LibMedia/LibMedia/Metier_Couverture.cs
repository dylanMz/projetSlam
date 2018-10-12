using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibMedia
{
    class Metier_Couverture
    {
        private MySqlCommand cmdEnregistrer;
        private MySqlCommand cmdUpdate;
        private MySqlCommand cmdDelete;
        private ConnexionBase _connexion;

        public Metier_Couverture()
        {
            _connexion = new ConnexionBase();
            _connexion.OuvrirConnexion();
            cmdEnregistrer = new MySqlCommand();
            cmdUpdate = new MySqlCommand();
            cmdDelete = new MySqlCommand();
        }
    }
}
