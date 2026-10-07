using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class phoneNumberAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string phoneNumber = (string)value;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                ErrorMessage = "شماره تماس را وارد کن";
                return false;
            }
            if(!phoneNumber.All(char.IsDigit))
            {
                ErrorMessage = "شماره تماس باید عدد باشه";
              return false;
            }
            if (!phoneNumber.StartsWith("09"))
            {
                ErrorMessage = "شماره موبایل باید با09 شروع شود";
                return false;
            }
            if(phoneNumber.Length!=11)
            {
                ErrorMessage = "شماره تماس باید11رقم باشد";
                return false;
            }
            return true;
        }
    }
}
 