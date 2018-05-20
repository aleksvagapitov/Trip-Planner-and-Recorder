using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TheWorld.Services;
using TheWorld.ViewModels;

namespace TheWorld.Controllers.Web {
    public class AppController : Controller {
        private IMailService _mailService;
        private IConfigurationRoot _config;

        //private IMailService _mailService;

        public AppController (IMailService mailService, IConfigurationRoot config) {
            _mailService = mailService;
            _config = config;
        }

        public IActionResult Index () {
            return View ();
        }
        public IActionResult Contact () {
            //throw new InvalidOperationException ("Bad things happen to good developers");

            return View ();
        }

        [HttpPost]
        public IActionResult Contact (ContactViewModel model) {
            _mailService.SendMail (_config["MailSettings:ToAddress"], model.Email, "From TheWorld", model.Message);
            return View ();

        }

        public IActionResult About () {
            return View ();
        }
    }
}