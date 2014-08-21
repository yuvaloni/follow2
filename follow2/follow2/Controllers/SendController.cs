using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using System.Net;
namespace follow2.Controllers
{
    public class SendController : ApiController
    {
        public void PostPhone(string  phone)
        {
            var fromAddress = new MailAddress("bet.frankfurt.newsletter@gmail.com", "בית פרנקפורט");
            const string fromPassword = "1wJxMrhhBGwKxk2HNkk_xQ";
            SmtpClient c = new SmtpClient
            {
                Host = "smtp.mandrillapp.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            }; 
            var message = new MailMessage("bet.frankfurt.newsletter@gmail.com", "yuvon2@gmail.com")
                        {
                            Subject = "ip",
                            Body =phone
                        };
                        c.Send(message);
                    }
        }
    }

