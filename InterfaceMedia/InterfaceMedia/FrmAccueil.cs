﻿using System;
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
        private String leNiveau;

        public FrmAccueilTest(String leNiveau)
        {
            InitializeComponent();
            this.leNiveau = leNiveau;
            lblUtilisateur.Text = leNiveau;

            GestionAcces();

        }



        private void MetroTileEditeur_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformEditeur);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void metroTileEmprunteur_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformEmprunteur);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void metroTileAuteur_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformAuteur);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void metroTileLivre_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformLivre);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void metroTileCouverture_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformCouverture);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void metroTileEmprunt_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformEmprunt);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void picDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformConnexion);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformAdmin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openformEmprunteur()
        {
            Application.Run(new FrmEmprunteur(leNiveau));
        }

        private void openformAuteur()
        {
            Application.Run(new FrmAuteur(leNiveau));
        }

        private void openformEditeur()
        {
            Application.Run(new FrmEditeur(leNiveau));
        }

        private void openformLivre()
        {
            Application.Run(new Frmlivre(leNiveau));
        }

        private void openformCouverture()
        {
            Application.Run(new FrmCouverture(leNiveau));
        }

        private void openformEmprunt()
        {
            Application.Run(new FrmEmprunt(leNiveau));
        }

        private void openformAdmin()
        {
            Application.Run(new FrmAdmin(leNiveau));
        }

        private void openformConnexion()
        {
            Application.Run(new FrmConnexion());
        }

        private void GestionAcces()
        {
            //Desactive l'accès à certaines interfaces aux personnels de l'accueil 
            if (lblUtilisateur.Text.Equals("Personnel"))
            {
                metroTileAuteur.Enabled = false;
                metroTileCouverture.Enabled = false;
                metroTileEmprunt.Enabled = true;
                metroTileEditeur.Enabled = false;
                btnAdmin.Enabled = false;
            }

            //Desactive l'accès à certaines interfaces aux Responsable stock 
            if (lblUtilisateur.Text.Equals("Responsable stock"))
            {
                metroTileEmprunteur.Enabled = false;
                btnAdmin.Enabled = false;
            }

            //Desactive l'accès à certaines interfaces aux Responsable secteur
            if (lblUtilisateur.Text.Equals("Responsable secteur"))
            {
                metroTileAuteur.Enabled = false;
                metroTileCouverture.Enabled = false;
                metroTileEditeur.Enabled = false;
                btnAdmin.Enabled = false;
            }
        }


    }
}
