namespace CourseManagementSystem
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.instructor = new System.Windows.Forms.TextBox();
            this.coursename = new System.Windows.Forms.TextBox();
            this.coursecode = new System.Windows.Forms.TextBox();
            this.crdthr = new System.Windows.Forms.TextBox();
            this.outline = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MScourse = new System.Windows.Forms.RadioButton();
            this.Bscourse = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Credit Hours";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Instructor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Outline";
            // 
            // instructor
            // 
            this.instructor.Location = new System.Drawing.Point(135, 112);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(142, 20);
            this.instructor.TabIndex = 7;
            // 
            // coursename
            // 
            this.coursename.Location = new System.Drawing.Point(135, 56);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(142, 20);
            this.coursename.TabIndex = 8;
            // 
            // coursecode
            // 
            this.coursecode.Location = new System.Drawing.Point(135, 25);
            this.coursecode.Name = "coursecode";
            this.coursecode.Size = new System.Drawing.Size(142, 20);
            this.coursecode.TabIndex = 9;
            // 
            // crdthr
            // 
            this.crdthr.Location = new System.Drawing.Point(135, 81);
            this.crdthr.Name = "crdthr";
            this.crdthr.Size = new System.Drawing.Size(142, 20);
            this.crdthr.TabIndex = 10;
            // 
            // outline
            // 
            this.outline.Location = new System.Drawing.Point(135, 181);
            this.outline.Name = "outline";
            this.outline.Size = new System.Drawing.Size(142, 51);
            this.outline.TabIndex = 12;
            this.outline.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.ForeColor = System.Drawing.Color.FloralWhite;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(135, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.ForeColor = System.Drawing.Color.FloralWhite;
            this.button2.Location = new System.Drawing.Point(227, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MScourse
            // 
            this.MScourse.AutoSize = true;
            this.MScourse.BackColor = System.Drawing.Color.Teal;
            this.MScourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MScourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MScourse.ForeColor = System.Drawing.Color.FloralWhite;
            this.MScourse.Location = new System.Drawing.Point(119, 4);
            this.MScourse.Margin = new System.Windows.Forms.Padding(2);
            this.MScourse.Name = "MScourse";
            this.MScourse.Size = new System.Drawing.Size(85, 17);
            this.MScourse.TabIndex = 16;
            this.MScourse.TabStop = true;
            this.MScourse.Text = "MS course";
            this.MScourse.UseVisualStyleBackColor = false;
            this.MScourse.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Bscourse
            // 
            this.Bscourse.AutoSize = true;
            this.Bscourse.BackColor = System.Drawing.Color.Teal;
            this.Bscourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bscourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bscourse.ForeColor = System.Drawing.Color.FloralWhite;
            this.Bscourse.Location = new System.Drawing.Point(220, 4);
            this.Bscourse.Margin = new System.Windows.Forms.Padding(2);
            this.Bscourse.Name = "Bscourse";
            this.Bscourse.Size = new System.Drawing.Size(83, 17);
            this.Bscourse.TabIndex = 17;
            this.Bscourse.TabStop = true;
            this.Bscourse.Text = "BS course";
            this.Bscourse.UseVisualStyleBackColor = false;
            this.Bscourse.CheckedChanged += new System.EventHandler(this.Bscourse_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.sem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Bscourse);
            this.panel1.Controls.Add(this.coursecode);
            this.panel1.Controls.Add(this.MScourse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.coursename);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.crdthr);
            this.panel1.Controls.Add(this.outline);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.instructor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(72, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 283);
            this.panel1.TabIndex = 18;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackgroundImage = global::CourseManagementSystem.Properties.Resources.images__8_;
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // sem
            // 
            this.sem.Location = new System.Drawing.Point(135, 144);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(142, 20);
            this.sem.TabIndex = 18;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox instructor;
        private System.Windows.Forms.TextBox coursename;
        private System.Windows.Forms.TextBox coursecode;
        private System.Windows.Forms.TextBox crdthr;
        private System.Windows.Forms.RichTextBox outline;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton MScourse;
        private System.Windows.Forms.RadioButton Bscourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.TextBox sem;
    }
}