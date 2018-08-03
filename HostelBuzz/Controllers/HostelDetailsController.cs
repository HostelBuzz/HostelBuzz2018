using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelBuzz.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
 

namespace HostelBuzz.Controllers
{
    public class HostelDetailsController : Controller
    {
        // GET: HostelDetails
        public ActionResult Index()
        {
            return View();
        }

        // GET: HostelDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet, ActionName("gethostellist")]
        public ActionResult GetHostelList()
        {
            var list = new List<HostelDetails>();
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response;
            //http://localhost:51773/api/HostelDetails
            response = httpClient.GetAsync("http://localhost:51773/api/HostelDetails").Result;
            //response = httpClient.GetAsync("http://localhost:59866/api/" + "HostelDetails/GetAllHostelDetails/").Result;
            response.EnsureSuccessStatusCode();
            List<HostelDetails> cd = response.Content.ReadAsAsync<List<HostelDetails>>().Result;
            return View("~/Views/HostelDetails/HostelDetails.cshtml", cd);
        }


        // GET: HostelDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HostelDetails/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HostelDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HostelDetails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HostelDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HostelDetails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
