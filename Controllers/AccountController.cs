using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Web_Stock_Market.Models;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Web_Stock_Market.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection connetion = new SqlConnection();
        SqlCommand command = new SqlCommand();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {

        }
        public ActionResult Verify(Account account)
        {
            return View();

        }
    }
}
