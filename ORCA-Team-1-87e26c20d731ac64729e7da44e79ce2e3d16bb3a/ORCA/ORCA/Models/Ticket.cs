using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORCA.Models
{
    public class Ticket
    {

        //we are still missing created date for this table
        public string TickId { get; set; }
        public int ID { get; set; }
        public string Subject { get; set; }
    }
}