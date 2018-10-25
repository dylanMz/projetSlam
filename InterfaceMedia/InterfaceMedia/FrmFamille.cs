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
        private List<Famille> lesidfamilles;
        

        public FrmFamille(List<Famille> familles)
        {
            
            InitializeComponent();
            this.lesidfamilles = familles;
            RefreshGrid();
        }

        private void metrotileQuitter_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //Methode pour mettre à jour le grid
        public void RefreshGrid()
        {
            GridFamille.DataSource = lesidfamilles;
            GridFamille.Refresh();
            GridFamille.Update();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnum.Text =  GridFamille.CurrentRow.Cells["numéro"].Value.ToString();
            txtnom.Text = GridFamille.CurrentRow.Cells["nom"].Value.ToString();
        }
    }
}
