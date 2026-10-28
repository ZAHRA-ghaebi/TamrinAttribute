
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
            var controlMap= new Dictionary<string, Control>
            {
                {nameof(Doctor.FirstName),txtfirstname },
                {nameof(Doctor.LastName),txtlastname  },
                {nameof(Doctor.PhoneNumber),txtphonenumber }
            };
            var result = new List<ValidationResult>();
            if(!_drManager.ValidateDr(dr,result)) 
            {
                foreach (ValidationResult item in result)
                {
                    foreach (string memberName in item.MemberNames)
                    {
                        if (controlMap.TryGetValue(memberName,out Control control))
                        {
                            errorProvider1.SetError(control,item.ErrorMessage);
                        }
                        return;
                    }
                }
            }
            _drManager.Insert(dr);

        }
    }
}

