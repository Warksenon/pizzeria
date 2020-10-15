using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza.Presenters
{
    class FormMailPresenters
    {
        readonly IFormMail mail;

        public FormMailPresenters(IFormMail mail)
        {
            this.mail = mail;
        }


        public void SetTextView()
        {
            Registry registry = new Registry();
            mail.TextBoxSender.Text = registry.Sender;
            mail.TextBoxPassword.Text = registry.Password;
            mail.TextBoxPort.Text = registry.Port;
            mail.TextBoxSmtp.Text = registry.Smtp;
            mail.TextBoxRecipient.Text = registry.Recipient;
        }


        public bool SaveDataEmial()
        {
            Registry registry = new Registry();
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
