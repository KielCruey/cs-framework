namespace WinFormsApp
{
    partial class AsycnWorkerExample
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
            startAsyncButton = new Button();
            cancelAsyncButton = new Button();
            resultLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // startAsyncButton
            // 
            startAsyncButton.Location = new Point(33, 59);
            startAsyncButton.Name = "startAsyncButton";
            startAsyncButton.Size = new Size(75, 23);
            startAsyncButton.TabIndex = 0;
            startAsyncButton.Text = "Start";
            startAsyncButton.UseVisualStyleBackColor = true;
            startAsyncButton.Click += startAsyncButton_Click;
            // 
            // cancelAsyncButton
            // 
            cancelAsyncButton.Location = new Point(197, 59);
            cancelAsyncButton.Name = "cancelAsyncButton";
            cancelAsyncButton.Size = new Size(75, 23);
            cancelAsyncButton.TabIndex = 1;
            cancelAsyncButton.Text = "Cancel";
            cancelAsyncButton.UseVisualStyleBackColor = true;
            cancelAsyncButton.Click += cancelAsyncButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(127, 23);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(60, 15);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "Percent %";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // AsycnWorkerExample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 98);
            Controls.Add(resultLabel);
            Controls.Add(cancelAsyncButton);
            Controls.Add(startAsyncButton);
            MaximumSize = new Size(329, 137);
            MinimumSize = new Size(329, 137);
            Name = "AsycnWorkerExample";
            Text = "Asycn Worker Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startAsyncButton;
        private Button cancelAsyncButton;
        private Label resultLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}