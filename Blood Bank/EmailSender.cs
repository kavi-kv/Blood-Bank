using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public  class EmailSender
    {

        // gavanvpvhblddwme

        public static int otpCode;
        public static void sendEmail(string reciepent)
        {
            try
            {
                var random = new Random();
                otpCode = random.Next(1000, 9999);
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("akafi54@gmail.com", "gavanvpvhblddwme"),
                    EnableSsl = true,
                };
                MailMessage msg = new MailMessage()
                {
                    From = new MailAddress("akafi54@gmail.com", "BloodBank System"),
                    Subject = "VERIFICATION CODE",
                    Body = $"<h1>OTP CODE - BLOOD BANK SYSTEM</h1><p>Your OTP Code is : {otpCode}",
                    IsBodyHtml = true
                };
                msg.To.Add(reciepent);
                smtpClient.Send(msg);
                MessageBox.Show("Succesfully Sent....");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
