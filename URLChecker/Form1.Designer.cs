namespace URLChecker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.splitTwo = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.basicGrid = new System.Windows.Forms.PropertyGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.queryText = new System.Windows.Forms.TextBox();
            this.selectDefaultAppLink = new System.Windows.Forms.LinkLabel();
            this.copyUrlLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitTwo)).BeginInit();
            this.splitTwo.Panel1.SuspendLayout();
            this.splitTwo.Panel2.SuspendLayout();
            this.splitTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // urlText
            // 
            this.urlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlText.Location = new System.Drawing.Point(12, 32);
            this.urlText.Name = "urlText";
            this.urlText.ReadOnly = true;
            this.urlText.Size = new System.Drawing.Size(1002, 28);
            this.urlText.TabIndex = 2;
            // 
            // splitTwo
            // 
            this.splitTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitTwo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitTwo.Location = new System.Drawing.Point(12, 66);
            this.splitTwo.Name = "splitTwo";
            // 
            // splitTwo.Panel1
            // 
            this.splitTwo.Panel1.Controls.Add(this.basicGrid);
            this.splitTwo.Panel1.Controls.Add(this.label2);
            // 
            // splitTwo.Panel2
            // 
            this.splitTwo.Panel2.Controls.Add(this.queryText);
            this.splitTwo.Panel2.Controls.Add(this.label3);
            this.splitTwo.Size = new System.Drawing.Size(1002, 686);
            this.splitTwo.SplitterDistance = 511;
            this.splitTwo.SplitterWidth = 6;
            this.splitTwo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL 基本情報";
            // 
            // basicGrid
            // 
            this.basicGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicGrid.Location = new System.Drawing.Point(0, 23);
            this.basicGrid.Name = "basicGrid";
            this.basicGrid.Size = new System.Drawing.Size(511, 663);
            this.basicGrid.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "クエリ文字列情報";
            // 
            // queryText
            // 
            this.queryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryText.Location = new System.Drawing.Point(0, 23);
            this.queryText.Multiline = true;
            this.queryText.Name = "queryText";
            this.queryText.ReadOnly = true;
            this.queryText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.queryText.Size = new System.Drawing.Size(485, 663);
            this.queryText.TabIndex = 1;
            this.queryText.WordWrap = false;
            // 
            // selectDefaultAppLink
            // 
            this.selectDefaultAppLink.AutoSize = true;
            this.selectDefaultAppLink.Location = new System.Drawing.Point(92, 9);
            this.selectDefaultAppLink.Name = "selectDefaultAppLink";
            this.selectDefaultAppLink.Size = new System.Drawing.Size(149, 20);
            this.selectDefaultAppLink.TabIndex = 3;
            this.selectDefaultAppLink.TabStop = true;
            this.selectDefaultAppLink.Text = "既定のアプリを変更...";
            this.selectDefaultAppLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectDefaultAppLink_LinkClicked);
            // 
            // copyUrlLink
            // 
            this.copyUrlLink.AutoSize = true;
            this.copyUrlLink.Location = new System.Drawing.Point(299, 9);
            this.copyUrlLink.Name = "copyUrlLink";
            this.copyUrlLink.Size = new System.Drawing.Size(94, 20);
            this.copyUrlLink.TabIndex = 4;
            this.copyUrlLink.TabStop = true;
            this.copyUrlLink.Text = "URL をコピー";
            this.copyUrlLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copyUrlLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1026, 764);
            this.Controls.Add(this.copyUrlLink);
            this.Controls.Add(this.selectDefaultAppLink);
            this.Controls.Add(this.splitTwo);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitTwo.Panel1.ResumeLayout(false);
            this.splitTwo.Panel1.PerformLayout();
            this.splitTwo.Panel2.ResumeLayout(false);
            this.splitTwo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTwo)).EndInit();
            this.splitTwo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.SplitContainer splitTwo;
        private System.Windows.Forms.PropertyGrid basicGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox queryText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel selectDefaultAppLink;
        private System.Windows.Forms.LinkLabel copyUrlLink;
    }
}

