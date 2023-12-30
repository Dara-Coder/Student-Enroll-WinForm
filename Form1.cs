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
        private bool sidebarExpand;
        private Form activeForm;
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

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            containerRender.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void NewStudentBtn_Click(object sender, EventArgs e)
        {
            titleLb.Text = "New Student";
            OpenChildForm(new Forms.NewStudentForm(), sender);
        }

        private void EnrollStudentBtn_Click(object sender, EventArgs e)
        {
            titleLb.Text = "Enroll Student";
            OpenChildForm(new Forms.NewEnrollStudentForm(), sender);
        }

        private void SubjectBtn_Click(object sender, EventArgs e)
        {
            titleLb.Text = "Subject";
            OpenChildForm(new Forms.SubjectForm(), sender);
        }

        private void SectionBtn_Click(object sender, EventArgs e)
        {
            titleLb.Text = "Section";
            OpenChildForm(new Forms.SectionForm(), sender);
        }
    }
}