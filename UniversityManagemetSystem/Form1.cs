using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagemetSystem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            student1.Show();
            student1.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student1.Hide();
            department1.Hide();
            course1.Hide();
//hello second hello
           

        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            department1.Show();
            department1.Dock = DockStyle.Fill;
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            course1.Show();
            course1.Dock = DockStyle.Fill;
               
        }
    } 

   
}
