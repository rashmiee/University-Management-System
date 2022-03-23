namespace UniversityManagemetSystem
{
    partial class Department
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
            this.DepartmentDataGrid = new System.Windows.Forms.DataGridView();
            this.btnDepartmentNew = new System.Windows.Forms.Button();
            this.pnlDepartmentAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGrid)).BeginInit();
            this.pnlDepartmentAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentDataGrid
            // 
            this.DepartmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDataGrid.Location = new System.Drawing.Point(36, 268);
            this.DepartmentDataGrid.Name = "DepartmentDataGrid";
            this.DepartmentDataGrid.RowHeadersWidth = 51;
            this.DepartmentDataGrid.RowTemplate.Height = 24;
            this.DepartmentDataGrid.Size = new System.Drawing.Size(762, 265);
            this.DepartmentDataGrid.TabIndex = 0;
            // 
            // btnDepartmentNew
            // 
            this.btnDepartmentNew.Location = new System.Drawing.Point(711, 55);
            this.btnDepartmentNew.Name = "btnDepartmentNew";
            this.btnDepartmentNew.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentNew.TabIndex = 1;
            this.btnDepartmentNew.Text = "NEW";
            this.btnDepartmentNew.UseVisualStyleBackColor = true;
            this.btnDepartmentNew.Click += new System.EventHandler(this.BtnDepartmentNew_Click);
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
            this.label1.Location = new System.Drawing.Point(119, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDepartmentAdd);
            this.Controls.Add(this.btnDepartmentNew);
            this.Controls.Add(this.DepartmentDataGrid);
            this.Name = "Department";
            this.Size = new System.Drawing.Size(842, 574);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGrid)).EndInit();
            this.pnlDepartmentAdd.ResumeLayout(false);
            this.pnlDepartmentAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DepartmentDataGrid;
        private System.Windows.Forms.Button btnDepartmentNew;
        private System.Windows.Forms.Panel pnlDepartmentAdd;
        private System.Windows.Forms.Label label1;
    }
}
