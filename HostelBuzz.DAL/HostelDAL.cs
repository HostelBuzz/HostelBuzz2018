using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelBuzz.Models;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace HostelBuzz.DAL
{
    public class HostelDAL
    {
    
            #region Variables  
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataAdapter adap;
            DataTable dt;
            DataSet ds;
            string connectionstring = ConfigurationManager.ConnectionStrings["HostelTrackerConnectionString"].ConnectionString;
            #endregion

            #region Constructor  
            public HostelDAL()
            {
                con = new MySqlConnection(this.connectionstring);
            }
            #endregion

            #region Public Method  
            /// <summary>  
            /// This method is used to get all User Details.  
            /// </summary>  
            /// <returns></returns>  
            public List<UserDetails> GetUserDetails()
            {
            //for test
            // return new List<UserDetails>() { new UserDetails() { id = 1, fname = "Tesla", phone_number = "12345" }, new UserDetails() { id = 1, fname = "Tata", phone_number = "54321" } };
            return new List<UserDetails>() { new UserDetails() { id = 9, fname = "Prasad", lname = "Das", address = "Thalasherry", phone_number = "12345", email_id = "test@123", state_id = 1, city = "Kannur", created_on = DateTime.Now, is_active = "1", role_id = 1 }, new UserDetails() { id = 10, fname = "Sreejith", lname = "Thampy", address = "TVM", phone_number = "54321", email_id = "test1@123", state_id = 1, city = "Kannur", created_on = DateTime.Now, is_active = "1", role_id = 1 }, new UserDetails() { id = 11, fname = "Vineeth", lname = "Kumar", address = "Banglore", phone_number = "985645213", email_id = "test11@123", state_id = 1, city = "Kannur", created_on = DateTime.Now, is_active = "1", role_id = 1 } };

            List<UserDetails> objUserDetails = new List<UserDetails>();
                using (cmd = new MySqlCommand("P_GetUserDetails", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        adap = new MySqlDataAdapter();
                        adap.SelectCommand = cmd;
                        dt = new DataTable();
                        adap.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                        UserDetails col = new UserDetails();
                        col.id = Convert.ToInt32(row["id"]);
                        col.fname = row["fname"].ToString();
                        col.lname = row["lname"].ToString();
                        col.address =row["address"].ToString();
                        col.phone_number = row["phone_number"].ToString();
                        col.email_id = row["email_id"].ToString();
                        col.state_id = Convert.ToInt32(row["state_id"]);
                        col.city = row["city"].ToString();
                        col.created_on = Convert.ToDateTime(row["created_on"].ToString());
                        col.is_active = row["is_active"].ToString();
                        objUserDetails.Add(col);
                        }
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                    }
                    return objUserDetails;
                }
            }
        #endregion
        public List<UserDetails> GetUserById(int id)
        {
            //for test
            return new List<UserDetails>() { new UserDetails() { id = 9, fname = "Prasad",lname= "Das",address= "Thalasherry", phone_number = "12345",email_id= "test@123", state_id=1,city= "Kannur", created_on= Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy HH:mm")), is_active ="1",role_id=1 } };

            List<UserDetails> objVendorById = new List<UserDetails>();
            using (cmd = new MySqlCommand("P_GetUserDetails", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@Userid", id));
                    con.Open();
                    adap = new MySqlDataAdapter();
                    adap.SelectCommand = cmd;
                    dt = new DataTable();
                    adap.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        UserDetails col = new UserDetails();
                        col.id = Convert.ToInt32(row["id"]);
                        col.fname = row["fname"].ToString();
                        col.lname = row["lname"].ToString();
                        col.address = row["address"].ToString();
                        col.phone_number = row["phone_number"].ToString();
                        col.email_id = row["email_id"].ToString();
                        col.state_id = Convert.ToInt32(row["state_id"]);
                        col.city = row["city"].ToString();
                        col.created_on = Convert.ToDateTime(row["created_on"].ToString());
                        col.is_active = row["is_active"].ToString();
                        col.role_id = Convert.ToInt32(row["role_id"]);
                        objVendorById.Add(col);
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                }
                return objVendorById;
            }
        }

        public int SaveOrUpdateUser(UserDetails userDetails)
        {
            int res = 0;
            //string result;
            //using (cmd = new MySqlCommand("sp_user_insert", con))
            //{
            //    try
            //    {

            //        con.Open();

            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@id", userDetails.id);
            //        cmd.Parameters.AddWithValue("@fname", userDetails.fname);
            //        cmd.Parameters.AddWithValue("@lname", userDetails.lname);
            //        cmd.Parameters.AddWithValue("@address", userDetails.address);
            //        cmd.Parameters.AddWithValue("@phone_number", userDetails.phone_number);
            //        cmd.Parameters.AddWithValue("@email_id", userDetails.email_id);
            //        cmd.Parameters.AddWithValue("@state_id", userDetails.state_id);
            //        cmd.Parameters.AddWithValue("@city", userDetails.city);
            //        cmd.Parameters.AddWithValue("@created_on", userDetails.created_on);
            //        cmd.Parameters.AddWithValue("@is_active", userDetails.is_active);
            //        cmd.Parameters.AddWithValue("@role_id", userDetails.role_id);
            //        cmd.Parameters.Add("@returnid", MySqlDbType.Int16, 500);
            //        cmd.Parameters["@returnid"].Direction = ParameterDirection.Output;
            //        cmd.ExecuteScalar();
            //        result = cmd.Parameters["@returnid"].Value.ToString();
            //        res = Convert.ToInt16(result);
            //        con.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        con.Close();
            //    }
            //}

            if (res == 0 || res==null)
            {
                res = 11;
            }
            
            return res;
        }


    }
}  