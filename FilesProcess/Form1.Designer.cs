namespace FilesProcess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.FromButton = new System.Windows.Forms.Button();
            this.ToButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendButton = new System.Windows.Forms.Button();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(86, 32);
            this.FromTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(348, 27);
            this.FromTextBox.TabIndex = 2;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(86, 80);
            this.ToTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(348, 27);
            this.ToTextBox.TabIndex = 3;
            // 
            // FromButton
            // 
            this.FromButton.Location = new System.Drawing.Point(491, 30);
            this.FromButton.Margin = new System.Windows.Forms.Padding(2);
            this.FromButton.Name = "FromButton";
            this.FromButton.Size = new System.Drawing.Size(90, 27);
            this.FromButton.TabIndex = 4;
            this.FromButton.Text = "...";
            this.FromButton.UseVisualStyleBackColor = true;
            this.FromButton.Click += new System.EventHandler(this.FromButton_Click_1);
            // 
            // ToButton
            // 
            this.ToButton.Location = new System.Drawing.Point(491, 82);
            this.ToButton.Margin = new System.Windows.Forms.Padding(2);
            this.ToButton.Name = "ToButton";
            this.ToButton.Size = new System.Drawing.Size(90, 27);
            this.ToButton.TabIndex = 5;
            this.ToButton.Text = "...";
            this.ToButton.UseVisualStyleBackColor = true;
            this.ToButton.Click += new System.EventHandler(this.ToButton_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 142);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(158, 27);
            this.progressBar1.TabIndex = 6;
            // 
            // SuspendButton
            // 
            this.SuspendButton.Location = new System.Drawing.Point(206, 142);
            this.SuspendButton.Margin = new System.Windows.Forms.Padding(2);
            this.SuspendButton.Name = "SuspendButton";
            this.SuspendButton.Size = new System.Drawing.Size(90, 27);
            this.SuspendButton.TabIndex = 7;
            this.SuspendButton.Text = "Suspend";
            this.SuspendButton.UseVisualStyleBackColor = true;
            this.SuspendButton.Click += new System.EventHandler(this.SuspendButton_Click_1);
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(300, 142);
            this.ResumeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(90, 27);
            this.ResumeButton.TabIndex = 8;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click_1);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(394, 142);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(2);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(90, 27);
            this.AbortButton.TabIndex = 9;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click_1);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(491, 142);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(90, 27);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 191);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.SuspendButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ToButton);
            this.Controls.Add(this.FromButton);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FromButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FromTextBox;
        private TextBox ToTextBox;
        private Button FromButton;
        private Button ToButton;
        private ProgressBar progressBar1;
        private Button SuspendButton;
        private Button ResumeButton;
        private Button AbortButton;
        private Button CopyButton;
    }
}