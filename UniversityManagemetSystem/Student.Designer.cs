namespace UniversityManagemetSystem
{
    partial class Student
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
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            this.btnStudentNew = new System.Windows.Forms.Button();
            this.pnlStudentAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            this.pnlStudentAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(28, 263);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.RowHeadersWidth = 51;
            this.StudentDataGrid.RowTemplate.Height = 24;
            this.StudentDataGrid.Size = new System.Drawing.Size(789, 272);
            this.StudentDataGrid.TabIndex = 0;
            // 
            // btnStudentNew
            // 
            this.btnStudentNew.Location = new System.Drawing.Point(709, 68);
            this.btnStudentNew.Name = "btnStudentNew";
            this.btnStudentNew.Size = new System.Drawing.Size(107, 34);
            this.btnStudentNew.TabIndex = 1;
            this.btnStudentNew.Text = "New";
            this.btnStudentNew.UseVisualStyleBackColor = true;
            this.btnStudentNew.Click += new System.EventHandler(this.BtnStudentNew_Click);
            // 
            // pnlStudentAdd
            // 
            this.pnlStudentAdd.Controls.Add(this.textBox4);
            this.pnlStudentAdd.Controls.Add(this.textBox3);
            this.pnlStudentAdd.Controls.Add(this.textBox2);
            this.pnlStudentAdd.Controls.Add(this.textBox1);
            this.pnlStudentAdd.Controls.Add(this.label4);
            this.pnlStudentAdd.Controls.Add(this.label3);
            this.pnlStudentAdd.Controls.Add(this.label2);
            this.pnlStudentAdd.Controls.Add(this.label1);
            this.pnlStudentAdd.Location = new System.Drawing.Point(63, 47);
            this.pnlStudentAdd.Name = "pnlStudentAdd";
            this.pnlStudentAdd.Size = new System.Drawing.Size(316, 146);
            this.pnlStudentAdd.TabIndex = 2;
            this.pnlStudentAdd.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(404, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(404, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(404, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStudentAdd);
            this.Controls.Add(this.btnStudentNew);
            this.Controls.Add(this.StudentDataGrid);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(842, 574);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            this.pnlStudentAdd.ResumeLayout(false);
            this.pnlStudentAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDataGrid;
        private System.Windows.Forms.Button btnStudentNew;
        private System.Windows.Forms.Panel pnlStudentAdd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
