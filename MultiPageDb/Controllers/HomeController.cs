/***************************************************************
* Name        : MultiPageDb
* Author      : Jacob Sharpe
* Created     : 09/9/2020
* Course      : CIS 174 - C#
* Version     : 1.0
* OS          : Windows 10, Visual Studio 19
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This is a multi page web app that keeps track of a persons contact
*               Input:  contact information
*               Output: person's contact list
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiPageDb.Models;


namespace MultiPageDb.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
    }
}
