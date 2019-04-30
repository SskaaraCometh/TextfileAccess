using CustomerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDatabaseUI
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                CustomerModel model = new CustomerModel();

                model.FirstName = forenameTextbox.Text;
                model.SecondName = surnameTextbox.Text;
                model.IdNumber = idTextbox.Text;
                model.Url = urlTextbox.Text;
            }
        }
        
        private bool ValidateForm()
        {
            bool output = true;
            if (forenameTextbox.Text.Length == 0)
            {
                output = false;
            }

            if (surnameTextbox.Text.Length == 0)
            {
                output = false;
            }

            if (idTextbox.Text.Length == 0)
            {
                output = false;
            }

            if (urlTextbox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }
    }
}
