using Golestan_Graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOLESTAN_PROJECT
{
    public partial class Student_Form : Form
    {
        public Student_Form(Student student)
        {
            InitializeComponent();
            LinkedStudent = student;
            LinkedStudent_Semesters = LinkedStudent.RetStudentSemesters();
        }
        private Student LinkedStudent { get; set; }
        private List<Semester> LinkedStudent_Semesters { get; set; }
        private void Student_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Show_Form_inPanel(Panel panel, Form form)
        {
            panel.Controls.Clear();

            panel.Controls.Add(form);
            form.Show();
        }
        private void ShowSemesters_btn_Click(object sender, EventArgs e)
        {
            Student_Semesters_Form student_Semesters_Form = new Student_Semesters_Form(this.LinkedStudent) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, student_Semesters_Form);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void student_information_btn_Click(object sender, EventArgs e)
        {

            Edit_User_Information edit_User_Information = new Edit_User_Information(LinkedStudent) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, edit_User_Information);
            edit_User_Information.Show();

        }


        private void enroll_btn_Click_1(object sender, EventArgs e)
        {
            Student_Semesters_Form student_Semesters_Form = new Student_Semesters_Form(this.LinkedStudent) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, student_Semesters_Form);
        }
    }
}
