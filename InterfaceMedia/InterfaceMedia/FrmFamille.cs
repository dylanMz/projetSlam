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
        private Crud_Famille unefamille;
        private Boolean newfamille = false;
        private int lecheffamille;
        private int unchef;


        public FrmFamille(List<Famille> familles, Boolean newfamille)
        {
            unefamille = new Crud_Famille();
            InitializeComponent();
            this.lesidfamilles = familles;
            this.newfamille = newfamille;
            if(newfamille == false)
            {
                btnAjouter.Visible = false;
                btnModifier.Visible = true;
            }
            else
            {
                btnAjouter.Visible = true;
                btnModifier.Visible = false;
            }
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
            if (btnAjouter.Text.Equals("Ajouter Chef")&!txtnum.Text.Equals(""))
            {
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;
                btnAjouter.BackColor = Color.Green;

            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                btnAjouter.Text = "Ajouter Chef";
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
                            unefamille.InsertFamille("proc_insert_famille", Convert.ToInt32(txtnum.Text), num);
                        }

                    }
                }

                //met à jour le datagrid
                unchef = Convert.ToInt16(GridFamille.Rows[1].Cells[8].Value.ToString());
                Famille idfamille = new Famille(unchef);
                unefamille.Recup_Toutelafamille(idfamille);
                GridFamille.DataSource = unefamille.lesfamilles;
            }
        }

        //permet de modifier le chef de famille
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text.Equals("Modifier Chef")&!txtnum.Text.Equals(""))
            {
                btnModifier.Text = "Valider";
                btnAnnuler.Visible = true;
                btnModifier.BackColor = Color.Green;

            }
            else if (btnModifier.Text.Equals("Valider"))
            {
                btnModifier.Text = "Modifier Chef";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;




                //modifie le chef de famille de tout le datagrid
                Int32 RowCount = GridFamille.RowCount;
                if (RowCount > 0)
                {
                    //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    for (int i = 0; i < RowCount; i++)
                    {

                        int num = Convert.ToInt16(GridFamille.Rows[i].Cells[0].Value.ToString());
                        int ancienresp = Convert.ToInt16(GridFamille.Rows[i].Cells[8].Value.ToString());
                        int compar = Convert.ToInt32(txtnum.Text);
                        if (compar != num)
                        {
                            unefamille.UpdateFamille("proc_update_famille", Convert.ToInt32(txtnum.Text), num, ancienresp);
                        }

                    }
                }

                //met à jour le datagrid
                RefreshGrid();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnModifier.Text = "Modifier Chef";
            btnModifier.BackColor = Color.SteelBlue;
            btnAnnuler.Visible = false;
            btnAjouter.Text = "Ajouter Chef";
            btnAjouter.BackColor = Color.SteelBlue;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.BackColor = Color.SteelBlue;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text.Equals("Supprimer") & !txtnum.Text.Equals(""))
            {
                btnSupprimer.Text = "Valider";
                btnAnnuler.Visible = true;
                btnSupprimer.BackColor = Color.Green;

            }
            else if (btnSupprimer.Text.Equals("Valider"))
            {
                Int32 RowCount = GridFamille.RowCount;
                if (RowCount > 0)
                {

                    for (int i = 0; i < RowCount; i++)
                    {
                        lecheffamille = Convert.ToInt16(GridFamille.Rows[i].Cells[8].Value.ToString());
                    }
                }

                //si le membre de la famille est un chef de famille affiche un message d'erreur
                if (lecheffamille == Convert.ToInt16(txtnum.Text))
                {
                    MessageBox.Show("Impossible de supprimer un chef de famille", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int wid = Convert.ToInt16(txtnum.Text);
                    unefamille.DeleteMembreFamille("proc_delete_membre_famille", wid);
                }

                btnSupprimer.Text = "Supprimer";
                btnSupprimer.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnModifier.Enabled = true;
            }
        }
    }
}
