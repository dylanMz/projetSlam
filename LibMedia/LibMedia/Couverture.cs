using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Couverture
    {
        #region propriété
        private int codeBd;
        private string titreBd;
        private string Auteur;
        private string editeurBd;
        private string imageBd;
        private int tomeBd;
        private string anneeParution;
        #endregion
        #region constructeur
        public Couverture(int unCodeBd, string uneImageBd, string unTitreBd, int unTomeBd, string uneAnneeParution)
        {
            codeBd = unCodeBd;
            titreBd = unTitreBd;
            imageBd = uneImageBd;
            tomeBd = unTomeBd;
            anneeParution = uneAnneeParution;
        }
        public Couverture(int unCodeBd, string uneImageBd)
        {
            codeBd = unCodeBd;
            imageBd = uneImageBd;
        }
        public Couverture(int unCodeBd)
        {
            codeBd = unCodeBd;
        }
        public Couverture(string unTitre)
        {
            titreBd = unTitre;
        }

        public Couverture(int unCodeBd, string unTitreBd, int unTomeBd, string uneAnneeParution)
        {
            codeBd = unCodeBd;
            titreBd = unTitreBd;
            tomeBd = unTomeBd;
            anneeParution = uneAnneeParution;
        }
        #endregion
        #region accesseur
        public int getCodeBd()
        {
            return codeBd;
        }
        public void setCodeBd(int unCode)
        {
            codeBd = unCode;
        }

        public string getTitreBd()
        {
            return titreBd;
        }
        public void setTitreBd(string unTitre)
        {
            titreBd = unTitre;
        }

        public string getImageBd()
        {
            return imageBd;
        }
        public void setImageBd(string uneImageBd)
        {
            imageBd = uneImageBd;
        }

        public int getTomeBd()
        {
            return tomeBd;
        }
        public void setTomeBd(int unTome)
        {
            tomeBd = unTome;
        }

        public string getAnneeParution()
        {
            return anneeParution;
        }
        public void setAnneeParution(string uneAnneeParution)
        {
            anneeParution = uneAnneeParution;
        }
        #endregion
    }
}
