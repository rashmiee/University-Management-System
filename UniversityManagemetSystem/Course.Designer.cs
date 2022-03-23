namespace UniversityManagemetSystem
{
    partial class Course
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CourseDataGrid = new System.Windows.Forms.DataGridView();
            this.btnCourseNew = new System.Windows.Forms.Button();
            this.pnlDepartmentAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).BeginInit();
            this.pnlDepartmentAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseDataGrid
            // 
            this.CourseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGrid.Location = new System.Drawing.Point(29, 301);
            this.CourseDataGrid.Name = "CourseDataGrid";
            this.CourseDataGrid.RowHeadersWidth = 51;
            this.CourseDataGrid.RowTemplate.Height = 24;
            this.CourseDataGrid.Size = new System.Drawing.Size(778, 246);
            this.CourseDataGrid.TabIndex = 0;
            // 
            // btnCourseNew
            // 
            this.btnCourseNew.Location = new System.Drawing.Point(707, 67);
            this.btnCourseNew.Name = "btnCourseNew";
            this.btnCourseNew.Size = new System.Drawing.Size(75, 23);
            this.btnCourseNew.TabIndex = 1;
            this.btnCourseNew.Text = "NEW";
            this.btnCourseNew.UseVisualStyleBackColor = true;
            this.btnCourseNew.Click += new System.EventHandler(this.BtnCourseNew_Click);
            // 
            // pnlDepartmentAdd
            // 
            this.pnlDepartmentAdd.Controls.Add(this.label1);
            this.pnlDepartmentAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDepartmentAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlDepartmentAdd.Name = "pnlDepartmentAdd";
            this.pnlDepartmentAdd.Size = new System.Drawing.Size(842, 574);
            this.pnlDepartmentAdd.TabIndex = 2;
            this.pnlDepartmentAdd.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDepartmentAdd);
            this.Controls.Add(this.btnCourseNew);
            this.Controls.Add(this.CourseDataGrid);
            this.Name = "Course";
            this.Size = new System.Drawing.Size(842, 574);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).EndInit();
            this.pnlDepartmentAdd.ResumeLayout(false);
            this.pnlDepartmentAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CourseDataGrid;
        private System.Windows.Forms.Button btnCourseNew;
        private System.Windows.Forms.Panel pnlDepartmentAdd;
        private System.Windows.Forms.Label label1;
    }
}
