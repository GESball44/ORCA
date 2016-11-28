using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORCA.Models
{
    public class Ticket
    {

        //we are still missing created date for this table
        public int ID { get; set; }
        public string UserEmail { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public string CreateDate { get; set; }
        public string ExpertID{ get; set; }
    }
}