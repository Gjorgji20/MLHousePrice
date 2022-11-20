using MLHousePrice.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLHousePrice.DAL
{
    public class Dal_Users : IUser
    {
        public DataSet GetUser(string Account, string Pass)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-09Q6SHE\\SQLEXPRESS;Initial Catalog=ML_project;User ID=sa;Password=Gjorgji1@";
            cnn = new SqlConnection(connetionString);
            try
            {
           
            cnn.Open();
            DataSet dt = new DataSet();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "GetUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 128)).Value = Account;
            cmd.Parameters.Add(new SqlParameter("@Pass", SqlDbType.NVarChar, 128)).Value = Pass;
             
                cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dt, "test");

       
             return dt;

           
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");                
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }

        public void SaveUser(string Name, string Surname, string Education, int Age, bool WorkingStatus, string Account, string Password)
        {
           
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=DESKTOP-09Q6SHE\\SQLEXPRESS;Initial Catalog=ML_project;User ID=sa;Password=Gjorgji1@";
                cnn = new SqlConnection(connetionString);
                try
                {

                    cnn.Open();
                   
                    var cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SaveUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 128)).Value = Name;
                    cmd.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar, 128)).Value = Surname;
                    cmd.Parameters.Add(new SqlParameter("@Education", SqlDbType.NVarChar, 128)).Value = Education;
                    cmd.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int)).Value = Age;
                    cmd.Parameters.Add(new SqlParameter("@WorkingStatus", SqlDbType.SmallInt)).Value = WorkingStatus;
                    cmd.Parameters.Add(new SqlParameter("@Account", SqlDbType.NVarChar, 128)).Value = Account;
                    cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 128)).Value = Password;
                cmd.Parameters.Add("@return_value", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                returnvalue = int.Parse(cmd.Parameters["@return_value"].Value.ToString());
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! ");
                   
                }
                finally
                {
                    cnn.Close();
                }


            }
        public int returnvalue = 0;
    }
}
