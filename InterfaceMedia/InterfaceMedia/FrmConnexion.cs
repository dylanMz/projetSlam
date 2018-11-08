using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMedia;
using MetroFramework.Forms;


namespace InterfaceMedia
{
    public partial class FrmConnexion : MetroForm
    {
        private ConnexionBase uneconnexion;

        public FrmConnexion()
        {
            InitializeComponent();
            uneconnexion = new ConnexionBase();

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            uneconnexion = new ConnexionBase();
            uneconnexion.OuvrirConnexion();
            SqlCommand cmd = new SqlCommand("SELECT userid,password from login where userid='" + txtIdentifiant.Text + "'and password='" + txtPassword + "'");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess");
            }
            else
            {
                MessageBox.Show("Utilisateur ou mot de passes invalide.s");
            }
            uneconnexion.closeConnexion();
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMdpOublie_Click(object sender, EventArgs e)
        {

        }


    }
}
