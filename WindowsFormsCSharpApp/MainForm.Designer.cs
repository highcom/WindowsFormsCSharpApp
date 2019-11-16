namespace WindowsFormsCSharpApp
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.DispSubButton = new System.Windows.Forms.Button();
            this.DispTextBox = new System.Windows.Forms.TextBox();
            this.StartBackGround = new System.Windows.Forms.Button();
            this.BackGroundProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DispSubButton
            // 
            this.DispSubButton.Location = new System.Drawing.Point(12, 41);
            this.DispSubButton.Name = "DispSubButton";
            this.DispSubButton.Size = new System.Drawing.Size(75, 23);
            this.DispSubButton.TabIndex = 1;
            this.DispSubButton.Text = "DispSub";
            this.DispSubButton.UseVisualStyleBackColor = true;
            this.DispSubButton.Click += new System.EventHandler(this.DispSubButton_Click);
            // 
            // DispTextBox
            // 
            this.DispTextBox.Location = new System.Drawing.Point(94, 41);
            this.DispTextBox.Name = "DispTextBox";
            this.DispTextBox.Size = new System.Drawing.Size(225, 22);
            this.DispTextBox.TabIndex = 2;
            this.DispTextBox.Text = "None";
            // 
            // StartBackGround
            // 
            this.StartBackGround.Location = new System.Drawing.Point(12, 70);
            this.StartBackGround.Name = "StartBackGround";
            this.StartBackGround.Size = new System.Drawing.Size(125, 23);
            this.StartBackGround.TabIndex = 3;
            this.StartBackGround.Text = "StartBackGround";
            this.StartBackGround.UseVisualStyleBackColor = true;
            this.StartBackGround.Click += new System.EventHandler(this.StartBackGround_Click);
            // 
            // BackGroundProgress
            // 
            this.BackGroundProgress.Location = new System.Drawing.Point(12, 99);
            this.BackGroundProgress.Name = "BackGroundProgress";
            this.BackGroundProgress.Size = new System.Drawing.Size(307, 23);
            this.BackGroundProgress.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 211);
            this.Controls.Add(this.BackGroundProgress);
            this.Controls.Add(this.StartBackGround);
            this.Controls.Add(this.DispTextBox);
            this.Controls.Add(this.DispSubButton);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DispSubButton;
        private System.Windows.Forms.TextBox DispTextBox;
        private System.Windows.Forms.Button StartBackGround;
        private System.Windows.Forms.ProgressBar BackGroundProgress;
    }
}

