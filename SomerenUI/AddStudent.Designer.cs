namespace SomerenUI
{
    partial class AddStudent
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
            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtStudentNumber = new System.Windows.Forms.TextBox();
            txtRoomNumber = new System.Windows.Forms.TextBox();
            txtTelephone = new System.Windows.Forms.TextBox();
            txtClass = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(276, 22);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(125, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(276, 76);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(125, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new System.Drawing.Point(276, 129);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new System.Drawing.Size(125, 27);
            txtStudentNumber.TabIndex = 2;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new System.Drawing.Point(276, 182);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new System.Drawing.Size(125, 27);
            txtRoomNumber.TabIndex = 3;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new System.Drawing.Point(276, 233);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(125, 27);
            txtTelephone.TabIndex = 4;
            // 
            // txtClass
            // 
            txtClass.Location = new System.Drawing.Point(276, 284);
            txtClass.Name = "txtClass";
            txtClass.Size = new System.Drawing.Size(125, 27);
            txtClass.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 20);
            label1.TabIndex = 6;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(32, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 20);
            label2.TabIndex = 7;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(32, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 20);
            label3.TabIndex = 8;
            label3.Text = "Student Number: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(32, 185);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 20);
            label4.TabIndex = 9;
            label4.Text = "Room Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(32, 240);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 20);
            label5.TabIndex = 10;
            label5.Text = "Telephone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(32, 287);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 20);
            label6.TabIndex = 11;
            label6.Text = "Class:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(32, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(369, 53);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(449, 445);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClass);
            Controls.Add(txtTelephone);
            Controls.Add(txtRoomNumber);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "AddStudent";
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
    }
}