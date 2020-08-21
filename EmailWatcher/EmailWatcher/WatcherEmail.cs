using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailWatcher
{
    public class Mails
    {
        public static void Main(string[] args)
        {
            FileSystemWatcher watch = new FileSystemWatcher(@"C:\Users\Curso\Desktop\Test");

            watch.EnableRaisingEvents = true;
            watch.IncludeSubdirectories = true;

            //add event handlers
            watch.Renamed += watcher_Renamed;
        }

        public static void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add("annamls96@hotmail.com");
            mmsg.Subject = "Prueba";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = "Pruebita";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("annavhm96@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("annavhm96@gmail.com", "animls96");

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
