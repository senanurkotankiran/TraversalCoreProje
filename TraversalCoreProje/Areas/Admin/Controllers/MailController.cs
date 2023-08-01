using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            //mail gonderecek kisinin bilgileri
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin","srskk29@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            //mail alicak kisinin bilgileri
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com",587,false);
            client.Authenticate("srskk29@gmail.com", "lvzdlljyocgiccta");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
