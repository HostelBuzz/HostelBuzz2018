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
                        col.fname = row["HostelName"].ToString();
                        col.lname = row["HostelAddress"].ToString();
                        col.address =row["HostelPhone"].ToString();
                        col.phone_number = row["HostelEmailID"].ToString();
                        col.email_id = row["ContactPerson"].ToString();
                        col.state_id = Convert.ToInt32(row["state_id"]);
                        col.city = row["City"].ToString();
                        col.created_on = Convert.ToDateTime(row["City"].ToString());
                        col.is_active = Convert.ToBoolean(row["City"].ToString());
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
        }
    }  