using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    public class Emprunt
    {

        private int _numEmp;

        public int numEmp
        {
            get { return _numEmp; }
            set { _numEmp = value; }
        }

        private string _refEx;

        public string refEx
        {
            get { return _refEx; }
            set { _refEx = value; }
        }

        private DateTime _dateEmp;

        public DateTime dateEmp
        {
            get { return _dateEmp; }
            set { _dateEmp = value; }
        }

        private DateTime _dateRetour;

        public DateTime dateRetour
        {
            get { return _dateRetour; }
            set { _dateRetour = value; }
        }

        private DateTime _dateRetourPrevu;

        public DateTime dateRetourPrevu
        {
            get { return _dateRetourPrevu; }
            set { _dateRetourPrevu = value; }
        }


    }
}
