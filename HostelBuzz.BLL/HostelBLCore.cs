using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelBuzz.DAL;
using HostelBuzz.Models;

namespace HostelBuzz.BLL
{
    
    public abstract class HostelBLCore
        {
        #region Public Method  
        /// <summary>  
        /// This method is used to get the Hostel Details  
        /// </summary>  
        /// <returns></returns>  
        protected List<UserDetails> GetUserDetails()
        {
            List<UserDetails> objUserDetails = null;
            try
            {
                objUserDetails = new HostelDAL().GetUserDetails();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objUserDetails;
        }

        protected List<UserDetails> GetUserById(int id)
        {
            List<UserDetails> objVendorById = null;
            int vendorid = id;
            try
            {
                objVendorById = new HostelDAL().GetUserById(vendorid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objVendorById;
        }

        protected int SaveOrUpdateUser(UserDetails userDetails)
        {
            int res=0;            
            try
            {
                res = new HostelDAL().SaveOrUpdateUser(userDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }
        #endregion

    }
}