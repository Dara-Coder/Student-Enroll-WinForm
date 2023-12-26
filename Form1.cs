using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Enroll_WindowForm
{
    public partial class StudentForm : Form
    {
        bool sidebarExpand;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                int v = sidebar.Width - sidebar.MinimumSize.Width;
                if (v == 0)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                int v = sidebar.Width - sidebar.MaximumSize.Width;
                if (v == 0)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void NewStudentBtn_Click(object sender, EventArgs e)
        {
            titleLb.Text = "New Student";
        }

        private void EnrollStudentBtn_Click(object sender, EventArgs e)
        {
            titleLb.Text = "Enroll Student";
        }

        private void SubjectBtn_Click(object sender, EventArgs e)
        {
            titleLb.Text = "Subject";
        }

        private void SectionBtn_Click(object sender, EventArgs e)
        {
            titleLb.Text = "Section";
        }
    }
}