using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MMSalesBoard.Models.Identity;


namespace MMSalesBoard.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private IConfiguration _config;


        public UserController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration config
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
        }



        [Route("Register")]
        [HttpPost]
        public async Task<JsonResult> Register([FromBody]RegisterModel model)
        {
            var message = string.Empty;
            var user = new ApplicationUser
            {
                UserName = model.TCKN,
                Email = model.Email,
                FullName = model.FullName,
                PhoneNumber = model.PhoneNo,
                EmailConfirmed = true
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {

                return Json(new { success = true, message = "Kayit basariyla gerceklesti. Giris ekranina yonlendiriliyorsunuz..", code = 200 });
            }

            message = result.Errors.Aggregate(message, (current, error) => current + error.Description);

            return Json(new { success = false, message = message, code = 205 });

        }



    }



    public class UsercredentialsModel
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }
    }

    public class RegisterModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public string TCKN { get; set; }
    }

    public class ForgotViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }

    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}