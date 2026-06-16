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
    public partial class Student_ClassRegistration_Form : Form
    {
        public Student_ClassRegistration_Form(Student student , Semester semester)
        {
            InitializeComponent();
            this.LinkedStudent = student;
            this.LinkedSemester = semester;
            LinkedStudent_Classes = LinkedStudent.RetRegisteredClasses(LinkedSemester);
            LinkedSemester_Classes = LinkedSemester.RetClassesInSemester(LinkedStudent.GetField()).Values.ToList();

        }

        private Semester LinkedSemester { get; set; }
        private Student LinkedStudent { get; set; }
        private List<Class> LinkedStudent_Classes { get; set; }
        private List<Class> LinkedSemester_Classes { get; set; }

        private void Student_ClassRegistration_Form_Load(object sender, EventArgs e)
        {
            this.average_lbl.Text += LinkedStudent.CalculateAverageMark().ToString();
            this.semester_lbl.Text += LinkedSemester.GetSemesterId();

            ShowSemesterClasses_Listview();
            ShowRegisteredClasses_Listview();
        }

        private void ShowSemesterClasses_Listview()
        {
            this.RegisteredClass_listView.Items.Clear();
            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach (Class _class in LinkedSemester_Classes)
            {

                IUser ClassSemester_professor = _class.RetSemesterClassProfessor(this.LinkedSemester);

                ListViewItem item = new ListViewItem(_class.ClassName) { };

                item.SubItems.Add(_class.GetClassId());

                if (ClassSemester_professor != null)
                {
                    item.SubItems.Add(ClassSemester_professor.Name);
                }
                else
                {
                    item.SubItems.Add("None");
                }

                item.SubItems.Add(_class.GetClassCredits().ToString());

                items_list.Add(item);

            }
            this.SemesterClass_listView.Items.AddRange(items_list.ToArray());
        }
        private void ShowRegisteredClasses_Listview()
        {
            this.RegisteredClass_listView.Items.Clear();
            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach (Class _class in LinkedStudent.RetRegisteredClasses(LinkedSemester))
            {

                IUser ClassSemester_professor = _class.RetSemesterClassProfessor(this.LinkedSemester);

                ListViewItem item = new ListViewItem(_class.ClassName) { };

                item.SubItems.Add(_class.GetClassId());

                if (ClassSemester_professor != null)
                {
                    item.SubItems.Add(ClassSemester_professor.Name);
                }
                else
                {
                    item.SubItems.Add("None");
                }

                item.SubItems.Add(_class.GetClassCredits().ToString());

                items_list.Add(item);

            }
            this.RegisteredClass_listView.Items.AddRange(items_list.ToArray());
        }

        private int RegisteredCredits()
        {
            int res = 0;
            foreach(Class _class in LinkedStudent.RetRegisteredClasses(LinkedSemester))
            {
                res += _class.GetClassCredits();
            }
            return res;
        }

        private void RegInClass_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.SemesterClass_listView.SelectedItems;

            if (SemesterClass_listView.SelectedItems.Count > 0)
            {
                Class selectedClass = new Info().RetClass(selected_items[0].SubItems[1].Text.ToString());
                
                if (LinkedStudent.CalculateAverageMark() >= 17)
                {
                    if (RegisteredCredits() + selectedClass.GetClassCredits() > 24)
                    {
                        MessageBox.Show("حداکثر تعداد واحد برای شما 24 واحد است");
                    }
                    else
                    {
                        string command = "add_student" + " " + LinkedStudent.Id
                            + " " + selectedClass.GetClassId() + " " + this.LinkedSemester.GetSemesterId();

                        string res = Commandcenter.Action(command);
                        MessageBox.Show(res);
                        if (res == "دانشجو با موفقیت به کلاس اضافه شد")
                        {
                            ShowRegisteredClasses_Listview();
                        }
                    }
                }
                else if (LinkedStudent.CalculateAverageMark() < 17 && LinkedStudent.CalculateAverageMark() >= 12)
                {
                    if (RegisteredCredits() + selectedClass.GetClassCredits() > 20)
                    {
                        MessageBox.Show("حداکثر تعداد واحد برای شما 20 واحد است");
                    }
                    else
                    {
                        string command = "add_student" + " " + LinkedStudent.Id
                            + " " + selectedClass.GetClassId() + " " + this.LinkedSemester.GetSemesterId();

                        string res = Commandcenter.Action(command);
                        MessageBox.Show(res);
                        if (res == "دانشجو با موفقیت به کلاس اضافه شد")
                        {
                            ShowRegisteredClasses_Listview();
                        }
                    }
                }
                else if (LinkedStudent.CalculateAverageMark() < 12 )
                {
                    if (RegisteredCredits() + selectedClass.GetClassCredits() > 12)
                    {
                        MessageBox.Show("حداکثر تعداد واحد برای شما 12 واحد است");
                    }
                    else
                    {
                        string command = "add_student" + " " + LinkedStudent.Id
                            + " " + selectedClass.GetClassId() + " " + this.LinkedSemester.GetSemesterId();

                        string res = Commandcenter.Action(command);
                        MessageBox.Show(res);
                        if (res == "دانشجو با موفقیت به کلاس اضافه شد")
                        {
                            ShowRegisteredClasses_Listview();
                        }
                    }
                }
                

            }
            else
            {
                MessageBox.Show("لطفا یکی ازکلاس ها را انتخاب کنید");
            }

            
        }

        private void removeclass_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.RegisteredClass_listView.SelectedItems;

            if (selected_items.Count > 0)
            {
                Class selectedClass = new Info().RetClass(selected_items[0].SubItems[1].Text.ToString());

                string command = "remove_student_from_class" + " " + LinkedStudent.Id
                    + " " + selectedClass.GetClassId() + " " + this.LinkedSemester.GetSemesterId();

                string res = Commandcenter.Action(command);
                MessageBox.Show(res);
                if (res == "حذف دانشجو از این کلاس با موفقیت انجام شد")
                {
                    ShowRegisteredClasses_Listview();
                }
                    
            }
            else
            {
                MessageBox.Show("لطفا یکی ازکلاس ها را انتخاب کنید");
            }
        }
    }
}
