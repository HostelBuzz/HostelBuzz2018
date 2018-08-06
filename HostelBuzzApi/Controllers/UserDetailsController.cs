using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HostelBuzz.Models;
using HostelBuzzApi.Areas.BLL;

namespace HostelBuzzApi.Controllers
{
    public class UserDetailsController : ApiController
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
        [Route("api/userdetails/GetUserDetails")]
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

        [HttpGet, ActionName("GetUserByID")]
        [Route("api/userdetails/GetUserDetails/{id:int}")]
        public HttpResponseMessage GetUserByID(int id)
        {
            objHostelBL = new HostelBL();
            int vendorid = id;
            HttpResponseMessage response;
            try
            {
                var detailsResponse = objHostelBL.GetUserById(vendorid);
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

        [HttpPost, ActionName("SaveOrUpdateUser")]
        public HttpResponseMessage SaveOrUpdateUser([FromBody] UserDetails userDetails)
        {
            objHostelBL = new HostelBL();            
            HttpResponseMessage response;
            try
            {
                var detailsResponse = objHostelBL.SaveOrUpdateUser(userDetails);
                if (detailsResponse != null)
                    response = Request.CreateResponse<int>(HttpStatusCode.OK, detailsResponse);
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
