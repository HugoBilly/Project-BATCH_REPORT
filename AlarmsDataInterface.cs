using System;
using System.Data;
using System.Windows.Forms;
using TEST_Rapport5.Properties;

// Author : Stagiaire BILLY Hugo
// V.1.0

namespace TEST_Rapport5
{
    public partial class Alarms_DataInterface : Form
    {
        // DECLARATION of Private members
        private string FileName = string.Empty;
        public Alarms_DataInterface()
        {
            InitializeComponent();
        }

        #region CREATE ALARMS TABLE
        DataTable CreateAlarmsTable()
        {
            //  CREATE an empty DataTable named "AlarmsTable"
            DataTable Result = new DataTable("AlarmsTable");

            //CREATION of DataColumns
            Result.Columns.Add(new DataColumn("Date", typeof(string)));                     // Header : "Date"
            Result.Columns.Add(new DataColumn("Type_alarme", typeof(string)));              // Header : "Type_alarme"
            Result.Columns.Add(new DataColumn("Evénement_alarme", typeof(string)));         // Header : "Evénement_alarme"
            Result.Columns.Add(new DataColumn("Nbr_Description_alarme", typeof(string)));   // Header : "Nbr_Description_alarme"
            Result.Columns.Add(new DataColumn("PLC", typeof(string)));                      // Header : "PLC"

            // RETURN value
            return Result;
        }
        #endregion CREATE ALARMS TABLE

        # region ADD ROWS ALARMS TABLE
        private void AddRowsAlarmsTable(string RowRead, DataTable AlarmsTable)
        {
            // DEFINITION of the reading index position 
            int index = 0;

            // CUT the line according to the separator character ";"
            string[] ReadValues = RowRead.Split(new char[] { ';' });

            // CREATE a new DataRow
            DataRow DataRows = AlarmsTable.NewRow();

            // UPDATE the DataRow for all values 
            foreach (string values in ReadValues)
            {
                switch (index++)
                {
                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "Date" header
                    case 13:
                        DataRows["Date"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "Type_alarme" header
                    case 1:
                        DataRows["Type_alarme"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "Evénement_alarme" header
                    case 2:
                        DataRows["Evénement_alarme"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "Nbr_Description_alarme" header
                    case 5:
                        DataRows["Nbr_Description_alarme"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n-1' to get the CSV DataColumn and link it to the "PLC" header
                    case 15:
                        DataRows["PLC"] = values.Trim();
                        break;
                }
            }
            // ADDS the new DataRow to the DataTable
            AlarmsTable.Rows.Add(DataRows);
        }
        #endregion ADD ROWS ALARMS TABLE

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
                        result = CreateAlarmsTable();
                        IsFirstLine = false;
                    }

                    // If the data row is not null, then ADD the row to the DataTable
                    if (LineRead != null)
                        AddRowsAlarmsTable(LineRead, result);
                } while (LineRead != null);
            }
            // Return value
            return result;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog FileOpen = new System.Windows.Forms.OpenFileDialog())
            {
                // File OPENING with CSV extension filter
                FileOpen.Filter = "Alarms File(.csv)|*.csv";
                FileOpen.InitialDirectory = @"";
                if (FileOpen.ShowDialog() == DialogResult.OK)
                {
                    // LOADS the data file into the BindingSource(Alarms)
                    BindingSourceAlarms.DataSource = this.OpenFile(FileOpen.FileName);

                    // CONFIGURE navigation
                    BindingNavigatorAlarms.BindingSource = BindingSourceAlarms;

                    // CONFIGURES the DataGridView on the same source as the navigation source
                    DataGridViewAlarms.DataSource = BindingNavigatorAlarms.BindingSource;                   

                    // STORES the file name 
                    FileName = FileOpen.FileName;

                    // SPECIFIES the file name
                    // [FILENAME WITHOUT PATH : SafeFileName ?]
                    Text = string.Concat(FileName);                    
                }
            }
        }
        #endregion Open CSV FILES

        #region PRINT DATAGRIDVIEW
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // PRINTING, recording pdf format of the dynamic DataGridview
            // USING DllGlobal, DllUserControl, Imprimer
            DataGridViewAlarms.Imprimer(FileName, "",Resources.logo_pg_2, null);            
        }    
        #endregion PRINT DATAGRIDVIEW

        #region QUIT FORM
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CLOSES the AlarmsDataInterface
            this.Close();
        }

        private void Alarms_DataInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Message title : "Are you sure that you would like to close the form ?"
            const string message = "Are you sure that you would like to close the form ?";

            // Safety during "FormClosing" event
            const string caption = "Form Closing";

            // CONFIGURE message display and activate a YesNo question
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed
            if (result == DialogResult.No)
            {
                // CANCEL the closure of the AlarmsDataInterface
                e.Cancel = true;
            }
        }
        #endregion QUIT FORM

        #region DATAGRIDVIEW FILTER
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // CONFIGURES the textBox1 to filter the DataColumn "Phase" of DataGridView based on the keyword
            BindingSourceAlarms.Filter = "Nbr_Description_alarme like '%" + textBox1.Text + "%'";
        }
        #endregion DATAGRIDVIEW FILTER
    }
}
