using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ORCA.Models;
using System.Data.Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace ORCA.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private DefaultConnection db = new DefaultConnection();

        public ManageController()
        {
        }

        public ManageController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set 
            { 
                _signInManager = value; 
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        //DO NOT MESS WITH ANYTHING ABOVE THIS













//for User table  vvvv
        public string getFirstName(string email)
        {
            string firstName = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con)){
                string oString = "Select * from Users where email=@fName";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Fname", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        firstName = oReader["FirstName"].ToString();
                    }
                    myConnection.Close();
                }
            }
            return firstName;
        }

        public string getLastName(string email)
        {
            string lastName = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@lName";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Lname", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lastName = oReader["FirstName"].ToString();
                    }
                    myConnection.Close();
                }
                return lastName;
            }
        }

        public string getPhoneNumber(string email)
        {
            string phoneNum = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@phoneNum";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@PhoneNum", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        phoneNum = oReader["PhoneNumber"].ToString();
                    }
                    myConnection.Close();
                }
                return phoneNum;
            }
        }

        public string getState(string email)
        {
            string state = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@STate";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@STATe", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        state = oReader["State"].ToString();
                    }
                    myConnection.Close();
                }
                return state;
            }
        }

        public string getCountry(string email)
        {
            string country = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@COuntry";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@COUntry", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        country = oReader["Country"].ToString();
                    }
                    myConnection.Close();
                }
                return country;
            }
        }

        public string getCity(string email)
        {
            string city = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@CIty";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@City", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        city = oReader["City"].ToString();
                    }
                    myConnection.Close();
                }
                return city;
            }
        }

        public string getZip(string email)
        {
            string zip = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@ZipCode";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Zipcode", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        zip = oReader["Zip"].ToString();
                    }
                    myConnection.Close();
                }
                return zip;
            }
        }

        public string getOrg(string email)
        {
            string org = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@Organization";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@ORganization", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        org = oReader["Organization"].ToString();
                    }
                    myConnection.Close();
                }
                return org;
            }
        }

        public string getUserType(string email)
        {
            string userType = "";
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@Usertype";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@usertype", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        userType = oReader["UserType"].ToString();
                    }
                    myConnection.Close();
                }
            }
            return userType;
        }

        public string getCreateDate (string email)
        {
            string createDate = "";

            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where email=@CreateDate";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@createdate", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        createDate = oReader["CreateDate"].ToString();
                    }
                    myConnection.Close();
                }
            }
            return createDate;
        }
        
        public int getID(string email)
        {
            int ID = 0;

            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users Where Email=@theID";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Theid", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        ID = Convert.ToInt32(oReader["ID"].ToString());
                    }
                    myConnection.Close();
                }
            }
            return ID;
        }

        public bool getIsAdmin(string email)
        {
            bool isAdmin = false;
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where Email=@isAdmin";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Isadmin", email);
                myConnection.Open();
                using(SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        string a = oReader["IsAdmin"].ToString();
                        if (a.Equals("True"))
                        {
                            isAdmin = true;
                        }
                        else
                        {
                            isAdmin = false;
                        }
                        
                    }
                    myConnection.Close();
                }
            }
            return isAdmin;
        }
//for User table ^^^^

//for expert table vvvv

        public int getExpertID(string email)
        {
            int ID = 0;

            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Experts Where Email=@theID";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Theid", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        ID = Convert.ToInt32(oReader["ID"].ToString());
                    }
                    myConnection.Close();
                }
            }
            return ID;
        }

        public string getExpertTitle(string email)
        {
            string title = "";

            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Experts where email=@Title";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@TItle", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        title = oReader["Title"].ToString();
                    }
                    myConnection.Close();
                }
            }
            return title;
        }

        public string getExpertCategory(string email)
        {
            string cat = "";

            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Experts where email=@Category";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@CAtegory", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        cat = oReader["Category"].ToString();
                    }
                    myConnection.Close();
                }
            }
            return cat;
        }

        public string getExpertDesc(string email)
        {
            string desc = "";

            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Experts where email=@Description";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@DEscription", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        desc = oReader["Description"].ToString();
                    }
                    myConnection.Close();
                }
            }
            return desc;
        }

        public bool getHasRequested(string email)
        {
            bool hasRequested = false;
            var con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Users where Email=@Requested";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@requested", email);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        string a = oReader["Requested"].ToString();
                        if (a.Equals("True"))
                        {
                            hasRequested = true;
                        }
                        else
                        {
                            hasRequested = false;
                        }
                    }
                    myConnection.Close();
                }
            }
            return hasRequested;
        }
        //for expert table ^^^^


        //GET: /Manage/AdminPromote
        public ActionResult AdminPromote()
        {
            var temp = db.Users.ToList();
            return View(temp);
        }
        //POST: /Manage/AdminPromote
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminPromote(string email)
        {
            var user = new User
            {
                //this is the only one changed by view
                IsAdmin = true,
                //the rest are pulled back from db
                UserType = getUserType(email),
                CreateDate = getCreateDate(email),
                ID = getID(email),
                Email = email,
                FirstName = getFirstName(email),
                LastName = getLastName(email),
                PhoneNumber = getPhoneNumber(email),
                State = getState(email),
                Country = getCountry(email),
                City = getCity(email),
                Zip = getZip(email),
                Organization = getOrg(email)

            };


            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //GET: /Manage/VerifyExpert
        public ActionResult VerifyExpert()
        {
            var temp = db.Experts.ToList();
            return View(temp);
        }
        //POST: /Manage/VerifyExpert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VerifyExpert(string email)
        {
            //change usertype and put in old info. might be a better way to do this but this is the way i knew how to
            var user = new User
            {
                //this is the only one changed by view
                UserType = "expert",
                //the rest are pulled back from db
                CreateDate = getCreateDate(email),
                ID = getID(email),
                IsAdmin = getIsAdmin(email),
                Email = email,
                FirstName = getFirstName(email),
                LastName = getLastName(email),
                PhoneNumber = getPhoneNumber(email),
                State = getState(email),
                Country = getCountry(email),
                City = getCity(email),
                Zip = getZip(email),
                Organization = getOrg(email)

            };

            //change request to false so it stops showing up on list
            var expert = new Expert
            {
                //only one to be changed
                Requested = false,
                //these need to just be taken from db
                ID = getExpertID(email),
                Email = email,
                Title = getExpertTitle(email),
                Category = getExpertCategory(email),
                Description = getExpertDesc(email)
            };

            if (ModelState.IsValid)
            {
                //save new user info
                db.Entry(user).State = EntityState.Modified;
                //save new expert info
                db.Entry(expert).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);

        }

        //GET: /Manage/EditAccount
        public ActionResult EditAccount()
        {
            return View();
        }
        //POST: /Manage/EditAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAccount(User model)
        {
            User user = new Models.User
            {
                //not edited by user
                //all of these need to be taken from database otherwise they will all try to fill with null because the view isnt returning anytihng
                //taken using email. should be safe??
                UserType = getUserType(model.Email),
                IsAdmin = getIsAdmin(model.Email),
                CreateDate = getCreateDate(model.Email),
                ID = getID(model.Email),

                //edited by user
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                State = model.State,
                Country = model.Country,
                City = model.City,
                Zip = model.Zip,
                Organization = model.Organization
            };

            var expert = new Expert
            {
                Requested = getHasRequested(User.Identity.GetUserName()),
                ID = getExpertID(User.Identity.GetUserName()),
                Email = model.Email,
                Title = getExpertTitle(User.Identity.GetUserName()),
                Category = getExpertCategory(User.Identity.GetUserName()),
                Description = getExpertDesc(User.Identity.GetUserName())
            };


            //test for errors
            //this just builds a list of errors for you
            //debug from this line and read the  errors
            var errors = ModelState.Values.SelectMany(v => v.Errors);

            if (ModelState.IsValid)
            {
                db.Entry(expert).State = EntityState.Modified;

                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //GET: /Manage/ExpertList
        public ActionResult ExpertList()
        {
            var temp = db.Experts.ToList();
            return View(temp);
        }

        //GET: /Manage/CreateTicket
        public ActionResult CreateTicket()
        {

            return View();
        }
        //POST: /Manage/CreateTicket
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTicket(Ticket model)
        {
            //// expertID = ;
            //var ticket = new Ticket
            //{
            //    ID = model.ID,
            //    UserEmail = User.Identity.GetUserName(),
            //    ExpertID = ,
            //    Subject = model.Subject,
            //    Text = model.Text,
            //    CreateDate = DateTime.Today.ToString()

            //};

            //if (ModelState.IsValid)
            //{
            //    db.Entry(ticket).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            return View();
        }


















        //DO NOT MESS WITH ANYTHING BELOW THIS

        //
        // GET: /Manage/Index
        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."
                : message == ManageMessageId.Error ? "An error has occurred."
                : message == ManageMessageId.AddPhoneSuccess ? "Your phone number was added."
                : message == ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."
                : "";

            var userId = User.Identity.GetUserId();
            var model = new IndexViewModel
            {
                HasPassword = HasPassword(),
                PhoneNumber = await UserManager.GetPhoneNumberAsync(userId),
                TwoFactor = await UserManager.GetTwoFactorEnabledAsync(userId),
                Logins = await UserManager.GetLoginsAsync(userId),
                BrowserRemembered = await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId)
            };
            return View(model);
        }

        //
        // POST: /Manage/RemoveLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemoveLogin(string loginProvider, string providerKey)
        {
            ManageMessageId? message;
            var result = await UserManager.RemoveLoginAsync(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                message = ManageMessageId.RemoveLoginSuccess;
            }
            else
            {
                message = ManageMessageId.Error;
            }
            return RedirectToAction("ManageLogins", new { Message = message });
        }

        //
        // GET: /Manage/AddPhoneNumber
        public ActionResult AddPhoneNumber()
        {
            return View();
        }

        //
        // POST: /Manage/AddPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddPhoneNumber(AddPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Generate the token and send it
            var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), model.Number);
            if (UserManager.SmsService != null)
            {
                var message = new IdentityMessage
                {
                    Destination = model.Number,
                    Body = "Your security code is: " + code
                };
                await UserManager.SmsService.SendAsync(message);
            }
            return RedirectToAction("VerifyPhoneNumber", new { PhoneNumber = model.Number });
        }

        //
        // POST: /Manage/EnableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EnableTwoFactorAuthentication()
        {
            await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), true);
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", "Manage");
        }

        //
        // POST: /Manage/DisableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DisableTwoFactorAuthentication()
        {
            await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), false);
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", "Manage");
        }

        //
        // GET: /Manage/VerifyPhoneNumber
        public async Task<ActionResult> VerifyPhoneNumber(string phoneNumber)
        {
            var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), phoneNumber);
            // Send an SMS through the SMS provider to verify the phone number
            return phoneNumber == null ? View("Error") : View(new VerifyPhoneNumberViewModel { PhoneNumber = phoneNumber });
        }

        //
        // POST: /Manage/VerifyPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyPhoneNumber(VerifyPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePhoneNumberAsync(User.Identity.GetUserId(), model.PhoneNumber, model.Code);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.AddPhoneSuccess });
            }
            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "Failed to verify phone");
            return View(model);
        }

        //
        // POST: /Manage/RemovePhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemovePhoneNumber()
        {
            var result = await UserManager.SetPhoneNumberAsync(User.Identity.GetUserId(), null);
            if (!result.Succeeded)
            {
                return RedirectToAction("Index", new { Message = ManageMessageId.Error });
            }
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
            }
            return RedirectToAction("Index", new { Message = ManageMessageId.RemovePhoneSuccess });
        }

        //
        // GET: /Manage/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Manage/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                if (user != null)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                }
                return RedirectToAction("Index", new { Message = ManageMessageId.ChangePasswordSuccess });
            }
            AddErrors(result);
            return View(model);
        }

        //
        // GET: /Manage/SetPassword
        public ActionResult SetPassword()
        {
            return View();
        }

        //
        // POST: /Manage/SetPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SetPassword(SetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await UserManager.AddPasswordAsync(User.Identity.GetUserId(), model.NewPassword);
                if (result.Succeeded)
                {
                    var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
                    if (user != null)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                    }
                    return RedirectToAction("Index", new { Message = ManageMessageId.SetPasswordSuccess });
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Manage/ManageLogins
        public async Task<ActionResult> ManageLogins(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
                : message == ManageMessageId.Error ? "An error has occurred."
                : "";
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());
            if (user == null)
            {
                return View("Error");
            }
            var userLogins = await UserManager.GetLoginsAsync(User.Identity.GetUserId());
            var otherLogins = AuthenticationManager.GetExternalAuthenticationTypes().Where(auth => userLogins.All(ul => auth.AuthenticationType != ul.LoginProvider)).ToList();
            ViewBag.ShowRemoveButton = user.PasswordHash != null || userLogins.Count > 1;
            return View(new ManageLoginsViewModel
            {
                CurrentLogins = userLogins,
                OtherLogins = otherLogins
            });
        }

        //
        // POST: /Manage/LinkLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LinkLogin(string provider)
        {
            // Request a redirect to the external login provider to link a login for the current user
            return new AccountController.ChallengeResult(provider, Url.Action("LinkLoginCallback", "Manage"), User.Identity.GetUserId());
        }

        //
        // GET: /Manage/LinkLoginCallback
        public async Task<ActionResult> LinkLoginCallback()
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync(XsrfKey, User.Identity.GetUserId());
            if (loginInfo == null)
            {
                return RedirectToAction("ManageLogins", new { Message = ManageMessageId.Error });
            }
            var result = await UserManager.AddLoginAsync(User.Identity.GetUserId(), loginInfo.Login);
            return result.Succeeded ? RedirectToAction("ManageLogins") : RedirectToAction("ManageLogins", new { Message = ManageMessageId.Error });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }

            base.Dispose(disposing);
        }

#region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        private bool HasPhoneNumber()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PhoneNumber != null;
            }
            return false;
        }

        public enum ManageMessageId
        {
            AddPhoneSuccess,
            ChangePasswordSuccess,
            SetTwoFactorSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            RemovePhoneSuccess,
            Error
        }

#endregion
    }
}