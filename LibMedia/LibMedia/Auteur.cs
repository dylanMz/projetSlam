using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    class Auteur
    {
        #region Propriétés
        public int Auteurld;
        public String AuteurNom;
        public String AuteurPrenom;
        public String AuteurPseudo;
        public DateTime DateNaissance;
        public DateTime AuteurDeces;
        public String AuteurPays;
        public String AuteurBiographie;

        #endregion
        

        #region constructeur

        public Auteur(int unAuteurld, String unNom, String unPrenom, String unPseudo, DateTime uneDateNaiss, DateTime uneDateDeces, String unPays, String uneBiographie)
        {
            unAuteurld = Auteurld;
            unNom = AuteurNom;
            unPrenom = AuteurPrenom;
            unPseudo = AuteurPseudo;
            uneDateNaiss = DateNaissance;
            uneDateDeces = AuteurDeces;
            unPays = AuteurPays;
            uneBiographie = AuteurBiographie;
        }
        #endregion

        #region Accesseurs
        public int _Auteurld
        {
            get { return Auteurld; }
            set { Auteurld = value; }
        }

        public String _AuteurNom
        {
            get { return AuteurNom; }
            set { AuteurNom = value; }
        }
        public String _AuteurPrenom
        {
            get { return AuteurPrenom; }
            set { AuteurPrenom = value; }
        }

        public String _AuteurPseudo
        {
            get { return AuteurPseudo; }
            set { AuteurPseudo = value; }
        }

        public DateTime _DateNaissance
        {
            get { return DateNaissance; }
            set { DateNaissance = value; }
        }

        public DateTime _AuteurDeces
        {
            get { return AuteurDeces; }
            set { AuteurDeces = value; }
        }

        public String _AuteurPays
        {
            get { return AuteurPays; }
            set { AuteurPays = value; }
        }

        public String _AuteurBiographie
        {
            get { return AuteurBiographie; }
            set { AuteurBiographie = value; }
        }
        #endregion
    }
}
