using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMailInfo
{
    public partial class EmailForm : Form
    {
        public EmailForm(Email mail)
        {
            InitializeComponent();
            txtSender.Text = mail.SenderEmailAddress;
            txtTo.Text = mail.To;
            txtCc.Text = mail.Cc;
            txtSubject.Text = mail.Subject;
            txtMessage.Text = mail.Body;
            lblDateValue.Text = mail.DateSend.ToString();
        }

       

        private void EmailForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        
    }
}
