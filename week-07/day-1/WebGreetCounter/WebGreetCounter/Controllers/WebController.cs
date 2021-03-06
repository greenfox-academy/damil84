﻿using Microsoft.AspNetCore.Mvc;
using WebGreetCounter.Models;

namespace WebGreetCounter.Controllers
{
    [Route("")]
    [Route("web")]
    public class WebController : Controller
    {
        public static int WebCounter;
        public int Id { get; private set; }

        [Route("")]
        public IActionResult Index()    
        {
            return Content("This is the /web index, Nice to see you here!");
        }

        [Route("Greeting")]
        public IActionResult Greeting([FromQuery]string name)
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = $"{name}! This site was loaded {++WebCounter} times since last server start"
            };

            return View(greeting);
        }
    }
}