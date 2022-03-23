using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagemetSystem
{
    public partial class Course : UserControl
    {
        public Course()
        {
            InitializeComponent();
        }

        private void BtnCourseNew_Click(object sender, EventArgs e)
        {
            pnlDepartmentAdd.Visible = true;
        }
    }
}
