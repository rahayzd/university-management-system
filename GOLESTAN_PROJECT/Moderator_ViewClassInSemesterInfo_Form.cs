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
    public partial class Moderator_ViewClassInSemesterInfo_Form : Form
    {
        public Moderator_ViewClassInSemesterInfo_Form(Semester semester , Class _class)
        {
            InitializeComponent();
            this.LinkedSemester = semester;
            this.LinkedClass = _class;
        }
        private Semester LinkedSemester { get; set; }
        private Class LinkedClass { get; set; }

        private void ShowSemester_Listview()
        {

            this.SemesterClassStudent_listView.Items.Clear();

            var res = Commandcenter.Action("class_status" + " " + this.LinkedClass.GetClassId() + " "
                + this.LinkedSemester.GetSemesterId()).Split(',').ToList();

            List<ListViewItem> items_list = new List<ListViewItem>();

            this.professor_name_lbl.Text += res[0];
            res.RemoveRange(0, 1);

            foreach (string studentid in res)
            {

                IUser ClassSemester_student = new Info().RetPerson(studentid);

                ListViewItem item = new ListViewItem(ClassSemester_student.Name) { };

                item.SubItems.Add(ClassSemester_student.Id);
                item.SubItems.Add((ClassSemester_student as Student).GetClassMark(LinkedClass, LinkedClass.GetClassId()));

                

                items_list.Add(item);
            }
            this.SemesterClassStudent_listView.Items.AddRange(items_list.ToArray());
        }
        private void Moderator_ViewClassInSemesterInfo_Form_Load(object sender, EventArgs e)
        {
            this.ShowSemester_Listview();
            this.semester_lbl.Text += LinkedSemester.GetSemesterId();
            this.professor_name_lbl.Text = "";
            this.professor_name_lbl.Text = LinkedClass.RetClassSemesterProfessor(LinkedSemester) == null ? "None" : LinkedClass.RetClassSemesterProfessor(LinkedSemester).Name;
        }

        private void changeclass_professor_btn_Click(object sender, EventArgs e)
        {
            if(this.profid_tbox.Text.Length > 0)
            {
                string professorid = this.profid_tbox.Text;
                string classid = this.LinkedClass.GetClassId();
                
                string command = "add_change_class_professor" + " " + professorid 
                    + " " + classid + " " +  this.LinkedSemester.GetSemesterId();

                string res = Commandcenter.Action(command);
                MessageBox.Show(res);
                if (res == "استاد درس با موفقیت تغییر یافت")
                {
                    this.profid_tbox.Clear();
                    ShowSemester_Listview();
                    this.professor_name_lbl.Text = "";
                    this.professor_name_lbl.Text = LinkedClass.RetClassSemesterProfessor(LinkedSemester) == null ? "None" : LinkedClass.RetClassSemesterProfessor(LinkedSemester).Name;
                }
            }
            else
            {
                MessageBox.Show("کد ملی استاد مورد نظر را وارد کنید");
            }
        }

        private void Add_student_btn_Click(object sender, EventArgs e)
        {
            if (this.studentId_tbox.Text.Length > 0)
            {
                string studentid = this.studentId_tbox.Text.Trim();
                string classid = this.LinkedClass.GetClassId().Trim();

                string command = "add_student" + " " + studentid 
                    + " " + classid + " " + this.LinkedSemester.GetSemesterId();

                string res = Commandcenter.Action(command);
                MessageBox.Show(res);
                if (res == "دانشجو با موفقیت به کلاس اضافه شد")
                {
                    this.studentId_tbox.Clear();
                    ShowSemester_Listview();
                }
            }
            else
            {
                MessageBox.Show("کد ملی دانشجوی مورد نظر را وارد کنید");
            }
        }

        private void Update_ClassListview_btn_Click(object sender, EventArgs e)
        {
            ShowSemester_Listview();
            this.professor_name_lbl.Text = "";
            this.professor_name_lbl.Text = LinkedClass.RetClassSemesterProfessor(LinkedSemester) == null ? "None" : LinkedClass.RetClassSemesterProfessor(LinkedSemester).Name;
        }

        private void RemoveُStudent_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.SemesterClassStudent_listView.SelectedItems;
            if (selected_items.Count > 0)
            {
                string studentid = selected_items[0].SubItems[1].Text;
                string classid = this.LinkedClass.GetClassId();
                

                string command  = "remove_student_from_class" + " " + studentid 
                    + " " + classid + " " + this.LinkedSemester.GetSemesterId();

                string res = Commandcenter.Action(command);
                MessageBox.Show(res);
                if(res == "حذف دانشجو از این کلاس با موفقیت انجام شد")
                {
                    ShowSemester_Listview();
                }
                
            }
            else
            {
                MessageBox.Show("لظفا یکی از دانشجویان را برای حذف از این کلاس انتخاب کنید");
            }

        }
    }
}
