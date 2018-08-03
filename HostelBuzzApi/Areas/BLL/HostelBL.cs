using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HostelBuzz.BLL;
using HostelBuzz.Models;


namespace HostelBuzzApi.Areas.BLL
{
        internal sealed class HostelBL : HostelBLCore
        {
        /// <summary>  
        /// This method is used to get the Hostel Details  
        /// </summary>  
        /// <returns></returns>  
        internal new List<UserDetails> GetUserDetails()
            {
                return base.GetUserDetails();
            }
        }
    }

