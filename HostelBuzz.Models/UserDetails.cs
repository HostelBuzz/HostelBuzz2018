using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HostelBuzz.Models
{

    /// <summary>  
    /// class for User Details  
    /// </summary>  
    public class UserDetails
    {
       

        public int id { get; set; }

        public string fname { get; set; }

        public string lname { get; set; }

        public string address { get; set; }

        public string phone_number { get; set; }

        public string email_id { get; set; }

        public int state_id { get; set; }

        public string city { get; set; }

        public DateTime created_on { get; set; }

        public bool is_active { get; set; }
    }
}

