using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace places_webapi.Services;

public class EmailSender : IMessageService
{



    public void SendEmail(string from, string fromAddr, string to, string toAddr, string subject, string body)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(from, fromAddr));
        message.To.Add(new MailboxAddress(to, toAddr));
        message.Subject = subject;
        message.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = body };

        using var client = new SmtpClient();
        client.Connect("localhost", 1025, false);
        //client.Authenticate("1519297bb9afb8", "fbff028b266255");
        client.Send(message);
        client.Disconnect(true);

    }

    public void SendEmail(string fromAddr, string toAddr, string subject, string body)
    {
        SendEmail(fromAddr, fromAddr, toAddr, toAddr, subject, body);
    }
}