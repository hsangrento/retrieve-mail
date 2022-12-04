using System;
using System.Globalization;
using System.IO;
using EAGetMail;

namespace Client {
    class Program {
        public static void Main(string[] args) {
            try {
                string directory = string.Format("{0}//output", Directory.GetCurrentDirectory());
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                MailServer oServer = new MailServer("imap.gmail.com", "your_email", "your_password", ServerProtocol.Imap4);
                oServer.SSLConnection = true;
                oServer.Port = 993;

                MailClient oClient = new MailClient("TryIt"); // if you have a license code, replace "tryit" with your own license code
                oClient.Connect(oServer);
                MailInfo[] infos = oClient.GetMailInfos();
                int count = infos.Length;
                Console.WriteLine("loaded email(s): {0}", count);
                if(count != 0) {
                    for(int i=0;i<infos.Length;i++) {
                        MailInfo info = infos[i];
                        Mail oMail = oClient.GetMail(info);
                        string subjectDirectory = string.Format("{0}//output//{1}", Directory.GetCurrentDirectory(), oMail.Subject);
                        if(!Directory.Exists(subjectDirectory)) {
                            Directory.CreateDirectory(subjectDirectory);
                        }
                        string contentDirectory = string.Format("{0}//output//{1}//{2}", Directory.GetCurrentDirectory(), oMail.Subject , "content.txt");
                        if(!File.Exists(contentDirectory)) {
                            using (StreamWriter sw = File.CreateText(contentDirectory)) {
                                sw.WriteLine(oMail.From.ToString());
                                sw.WriteLine(oMail.HtmlBody);
                            }
                        }
                        Attachment [] atts = oMail.Attachments;
                        for(int j=0;j<atts.Length;j++) {
                            Attachment att = atts[j];
                            string attPath = string.Format("{0}//output//{1}//{2}", Directory.GetCurrentDirectory(), oMail.Subject, att.Name);
                            att.SaveAs(attPath, true);
                        }
                    }
                }
                oClient.Quit();
            } catch(Exception ep) {
                Console.WriteLine(ep.Message);
            }
        }
    }
}