using MLHousePrice.BLL;
using MLHousePrice.DAL;
using MLHousePrice.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MLHousePrice
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();



         

        }      

        private void btnLogin_Click(object sender, EventArgs e)
        {
          


            Dal_Users user = new Dal_Users();

               DataSet ds= user.GetUser(tbAccount.Text, tbPass.Text);

               if (ds.Tables[0].Rows.Count > 0)
               {
                   User.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                   User.Surname = ds.Tables[0].Rows[0]["Surname"].ToString();
                   User.Education = ds.Tables[0].Rows[0]["Education"].ToString();
                   User.Age = int.Parse(ds.Tables[0].Rows[0]["Age"].ToString());

                   var usergoal = ShowDialog();
                
                   Dal_UserGoal dal_UserGoal = new Dal_UserGoal();
                    
                   bool goal = dal_UserGoal.UserGoalMLModel(usergoal);

                    if(goal)
                    {
                        FrmPrediction form1 = new FrmPrediction();
                        form1.Show();

                    }
                    else
                {
                    MessageBox.Show("You are denied");
                }
               }
                else
                   {
                       MessageBox.Show("You are not registered.");
                   }
            
                tbAccount.Text = "";
                tbPass.Text = "";           
        }     

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();
        }

        public static string ShowDialog()
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Attention",
                ForeColor = Color.Blue,             
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.White
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 400, ForeColor = Color.Blue, Text = "Why this site are visited by you?" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
   

}
