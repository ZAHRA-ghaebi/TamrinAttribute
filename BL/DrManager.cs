using DL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL
{
    public class DrManager
    {
        DrManagment _drmanagment;
        public DrManager()
        {
            _drmanagment = new DrManagment();
        }
        public void Insert(Doctor dr)
        {
            _drmanagment.Insert(dr);
        }
        public List<Doctor> Select()
        {
            return _drmanagment.Select();
        }
        public bool ValidateDr(Doctor dr,List<ValidationResult> result)
        {
            var validatinC = new ValidationContext(dr);
            return  Validator.TryValidateObject(dr, validatinC, result, true);
        } 
    }
}
