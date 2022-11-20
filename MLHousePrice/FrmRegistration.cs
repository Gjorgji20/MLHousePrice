using MLHousePrice.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLHousePrice
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Dal_Users user = new Dal_Users();

            user.SaveUser(tbName.Text, tbSurname.Text, tbEducation.Text, int.Parse(tbAge.Text), bool.Parse(cbWStatus.Checked.ToString()), tbAccount.Text, tbPass.Text);

            if (user.returnvalue == 2)
            {
                MessageBox.Show("Successfully registration");
            }
            if(user.returnvalue==3)
            {
                MessageBox.Show("This user name exists");
            }
            if(user.returnvalue==1)
            {
                MessageBox.Show("Please, fill up all fields");
            }

            this.Close();

            tbName.Text = "";
            tbSurname.Text = "";
            tbEducation.Text = "";
            tbAge.Text = "";
            cbWStatus.Checked = false;
            tbAccount.Text = "";
            tbPass.Text = "";
        }
    }
}
