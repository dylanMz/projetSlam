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
        #endregion
        #region constructeur
        public Couverture(int unCodeBd, string unTitreBd, string unAuteurBd, string unEditeurBd, string uneImageBd)
        {
            codeBd = unCodeBd;
            titreBd = unTitreBd;
            Auteur = unAuteurBd;
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

        public string getAuteurBd()
        {
            return Auteur;
        }
        public void setSerieBd(string unAuteur)
        {
            Auteur = unAuteur;
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
