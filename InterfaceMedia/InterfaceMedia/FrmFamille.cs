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
using MetroFramework.Forms;

namespace InterfaceMedia
{
    public partial class FrmFamille : MetroForm
    {
 

        public FrmFamille()
        {
            InitializeComponent();
        }

        private void metrotileQuitter_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
