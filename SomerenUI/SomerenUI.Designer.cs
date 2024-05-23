namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            btnEditStudent = new System.Windows.Forms.Button();
            btnRemoveStudent = new System.Windows.Forms.Button();
            btnAddStudent = new System.Windows.Forms.Button();
            pnlLecturer = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listViewLecturers = new System.Windows.Forms.ListView();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            pnlDrinks = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            listViewDrinks = new System.Windows.Forms.ListView();
            label3 = new System.Windows.Forms.Label();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            orderDrinktoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(btnEditStudent);
            pnlStudents.Controls.Add(btnRemoveStudent);
            pnlStudents.Controls.Add(btnAddStudent);
            pnlStudents.Controls.Add(pnlLecturer);
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 621);
            pnlStudents.TabIndex = 2;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Location = new System.Drawing.Point(774, 484);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new System.Drawing.Size(119, 46);
            btnEditStudent.TabIndex = 6;
            btnEditStudent.Text = "Edit";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new System.Drawing.Point(385, 484);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new System.Drawing.Size(119, 46);
            btnRemoveStudent.TabIndex = 5;
            btnRemoveStudent.Text = "Remove";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new System.Drawing.Point(18, 484);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new System.Drawing.Size(119, 46);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // pnlLecturer
            // 
            pnlLecturer.Controls.Add(pnlDrinks);
            pnlLecturer.Controls.Add(pictureBox2);
            pnlLecturer.Controls.Add(listViewLecturers);
            pnlLecturer.Controls.Add(label2);
            pnlLecturer.Location = new System.Drawing.Point(0, 0);
            pnlLecturer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlLecturer.Name = "pnlLecturer";
            pnlLecturer.Size = new System.Drawing.Size(1072, 621);
            pnlLecturer.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(920, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(149, 164);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Location = new System.Drawing.Point(18, 56);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(875, 408);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(125, 41);
            label2.TabIndex = 0;
            label2.Text = "Lecturer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(920, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 408);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlDrinks
            // 
            pnlDrinks.Controls.Add(pictureBox3);
            pnlDrinks.Controls.Add(listViewDrinks);
            pnlDrinks.Controls.Add(label3);
            pnlDrinks.Location = new System.Drawing.Point(0, 0);
            pnlDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1072, 621);
            pnlDrinks.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(920, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(149, 164);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewDrinks
            // 
            listViewDrinks.Location = new System.Drawing.Point(18, 56);
            listViewDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(875, 408);
            listViewDrinks.TabIndex = 1;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(15, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 41);
            label3.TabIndex = 0;
            label3.Text = "Drinks";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            drinksToolStripMenuItem.Text = "Drinks";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // orderDrinktoolStripMenuItem
            // 
            orderDrinktoolStripMenuItem.Name = "orderDrinktoolStripMenuItem";
            orderDrinktoolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            orderDrinktoolStripMenuItem.Text = "Order Drink";
            orderDrinktoolStripMenuItem.Click += orderDrinktoolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, drinksToolStripMenuItem, orderDrinktoolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1099, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 673);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            Load += SomerenUI_Load;
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            pnlLecturer.ResumeLayout(false);
            pnlLecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLecturer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDrinktoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
    }
}