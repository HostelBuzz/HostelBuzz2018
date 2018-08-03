using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HostelBuzz.Models;
using HostelBuzzApi.Areas.BLL;

namespace HostelBuzzApi.Controllers
{
    public class HostelDetailsController : ApiController
    {
        #region Variable  
        /// <summary>  
        /// varibale for HostelBL  
        /// </summary>  
        private HostelBL objHostelBL;
        /// <summary>  
        /// variable for HttpResponseMessage  
        /// </summary>  
        HttpResponseMessage response;
        #endregion

        #region Response Method  

        /// <summary>  
        /// This method is used to fetch the Hostel Details  
        /// </summary>  
        /// <returns></returns>  
        [HttpGet, ActionName("GetUserDetails")]
        public HttpResponseMessage GetUserDetails()
        {
            objHostelBL = new HostelBL();
            HttpResponseMessage response;
            try
            {
                var detailsResponse = objHostelBL.GetUserDetails();
                if (detailsResponse != null)
                    response = Request.CreateResponse<List<UserDetails>>(HttpStatusCode.OK, detailsResponse);
                else
                    response = new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }
        #endregion
    }
}
