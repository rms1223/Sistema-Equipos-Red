using FOD_Meraki.Clases.Api_Fod;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace FOD_Meraki.Clases.MailModel
{
    class Procesar_Email
    {
        public Mail _Mail { get; set; }
        private SmtpClient smtpClient;
        private MailMessage mailMessage;


        public Procesar_Email(Mail mail)
        {
            this._Mail = mail;
            smtpClient = new SmtpClient();
            mailMessage = new MailMessage();
        }

        public bool Send_Mail()
        {
            try
            {

                smtpClient.Host = Key.SmtpHost;
                smtpClient.Port = Key.SmtpPort;

                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;

                smtpClient.Credentials = new System.Net.NetworkCredential(Key.Mail_User, Key.Mail_Pass);
                mailMessage.From = new MailAddress(Key.Mail_User);

                mailMessage.To.Add(new MailAddress(_Mail.Mail_To));
                if (_Mail.Mail_Cc.Count != 0)
                {
                    foreach (var cc in _Mail.Mail_Cc)
                    {
                        mailMessage.CC.Add(cc);

                    }
                }

                mailMessage.Subject = _Mail.Mail_Subject;
                string mensaje = string.Empty;
                mensaje += "<html> <body>  <h5>Nombre del Centro Educativo: "+_Mail.Mail_Message.nombreCE+"(" + _Mail.Mail_Message.codigo + ")</h5>" +
                    "<h5>Estado de Aceptación: " + _Mail.Mail_Message.estado+"</h5>" +
                    "<h5>Cartel: " + _Mail.Mail_Message.cartel + "</h5>" +
                    "<h5>" + _Mail.Mail_Message.descripcion + "</h5>" +
                    "<h5>" + _Mail.Mail_Message.NombreTecnico + "</h5>" +
                    "<h5>Fecha de Aceptación: " + _Mail.Mail_Message.fecha + "</h5>" +
                    "<img src='http://redesfod.com/images/aceptacionesRed.jpg'/>" +
                "</body>" +
                "</html>";
                mailMessage.Body = mensaje;
                if (_Mail.attachments.Count != 0)
                {
                    foreach (var attach in _Mail.attachments)
                    {
                        mailMessage.Attachments.Add(attach);
                    }
                }
                mailMessage.IsBodyHtml = true;
                smtpClient.Send(mailMessage);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
