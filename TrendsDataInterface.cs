using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author : Stagiaire BILLY Hugo
// V.1.0

namespace TEST_Rapport5
{
    public partial class TrendsDataInterface : Form
    {
        // DECLARATION of private members
        private string FileName = string.Empty;
        public TrendsDataInterface()
        {
            InitializeComponent();
        }

        #region CREATE TRENDS TABLE
        private DataTable CreateTrendsTable()
        {
            // CREATE an empty DataTable named "TrendsTable"
            DataTable Result = new DataTable("TrendsTable");

            // // CREATION of DataColumns 
            Result.Columns.Add(new DataColumn("Date", typeof(string)));     // Header : "Date"
            Result.Columns.Add(new DataColumn("Field_2", typeof(string)));  // Header : "Field_2"
            Result.Columns.Add(new DataColumn("Field_3", typeof(string)));  // Header : "Field_3"
            Result.Columns.Add(new DataColumn("Field_4", typeof(string)));  // Header : "Field_4"
            Result.Columns.Add(new DataColumn("Field_5", typeof(string)));  // Header : "Field_5"
            Result.Columns.Add(new DataColumn("Field_6", typeof(string)));  // Header : "Field_6"
            Result.Columns.Add(new DataColumn("Field_7", typeof(string)));  // Header : "Field_7"
            Result.Columns.Add(new DataColumn("Field_8", typeof(string)));  // Header : "Field_8"
            Result.Columns.Add(new DataColumn("Field_9", typeof(string)));  // Header : "Field_9"

            // RETURN value
            return Result;
        }
        #endregion CREATE TRENDS TABLE

        # region ADD ROWS TRENDS TABLE
        private void AddRowsTrendsTable(string RowRead, DataTable TrendsTable)
        {
            // DEFINITION of the reading index position 
            int index = 0;

            // CUT the line according to the separator character ";"
            string[] ReadValues = RowRead.Split(new char[] { ';' });

            // CREATE a new DataRow
            DataRow DataRows = TrendsTable.NewRow();

            // UPDATE the DataRow for all values 
            foreach (string values in ReadValues)
            {
                switch (index++)
                {
                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Date" header
                    case 0:
                        DataRows["Date"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Field_2" header
                    case 1:
                        DataRows["Field_2"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Field_3" header
                    case 2:
                        DataRows["Field_3"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Field_4" header
                    case 3:
                        DataRows["Field_4"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Field_5" header
                    case 4:
                        DataRows["Field_5"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Field_6" header
                    case 5:
                        DataRows["Field_6"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Field_7" header
                    case 6:
                        DataRows["Field_7"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Field_8" header
                    case 7:
                        DataRows["Field_8"] = values.Trim();
                        break;

                    // CONFIGURE case 'n = n' to get the CSV DataColumn and link it to the "Field_9" header
                    case 8:
                        DataRows["Field_9"] = values.Trim();
                        break;
                }
            }
            // ADDS the new DataRow to the DataTable
            TrendsTable.Rows.Add(DataRows);
        }
        #endregion ADD ROWS TRENDS TABLE

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
                        result = CreateTrendsTable();
                        IsFirstLine = false;
                    }
                    // If the DataRow is not null, then ADD the row to the DataTable
                    if (LineRead != null)
                        AddRowsTrendsTable(LineRead, result);
                } while (LineRead != null);
            }
            // RETURN value
            return result;
        }

        private void OpenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog FileOpen = new System.Windows.Forms.OpenFileDialog())
            {
                // File OPENING with CSV file extension filter
                FileOpen.Filter = "Trends File(.csv)|*.csv";
                FileOpen.InitialDirectory = @"";
                if (FileOpen.ShowDialog() == DialogResult.OK)
                {
                    // LOADS the data file into the BindingSource
                    BindingSourceTrends.DataSource = this.OpenFile(FileOpen.FileName);

                    // CONFIGURE navigation
                    BindingNavigatorTrends.BindingSource = BindingSourceTrends;

                    // CONFIGURES the DataGridView on the same source as the navigation source
                    DataGridViewTrends.DataSource = BindingNavigatorTrends.BindingSource;

                    // STORES the file name 
                    FileName = FileOpen.FileName;

                    // SPECIFIES the file name
                    // [FILENAME WITHOUT PATH : SafeFileName ?]
                    Text = string.Concat(FileName);
                }
            }
        }
        #endregion OPEN CSV FILES 

        #region QUIT FORM
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CLOSE the TrendsDataInterface
            this.Close();
        }

        private void TrendsDataInterface_FormClosing(object sender, FormClosingEventArgs e)
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
                // Cancel the closure of the TrendsDataInterface
                e.Cancel = true;
            }
        }
        #endregion QUIT FORM

        /*private void button1_Click(object sender, EventArgs e)
        {
            chartTrends.Series["Date"].XValueMember = "Date";
            chartTrends.Series["Field_2"].YValueMembers = "Field_2";
            chartTrends.DataSource = TrendsTable;
            chartTrends.DataBind();
        }*/
    }

}
