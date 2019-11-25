using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject_service.Models
{
    public class dish
    {
        public string name { get; set; }
        public string description { get; set; }
        public string section { get; set; }
        public string detail { get; set; }
        public int price { get; set; }
        public string imgUrl { get; set; }
        
        public dish(string name, string description, string section, string detail, int price, string imgUrl)
        {
            this.name = name;
            this.description = description;
            this.detail = detail;
            this.section=section;
            this.price = price;
            this.imgUrl = imgUrl;            
        }
    }

}
