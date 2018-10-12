using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace LibMedia
{
    public class ConnexionBase
    {

        private MySqlConnection _Connect;

        public ConnexionBase()
        {
            _Connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionBase"].ConnectionString);
            //String uneConnxion = "Server=localhost; userid=Slam, password=Slam; Database=voiture; SslMode=none;";
            //_Connect = new MySqlConnection(uneConnxion);

        }

        #region Accesseurs

        public MySqlConnection getConnexion()
        {
            return _Connect;
        }
        #endregion

        #region Methodes

        public bool OuvrirConnexion()
        {
            try
            {
                _Connect.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public void closeConnexion()
        {
            _Connect.Close();
        }

        #endregion
    }

}

