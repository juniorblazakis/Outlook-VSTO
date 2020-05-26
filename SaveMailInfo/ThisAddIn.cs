using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace SaveMailInfo
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // Get the Application object
            Outlook.Application application = this.Application;
            // Get the Inspector object
            Outlook.Inspectors inspectors = application.Inspectors;
            // Get the active Inspector object
            Outlook.Inspector activeInspector = application.ActiveInspector();
            if (activeInspector != null)
            {
                // Get the title of the active item when the Outlook start.
                MessageBox.Show("Active inspector: " + activeInspector.Caption);
            }

            // ...
            // Add a new Inspector to the application
            inspectors.NewInspector +=
                new Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_AddTextToNewMail);


            // Get the Explorer objects
            Outlook.Explorers explorers = application.Explorers;
            // Get the active Explorer object
            Outlook.Explorer activeExplorer = application.ActiveExplorer();
            if (activeExplorer != null)
            {
                // Get the title of the active folder when the Outlook start.
                MessageBox.Show("Active explorer: " + activeExplorer.Caption);
            }
        }

        void Inspectors_AddTextToNewMail(Outlook.Inspector inspector)
        {
            MessageBox.Show(inspector.Caption);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
