using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject_service.Models
{
    public class drink
    {
        public string name { get; set; }
        public string description{ get; set; }
        public string section { get; set; }
        public string price { get; set; }
        public string imgUrl { get; set; }

        public drink(string name, string description, string section, string price, string imgUrl)
        {
            this.name = name;
            this.description = description;
            this.section = section;
            this.price = price;
            this.imgUrl = imgUrl;
        }
    }

}