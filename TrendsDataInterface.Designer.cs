namespace TEST_Rapport5
{
    partial class TrendsDataInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrendsDataInterface));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewTrends = new System.Windows.Forms.DataGridView();
            this.BindingNavigatorTrends = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TrendsTableLayoutPanelTrends = new System.Windows.Forms.TableLayoutPanel();
            this.chartTrends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BindingSourceTrends = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorTrends)).BeginInit();
            this.BindingNavigatorTrends.SuspendLayout();
            this.TrendsTableLayoutPanelTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTrends)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.FilesToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.FilesToolStripMenuItem.Text = "&Files";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(178, 6);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.PrintToolStripMenuItem.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // QuitToolStripMenuItem
            // 
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            this.QuitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.QuitToolStripMenuItem.Text = "&Quit";
            this.QuitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TrendsTableLayoutPanelTrends, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 882F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 662);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.DataGridViewTrends, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BindingNavigatorTrends, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(954, 654);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DataGridViewTrends
            // 
            this.DataGridViewTrends.AllowUserToAddRows = false;
            this.DataGridViewTrends.AllowUserToResizeColumns = false;
            this.DataGridViewTrends.AllowUserToResizeRows = false;
            this.DataGridViewTrends.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridViewTrends.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewTrends.BackgroundColor = System.Drawing.Color.Red;
            this.DataGridViewTrends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewTrends.Location = new System.Drawing.Point(4, 90);
            this.DataGridViewTrends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewTrends.Name = "DataGridViewTrends";
            this.DataGridViewTrends.RowHeadersVisible = false;
            this.DataGridViewTrends.RowHeadersWidth = 51;
            this.DataGridViewTrends.Size = new System.Drawing.Size(946, 560);
            this.DataGridViewTrends.TabIndex = 0;
            // 
            // BindingNavigatorTrends
            // 
            this.BindingNavigatorTrends.AddNewItem = null;
            this.BindingNavigatorTrends.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorTrends.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BindingNavigatorTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BindingNavigatorTrends.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigatorTrends.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem});
            this.BindingNavigatorTrends.Location = new System.Drawing.Point(0, 43);
            this.BindingNavigatorTrends.MoveFirstItem = null;
            this.BindingNavigatorTrends.MoveLastItem = null;
            this.BindingNavigatorTrends.MoveNextItem = null;
            this.BindingNavigatorTrends.MovePreviousItem = null;
            this.BindingNavigatorTrends.Name = "BindingNavigatorTrends";
            this.BindingNavigatorTrends.PositionItem = null;
            this.BindingNavigatorTrends.Size = new System.Drawing.Size(954, 43);
            this.BindingNavigatorTrends.TabIndex = 1;
            this.BindingNavigatorTrends.Text = "BindingNavigatorTrends";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 40);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Red;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(946, 35);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "TRENDS REPORT";
            // 
            // TrendsTableLayoutPanelTrends
            // 
            this.TrendsTableLayoutPanelTrends.ColumnCount = 1;
            this.TrendsTableLayoutPanelTrends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TrendsTableLayoutPanelTrends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TrendsTableLayoutPanelTrends.Controls.Add(this.chartTrends, 0, 0);
            this.TrendsTableLayoutPanelTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrendsTableLayoutPanelTrends.Location = new System.Drawing.Point(966, 4);
            this.TrendsTableLayoutPanelTrends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrendsTableLayoutPanelTrends.Name = "TrendsTableLayoutPanelTrends";
            this.TrendsTableLayoutPanelTrends.RowCount = 1;
            this.TrendsTableLayoutPanelTrends.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TrendsTableLayoutPanelTrends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TrendsTableLayoutPanelTrends.Size = new System.Drawing.Size(954, 654);
            this.TrendsTableLayoutPanelTrends.TabIndex = 2;
            // 
            // chartTrends
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTrends.ChartAreas.Add(chartArea1);
            this.chartTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTrends.Legends.Add(legend1);
            this.chartTrends.Location = new System.Drawing.Point(4, 4);
            this.chartTrends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartTrends.Name = "chartTrends";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Date";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Field_2";
            this.chartTrends.Series.Add(series1);
            this.chartTrends.Series.Add(series2);
            this.chartTrends.Size = new System.Drawing.Size(947, 646);
            this.chartTrends.TabIndex = 0;
            this.chartTrends.Text = "chartTrends";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrendsDataInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TrendsDataInterface";
            this.Text = "Trends_DataInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrendsDataInterface_FormClosing);
            this.Load += new System.EventHandler(this.OpenToolStripMenuItem_Click_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorTrends)).EndInit();
            this.BindingNavigatorTrends.ResumeLayout(false);
            this.BindingNavigatorTrends.PerformLayout();
            this.TrendsTableLayoutPanelTrends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTrends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource BindingSourceTrends;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DataGridViewTrends;
        private System.Windows.Forms.BindingNavigator BindingNavigatorTrends;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel TrendsTableLayoutPanelTrends;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrends;
        private System.Windows.Forms.Button button1;
    }
}
