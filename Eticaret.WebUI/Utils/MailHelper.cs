using Eticaret.Core.Entities;
using System.Net;
using System.Net.Mail;


namespace Eticaret.WebUI.Utils

{
    public class MailHelper
    {
        public static async  Task SendMailAsync (Contact contact)
        {
            SmtpClient client = new SmtpClient("mail.siteadi.com", 587);
            client.Credentials = new NetworkCredential("info@siteadi.com","mailşifresi");
            client.EnableSsl = false;
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("info@siteadi.com");//maili gonderen 
            mailMessage.To.Add("bilgi@siteadi.com"); //mailin gicegei adres
            mailMessage.Subject = "Siteden mesaj geldi";
            mailMessage.Body =$"İsim : {contact.Name} - Soyisim: {contact.Surname} -Email : {contact.Email} - Telefon :  {contact.Phone} - Mesaj : { contact.Message}" ;
            mailMessage.IsBodyHtml = true;
            await client.SendMailAsync(mailMessage);
            client.Dispose();
        }

    }
}
