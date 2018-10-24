using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMedia;
using MetroFramework.Forms;

namespace InterfaceMedia
{
    public partial class FrmFamille : MetroForm
    {
        private Crud_Emprunteur unEmprunteur;
        private ConnexionBase uneconnexion;
        private FrmEmprunteur frmemprunteur;
        private String lesidfamilles;
        

        public FrmFamille(String wid)
        {
            
            InitializeComponent();
            this.lesidfamilles = wid;
            uneconnexion = new ConnexionBase();
            unEmprunteur = new Crud_Emprunteur(uneconnexion);
            frmemprunteur = new FrmEmprunteur();
            unEmprunteur.connectprocedureFamille("proc_famille_selection", lesidfamilles);
            GridFamille.DataSource = unEmprunteur.lesFamilles;
        }

        private void metrotileQuitter_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
