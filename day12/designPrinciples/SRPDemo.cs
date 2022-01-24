using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

// Single Responsiblity Demo

namespace FirstProject.day12.designPrinciples.SRP {

    public class UserRegistration {
        public void RegisterUser(string uname, string pwd) {
            Console.WriteLine($"user registrated with {uname} and {pwd}");
        }
    }

    public class Logger {
        public void show(string content) {
            Console.WriteLine($"Error : content");
        }
    }

    public class SendEmail {
        public void Compose(string email, string subject, string content) {
            try {

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("hrshkndra@gmail.com");
                message.To.Add(new MailAddress(email));
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = content;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("hrshkndra@gmail.com","qwerty123#");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                Console.WriteLine($"Email Sent to {email}");

            } catch (Exception e) {
                Console.WriteLine($"Error (Email): {e.Message}");
            }
        }
    }

    class Demo {
        static void Main(string[] args) {
            try {
                var user = new UserRegistration();
                user.RegisterUser("imhrsh", "abc");

                var email = new SendEmail();
                email.Compose("harsh.bhumca18@gmail.com", "User Registered", "User Registered Successfully");


            } catch (Exception e) {
                Console.WriteLine($"Error : {e.Message}");
            }
        }
    }
}
