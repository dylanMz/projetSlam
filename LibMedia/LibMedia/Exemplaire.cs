using LibMedia.LaibrairieClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Exemplaire 
    {
        private String ExempRef;
        private String ExempEtat;
        private int bdcope;
        #region Constructeur

 public Exemplaire(String WexempRef, String WExempEtat, int wbdcode) 
        {
            ExempRef = WexempRef;
            ExempEtat = WExempEtat;
            bdcope = wbdcode;
        }
        #endregion

      
       

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
