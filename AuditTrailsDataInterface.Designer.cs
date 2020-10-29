using Neptune.Dll.DllUserControl;

namespace TEST_Rapport5
{
    partial class AuditTrailsDataInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditTrailsDataInterface));
            this.MenuStripAuditTrails = new System.Windows.Forms.MenuStrip();
            this.FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BindingSourceAuditTrails = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxAlarms = new System.Windows.Forms.CheckBox();
            this.checkBoxByPass = new System.Windows.Forms.CheckBox();
            this.checkBoxSetpoint = new System.Windows.Forms.CheckBox();
            this.checkBoxOverride = new System.Windows.Forms.CheckBox();
            this.checkBoxParameters = new System.Windows.Forms.CheckBox();
            this.checkBoxPhases = new System.Windows.Forms.CheckBox();
            this.checkBoxController = new System.Windows.Forms.CheckBox();
            this.checkBoxOperatorManagement = new System.Windows.Forms.CheckBox();
            this.checkBoxRecording = new System.Windows.Forms.CheckBox();
            this.checkBoxRecipe = new System.Windows.Forms.CheckBox();
            this.checkDisconnection = new System.Windows.Forms.CheckBox();
            this.checkBoxClearFilters = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewAuditTrails = new Neptune.Dll.DllUserControl.PGDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BindingNavigatorAuditTrails = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MenuStripAuditTrails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceAuditTrails)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuditTrails)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorAuditTrails)).BeginInit();
            this.BindingNavigatorAuditTrails.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripAuditTrails
            // 
            this.MenuStripAuditTrails.BackColor = System.Drawing.Color.White;
            this.MenuStripAuditTrails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripAuditTrails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesToolStripMenuItem});
            this.MenuStripAuditTrails.Location = new System.Drawing.Point(0, 0);
            this.MenuStripAuditTrails.Name = "MenuStripAuditTrails";
            this.MenuStripAuditTrails.Size = new System.Drawing.Size(1443, 24);
            this.MenuStripAuditTrails.TabIndex = 0;
            this.MenuStripAuditTrails.Text = "MenuStripAuditTrails";
            // 
            // FilesToolStripMenuItem
            // 
            this.FilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.toolStripSeparator,
            this.PrintToolStripMenuItem,
            this.toolStripSeparator2,
            this.QuitToolStripMenuItem});
            this.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem";
            this.FilesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.FilesToolStripMenuItem.Text = "&Files";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.PrintToolStripMenuItem.Text = "&Print";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.QuitToolStripMenuItem.Text = "&Quit";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "KeyWord Filter";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PHASE"});
            this.comboBox1.Location = new System.Drawing.Point(240, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxAlarms
            // 
            this.checkBoxAlarms.AutoSize = true;
            this.checkBoxAlarms.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBoxAlarms.Location = new System.Drawing.Point(379, 0);
            this.checkBoxAlarms.Name = "checkBoxAlarms";
            this.checkBoxAlarms.Size = new System.Drawing.Size(57, 17);
            this.checkBoxAlarms.TabIndex = 4;
            this.checkBoxAlarms.Text = "Alarms";
            this.checkBoxAlarms.UseVisualStyleBackColor = false;
            this.checkBoxAlarms.CheckedChanged += new System.EventHandler(this.checkBoxAlarms_CheckedChanged);
            // 
            // checkBoxByPass
            // 
            this.checkBoxByPass.AutoSize = true;
            this.checkBoxByPass.BackColor = System.Drawing.Color.Orange;
            this.checkBoxByPass.Location = new System.Drawing.Point(442, 0);
            this.checkBoxByPass.Name = "checkBoxByPass";
            this.checkBoxByPass.Size = new System.Drawing.Size(64, 17);
            this.checkBoxByPass.TabIndex = 5;
            this.checkBoxByPass.Text = "By Pass";
            this.checkBoxByPass.UseVisualStyleBackColor = false;
            this.checkBoxByPass.CheckedChanged += new System.EventHandler(this.checkBoxByPass_CheckedChanged);
            // 
            // checkBoxSetpoint
            // 
            this.checkBoxSetpoint.AutoSize = true;
            this.checkBoxSetpoint.BackColor = System.Drawing.Color.BlueViolet;
            this.checkBoxSetpoint.Location = new System.Drawing.Point(1059, 0);
            this.checkBoxSetpoint.Name = "checkBoxSetpoint";
            this.checkBoxSetpoint.Size = new System.Drawing.Size(65, 17);
            this.checkBoxSetpoint.TabIndex = 6;
            this.checkBoxSetpoint.Text = "Setpoint";
            this.checkBoxSetpoint.UseVisualStyleBackColor = false;
            this.checkBoxSetpoint.CheckedChanged += new System.EventHandler(this.checkBoxSetpoint_CheckedChanged);
            // 
            // checkBoxOverride
            // 
            this.checkBoxOverride.AutoSize = true;
            this.checkBoxOverride.BackColor = System.Drawing.Color.DimGray;
            this.checkBoxOverride.Location = new System.Drawing.Point(688, 0);
            this.checkBoxOverride.Name = "checkBoxOverride";
            this.checkBoxOverride.Size = new System.Drawing.Size(66, 17);
            this.checkBoxOverride.TabIndex = 7;
            this.checkBoxOverride.Text = "Override";
            this.checkBoxOverride.UseVisualStyleBackColor = false;
            this.checkBoxOverride.CheckedChanged += new System.EventHandler(this.checkBoxOverride_CheckedChanged);
            // 
            // checkBoxParameters
            // 
            this.checkBoxParameters.AutoSize = true;
            this.checkBoxParameters.BackColor = System.Drawing.Color.Tan;
            this.checkBoxParameters.Location = new System.Drawing.Point(760, 0);
            this.checkBoxParameters.Name = "checkBoxParameters";
            this.checkBoxParameters.Size = new System.Drawing.Size(79, 17);
            this.checkBoxParameters.TabIndex = 8;
            this.checkBoxParameters.Text = "Parameters";
            this.checkBoxParameters.UseVisualStyleBackColor = false;
            this.checkBoxParameters.CheckedChanged += new System.EventHandler(this.checkBoxParameters_CheckedChanged);
            // 
            // checkBoxPhases
            // 
            this.checkBoxPhases.AutoSize = true;
            this.checkBoxPhases.BackColor = System.Drawing.Color.Green;
            this.checkBoxPhases.Location = new System.Drawing.Point(845, 0);
            this.checkBoxPhases.Name = "checkBoxPhases";
            this.checkBoxPhases.Size = new System.Drawing.Size(61, 17);
            this.checkBoxPhases.TabIndex = 9;
            this.checkBoxPhases.Text = "Phases";
            this.checkBoxPhases.UseVisualStyleBackColor = false;
            this.checkBoxPhases.CheckedChanged += new System.EventHandler(this.checkBoxPhases_CheckedChanged);
            // 
            // checkBoxController
            // 
            this.checkBoxController.AutoSize = true;
            this.checkBoxController.BackColor = System.Drawing.Color.IndianRed;
            this.checkBoxController.Location = new System.Drawing.Point(512, 1);
            this.checkBoxController.Name = "checkBoxController";
            this.checkBoxController.Size = new System.Drawing.Size(70, 17);
            this.checkBoxController.TabIndex = 10;
            this.checkBoxController.Text = "Controller";
            this.checkBoxController.UseVisualStyleBackColor = false;
            this.checkBoxController.CheckedChanged += new System.EventHandler(this.checkBoxController_CheckedChanged);
            // 
            // checkBoxOperatorManagement
            // 
            this.checkBoxOperatorManagement.AutoSize = true;
            this.checkBoxOperatorManagement.BackColor = System.Drawing.Color.Olive;
            this.checkBoxOperatorManagement.Location = new System.Drawing.Point(1130, 0);
            this.checkBoxOperatorManagement.Name = "checkBoxOperatorManagement";
            this.checkBoxOperatorManagement.Size = new System.Drawing.Size(132, 17);
            this.checkBoxOperatorManagement.TabIndex = 11;
            this.checkBoxOperatorManagement.Text = "Operator Management";
            this.checkBoxOperatorManagement.UseVisualStyleBackColor = false;
            this.checkBoxOperatorManagement.CheckedChanged += new System.EventHandler(this.checkBoxOperatorManagement_CheckedChanged);
            // 
            // checkBoxRecording
            // 
            this.checkBoxRecording.AutoSize = true;
            this.checkBoxRecording.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBoxRecording.Location = new System.Drawing.Point(978, 0);
            this.checkBoxRecording.Name = "checkBoxRecording";
            this.checkBoxRecording.Size = new System.Drawing.Size(75, 17);
            this.checkBoxRecording.TabIndex = 13;
            this.checkBoxRecording.Text = "Recording";
            this.checkBoxRecording.UseVisualStyleBackColor = false;
            this.checkBoxRecording.CheckedChanged += new System.EventHandler(this.checkBoxRecording_CheckedChanged);
            // 
            // checkBoxRecipe
            // 
            this.checkBoxRecipe.AutoSize = true;
            this.checkBoxRecipe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.checkBoxRecipe.Location = new System.Drawing.Point(912, 0);
            this.checkBoxRecipe.Name = "checkBoxRecipe";
            this.checkBoxRecipe.Size = new System.Drawing.Size(60, 17);
            this.checkBoxRecipe.TabIndex = 14;
            this.checkBoxRecipe.Text = "Recipe";
            this.checkBoxRecipe.UseVisualStyleBackColor = false;
            this.checkBoxRecipe.CheckedChanged += new System.EventHandler(this.checkBoxRecipe_CheckedChanged);
            // 
            // checkDisconnection
            // 
            this.checkDisconnection.AutoSize = true;
            this.checkDisconnection.BackColor = System.Drawing.Color.MistyRose;
            this.checkDisconnection.Location = new System.Drawing.Point(588, 0);
            this.checkDisconnection.Name = "checkDisconnection";
            this.checkDisconnection.Size = new System.Drawing.Size(94, 17);
            this.checkDisconnection.TabIndex = 15;
            this.checkDisconnection.Text = "Disconnection";
            this.checkDisconnection.UseVisualStyleBackColor = false;
            this.checkDisconnection.CheckedChanged += new System.EventHandler(this.checkDisconnection_CheckedChanged);
            // 
            // checkBoxClearFilters
            // 
            this.checkBoxClearFilters.AutoSize = true;
            this.checkBoxClearFilters.Location = new System.Drawing.Point(1268, 1);
            this.checkBoxClearFilters.Name = "checkBoxClearFilters";
            this.checkBoxClearFilters.Size = new System.Drawing.Size(108, 17);
            this.checkBoxClearFilters.TabIndex = 16;
            this.checkBoxClearFilters.Text = "CLEAR FILTERS";
            this.checkBoxClearFilters.UseVisualStyleBackColor = true;
            this.checkBoxClearFilters.CheckedChanged += new System.EventHandler(this.checkBoxClearFilters_CheckedChanged);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Controls.Add(this.DataGridViewAuditTrails, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1443, 537);
            this.TableLayoutPanel1.TabIndex = 17;
            // 
            // DataGridViewAuditTrails
            // 
            this.DataGridViewAuditTrails.AllowUserToAddRows = false;
            this.DataGridViewAuditTrails.AllowUserToResizeRows = false;
            this.DataGridViewAuditTrails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridViewAuditTrails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewAuditTrails.BackgroundColor = System.Drawing.Color.Green;
            this.DataGridViewAuditTrails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAuditTrails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewAuditTrails.DoNothingOnKeyDownEnter = true;
            this.DataGridViewAuditTrails.Location = new System.Drawing.Point(3, 38);
            this.DataGridViewAuditTrails.Name = "DataGridViewAuditTrails";
            this.DataGridViewAuditTrails.RowHeadersVisible = false;
            this.DataGridViewAuditTrails.Size = new System.Drawing.Size(2047, 780);
            this.DataGridViewAuditTrails.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BindingNavigatorAuditTrails, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2047, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BindingNavigatorAuditTrails
            // 
            this.BindingNavigatorAuditTrails.AddNewItem = null;
            this.BindingNavigatorAuditTrails.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorAuditTrails.CountItemFormat = "{0} elements";
            this.BindingNavigatorAuditTrails.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BindingNavigatorAuditTrails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BindingNavigatorAuditTrails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigatorAuditTrails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem});
            this.BindingNavigatorAuditTrails.Location = new System.Drawing.Point(1023, 0);
            this.BindingNavigatorAuditTrails.MoveFirstItem = null;
            this.BindingNavigatorAuditTrails.MoveLastItem = null;
            this.BindingNavigatorAuditTrails.MoveNextItem = null;
            this.BindingNavigatorAuditTrails.MovePreviousItem = null;
            this.BindingNavigatorAuditTrails.Name = "BindingNavigatorAuditTrails";
            this.BindingNavigatorAuditTrails.PositionItem = null;
            this.BindingNavigatorAuditTrails.Size = new System.Drawing.Size(1024, 32);
            this.BindingNavigatorAuditTrails.TabIndex = 0;
            this.BindingNavigatorAuditTrails.Text = "BindingNavigatorAuditTrails";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(72, 29);
            this.bindingNavigatorCountItem.Text = "{0} elements";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Green;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1017, 26);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "AUDIT TRAILS REPORT";
            // 
            // AuditTrailsDataInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 561);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.checkBoxClearFilters);
            this.Controls.Add(this.checkDisconnection);
            this.Controls.Add(this.checkBoxRecipe);
            this.Controls.Add(this.checkBoxRecording);
            this.Controls.Add(this.checkBoxOperatorManagement);
            this.Controls.Add(this.checkBoxController);
            this.Controls.Add(this.checkBoxPhases);
            this.Controls.Add(this.checkBoxParameters);
            this.Controls.Add(this.checkBoxOverride);
            this.Controls.Add(this.checkBoxSetpoint);
            this.Controls.Add(this.checkBoxByPass);
            this.Controls.Add(this.checkBoxAlarms);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MenuStripAuditTrails);
            this.MainMenuStrip = this.MenuStripAuditTrails;
            this.Name = "AuditTrailsDataInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuditTrails_DataInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuditTrailsDataInterface_FormClosing);
            this.Load += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            this.MenuStripAuditTrails.ResumeLayout(false);
            this.MenuStripAuditTrails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceAuditTrails)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAuditTrails)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorAuditTrails)).EndInit();
            this.BindingNavigatorAuditTrails.ResumeLayout(false);
            this.BindingNavigatorAuditTrails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripAuditTrails;
        private System.Windows.Forms.ToolStripMenuItem FilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.BindingSource BindingSourceAuditTrails;
        public System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxAlarms;
        private System.Windows.Forms.CheckBox checkBoxByPass;
        private System.Windows.Forms.CheckBox checkBoxSetpoint;
        private System.Windows.Forms.CheckBox checkBoxOverride;
        private System.Windows.Forms.CheckBox checkBoxParameters;
        private System.Windows.Forms.CheckBox checkBoxPhases;
        private System.Windows.Forms.CheckBox checkBoxController;
        private System.Windows.Forms.CheckBox checkBoxOperatorManagement;
        private System.Windows.Forms.CheckBox checkBoxRecording;
        private System.Windows.Forms.CheckBox checkBoxRecipe;
        private System.Windows.Forms.CheckBox checkDisconnection;
        private System.Windows.Forms.CheckBox checkBoxClearFilters;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private PGDataGridView DataGridViewAuditTrails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.BindingNavigator BindingNavigatorAuditTrails;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
