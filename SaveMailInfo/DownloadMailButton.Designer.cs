namespace SaveMailInfo
{
    partial class DownloadMailButton : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DownloadMailButton()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadMailButton));
            this.NewMailMessage = this.Factory.CreateRibbonTab();
            this.SaveMessage = this.Factory.CreateRibbonGroup();
            this.btnSave = this.Factory.CreateRibbonButton();
            this.ReadMailMessage = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.NewMailMessage.SuspendLayout();
            this.SaveMessage.SuspendLayout();
            this.ReadMailMessage.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewMailMessage
            // 
            this.NewMailMessage.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.NewMailMessage.ControlId.OfficeId = "TabNewMailMessage";
            this.NewMailMessage.Groups.Add(this.SaveMessage);
            this.NewMailMessage.Label = "TabNewMailMessage";
            this.NewMailMessage.Name = "NewMailMessage";
            // 
            // SaveMessage
            // 
            this.SaveMessage.Items.Add(this.btnSave);
            this.SaveMessage.Label = "Save Message";
            this.SaveMessage.Name = "SaveMessage";
            // 
            // btnSave
            // 
            this.btnSave.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSave.Description = "Save E-mail";
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Label = "Download E-mail";
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowImage = true;
            this.btnSave.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button1_Click);
            // 
            // ReadMailMessage
            // 
            this.ReadMailMessage.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.ReadMailMessage.ControlId.OfficeId = "TabReadMessage";
            this.ReadMailMessage.Groups.Add(this.group1);
            this.ReadMailMessage.Label = "TabReadMessage";
            this.ReadMailMessage.Name = "ReadMailMessage";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Label = "Save Message";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Description = "Save E-mail";
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Label = "Download E-mail";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            // 
            // DownloadMailButton
            // 
            this.Name = "DownloadMailButton";
            this.RibbonType = "Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.NewMailMessage);
            this.Tabs.Add(this.ReadMailMessage);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.DownloadMailButton_Load);
            this.NewMailMessage.ResumeLayout(false);
            this.NewMailMessage.PerformLayout();
            this.SaveMessage.ResumeLayout(false);
            this.SaveMessage.PerformLayout();
            this.ReadMailMessage.ResumeLayout(false);
            this.ReadMailMessage.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab NewMailMessage;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup SaveMessage;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSave;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab ReadMailMessage;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
    }

    partial class ThisRibbonCollection
    {
        internal DownloadMailButton DownloadMailButton
        {
            get { return this.GetRibbon<DownloadMailButton>(); }
        }
    }
}
