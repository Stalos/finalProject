using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using finalProject_service.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Json.Net;
namespace finalProject_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            // how to read from file and show it properly?  
            string filePath = @"C:\Users\Oren\Desktop\FinalProject\finalProject_service\finalProject_service\RestaurantRating.txt";

            var o1 = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(filePath));

            // read JSON directly from a file
            Console.WriteLine(System.IO.File.OpenText(filePath));
            using (StreamReader file = System.IO.File.OpenText(filePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                Console.WriteLine(JToken.ReadFrom(reader));
                //JObject o2 = (JObject)JToken.ReadFrom(reader);
            }


            //string json = System.IO.File.ReadAllText(filePath);
            //List <rating> result = JsonConvert.DeserializeObject<List<rating>>(json);

            //var objects = JsonConvert.DeserializeObject<List<rating>>(json);
            //var result = objects.Select(obj => JsonConvert.SerializeObject(obj)).ToArray();


            return Ok(o1);
        }
 
        // POST api/values
        [HttpGet]
        [Route("rate")]
        public void InsertNew([FromQuery] int stars, [FromQuery] string head, [FromQuery] string body)
        {
            /// read the file
            /// parse - list of json object
            /// 
            string filePath = @"C:\Users\Oren\Desktop\FinalProject\finalProject_service\finalProject_service\RestaurantRating.txt";
            List<rating> _data = new List<rating>();
            /// add the new object (rating)
            rating temp = new rating(stars, head, body);
            _data.Add(temp); // _data should be the list from the file
            string json = JsonConvert.SerializeObject(_data.ToArray());
            /// save the new list to file
            System.IO.File.WriteAllText(filePath, json);
        }
    }
}
