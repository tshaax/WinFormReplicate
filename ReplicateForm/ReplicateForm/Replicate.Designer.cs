namespace ReplicateForm
{
    partial class Replicate
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
            this.sourcePathTxt = new System.Windows.Forms.TextBox();
            this.destPathTxt = new System.Windows.Forms.TextBox();
            this.sourceBrowseBtn = new System.Windows.Forms.Button();
            this.destBrowseBtn = new System.Windows.Forms.Button();
            this.replicateBtn = new System.Windows.Forms.Button();
            this.btnViewlog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.subDirchkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourcePathTxt
            // 
            this.sourcePathTxt.Location = new System.Drawing.Point(175, 90);
            this.sourcePathTxt.Name = "sourcePathTxt";
            this.sourcePathTxt.Size = new System.Drawing.Size(247, 20);
            this.sourcePathTxt.TabIndex = 0;
            // 
            // destPathTxt
            // 
            this.destPathTxt.Location = new System.Drawing.Point(175, 136);
            this.destPathTxt.Name = "destPathTxt";
            this.destPathTxt.Size = new System.Drawing.Size(247, 20);
            this.destPathTxt.TabIndex = 1;
            // 
            // sourceBrowseBtn
            // 
            this.sourceBrowseBtn.Location = new System.Drawing.Point(444, 87);
            this.sourceBrowseBtn.Name = "sourceBrowseBtn";
            this.sourceBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.sourceBrowseBtn.TabIndex = 2;
            this.sourceBrowseBtn.Text = "Browse";
            this.sourceBrowseBtn.UseVisualStyleBackColor = true;
            this.sourceBrowseBtn.Click += new System.EventHandler(this.SourceBrowseBtn_Click);
            // 
            // destBrowseBtn
            // 
            this.destBrowseBtn.Location = new System.Drawing.Point(444, 136);
            this.destBrowseBtn.Name = "destBrowseBtn";
            this.destBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.destBrowseBtn.TabIndex = 3;
            this.destBrowseBtn.Text = "Browse";
            this.destBrowseBtn.UseVisualStyleBackColor = true;
            this.destBrowseBtn.Click += new System.EventHandler(this.DestBrowseBtn_Click);
            // 
            // replicateBtn
            // 
            this.replicateBtn.Location = new System.Drawing.Point(175, 204);
            this.replicateBtn.Name = "replicateBtn";
            this.replicateBtn.Size = new System.Drawing.Size(75, 23);
            this.replicateBtn.TabIndex = 4;
            this.replicateBtn.Text = "Replicate";
            this.replicateBtn.UseVisualStyleBackColor = true;
            this.replicateBtn.Click += new System.EventHandler(this.ReplicateBtn_Click);
            // 
            // btnViewlog
            // 
            this.btnViewlog.Location = new System.Drawing.Point(175, 331);
            this.btnViewlog.Name = "btnViewlog";
            this.btnViewlog.Size = new System.Drawing.Size(75, 23);
            this.btnViewlog.TabIndex = 5;
            this.btnViewlog.Text = "View log";
            this.btnViewlog.UseVisualStyleBackColor = true;
            this.btnViewlog.Click += new System.EventHandler(this.BtnViewlog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(427, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(175, 262);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(344, 23);
            this.progressBar.TabIndex = 7;
            // 
            // subDirchkBox
            // 
            this.subDirchkBox.AutoSize = true;
            this.subDirchkBox.Location = new System.Drawing.Point(175, 173);
            this.subDirchkBox.Name = "subDirchkBox";
            this.subDirchkBox.Size = new System.Drawing.Size(136, 17);
            this.subDirchkBox.TabIndex = 8;
            this.subDirchkBox.Text = "Include Sub Directories";
            this.subDirchkBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subDirchkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Progress Bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Destination";
            // 
            // Replicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subDirchkBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewlog);
            this.Controls.Add(this.replicateBtn);
            this.Controls.Add(this.destBrowseBtn);
            this.Controls.Add(this.sourceBrowseBtn);
            this.Controls.Add(this.destPathTxt);
            this.Controls.Add(this.sourcePathTxt);
            this.Name = "Replicate";
            this.Text = "Replicate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Replicate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourcePathTxt;
        private System.Windows.Forms.TextBox destPathTxt;
        private System.Windows.Forms.Button sourceBrowseBtn;
        private System.Windows.Forms.Button destBrowseBtn;
        private System.Windows.Forms.Button replicateBtn;
        private System.Windows.Forms.Button btnViewlog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox subDirchkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

