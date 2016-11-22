using System;
using System.Net.Mail;
using System.Net;

namespace Longhorn_Music_Team_17
{
    public class EmailMessaging
    {
        private const string _emailServiceLogin = "longhornmusicteam17@gmail.com";
        private const string _emailServicePassword = "Password123!";
        private const string _senderEmail = "noreplay@longhornmusic.com";
        public static void SendEmail(String toEmailAddress, String emailSubject, String emailBody)

        {
            //Create an email client to send the emails

            var client = new SmtpClient("smtp.gmail.com", 587)

            {
                Credentials = new NetworkCredential(_emailServiceLogin, _emailServicePassword),
                EnableSsl = true
            };

            var finalMessage = emailBody + "\n\n This is a disclaimer that will be on all    messages. ";

            //Create an email address object for the sender address

            var senderEmail = new MailAddress(_senderEmail, "Long Horn Music");

            var mm = new MailMessage();

            mm.Subject = emailSubject;

            mm.Sender = senderEmail;

            mm.From = senderEmail;

            mm.To.Add(new MailAddress(toEmailAddress));

            mm.Body = finalMessage; //adds a footer

            client.Send(mm);

        }
    }
}