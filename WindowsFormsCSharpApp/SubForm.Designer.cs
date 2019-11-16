namespace WindowsFormsCSharpApp
{
    partial class SubForm
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
            this.MainUpdateBtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainUpdateBtton
            // 
            this.MainUpdateBtton.Location = new System.Drawing.Point(103, 12);
            this.MainUpdateBtton.Name = "MainUpdateBtton";
            this.MainUpdateBtton.Size = new System.Drawing.Size(75, 23);
            this.MainUpdateBtton.TabIndex = 0;
            this.MainUpdateBtton.Text = "MainUpdate";
            this.MainUpdateBtton.UseVisualStyleBackColor = true;
            this.MainUpdateBtton.Click += new System.EventHandler(this.MainUpdateBtton_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 44);
            this.Controls.Add(this.MainUpdateBtton);
            this.Name = "SubForm";
            this.Text = "SubFormDelegate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainUpdateBtton;
    }
}