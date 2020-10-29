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
    public partial class AuditTrailsDataInterface : Form
    {

        // DECLARATION of the List containing the keywords for filter
        private List<String> filterConstraints;

        // DECLARATION of private members
        private string FileName = string.Empty;

        public AuditTrailsDataInterface()
        {
            InitializeComponent();
            populateCombo();
            comboBox1.DataSource = filterConstraints;
        }

        #region CREATE AUDITTRAILS TABLE
        private DataTable CreateAuditTrailsTable()
        {
            // CREATE an empty DataTable named "AuditTrailsTable"
            DataTable Result = new DataTable("AuditTrailsTable");

            // CREATION of DataColumns 
            Result.Columns.Add(new DataColumn("Date", typeof(string)));         // Header : "Date"
            Result.Columns.Add(new DataColumn("Phase", typeof(string)));        // Header : "Phase"
            Result.Columns.Add(new DataColumn("Action", typeof(string)));       // Header : "Action"
            Result.Columns.Add(new DataColumn("Opérateur", typeof(string)));    // Header : "Opérateur"

            // RETURN value
            return Result;
        }
        #endregion CREATE AUDITTRAILS TABLE

        # region ADD ROWS AUDITTRAILS TABLE
        private void AddRowsAuditTrailsTable(string RowRead, DataTable AuditTrailsTable)
        {
            // DEFINITION of the reading index position 
            int index = 0;

            // CUT the line according to the separator character ";"
            string[] ReadValues = RowRead.Split(new char[] { ';' });

            // CREATE a new DataRow
            DataRow DataRows = AuditTrailsTable.NewRow();

            // UPDATE the DataRow for all values 
            foreach (string values in ReadValues)
            {
                switch (index++)
                {
                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "Date" header
                    case 1:
                        DataRows["Date"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "Phase" header
                    case 4:
                        DataRows["Phase"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "Action" header
                    case 5:
                        DataRows["Action"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "Opérateur" header
                    case 3:
                        DataRows["Opérateur"] = values.Trim();
                        break;
                }
            }
            // ADDS the new DataRow to the DataTable
            AuditTrailsTable.Rows.Add(DataRows);
        }
        #endregion ADD ROWS AUDITTRAILS TABLE

        #region OPEN CSV FILES
        private DataTable OpenFile(string NameFile)
        {
            // DEFINITION of the return variable
            DataTable result = null;

            // DEFINITION and assignment of variables
            string LineRead = string.Empty;
            bool IsFirstLine = true;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(NameFile))
            {
                do
                {
                    // Foreach line READ
                    LineRead = sr.ReadLine();

                    // If this is the first row read, then CREATE the DataTable
                    if (IsFirstLine && LineRead != null)
                    {
                        result = CreateAuditTrailsTable();
                        IsFirstLine = false;
                    }
                    // If the DataRow is not null, then ADD the row to the DataTable
                    if (LineRead != null)
                        AddRowsAuditTrailsTable(LineRead, result);
                } while (LineRead != null);
            }
            // RETURN value
            return result;
        }
        
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog FileOpen = new System.Windows.Forms.OpenFileDialog())
            {
                // File OPENING with CSV file extension filter
                FileOpen.Filter = "AuditTrails File(.csv)|*.csv";
                FileOpen.InitialDirectory = @"";
                if (FileOpen.ShowDialog() == DialogResult.OK)
                {
                    // LOADS the data file into the BindingSource
                    BindingSourceAuditTrails.DataSource = this.OpenFile(FileOpen.FileName);

                    // CONFIGURE navigation
                    BindingNavigatorAuditTrails.BindingSource = BindingSourceAuditTrails;

                    // CONFIGURES the DataGridView on the same source as the navigation source
                    DataGridViewAuditTrails.DataSource = BindingNavigatorAuditTrails.BindingSource;

                    // STORES the file name 
                    FileName = FileOpen.FileName;

                    // SPECIFIES the file name
                    // [FILENAME WITHOUT PATH : SafeFileName ?]
                    Text = string.Concat(FileName);
                }
            }
        }
        #endregion OPEN CSV FILES

        #region PRINT DATAGRIDVIEW
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // PRINTING, recording pdf format of the dynamic DataGridview
            // USING DllGlobal, DllUserControl, Imprimer
            DataGridViewAuditTrails.Imprimer(FileName, "", Resources.logo_pg_2, null);
        }        
        #endregion PRINT DATAGRIDVIEW

        #region QUIT FORM
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CLOSE the AuditTrailsDataInterface
            this.Close();
        }

        private void AuditTrailsDataInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Message title : "Are you sure that you would like to close the form ?"
            const string message = "Are you sure that you would like to close the form ?";

            // Safety during "FormClosing" event
            const string caption = "Form Closing";

            // CONFIGURE message display and activate a YesNo question
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the 'No' button was pressed
            if (result == DialogResult.No)
            {
                // CANCEL the closure of the AuditTrailsDataInterface
                e.Cancel = true;
            }
        }
        #endregion QUIT FORM

        #region DATAGRIDVIEW FILTER
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CONFIGURES the comboBox1 navigation
            String selectedItem = comboBox1.SelectedItem.ToString();
            BindingSourceAuditTrails.Filter = string.Format("Phase Like '%{0}%'", selectedItem);
        }

        private void populateCombo()
        {
            // CREATION of a List containing the filters
            filterConstraints = new List<String>
            {               
                "",         // Empty box    : DISABLE all the filters                       :   ""                  
                "ALARM",    // ALARM box    : ENABLE  ALARM filter with keyword             :   "ALARM"                
                "PASS",     // PASS box     : ENABLE  BY_PASS filter with keyword           :   "PASS" 
                "REGU",     // REGU box     : ENABLE  CONTROLLER filter with keyword        :   "CONTROLLER"                 
                "DECO",     // DECO box     : ENABLE  DISCONNECTION filter with keyword     :   "DECO"               
                "FOR",      // FOR box      : ENABLE  OVERRIDE filter with keyword          :   "FOR"                               
                "PARAM",    // PARAM box    : ENABLE  PARAMETERS filter with keyword        :   "PARAM"              
                "PHASE",    // PHASE box    : ENABLE  PHASE filter with keyword             :   "PHASE"               
                "RECIP",    // RECIP box    : ENABLE  RECIPE filter with keyword            :   "RECIP"               
                "RECO",     // RECO box     : ENABLE  RECORDING filter with keyword         :   "RECO" 
                "CONSIGN",  // CONSIGN box  : ENABLE  SETPOINT filter with keyword          :   "CONSIGN"                             
                "UTIL"      // UTIL box     : ENABLE  USER_MANAGEMENT filter with keyword   :   "UTIL"
            };
            // ESTABLISHED the link between the comboBox1, the filter List and the DataGridView
            comboBox1.DataSource = filterConstraints;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // CONFIGURES the textBox1 to filter the DataColumn "Phase" of DataGridView based on the keyword
            BindingSourceAuditTrails.Filter = "Phase like '%" + textBox1.Text + "%'";
        }

        private void checkBoxClearFilters_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkBoxClearFilters.Checked)
            {
                // ESTABLISHED the link between checkBox "CLEAR FILTERS" and the textBox1 (Keyword Filter)
                textBox1.Text = "";
                
                checkBoxAlarms.Checked = false;                 // DISABLE checkBoxAlarms
                checkBoxByPass.Checked = false;                 // DISABLE checkBoxByPass
                checkBoxController.Checked = false;             // DISABLE checkBoxController
                checkDisconnection.Checked = false;             // DISABLE checkDisconnection
                checkBoxOverride.Checked = false;               // DISABLE checkBoxOverride
                checkBoxParameters.Checked = false;             // DISABLE checkBoxParameters
                checkBoxPhases.Checked = false;                 // DISABLE checkBoxPhases
                checkBoxRecipe.Checked = false;                 // DISABLE checkBoxRecipe
                checkBoxRecording.Checked = false;              // DISABLE checkBoxRecording
                checkBoxSetpoint.Checked = false;               // DISABLE checkBoxSetpoint
                checkBoxOperatorManagement.Checked = false;     // DISABLE checkBoxOperatorManagement

            }
        }

        private void checkBoxAlarms_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Alarms" and filters
            // TRUE  : "ALARM" filter 
            // FALSE : "CLEAR FILTERS"
            if (checkBoxAlarms.Checked)
            {
                textBox1.Text = "ALARM";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Alarms" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxByPass_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "ByPass" Recording and filter
            // TRUE  : "PASS" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxByPass.Checked)
            {
                textBox1.Text = "PASS";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "ByPass" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxController_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Controller" and filter
            // TRUE  : "REGU" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxController.Checked)
            {
                textBox1.Text = "REGU";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Controller" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkDisconnection_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Disconnection" and filter
            // TRUE  : "DECO" filter 
            // FALSE : "CLEAR" filter
            if (checkDisconnection.Checked)
            {
                textBox1.Text = "DECO";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Disconnection" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxOverride_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Override" and filter
            // TRUE  : "FOR" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxOverride.Checked)
            {
                textBox1.Text = "FOR";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Override" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxParameters_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Parameters" and filter
            // TRUE  : "PARAM" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxParameters.Checked)
            {
                textBox1.Text = "PARAM";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Parameters" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxPhases_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Phases" and filter
            // TRUE  : "PHASE" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxPhases.Checked)
            {
                textBox1.Text = "PHASE";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Phases" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxRecipe_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Recipe" and filter 
            // TRUE  : "RECIP" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxRecipe.Checked)
            {
                textBox1.Text = "RECIP";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Recipe" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxRecording_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Recording" and filter 
            // TRUE  : "RECO" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxRecording.Checked)
            {
                textBox1.Text = "RECO";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Recording" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxSetpoint_CheckedChanged(object sender, EventArgs e)
        {
            // ESTABLISHED the link between checkBox "Setpoint" and filter 
            // TRUE  : "CONSIGN" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxSetpoint.Checked)
            {
                textBox1.Text = "CONSIGN";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "Setpoint" and textBox1
                textBox1.Text = "";
            }
        }

        private void checkBoxOperatorManagement_CheckedChanged(object sender, EventArgs e)
        {

            // ESTABLISHED the link between checkBox "OperatorManagement" and filter 
            // TRUE  : "UTIL" filter 
            // FALSE : "CLEAR" filter
            if (checkBoxOperatorManagement.Checked)
            {
                textBox1.Text = "UTIL";
                checkBoxClearFilters.Checked = false;
            }
            else
            {
                // LINK between checkBox "OperatorManagement" and textBox1
                textBox1.Text = "";
            }
        }
        #endregion DATAGRIDVIEW FILTER
    }
}
