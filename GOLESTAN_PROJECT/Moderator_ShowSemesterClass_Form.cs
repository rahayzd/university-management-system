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
    public partial class Moderator_ShowSemesterClass_Form : Form
    {
        public Moderator_ShowSemesterClass_Form(Semester semester)
        {
            InitializeComponent();

            this.LinkedSemester = semester;
            

            this.field_filter_cbox.Items.AddRange(Enum.GetNames(typeof(fields_enum)));
        }

        private Semester LinkedSemester { get; set; }
        private Dictionary<string , Class> AllSemesterClasses_Dict { get; set; }

        private void ShowSemester_Listview(int field_filter)
        {
            
            this.SemesterClass_listView.Items.Clear();

            this.AllSemesterClasses_Dict = this.LinkedSemester.RetClassesInSemester(field_filter);

            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach(Class _class in this.AllSemesterClasses_Dict.Values)
            {
                IUser ClassSemester_professor = _class.RetSemesterClassProfessor(this.LinkedSemester);

                ListViewItem item = new ListViewItem(_class.ClassName) { };

                item.SubItems.Add(_class.GetClassId());
                if(ClassSemester_professor != null)
                {
                    item.SubItems.Add(ClassSemester_professor.Name);
                }
                else
                {
                    item.SubItems.Add("None");
                }
                
                Enum.TryParse(_class.ClassField.ToString(), out fields_enum value);
                item.SubItems.Add(value.ToString());

                item.SubItems.Add(_class.RetSemsesterClassRegistration(LinkedSemester, LinkedSemester.GetSemesterId()));

                items_list.Add(item);
            }
            this.SemesterClass_listView.Items.AddRange(items_list.ToArray());
        }


        private void Moderator_ShowSemesterClass_Form_Load(object sender, EventArgs e)
        {
            this.field_filter_cbox.SelectedIndex = -1;
            this.semester_lbl.Text += this.LinkedSemester.GetSemesterId();

            this.ShowSemester_Listview(-1);

        }

        

        private void Update_ClassListview_btn_Click(object sender, EventArgs e)
        {
            this.ShowSemester_Listview(this.field_filter_cbox.SelectedIndex);
            this.field_filter_cbox.SelectedIndex = -1;
        }

        private void RemoveClass_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.SemesterClass_listView.SelectedItems;

            if (selected_items.Count > 0)
            {
                string classid = selected_items[0].SubItems[1].Text;
                
                string command = "remove_class_from_semester" + " " + classid 
                    + " " + this.LinkedSemester.GetSemesterId();

                string res = Commandcenter.Action(command);
                MessageBox.Show(res);
                if (res == "حذف درس از این ترم با موفقیت انجام شد")
                {
                    ShowSemester_Listview(this.field_filter_cbox.SelectedIndex);
                }

            }
            else
            {
                MessageBox.Show("لظفا یکی از دروس را برای حذف از این ترم انتخاب کنید");
            }
        }

        private void Add_class_btn_Click(object sender, EventArgs e)
        {
            if(this.classId_tbox.Text.Length> 0 )
            {
                string classid = this.classId_tbox.Text;
                string command = "add_class_tosemester" + " " + classid + " " + this.LinkedSemester.GetSemesterId();
                string res = Commandcenter.Action(command);
                MessageBox.Show(res);
                if(res == "کلاس با موفقیت به ترم افزوده شد")
                {
                    this.classId_tbox.Clear();
                    ShowSemester_Listview(this.field_filter_cbox.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("کد درس مورد نظر را وارد کنید");
            }
        }

        private void ViewClassInfo_btn_Click(object sender, EventArgs e)
        {
            
            var selected_items = this.SemesterClass_listView.SelectedItems;

            if (selected_items.Count > 0)
            {
                string classid = selected_items[0].SubItems[1].Text;
                Moderator_ViewClassInSemesterInfo_Form moderator_ViewClassInSemesterInfo_Form =
                    new Moderator_ViewClassInSemesterInfo_Form(this.LinkedSemester, new Info().RetClass(classid));

                moderator_ViewClassInSemesterInfo_Form.Show();
            }
            else
            {
                MessageBox.Show("لظفا یکی از دروس را برای نمایش انتخاب کنید");
            }
        }

        private void report1_pdf_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
