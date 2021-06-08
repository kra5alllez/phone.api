using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhone.Models.Enums;

namespace WebApiPhone.Models
{
    public class Phone
    {
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int RAM { get; set; }
        public CPU CPU { get; set; }
        public Display Display { get; set; }
    }
}
