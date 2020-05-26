using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;

namespace SaveMailInfo
{
    public partial class DownloadMailButton
    {
        private void DownloadMailButton_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Button1_Click(object sender, RibbonControlEventArgs e)
        {
            // Get the Application object
            Outlook.Application application = Globals.ThisAddIn.Application;

            // Get the active Inspector object and check if is type of MailItem
            Outlook.Inspector inspector = application.ActiveInspector();

            var mailItem = inspector.CurrentItem as Outlook.MailItem;
            var email = new Email()
            {
                SenderEmailAddress = mailItem.SentOnBehalfOfName,
                To = mailItem.To,
                Cc = mailItem.CC,
                Subject = mailItem.Subject,
                Body = mailItem.Body,
                DateSend = DateTime.Now
            };

            var mailForm = new EmailForm(email);
            mailForm.ShowDialog();
        }
    }
}
