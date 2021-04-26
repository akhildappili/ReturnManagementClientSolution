using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReturnMgmtClientProject.Models.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ReturnMgmtClientProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            //HttpContext.Session.SetString("UserId", login.Username);
            string token = "";
            using (var httpclient = new HttpClient())
            {
                httpclient.BaseAddress = new Uri("http://localhost:9885/");
                var postData = httpclient.PostAsJsonAsync<Login>("api/Login/AuthenicateUser", login);
                var res = postData.Result;
                if (res.IsSuccessStatusCode)
                {
                    token = await res.Content.ReadAsStringAsync();
                   // HttpContext.Session.SetString("IsvalidUser", token);
                    TempData["token"] = token;
                    if (token != null)
                    {
                       return RedirectToAction("IndexWelcom", "User", new { name = login.Username });
                        //return RedirectToAction("ProcessRequest", "User",new {name=login.Username});
                        //return RedirectToAction("ProcessRequest", "User");
                    }
                }
                else
                {
                    ViewBag.Message = "Invalid details";
                }
            }
            return View();


        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}
