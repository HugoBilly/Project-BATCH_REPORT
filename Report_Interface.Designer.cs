namespace TEST_Rapport5
{
    partial class Report_Interface
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Interface));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MainMenuStripReportInterface = new System.Windows.Forms.MenuStrip();
            this.FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.checkBoxAlarmsDataInterface = new System.Windows.Forms.CheckBox();
            this.checkBoxAuditTrailsDataInterface = new System.Windows.Forms.CheckBox();
            this.checkBoxTrendsDataInterface = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainMenuStripReportInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TEST_Rapport5.Properties.Resources.logo_pg_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(784, 20);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "   BATCH REPORT";
            // 
            // MainMenuStripReportInterface
            // 
            this.MainMenuStripReportInterface.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenuStripReportInterface.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStripReportInterface.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesToolStripMenuItem});
            this.MainMenuStripReportInterface.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStripReportInterface.Name = "MainMenuStripReportInterface";
            this.MainMenuStripReportInterface.Size = new System.Drawing.Size(784, 24);
            this.MainMenuStripReportInterface.TabIndex = 4;
            this.MainMenuStripReportInterface.Text = "MainMenuStripReportInterface";
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
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(100, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.PrintToolStripMenuItem.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.QuitToolStripMenuItem.Text = "&Quit";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(0, 441);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(784, 20);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "2020  |  V.1.0  ";
            // 
            // checkBoxAlarmsDataInterface
            // 
            this.checkBoxAlarmsDataInterface.AutoSize = true;
            this.checkBoxAlarmsDataInterface.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBoxAlarmsDataInterface.ForeColor = System.Drawing.Color.White;
            this.checkBoxAlarmsDataInterface.Location = new System.Drawing.Point(68, 0);
            this.checkBoxAlarmsDataInterface.Name = "checkBoxAlarmsDataInterface";
            this.checkBoxAlarmsDataInterface.Size = new System.Drawing.Size(122, 17);
            this.checkBoxAlarmsDataInterface.TabIndex = 6;
            this.checkBoxAlarmsDataInterface.Text = "AlarmsDataInterface";
            this.checkBoxAlarmsDataInterface.UseVisualStyleBackColor = false;
            // 
            // checkBoxAuditTrailsDataInterface
            // 
            this.checkBoxAuditTrailsDataInterface.AutoSize = true;
            this.checkBoxAuditTrailsDataInterface.BackColor = System.Drawing.Color.Green;
            this.checkBoxAuditTrailsDataInterface.ForeColor = System.Drawing.Color.White;
            this.checkBoxAuditTrailsDataInterface.Location = new System.Drawing.Point(196, 0);
            this.checkBoxAuditTrailsDataInterface.Name = "checkBoxAuditTrailsDataInterface";
            this.checkBoxAuditTrailsDataInterface.Size = new System.Drawing.Size(140, 17);
            this.checkBoxAuditTrailsDataInterface.TabIndex = 7;
            this.checkBoxAuditTrailsDataInterface.Text = "AuditTrailsDataInterface";
            this.checkBoxAuditTrailsDataInterface.UseVisualStyleBackColor = false;
            // 
            // checkBoxTrendsDataInterface
            // 
            this.checkBoxTrendsDataInterface.AutoSize = true;
            this.checkBoxTrendsDataInterface.BackColor = System.Drawing.Color.Red;
            this.checkBoxTrendsDataInterface.ForeColor = System.Drawing.Color.White;
            this.checkBoxTrendsDataInterface.Location = new System.Drawing.Point(342, 0);
            this.checkBoxTrendsDataInterface.Name = "checkBoxTrendsDataInterface";
            this.checkBoxTrendsDataInterface.Size = new System.Drawing.Size(124, 17);
            this.checkBoxTrendsDataInterface.TabIndex = 8;
            this.checkBoxTrendsDataInterface.Text = "TrendsDataInterface";
            this.checkBoxTrendsDataInterface.UseVisualStyleBackColor = false;
            // 
            // Report_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.checkBoxTrendsDataInterface);
            this.Controls.Add(this.checkBoxAuditTrailsDataInterface);
            this.Controls.Add(this.checkBoxAlarmsDataInterface);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainMenuStripReportInterface);
            this.MainMenuStrip = this.MainMenuStripReportInterface;
            this.Name = "Report_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Interface";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainMenuStripReportInterface.ResumeLayout(false);
            this.MainMenuStripReportInterface.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip MainMenuStripReportInterface;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripMenuItem FilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxAlarmsDataInterface;
        private System.Windows.Forms.CheckBox checkBoxAuditTrailsDataInterface;
        private System.Windows.Forms.CheckBox checkBoxTrendsDataInterface;
    }
}
