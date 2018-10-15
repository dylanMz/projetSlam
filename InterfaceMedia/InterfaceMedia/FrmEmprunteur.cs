using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMedia;
using MetroFramework.Forms;

namespace InterfaceMedia
{
    public partial class FrmEmprunteur : MetroForm
    {
        private Metier_Emprunteur unEmprunteur;
        private ConnexionBase uneconnexion;
        public FrmEmprunteur()
        {
            InitializeComponent();
           // uneconnexion = new ConnexionBase();
           // unEmprunteur = new Metier_Emprunteur(uneconnexion);
           // unEmprunteur.Recup_TableEmprunteur();
           // gridEmprunteur.DataSource = unEmprunteur.lesEmprunteurs;

        }
    }

}
