using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ORCA.Models
{
    public class User
    {

        //dont know what to do with all the field so some of them will not be required or asked for for awhile
        public int ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        //where the user is from
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        //what organizate user is with
        public string Organization { get; set; }

        //these are preset field that the user doesnt enter

        //tells whether they are regular user or expert
        //should default to regular
        public string UserType { get; set; }
        //isAdmin should default to false
        public bool IsAdmin { get; set; }
        //get this from local machine for now
        public string CreateDate { get; set; }

    }

    public class DefaultConnection : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Response> Responses { get; set; }
    }
}