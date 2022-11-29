
namespace ExcelComparer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.excelSheet1DG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.excelSameCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.excelNewCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.excelSameCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.excelTotalCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.helpDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorblindModeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.excelSheet2DG = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.changedItemLabel = new System.Windows.Forms.Label();
            this.newItemLabel = new System.Windows.Forms.Label();
            this.sameItemLabel = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.excelSheet1DG)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excelSheet2DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // excelSheet1DG
            // 
            this.excelSheet1DG.AllowUserToAddRows = false;
            this.excelSheet1DG.AllowUserToDeleteRows = false;
            this.excelSheet1DG.AllowUserToResizeRows = false;
            this.excelSheet1DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.excelSheet1DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelSheet1DG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excelSheet1DG.Location = new System.Drawing.Point(0, 0);
            this.excelSheet1DG.Name = "excelSheet1DG";
            this.excelSheet1DG.ReadOnly = true;
            this.excelSheet1DG.RowHeadersVisible = false;
            this.excelSheet1DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.excelSheet1DG.Size = new System.Drawing.Size(368, 403);
            this.excelSheet1DG.TabIndex = 0;
            this.excelSheet1DG.UseWaitCursor = true;
            this.excelSheet1DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.excelSheet1DG_CellClick);
            this.excelSheet1DG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.excelSheet1DG_CellDoubleClick);
            this.excelSheet1DG.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.excelSheet1DG_CellEnter);
            this.excelSheet1DG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.excelSheet1DG_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelSameCounter,
            this.excelNewCounter,
            this.excelSameCount,
            this.excelTotalCounter,
            this.toolStripProgressBar1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(806, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            // 
            // excelSameCounter
            // 
            this.excelSameCounter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.excelSameCounter.Name = "excelSameCounter";
            this.excelSameCounter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.excelSameCounter.Size = new System.Drawing.Size(90, 17);
            this.excelSameCounter.Text = "Changed Items:";
            // 
            // excelNewCounter
            // 
            this.excelNewCounter.Name = "excelNewCounter";
            this.excelNewCounter.Size = new System.Drawing.Size(66, 17);
            this.excelNewCounter.Text = "New Items:";
            // 
            // excelSameCount
            // 
            this.excelSameCount.Name = "excelSameCount";
            this.excelSameCount.Size = new System.Drawing.Size(71, 17);
            this.excelSameCount.Text = "Same Items:";
            // 
            // excelTotalCounter
            // 
            this.excelTotalCounter.Name = "excelTotalCounter";
            this.excelTotalCounter.Size = new System.Drawing.Size(67, 17);
            this.excelTotalCounter.Text = "Total Items:";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripProgressBar1.Size = new System.Drawing.Size(220, 16);
            this.toolStripProgressBar1.ToolTipText = "Loading";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpDropDownButton,
            this.ExportButton,
            this.toolStripCopyButton,
            this.toolStripNewButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.UseWaitCursor = true;
            // 
            // helpDropDownButton
            // 
            this.helpDropDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorblindModeOffToolStripMenuItem});
            this.helpDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("helpDropDownButton.Image")));
            this.helpDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpDropDownButton.Name = "helpDropDownButton";
            this.helpDropDownButton.Size = new System.Drawing.Size(45, 22);
            this.helpDropDownButton.Text = "Help";
            // 
            // colorblindModeOffToolStripMenuItem
            // 
            this.colorblindModeOffToolStripMenuItem.Name = "colorblindModeOffToolStripMenuItem";
            this.colorblindModeOffToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.colorblindModeOffToolStripMenuItem.Text = "Colorblind Mode: Off";
            this.colorblindModeOffToolStripMenuItem.Click += new System.EventHandler(this.colorblindModeOffToolStripMenuItem_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExportButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportButton.Image")));
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(45, 22);
            this.ExportButton.Text = "Export";
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // toolStripCopyButton
            // 
            this.toolStripCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopyButton.Image")));
            this.toolStripCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopyButton.Name = "toolStripCopyButton";
            this.toolStripCopyButton.Size = new System.Drawing.Size(42, 22);
            this.toolStripCopyButton.Text = "Copy ";
            this.toolStripCopyButton.Click += new System.EventHandler(this.toolStripCopyButton_Click);
            // 
            // toolStripNewButton
            // 
            this.toolStripNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripNewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewButton.Image")));
            this.toolStripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewButton.Name = "toolStripNewButton";
            this.toolStripNewButton.Size = new System.Drawing.Size(35, 22);
            this.toolStripNewButton.Text = "New";
            this.toolStripNewButton.Click += new System.EventHandler(this.toolStripNewButton_Click_1);
            // 
            // excelSheet2DG
            // 
            this.excelSheet2DG.AllowUserToAddRows = false;
            this.excelSheet2DG.AllowUserToDeleteRows = false;
            this.excelSheet2DG.AllowUserToResizeRows = false;
            this.excelSheet2DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.excelSheet2DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelSheet2DG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excelSheet2DG.Location = new System.Drawing.Point(0, 0);
            this.excelSheet2DG.Name = "excelSheet2DG";
            this.excelSheet2DG.ReadOnly = true;
            this.excelSheet2DG.RowHeadersVisible = false;
            this.excelSheet2DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.excelSheet2DG.Size = new System.Drawing.Size(374, 403);
            this.excelSheet2DG.TabIndex = 4;
            this.excelSheet2DG.UseWaitCursor = true;
            this.excelSheet2DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.excelSheet2DG_CellClick);
            this.excelSheet2DG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.excelSheet2DG_CellDoubleClick);
            this.excelSheet2DG.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.excelSheet2DG_CellEnter);
            this.excelSheet2DG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.excelSheet2DG_DataBindingComplete);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Excel 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 97);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.excelSheet1DG);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.excelSheet2DG);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(782, 403);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.SplitterWidth = 40;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.UseWaitCursor = true;
            this.splitContainer1.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(12, 64);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.UseWaitCursor = true;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.UseWaitCursor = true;
            this.splitContainer2.Size = new System.Drawing.Size(782, 27);
            this.splitContainer2.SplitterDistance = 368;
            this.splitContainer2.SplitterWidth = 40;
            this.splitContainer2.TabIndex = 7;
            this.splitContainer2.UseWaitCursor = true;
            this.splitContainer2.Visible = false;
            // 
            // changedItemLabel
            // 
            this.changedItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changedItemLabel.AutoSize = true;
            this.changedItemLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.changedItemLabel.Location = new System.Drawing.Point(271, 533);
            this.changedItemLabel.Name = "changedItemLabel";
            this.changedItemLabel.Size = new System.Drawing.Size(73, 13);
            this.changedItemLabel.TabIndex = 8;
            this.changedItemLabel.Text = "Changed Item";
            this.changedItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changedItemLabel.UseWaitCursor = true;
            // 
            // newItemLabel
            // 
            this.newItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newItemLabel.AutoSize = true;
            this.newItemLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.newItemLabel.Location = new System.Drawing.Point(385, 533);
            this.newItemLabel.Name = "newItemLabel";
            this.newItemLabel.Size = new System.Drawing.Size(52, 13);
            this.newItemLabel.TabIndex = 9;
            this.newItemLabel.Text = "New Item";
            this.newItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newItemLabel.UseWaitCursor = true;
            // 
            // sameItemLabel
            // 
            this.sameItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sameItemLabel.AutoSize = true;
            this.sameItemLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.sameItemLabel.Location = new System.Drawing.Point(478, 533);
            this.sameItemLabel.Name = "sameItemLabel";
            this.sameItemLabel.Size = new System.Drawing.Size(57, 13);
            this.sameItemLabel.TabIndex = 10;
            this.sameItemLabel.Text = "Same Item";
            this.sameItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sameItemLabel.UseWaitCursor = true;
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 589);
            this.Controls.Add(this.sameItemLabel);
            this.Controls.Add(this.newItemLabel);
            this.Controls.Add(this.changedItemLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Comparer";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.excelSheet1DG)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excelSheet2DG)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView excelSheet1DG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel excelSameCounter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNewButton;
        private System.Windows.Forms.ToolStripButton toolStripCopyButton;
        private System.Windows.Forms.ToolStripStatusLabel excelSameCount;
        private System.Windows.Forms.DataGridView excelSheet2DG;
        private System.Windows.Forms.ToolStripStatusLabel excelNewCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.ToolStripStatusLabel excelTotalCounter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label changedItemLabel;
        private System.Windows.Forms.Label newItemLabel;
        private System.Windows.Forms.Label sameItemLabel;
        private System.Windows.Forms.ToolStripDropDownButton helpDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem colorblindModeOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}