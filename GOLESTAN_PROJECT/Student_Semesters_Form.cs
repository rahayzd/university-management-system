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
    public partial class Student_Semesters_Form : Form
    {
        public Student_Semesters_Form(Student student)
        {
            InitializeComponent();
            LinkedStudent = student;
            LinkedStudent_Semesters = LinkedStudent.RetStudentSemesters();
        }
        private Student LinkedStudent { get; set; }
        private List<Semester> LinkedStudent_Semesters { get; set; }
        private void Student_Semesters_Form_Load(object sender, EventArgs e)
        {
            this.average_lbl.Text += LinkedStudent.CalculateAverageMark().ToString();


            List<ListViewItem> items_list = new List<ListViewItem>();
            
            foreach (Semester semester in LinkedStudent_Semesters)
            {
                ListViewItem item = new ListViewItem( "ترم " + " " + semester.GetSemesterId()) {};
                items_list.Add(item);
            }
            this.semester_listView.Items.AddRange(items_list.ToArray());

        }

        private void show_semester_btn_Click(object sender, EventArgs e)
        {
            if(this.semester_listView.SelectedItems.Count > 0)
            {
                var selected_semesterid = this.semester_listView.SelectedItems[0].Text.Trim().Split(' ')[2];
                Student_SemesterClass_Form student_SemesterClass_Form =
                    new Student_SemesterClass_Form(LinkedStudent, new Info().RetSemester(selected_semesterid.Trim()));
                student_SemesterClass_Form.Show();

            }
            else
            {
                MessageBox.Show("لطفا یکی از ترم ها را انتخاب کنید");
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if(LinkedStudent.GetRegisterEnable() == true)
            {
                var selected_items = this.semester_listView.SelectedItems;

                if (semester_listView.SelectedItems.Count > 0)
                {
                    Semester semester = new Info().RetSemester(semester_listView.SelectedItems[0].Text.Trim().Split(' ')[2]);
                   
                    
                    if (DateTime.Today >= semester.GetRegisterationFirstDay() && DateTime.Today < semester.GetRegistration_LastDay())
                    {
                        Student_ClassRegistration_Form student_ClassRegistration_Form
                            = new Student_ClassRegistration_Form(LinkedStudent, semester);
                        student_ClassRegistration_Form.Show();
                    }
                    else
                    {
                        MessageBox.Show("خارج از بازه ثبت نام");
                    }
                }
                else
                {
                    MessageBox.Show("لطفا یکی ازکلاس ها را انتخاب کنید");
                }
            }
            else
            {
                MessageBox.Show("اجازه ثبت نام برای شما وجود ندارد");
            }
            
        }
    }
}
