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
    public partial class Department : UserControl
    {
        public Department()
        {
            InitializeComponent();
        }

        private void BtnDepartmentNew_Click(object sender, EventArgs e)
        {
            pnlDepartmentAdd.Visible = true;
        }
    }
}
