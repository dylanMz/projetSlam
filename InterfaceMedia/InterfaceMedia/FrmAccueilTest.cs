using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;


namespace InterfaceMedia
{
    public partial class FrmAccueilTest : MetroForm
    {

        Thread th;

        public FrmAccueilTest()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MetroTileEditeur_Click(object sender, EventArgs e)
        {
            FrmEditeur wFrmEidteur = new FrmEditeur();
            wFrmEidteur.ShowDialog();

        }

        private void metroTileEmprunteur_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformEmprunteur);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openformEmprunteur()
        {
            Application.Run(new FrmEmprunteur());
        }
    }
}
