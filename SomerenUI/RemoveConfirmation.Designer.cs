namespace SomerenUI
{
    partial class RemoveConfirmation
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
            btnYes = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Location = new System.Drawing.Point(60, 106);
            btnYes.Name = "btnYes";
            btnYes.Size = new System.Drawing.Size(94, 41);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(277, 106);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 41);
            button2.TabIndex = 1;
            button2.Text = "No";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(311, 20);
            label1.TabIndex = 2;
            label1.Text = "Are you sure you wish to remove this student?";
            // 
            // RemoveConfirmation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(429, 188);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnYes);
            Name = "RemoveConfirmation";
            Text = "RemoveConfirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}