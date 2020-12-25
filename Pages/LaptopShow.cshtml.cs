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
    public class LaptopShowModel: PageModel{

    public IList<Laptop> LaptopsTable { get; set; }
    private readonly parts context;
    public LaptopShowModel(parts context)
    {
        this.context = context;   
    }
    public void OnGet()
    {
        LaptopsTable = context.Laptop.ToList();
    }


    }
}