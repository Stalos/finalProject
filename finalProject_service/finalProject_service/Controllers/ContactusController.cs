using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using finalProject_service.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Json.Net;
using System.Windows;
using System.Net.Mail;

namespace finalProject_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactusController : ControllerBase
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
            }
            return Ok(o1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("mikesplaceangular@gmail.com");
                mail.To.Add("orenchen1990@gmail.com");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("yoursmtphost");
                smtp.Send(mail);
                //SmtpServer.Port = 587;
                //SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                //SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
            }
        }

    }
}
