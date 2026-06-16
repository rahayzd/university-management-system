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
    public partial class Professor_ShowSemseterClass_Form : Form
    {
        public Professor_ShowSemseterClass_Form(Teacher professor , Semester semester)
        {
            InitializeComponent();
            LinkedProfessor = professor;
            LinkedSemester = semester;
        }

        private Teacher LinkedProfessor { get; set; }
        private Semester LinkedSemester { get; set; }

        private List< Class> SemesterClasses { get; set; }
        private void Professor_ShowSemseterClass_Form_Load(object sender, EventArgs e)
        {
            this.semester_lbl.Text += this.LinkedSemester.GetSemesterId();

            this.ShowSemester_Listview(LinkedProfessor.GetField());

        }

        private void ShowSemester_Listview(int field_filter)
        {

            this.SemesterClass_listView.Items.Clear();

            //this.AllSemesterClasses_Dict = this.LinkedSemester.RetClassesInSemester(field_filter);
            this.SemesterClasses = LinkedProfessor.RetRegisteredClasses(LinkedSemester);
            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach (Class _class in this.SemesterClasses)
            {
                

                ListViewItem item = new ListViewItem(_class.ClassName) { };

                item.SubItems.Add(_class.GetClassId());
                

                Enum.TryParse(_class.ClassField.ToString(), out fields_enum value);
                item.SubItems.Add(value.ToString());

                item.SubItems.Add(_class.RetSemsesterClassRegistration(LinkedSemester, LinkedSemester.GetSemesterId()));

                items_list.Add(item);
            }
            this.SemesterClass_listView.Items.AddRange(items_list.ToArray());
        }

        private void Update_ClassListview_btn_Click(object sender, EventArgs e)
        {
            this.ShowSemester_Listview(LinkedProfessor.GetField());
        }

        private void ViewClassInfo_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.SemesterClass_listView.SelectedItems;

            if (selected_items.Count > 0)
            {
                string classid = selected_items[0].SubItems[1].Text;

                Professor_ViewClassInSemesterInfo_Form professor_ViewClassInSemesterInfo_Form =
                    new Professor_ViewClassInSemesterInfo_Form(LinkedProfessor, LinkedSemester, new Info().RetClass(classid));
                professor_ViewClassInSemesterInfo_Form.Show();
            }
            else
            {
                MessageBox.Show("لظفا یکی از دروس را برای نمایش انتخاب کنید");
            }
        }
    }
}
