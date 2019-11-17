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
            this.Status = new System.Windows.Forms.Label();
            this.StopBackGround = new System.Windows.Forms.Button();
            this.YieldStart = new System.Windows.Forms.Button();
            this.YieldLabel = new System.Windows.Forms.Label();
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
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 125);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(48, 15);
            this.Status.TabIndex = 6;
            this.Status.Text = "Status";
            // 
            // StopBackGround
            // 
            this.StopBackGround.Location = new System.Drawing.Point(143, 69);
            this.StopBackGround.Name = "StopBackGround";
            this.StopBackGround.Size = new System.Drawing.Size(126, 23);
            this.StopBackGround.TabIndex = 7;
            this.StopBackGround.Text = "StopBackGround";
            this.StopBackGround.UseVisualStyleBackColor = true;
            this.StopBackGround.Click += new System.EventHandler(this.StopBackGround_Click);
            // 
            // YieldStart
            // 
            this.YieldStart.Location = new System.Drawing.Point(12, 143);
            this.YieldStart.Name = "YieldStart";
            this.YieldStart.Size = new System.Drawing.Size(82, 23);
            this.YieldStart.TabIndex = 8;
            this.YieldStart.Text = "YieldStart";
            this.YieldStart.UseVisualStyleBackColor = true;
            this.YieldStart.Click += new System.EventHandler(this.YieldStart_Click);
            // 
            // YieldLabel
            // 
            this.YieldLabel.AutoSize = true;
            this.YieldLabel.Location = new System.Drawing.Point(12, 169);
            this.YieldLabel.Name = "YieldLabel";
            this.YieldLabel.Size = new System.Drawing.Size(41, 15);
            this.YieldLabel.TabIndex = 9;
            this.YieldLabel.Text = "None";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 211);
            this.Controls.Add(this.YieldLabel);
            this.Controls.Add(this.YieldStart);
            this.Controls.Add(this.StopBackGround);
            this.Controls.Add(this.Status);
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
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button StopBackGround;
        private System.Windows.Forms.Button YieldStart;
        private System.Windows.Forms.Label YieldLabel;
    }
}

