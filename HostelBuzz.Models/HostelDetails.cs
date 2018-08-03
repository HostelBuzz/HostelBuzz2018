using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HostelBuzz.Models
{

    /// <summary>  
    /// class for Hostel Details  
    /// </summary>  
    public class HostelDetails
    {
        #region Properties  
        ///<summary>  
        ///get and set the  Hostel ID  
        ///</summary>         
        public int HostelID { get; set; }
        ///<summary>  
        ///get and set the  Hostel Name  
        ///</summary>  
        [Display(Name = "Hostel Name")]
        public string HostelName { get; set; }
        ///<summary>  
        ///get and set the  Hostel Address  
        ///</summary>  
        [Display(Name = "Hostel Address")]
        public string HostelAddress { get; set; }
        ///<summary>  
        ///get and set the  Hostel Phone  
        ///</summary>  
        [Display(Name = "Hostel Phone")]
        public Int64 HostelPhone { get; set; }
        ///<summary>  
        ///get and set the  Hostel Email ID  
        ///</summary>  
        [Display(Name = "Hostel EmailID")]
        public string HostelEmailID { get; set; }
        ///<summary>  
        ///get and set the  Contact Person  
        ///</summary>  
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        ///<summary>  
        ///get and set the  State  
        ///</summary>  
        public string State { get; set; }
        ///<summary>  
        ///get and set the  City  
        ///</summary>  
        public string City { get; set; }
        #endregion

    }
}