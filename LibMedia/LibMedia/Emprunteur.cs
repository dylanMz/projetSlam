﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Emprunteur
    {
        public int emp_num;
        public String emp_nom;
        public String emp_prenom;
        public String emp_rue;
        public String emp_code_postal;
        public String emp_ville;
        public DateTime emp_date_naiss;
        public String emp_mail;
        public DateTime emp_prem_adh;
        public DateTime emp_ren_adh;


        #region Constructeur
        //constructeur
        public Emprunteur(int emp_num, String emp_nom, String emp_prenom, String emp_rue, String emp_code_postal, String emp_ville, DateTime emp_date_naiss, String emp_mail, DateTime emp_prem_adh, DateTime emp_ren_adh)
        {
            this.emp_num = emp_num;
            this.emp_nom = emp_nom;
            this.emp_prenom = emp_prenom;
            this.emp_rue = emp_rue;
            this.emp_code_postal = emp_code_postal;
            this.emp_ville = emp_ville;
            this.emp_date_naiss = emp_date_naiss;
            this.emp_mail = emp_mail;
            this.emp_prem_adh = emp_prem_adh;
            this.emp_ren_adh = emp_ren_adh;
        }
        #endregion

        #region Accesseur        
        //Accesseur


        public int NumEmprunteur
        {
            get { return emp_num; }
            set { emp_num = value; }
        }


        public String NomEmprunteur
        {
            get { return emp_nom; }
            set { emp_nom = value; }
        }

        public String PrenomEmprunteur
        {
            get { return emp_prenom; }
            set { emp_prenom = value; }
        }

        public String RueEmprunteur
        {
            get { return emp_rue; }
            set { emp_rue = value; }
        }

        public String CodePostalEmprunteur
        {
            get { return emp_code_postal; }
            set { emp_code_postal = value; }
        }

        public String VilleEmprunteur
        {
            get { return emp_ville; }
            set { emp_ville = value; }
        }

        public DateTime DateNaissEmprunteur
        {
            get { return emp_date_naiss; }
            set { emp_date_naiss = value; }
        }

        public String MailEmprunteur
        {
            get { return emp_mail; }
            set { emp_mail = value; }
        }

        public DateTime premAdhEmprunteur
        {
            get { return emp_prem_adh; }
            set { emp_prem_adh = value; }
        }

        public DateTime renAdhEmprunteur
        {
            get { return emp_ren_adh; }
            set { emp_ren_adh = value; }
        }

        #endregion









    }
}
