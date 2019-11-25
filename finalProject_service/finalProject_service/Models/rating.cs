using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject_service.Models
{
    public class rating
    {
        public int numOfStars;
        public string date;
        public string headline;
        public string text;

        public rating(int numOfStars, string headline, string text)
        {
            this.numOfStars = numOfStars;
            this.headline = headline;
            this.text = text;
            this.date = DateTime.Now.ToString();
        }
    }
}
