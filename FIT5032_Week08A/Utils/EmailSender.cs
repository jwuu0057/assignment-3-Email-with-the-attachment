using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FIT5032_Week08A.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@dinnerme.com", "DinnerMe Register");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, "Hi," + to + ". Welcome to DinnerMe! You are a member now.");
            //Attachment newAttach = new Attachment(Server.MapPath("~/MyFile.txt"));
            //msg.Attachments.Add(newAttach);
            var response = client.SendEmailAsync(msg);
        }

    }
}