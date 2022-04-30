namespace TaskManger
{
    partial class RunTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OpenTaskBox = new System.Windows.Forms.TextBox();
            this.RunTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open:";
            // 
            // OpenTaskBox
            // 
            this.OpenTaskBox.Location = new System.Drawing.Point(115, 21);
            this.OpenTaskBox.Name = "OpenTaskBox";
            this.OpenTaskBox.Size = new System.Drawing.Size(408, 27);
            this.OpenTaskBox.TabIndex = 1;
            // 
            // RunTaskBtn
            // 
            this.RunTaskBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RunTaskBtn.Location = new System.Drawing.Point(429, 74);
            this.RunTaskBtn.Name = "RunTaskBtn";
            this.RunTaskBtn.Size = new System.Drawing.Size(94, 29);
            this.RunTaskBtn.TabIndex = 2;
            this.RunTaskBtn.Text = "Run";
            this.RunTaskBtn.UseVisualStyleBackColor = true;
            this.RunTaskBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RunTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 130);
            this.Controls.Add(this.RunTaskBtn);
            this.Controls.Add(this.OpenTaskBox);
            this.Controls.Add(this.label1);
            this.Name = "RunTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Run new task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox OpenTaskBox;
        private Button RunTaskBtn;
    }
}