namespace FileList
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.folderNameSource = new System.Windows.Forms.TextBox();
            this.openFolderSource = new System.Windows.Forms.Button();
            this.openFolderTarget = new System.Windows.Forms.Button();
            this.folderNameTarget = new System.Windows.Forms.TextBox();
            this.execute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderNameSource
            // 
            this.folderNameSource.Location = new System.Drawing.Point(138, 17);
            this.folderNameSource.Name = "folderNameSource";
            this.folderNameSource.Size = new System.Drawing.Size(332, 19);
            this.folderNameSource.TabIndex = 0;
            // 
            // openFolderSource
            // 
            this.openFolderSource.Location = new System.Drawing.Point(478, 17);
            this.openFolderSource.Name = "openFolderSource";
            this.openFolderSource.Size = new System.Drawing.Size(61, 18);
            this.openFolderSource.TabIndex = 1;
            this.openFolderSource.Text = "open";
            this.openFolderSource.UseVisualStyleBackColor = true;
            this.openFolderSource.Click += new System.EventHandler(this.openFolderSource_Click);
            // 
            // openFolderTarget
            // 
            this.openFolderTarget.Location = new System.Drawing.Point(478, 52);
            this.openFolderTarget.Name = "openFolderTarget";
            this.openFolderTarget.Size = new System.Drawing.Size(61, 19);
            this.openFolderTarget.TabIndex = 2;
            this.openFolderTarget.Text = "open";
            this.openFolderTarget.UseVisualStyleBackColor = true;
            this.openFolderTarget.Click += new System.EventHandler(this.openFolderTarget_Click);
            // 
            // folderNameTarget
            // 
            this.folderNameTarget.Location = new System.Drawing.Point(138, 52);
            this.folderNameTarget.Name = "folderNameTarget";
            this.folderNameTarget.Size = new System.Drawing.Size(332, 19);
            this.folderNameTarget.TabIndex = 3;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(451, 97);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(88, 31);
            this.execute.TabIndex = 4;
            this.execute.Text = "execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "ソースファイルルート";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "クラスファイルルート";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.folderNameTarget);
            this.Controls.Add(this.openFolderTarget);
            this.Controls.Add(this.openFolderSource);
            this.Controls.Add(this.folderNameSource);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderNameSource;
        private System.Windows.Forms.Button openFolderSource;
        private System.Windows.Forms.Button openFolderTarget;
        private System.Windows.Forms.TextBox folderNameTarget;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

