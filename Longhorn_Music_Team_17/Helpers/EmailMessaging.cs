using System;
using System.Net.Mail;
using System.Net;

namespace Longhorn_Music_Team_17
{
    public class EmailMessaging
    {

        private const string _emailServiceLogin = "longhornmusicteam17@gmail.com";
        private const string _emailServicePassword = "Pssword123!";
        private const string _senderEmail = "noreplay@longhornmusic.com";
        public static void SendEmail(String toEmailAddress, String emailSubject, String emailBody)

        {

            try
            {
                //Create an email client to send the emails

                var client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(_emailServiceLogin, _emailServicePassword);



                var finalMessage = emailBody + "<br/><br/>Thank you!<br/><br/>Longhorn Music Team 17";

                //Create an email address object for the sender address

                var senderEmail = new MailAddress(_senderEmail, "Longhorn Music");

                var mm = new MailMessage();

                mm.Subject = emailSubject;

                mm.Sender = senderEmail;

                mm.From = senderEmail;

                mm.To.Add(new MailAddress(toEmailAddress));

                mm.Body = finalMessage; //adds a footer

                mm.IsBodyHtml = true;

                client.Send(mm);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}