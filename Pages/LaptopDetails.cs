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
    public class LaptopDetails: PageModel{


    public string ID {get; set;}
    private readonly parts context;
    public LaptopDetails(parts context)
    {
        this.context = context;   
    }
    public void OnGet()
    {
        ID = Request.QueryString.ToString();
        ID = ID.Replace("?ID=", "");
    }


    }
}