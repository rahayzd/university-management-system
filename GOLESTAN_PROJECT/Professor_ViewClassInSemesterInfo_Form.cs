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
    public partial class Professor_ViewClassInSemesterInfo_Form : Form
    {
        public Professor_ViewClassInSemesterInfo_Form(Teacher professor , Semester semester, Class _class)
        {
            InitializeComponent();

            LinkedSemester = semester;
            LinkedProfessor = professor;
            LinkedClass = _class;
        }
        private Teacher LinkedProfessor { get; set; }
        private Semester LinkedSemester { get; set; }
        private Class LinkedClass { get; set; }


        private void Professor_ViewClassInSemesterInfo_Form_Load(object sender, EventArgs e)
        {
            ShowSemester_Listview();
            this.semester_lbl.Text += LinkedSemester.GetSemesterId();
        }

        private void ShowSemester_Listview()
        {

            this.SemesterClassStudent_listView.Items.Clear();

            var res = Commandcenter.Action("class_status" + " " + this.LinkedClass.GetClassId() + " "
                + this.LinkedSemester.GetSemesterId()).Split(',').ToList();

            List<ListViewItem> items_list = new List<ListViewItem>();

            
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

        private void submit_mark_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.SemesterClassStudent_listView.SelectedItems;
            if (selected_items.Count > 0)
            {
                string studentid = selected_items[0].SubItems[1].Text;
                string classid = this.LinkedClass.GetClassId();
                string professorid = this.LinkedProfessor.Id;
                string semesterid = this.LinkedSemester.GetSemesterId();
                string mark = this.studentmark_tbox.Text;

                if(string.IsNullOrEmpty(mark) || int.Parse(mark) <0 || int.Parse(mark)>20)
                {
                    MessageBox.Show("نمره وارد شده نامعتبر است");
                }
                else
                {
                    string command = "set_final_mark" + " " + professorid + " " + studentid
                                        + " " + classid + " " + this.LinkedSemester.GetSemesterId()+ " " + mark;

                    string res = Commandcenter.Action(command);
                    MessageBox.Show(res);
                    if (res == "نمره دانشجو با موفقیت تغییر یافت")
                    {
                        ShowSemester_Listview();
                    }
                }
                

            }
            else
            {
                MessageBox.Show("لظفا یکی از دانشجویان را برای حذف از این کلاس انتخاب کنید");
            }
        }

        private void studentmark_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
