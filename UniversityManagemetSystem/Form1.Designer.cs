namespace UniversityManagemetSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.student1 = new UniversityManagemetSystem.Student();
            this.department1 = new UniversityManagemetSystem.Department();
            this.course1 = new UniversityManagemetSystem.Course();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.Info;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.Location = new System.Drawing.Point(88, 159);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(160, 128);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "STUDENT";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartment.Image")));
            this.btnDepartment.Location = new System.Drawing.Point(319, 159);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(160, 128);
            this.btnDepartment.TabIndex = 1;
            this.btnDepartment.Text = "DEPARTMENT";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.BtnDepartment_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnCourse.Image")));
            this.btnCourse.Location = new System.Drawing.Point(558, 160);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(160, 128);
            this.btnCourse.TabIndex = 2;
            this.btnCourse.Text = "COURSE";
            this.btnCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.BtnCourse_Click);
            // 
            // student1
            // 
            this.student1.Location = new System.Drawing.Point(12, 12);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(92, 82);
            this.student1.TabIndex = 3;
            // 
            // department1
            // 
            this.department1.Location = new System.Drawing.Point(319, 12);
            this.department1.Name = "department1";
            this.department1.Size = new System.Drawing.Size(103, 90);
            this.department1.TabIndex = 4;
            // 
            // course1
            // 
            this.course1.Location = new System.Drawing.Point(574, 24);
            this.course1.Name = "course1";
            this.course1.Size = new System.Drawing.Size(67, 57);
            this.course1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(826, 527);
            this.Controls.Add(this.course1);
            this.Controls.Add(this.department1);
            this.Controls.Add(this.student1);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnStudent);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "University Managemnet System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnCourse;
        private Student student1;
        private Department department1;
        private Course course1;
    }
}

