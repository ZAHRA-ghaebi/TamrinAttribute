
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

using System.Windows.Forms;
using BL;

namespace TamrinAttribute
{
    public partial class frmAdd : Form
    {
        DrManager _drManager;
        public frmAdd()
        {
            InitializeComponent();
            _drManager = new DrManager();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Doctor dr = new Doctor
            {
                FirstName = txtfirstname.Text,
                LastName = txtlastname.Text,
                PhoneNumber = txtphonenumber.Text,
            };
            var validatinC = new ValidationContext(dr);
            var result = new List<ValidationResult>();
            bool isvalid = Validator.TryValidateObject(dr, validatinC, result, true);
            if (!isvalid)
            { 
                foreach(ValidationResult item in  result)
                {
                    foreach (string memberName in item.MemberNames)
                    {
                        if(memberName=="FirstName")
                        {
                            errorProvider1.SetError(txtfirstname, item.ErrorMessage);
                        }
                        if(memberName=="LastName")
                        {
                            errorProvider1.SetError(txtlastname, item.ErrorMessage);
                        }
                        if(memberName=="PhoneNumber")
                        {
                            errorProvider1.SetError(txtphonenumber, item.ErrorMessage);
                        }    
                    }
                }
                return;
            }
            _drManager.Insert(dr);

        }
    }
}
