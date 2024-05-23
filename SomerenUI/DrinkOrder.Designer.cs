namespace SomerenUI
{
    partial class DrinkOrderForm
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
            drinkNameComboBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            amountTextBox = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            studentNrComboBox = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // drinkNameComboBox
            // 
            drinkNameComboBox.FormattingEnabled = true;
            drinkNameComboBox.Location = new System.Drawing.Point(173, 45);
            drinkNameComboBox.Name = "drinkNameComboBox";
            drinkNameComboBox.Size = new System.Drawing.Size(151, 28);
            drinkNameComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(29, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 28);
            label1.TabIndex = 1;
            label1.Text = "Drink Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(33, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 28);
            label2.TabIndex = 2;
            label2.Text = "Student Nr: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(33, 160);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 28);
            label3.TabIndex = 3;
            label3.Text = "Amount:";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new System.Drawing.Point(173, 164);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new System.Drawing.Size(151, 27);
            amountTextBox.TabIndex = 5;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(173, 216);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(151, 41);
            button1.TabIndex = 6;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // studentNrComboBox
            // 
            studentNrComboBox.FormattingEnabled = true;
            studentNrComboBox.Location = new System.Drawing.Point(173, 102);
            studentNrComboBox.Name = "studentNrComboBox";
            studentNrComboBox.Size = new System.Drawing.Size(151, 28);
            studentNrComboBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(29, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(105, 28);
            label4.TabIndex = 8;
            label4.Text = "Total Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(173, 281);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 28);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(33, 339);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(0, 28);
            label6.TabIndex = 10;
            // 
            // DrinkOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(411, 384);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(studentNrComboBox);
            Controls.Add(button1);
            Controls.Add(amountTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(drinkNameComboBox);
            Name = "DrinkOrderForm";
            Text = "DrinkOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox drinkNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox studentNrComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}