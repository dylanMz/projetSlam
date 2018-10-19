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

        public Emprunt(int EmpNum, string ExRef, DateTime dtEmp, DateTime dtRet, DateTime dtRetPrev)
        {
            _numEmp = EmpNum;
            _refEx = ExRef;
            _dateEmp = dtEmp;
            _dateRetour = dtRet;
            _dateRetourPrevu = dtRetPrev;
        }

        public Emprunt(int EmpNum, string ExRef, DateTime dtEmp)
        {
            _numEmp = EmpNum;
            _refEx = ExRef;
            _dateEmp = dtEmp;
            _dateRetourPrevu = dtEmp.AddDays(15);
        }

        public Emprunt(int EmpNum, string ExRef, DateTime dtEmp, DateTime dtRet)
        {
            _numEmp = EmpNum;
            _refEx = ExRef;
            _dateEmp = dtEmp;
            _dateRetourPrevu = dtRet;
        }

        public Emprunt(int EmpNum, string ExRef)
        {
            _numEmp = EmpNum;
            _refEx = ExRef;
        }
    }
}
