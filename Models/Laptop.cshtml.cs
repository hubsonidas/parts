using System;
using System.ComponentModel.DataAnnotations;

namespace myWebApp.Models
{
    public class Laptop
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Producer { get; set; }
        public string State { get; set; }
        public string Image { get; set; }
    }
}