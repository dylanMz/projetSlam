﻿using System;
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
        private FrmEmprunteur formemprunteurs;

        public FrmFamille()
        {
            formemprunteurs = new FrmEmprunteur();
            InitializeComponent();
            //rempgridfamille(formemprunteurs._desfamilles);
        }

        private void metrotileQuitter_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void rempgridfamille(List<Famille> lesfamilles)
        {
            GridFamille.DataSource = lesfamilles;
        }

    }
}
