using LibMedia.LaibrairieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Exemplaire : Livre
    {
        private String ExempRef;
        private String ExempEtat;

        #region Constructeur
 public Exemplaire(String WexempRef, String WExempEtat, int wbd_code, String wbd_titre, int wbd_num_tome, int wbd_annee_parution, String wbd_image, String wbd_serie, String wedi_cod) : base(wbd_code, wbd_titre, wbd_num_tome, wbd_annee_parution, wbd_image, wbd_serie, wedi_cod)
        {
            ExempRef = WexempRef;
            ExempEtat = WExempEtat;
        }
        #endregion

        #region 
       

        public String wExempRef
        {
            get { return ExempRef; }
            set { ExempRef = value; }
        }
        public String wExempEtat
        {
            get { return ExempEtat; }
            set { ExempEtat = value; }
        }
    }
}
}