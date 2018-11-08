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
        private string chefvalide;
        private Crud_Emprunteur unemprunteur;


        public FrmFamille(List<Famille> familles)
        {
            unemprunteur = new Crud_Emprunteur();
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
            //chefvalide = GridFamille.Rows[0].Cells[8].Value.ToString();
            ////Int32 RowCount = GridFamille.RowCount;
            ////if (RowCount == 1)
            ////{
            ////    int lechef = Convert.ToInt32(chefvalide);
            ////    unemprunteur.Recup_Toutelafamille(lechef);
            ////    GridFamille.DataSource = lesidfamilles;
            ////    GridFamille.Refresh();
            ////    GridFamille.Update();
            ////}

            //if (chefvalide.Equals("0"))
            //{
            //    GridFamille.Columns["Chef_famille"].Visible = false;
            //}
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnum.Text = chefvalide = GridFamille.CurrentRow.Cells["numéro"].Value.ToString();
            txtnom.Text = GridFamille.CurrentRow.Cells["nom"].Value.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text.Equals("Ajouter"))
            {
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;

            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnModifier.Enabled = true;


                

                //Ajoute le chef de famille à tout les membre du datagrid
                Int32 RowCount = GridFamille.RowCount;
                if (RowCount > 0)
                {
                    //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    for (int i = 0; i < RowCount; i++)
                    {

                        int num = Convert.ToInt16(GridFamille.Rows[i].Cells[0].Value.ToString());
                        int compar = Convert.ToInt32(txtnum.Text);
                        if (compar != num)
                        {
                            unemprunteur.InsertFamille("proc_insert_famille", Convert.ToInt32(txtnum.Text), num);
                        }

                    }
                }

                //met à jour le datagrid
                RefreshGrid();
            }
        }
    }
}
