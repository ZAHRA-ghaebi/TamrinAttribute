using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using common;
namespace Model
{
    public class Doctor
    {
        [Required(ErrorMessage = "نام الزامی است")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "نام خانوادگی الزامی است")]
        [MinLength(3, ErrorMessage = "نام خانوادگی باید طولش بیشتر از 3 باشد")]
        public string LastName { get; set; }
        [phoneNumberAttribute]
        public string PhoneNumber { get; set; }
        public int Id { get; set; }
        //public string Error { get; private set; }

        //public bool IsValid
        //{
        //    get
        //    {
        //        var validatinC = new ValidationContext(this);
        //        var result = new List<ValidationResult>();
        //        if (!Validator.TryValidateObject(this, validatinC, result, true))
        //        {
        //            Error = string.Join(Environment.NewLine, result.Select(x => x.ErrorMessage));
        //            return false;
        //        }
        //        return true;
        //    }
        //}
    }
}