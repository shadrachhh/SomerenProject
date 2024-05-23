namespace SomerenUI
{
    partial class EditStudent
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtLastName = new System.Windows.Forms.TextBox();
            txtStudentNumber = new System.Windows.Forms.TextBox();
            txtRoomNumber = new System.Windows.Forms.TextBox();
            txtClass = new System.Windows.Forms.TextBox();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtTelephone = new System.Windows.Forms.TextBox();
            btnEdit = new System.Windows.Forms.Button();
            studentNrComboBox = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 153);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 197);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 20);
            label3.TabIndex = 2;
            label3.Text = "Student Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(40, 241);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Room Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(40, 288);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "Telephone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(40, 336);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 20);
            label6.TabIndex = 5;
            label6.Text = "Class:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(266, 146);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(125, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new System.Drawing.Point(266, 190);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new System.Drawing.Size(125, 27);
            txtStudentNumber.TabIndex = 7;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new System.Drawing.Point(266, 238);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new System.Drawing.Size(125, 27);
            txtRoomNumber.TabIndex = 8;
            // 
            // txtClass
            // 
            txtClass.Location = new System.Drawing.Point(266, 333);
            txtClass.Name = "txtClass";
            txtClass.Size = new System.Drawing.Size(125, 27);
            txtClass.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(266, 104);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(125, 27);
            txtFirstName.TabIndex = 10;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new System.Drawing.Point(266, 285);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(125, 27);
            txtTelephone.TabIndex = 11;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(40, 398);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(351, 43);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // studentNrComboBox
            // 
            studentNrComboBox.FormattingEnabled = true;
            studentNrComboBox.Location = new System.Drawing.Point(241, 39);
            studentNrComboBox.Name = "studentNrComboBox";
            studentNrComboBox.Size = new System.Drawing.Size(151, 28);
            studentNrComboBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(40, 42);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(172, 20);
            label7.TabIndex = 14;
            label7.Text = "Select a student number:";
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(478, 490);
            Controls.Add(label7);
            Controls.Add(studentNrComboBox);
            Controls.Add(btnEdit);
            Controls.Add(txtTelephone);
            Controls.Add(txtFirstName);
            Controls.Add(txtClass);
            Controls.Add(txtRoomNumber);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditStudent";
            Text = "EditStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox studentNrComboBox;
        private System.Windows.Forms.Label label7;
    }
}