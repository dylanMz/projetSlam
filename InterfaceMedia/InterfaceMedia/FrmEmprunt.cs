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
    public partial class FrmEmprunt : MetroForm
    {
        public FrmEmprunt()
        {
            InitializeComponent();

        }

        private void btnRechercheLivre_Click(object sender, EventArgs e)
        {
            gpbxChoix.Enabled = true;
           // if()
        }

        private void btnAjoutEmp_Click(object sender, EventArgs e)
        {
            

            if(btnAjoutEmp.Text == "Ajouter")
            {
                btnAjoutEmp.Text = "Valider";
                btnAjoutEmp.Style = MetroFramework.MetroColorStyle.Green;
            }
            else
            {

            }
        }


    }
}
