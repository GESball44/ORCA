using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ORCA.Models
{
    public class Send
    {
        public string GetUserId(IRequest request)
        {
            var userId = MyCustomUserClass.FindUserId(request.User.Identity.Name);
            return userId.ToString();
        }
    }
}