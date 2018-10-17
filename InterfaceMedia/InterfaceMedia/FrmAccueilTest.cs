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


namespace InterfaceMedia
{
    public partial class FrmAccueilTest : MetroForm
    {
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
            Form.ActiveForm.Close();
        }

        private void metroTileEmprunteur_Click(object sender, EventArgs e)
        {
            FrmEmprunteur wFrmEmprunteur = new FrmEmprunteur();
            wFrmEmprunteur.ShowDialog();
            Form.ActiveForm.Close();
        }
    }
}
