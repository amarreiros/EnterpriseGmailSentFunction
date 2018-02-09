using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace emailGamilEnterprise
{
    class Program
    {

        static public void SendMailsGmailEnterprise(string pFromEmailUserStr, string pPasswordStr, string pDestEmailStr, string pEmailSubject, string pTextStr) {
            MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress(pFromEmailUserStr);
            message.From = fromAddress;
            message.To.Add(pDestEmailStr);
           
            message.Subject = pEmailSubject;  
            message.IsBodyHtml = true;
            message.Body = pTextStr;


            var client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = true;
            
            client.Credentials = new NetworkCredential(pFromEmailUserStr, pPasswordStr);
            client.EnableSsl = true;

            client.Send(message);
               
        }


        static void Main(string[] args)
        {
            string mailFrom = @"noreply@gmailEnt.eu";
            string userPass = "PsR4YrTpuwqw";
            string mailTo = "meuemail@teste.com";
            string mailSubject = "EmailGmailEnterprise";
            string mailBodyTest = @"Email test Lorem Ipsum, mas a maioria sofreu algum tipo de alteração, seja por inserção de passagens com humor, ou palavras aleatórias que não parecem nem um pouco convincentes. Se você pretende usar uma passagem de Lorem Ipsum, precisa ter certeza de que não há algo embaraçoso escrito escondido no meio do texto. Todos os geradores de Lorem Ipsum na internet tendem a repetir pedaços predefinidos conforme necessário, fazendo deste o primeiro gerador de Lorem Ipsum autêntico da internet. Ele usa um dicionário com mais de 200 palavras em Latim combinado com um punhado de modelos de estrutura de frases para gerar um Lorem Ipsum com aparência razoável, livre de repetições, inserções de humor, palavras não características, etc.";

            SendMailsGmailEnterprise(mailFrom, userPass, mailTo, mailSubject, mailBodyTest);
        }
    }
}
