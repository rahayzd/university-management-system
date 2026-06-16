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
    public partial class Professor_Semester_Form : Form
    {
        public Professor_Semester_Form(Teacher professor)
        {
            InitializeComponent();
            LinkedProfessor = professor;
        }
        private Teacher LinkedProfessor { get; set; }
        private List<Semester> SemesterList { get; set; }
        private void show_semester_btn_Click(object sender, EventArgs e)
        {
            if (this.semester_listView.SelectedItems.Count > 0)
            {
                var selected_semesterid = this.semester_listView.SelectedItems[0].Text.Trim().Split(' ')[2];
                Professor_ShowSemseterClass_Form professor_ShowSemseterClass_Form =
                    new Professor_ShowSemseterClass_Form(LinkedProfessor, new Info().RetSemester(selected_semesterid.Trim()));
                professor_ShowSemseterClass_Form.Show();
            }
            else
            {
                MessageBox.Show("لطفا یکی از ترم ها را انتخاب کنید");
            }
        }

        private void Professor_Semester_Form_Load(object sender, EventArgs e)
        {

            SemesterList = new Info().RetAllSemesters().Values.ToList();
            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach (Semester semester in SemesterList)
            {
                ListViewItem item = new ListViewItem("ترم " + " " + semester.GetSemesterId()) { };
                items_list.Add(item);
            }
            this.semester_listView.Items.AddRange(items_list.ToArray());
        }
    }
}
