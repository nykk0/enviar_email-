using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;
using System.Net;
using System.Net.Mail;

namespace testeasd
{
    internal class enviar_email
    {
        public string msg = "";

        public void Enviar_email(string emailDestinatario)
        {
            try
            {
                Random random = new Random();
                int codigo = random.Next(1111, 9999);
                string senha = "COLOQUE A SENHA DO SEU GMAIL" ;
                MailMessage mailMessage = new MailMessage("COLOQUEI SEU GMAIL", emailDestinatario);
                mailMessage.Subject = $"SEU TITULO";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = $"<p>SEU TEXTO</p>";
                mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("22001484@aluno.cotemig.com.br", senha);

                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);

                msg = "Seu email foi enviado com sucesso! :)";              
            }
            catch (Exception)
            {
                
                msg = "Houve um erro no envio do email :(";

            }
        }
        public string mensagem()
        {
            return msg;
        }
    }
}
