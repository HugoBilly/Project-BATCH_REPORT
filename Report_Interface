using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST_Rapport5.Properties;
using System.Windows.Forms;

// Author : Stagiaire BILLY Hugo
// V.1.0

namespace TEST_Rapport5
{
    public partial class Report_Interface : Form
    {
        public Report_Interface()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(checkBoxAlarmsDataInterface.Checked)
            {
                // If checkBoxAlarmsDataInterface.Checked = TRUE then OPEN the WindowChildForm "Alarms_DataInterface" and ACTIVATE its functions
                checkBoxAlarmsDataInterface.Checked = true;
                Alarms_DataInterface ChildFormAlarms_DataInterface = new Alarms_DataInterface();
                ChildFormAlarms_DataInterface.Show();
            }

            if (checkBoxAuditTrailsDataInterface.Checked)
            {
                // If checkBoxAuditTrailsDataInterface.Checked = TRUE then OPEN the WindowChildForm "AuditTrailsDataInterface" and ACTIVATE its functions
                checkBoxAuditTrailsDataInterface.Checked = true;
                AuditTrailsDataInterface ChildFormAuditTrailsDataInterface = new AuditTrailsDataInterface();
                ChildFormAuditTrailsDataInterface.Show();
            }

            if (checkBoxTrendsDataInterface.Checked)
            {
                // If checkBoxTrendsDataInterface.Checked = TRUE then OPEN the WindowChildForm "TrendsDataInterface" and ACTIVATE its functions
                checkBoxTrendsDataInterface.Checked = true;
                TrendsDataInterface ChildFormTrendsDataInterface = new TrendsDataInterface();
                ChildFormTrendsDataInterface.Show();
            }                  
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // Close the WindowChildForm "Alarms_DataInterface" and DISABLES its functions
            Alarms_DataInterface ChildFormAlarms_DataInterface = new Alarms_DataInterface();
            ChildFormAlarms_DataInterface.Close();
            this.Close();
            

            // Close the WindowChildForm "AuditTrailsDataInterface" and DISABLES its functions
            AuditTrailsDataInterface ChildFormAuditTrailsDataInterface = new AuditTrailsDataInterface();
            ChildFormAuditTrailsDataInterface.Close();
            this.Close();

            
            // Close the WindowChildForm "TrendsDataInterface" and DISABLES its functions
            TrendsDataInterface ChildFormTrendsDataInterface = new TrendsDataInterface();
            ChildFormTrendsDataInterface.Close();
            this.Close();

            // Close the WindowParentForm "Report_Interface", DISABLES its functions, and STOP 
            this.Close();         
        }
    }
}
