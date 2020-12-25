using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using myWebApp.Data;
using myWebApp.Models;


namespace myWebApp.Pages
{
    public class LaptopModel : PageModel
    {
        private parts db;

        [BindProperty]
        public Laptop laptop { get; set; }

        public LaptopModel(parts _db)
        {
            db = _db;
        }

        public void OnGet()
        {
            laptop = new Laptop();
             System.Diagnostics.Debug.WriteLine("laptop GET");
        }

        public void OnPost()
        {
            System.Diagnostics.Debug.WriteLine("LAPTOP POST");
            db.Laptop.Add(laptop);
            db.SaveChanges();
        }

    }
}