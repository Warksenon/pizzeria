using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza;
using Test.TModels;

namespace Test.TPresenters
{
    class TFormMailPresenters 
    {
        IFormMail mail;

        public TFormMailPresenters(IFormMail mail)
        {
            this.mail = mail;
        }

        public void SetTextView()
        {
            TRegistry registry = new TRegistry();
            mail.TextBoxSender.Text = registry.Sender;
            mail.TextBoxPassword.Text = registry.Password;
            mail.TextBoxPort.Text = registry.Port;
            mail.TextBoxSmtp.Text = registry.Smtp;
            mail.TextBoxRecipient.Text = registry.Recipient;
        }


        public bool SaveDataEmial()
        {
            TRegistry registry = new TRegistry();
            bool falg = true;
            registry.Sender = mail.TextBoxSender.Text;
            registry.Password = mail.TextBoxPassword.Text;
            registry.Port = mail.TextBoxPort.Text;
            registry.Smtp = mail.TextBoxSmtp.Text;
            registry.Recipient = mail.TextBoxRecipient.Text;

            if (!registry.SaveRegistry())
            {
                falg = false;
                MessageBox.Show("Nieprawidłowe dane. Upewni się że wprowadzone dane: andresów e-mail, hasło, smtp, port są prawidłowe ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return falg;
        }
    }
}
