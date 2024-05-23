namespace SomerenUI
{
    partial class RemoveStudent
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
            studentNrComboBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            btnRemove = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // studentNrComboBox
            // 
            studentNrComboBox.FormattingEnabled = true;
            studentNrComboBox.Location = new System.Drawing.Point(283, 76);
            studentNrComboBox.Name = "studentNrComboBox";
            studentNrComboBox.Size = new System.Drawing.Size(177, 28);
            studentNrComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(244, 20);
            label1.TabIndex = 1;
            label1.Text = "Select a student number to remove:";
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(12, 230);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(448, 53);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // RemoveStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(475, 338);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(studentNrComboBox);
            Name = "RemoveStudent";
            Text = "RemoveStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.ComboBox studentNrComboBox;
    }
}