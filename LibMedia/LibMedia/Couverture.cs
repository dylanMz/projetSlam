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
        private string serieBd;
        private int tomeBd;
        private string editeurBd;
        private string imageBd;
        #endregion
        #region constructeur
        public Couverture(int unCodeBd, string unTitreBd, string uneSerieBd, int unTomeBd, string unEditeurBd, string uneImageBd)
        {
            codeBd = unCodeBd;
            titreBd = unTitreBd;
            serieBd = uneSerieBd;
            tomeBd = unTomeBd;
            editeurBd = unEditeurBd;
            imageBd = uneImageBd;
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

        public string getSerieBd()
        {
            return serieBd;
        }
        public void setSerieBd(string uneSerie)
        {
            serieBd = uneSerie;
        }

        public int getTomeBd()
        {
            return tomeBd;
        }
        public void setTomeBd(int unTomeBd)
        {
            tomeBd = unTomeBd;
        }

        public string getEditeurBd()
        {
            return editeurBd;
        }
        public void setEditeurBd(string unEditeurBd)
        {
            editeurBd = unEditeurBd;
        }

        public string getImageBd()
        {
            return imageBd;
        }
        public void setImageBd(string uneImageBd)
        {
            imageBd = uneImageBd;
        }
        #endregion
    }
}
