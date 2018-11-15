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
        private String bdcode;
        private int lecode;
        #region Constructeur

 public Exemplaire(String WExempRef, String WExempEtat, String wbdcode) 
        {
            ExempRef = WExempRef;
            ExempEtat = WExempEtat;
            bdcode = wbdcode;
        }
        public Exemplaire(String WExempRef, String WExempEtat, int lebdcode)
        {
            ExempRef = WExempRef;
            ExempEtat = WExempEtat;
            lecode = lebdcode;
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
       

        public String wbdcode
        {
            get { return bdcode; }
            set { bdcode = value; }
        }

     

        public int lebdcode
        {
            get { return lecode; }
            set { lecode = value; }
        }


    }
}
