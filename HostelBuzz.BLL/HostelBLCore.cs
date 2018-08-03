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
        #endregion
    }
}