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
    public partial class FrmEditeur : MetroForm
    {
        public FrmEditeur()
        {
            InitializeComponent();
        }

        private void btnAjoutEdit_Click(object sender, EventArgs e)
        {
            //btnAjoutEdit.Style = ;
            if (btnAjoutEdit.Text == "Ajouter")
            {
                btnAjoutEdit.Style = MetroFramework.MetroColorStyle.Green;
                btnAjoutEdit.Text = "Valider";

            }

            else if (btnAjoutEdit.Text == "Valider")
            {
                btnAjoutEdit.Style = MetroFramework.MetroColorStyle.Blue;
            }
        }
    }
}
