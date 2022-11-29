
namespace ExcelComparer
{
    partial class Form1
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
            System.Windows.Forms.Label excelFile1Label;
            System.Windows.Forms.Label excelFile2Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.compareExcel1Button = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.excelFile1TextBox = new System.Windows.Forms.TextBox();
            this.excelFile2TextBox = new System.Windows.Forms.TextBox();
            this.excelFileB1 = new System.Windows.Forms.Button();
            this.excelFileB2 = new System.Windows.Forms.Button();
            this.compareExcel2Button = new System.Windows.Forms.Button();
            excelFile1Label = new System.Windows.Forms.Label();
            excelFile2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // excelFile1Label
            // 
            excelFile1Label.AutoSize = true;
            excelFile1Label.Location = new System.Drawing.Point(27, 70);
            excelFile1Label.Name = "excelFile1Label";
            excelFile1Label.Size = new System.Drawing.Size(64, 13);
            excelFile1Label.TabIndex = 6;
            excelFile1Label.Text = "Excel File 1:";
            // 
            // excelFile2Label
            // 
            excelFile2Label.AutoSize = true;
            excelFile2Label.Location = new System.Drawing.Point(27, 156);
            excelFile2Label.Name = "excelFile2Label";
            excelFile2Label.Size = new System.Drawing.Size(64, 13);
            excelFile2Label.TabIndex = 8;
            excelFile2Label.Text = "Excel File 2:";
            // 
            // compareExcel1Button
            // 
            this.compareExcel1Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.compareExcel1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compareExcel1Button.Location = new System.Drawing.Point(57, 264);
            this.compareExcel1Button.Name = "compareExcel1Button";
            this.compareExcel1Button.Size = new System.Drawing.Size(128, 47);
            this.compareExcel1Button.TabIndex = 6;
            this.compareExcel1Button.Text = "Compare Excel 1";
            this.compareExcel1Button.UseVisualStyleBackColor = true;
            this.compareExcel1Button.Click += new System.EventHandler(this.compareExcel1Button_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // excelFile1TextBox
            // 
            this.excelFile1TextBox.Location = new System.Drawing.Point(92, 66);
            this.excelFile1TextBox.Name = "excelFile1TextBox";
            this.excelFile1TextBox.Size = new System.Drawing.Size(208, 20);
            this.excelFile1TextBox.TabIndex = 7;
            // 
            // excelFile2TextBox
            // 
            this.excelFile2TextBox.Location = new System.Drawing.Point(92, 152);
            this.excelFile2TextBox.Name = "excelFile2TextBox";
            this.excelFile2TextBox.Size = new System.Drawing.Size(208, 20);
            this.excelFile2TextBox.TabIndex = 9;
            // 
            // excelFileB1
            // 
            this.excelFileB1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.excelFileB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelFileB1.Location = new System.Drawing.Point(310, 65);
            this.excelFileB1.Name = "excelFileB1";
            this.excelFileB1.Size = new System.Drawing.Size(75, 23);
            this.excelFileB1.TabIndex = 4;
            this.excelFileB1.Text = "Browse";
            this.excelFileB1.UseVisualStyleBackColor = true;
            this.excelFileB1.Click += new System.EventHandler(this.excelFileB1_Click);
            // 
            // excelFileB2
            // 
            this.excelFileB2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.excelFileB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelFileB2.Location = new System.Drawing.Point(310, 151);
            this.excelFileB2.Name = "excelFileB2";
            this.excelFileB2.Size = new System.Drawing.Size(75, 23);
            this.excelFileB2.TabIndex = 5;
            this.excelFileB2.Text = "Browse";
            this.excelFileB2.UseVisualStyleBackColor = true;
            this.excelFileB2.Click += new System.EventHandler(this.excelFileB2_Click);
            // 
            // compareExcel2Button
            // 
            this.compareExcel2Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.compareExcel2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compareExcel2Button.Location = new System.Drawing.Point(228, 264);
            this.compareExcel2Button.Name = "compareExcel2Button";
            this.compareExcel2Button.Size = new System.Drawing.Size(128, 47);
            this.compareExcel2Button.TabIndex = 10;
            this.compareExcel2Button.Text = "Compare Excel 2";
            this.compareExcel2Button.UseVisualStyleBackColor = true;
            this.compareExcel2Button.Click += new System.EventHandler(this.compareExcel2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 337);
            this.Controls.Add(this.compareExcel2Button);
            this.Controls.Add(excelFile1Label);
            this.Controls.Add(this.excelFile1TextBox);
            this.Controls.Add(excelFile2Label);
            this.Controls.Add(this.excelFile2TextBox);
            this.Controls.Add(this.compareExcel1Button);
            this.Controls.Add(this.excelFileB2);
            this.Controls.Add(this.excelFileB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Comparer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button compareExcel1Button;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox excelFile1TextBox;
        private System.Windows.Forms.TextBox excelFile2TextBox;
        private System.Windows.Forms.Button excelFileB2;
        private System.Windows.Forms.Button excelFileB1;
        private System.Windows.Forms.Button compareExcel2Button;
    }
}

