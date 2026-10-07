using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BL
{
    public class DrManager
    {
        DrManagment _drmanagment;
        public DrManager()
        {
            _drmanagment= new DrManagment();
        }
        public void Insert(Doctor dr)
        {
            _drmanagment.Insert(dr);
        }
        public List<Doctor> Select()
        {
            return _drmanagment.Select();
        }
    }
}
