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
    public partial class Moderator_SemesterManage_Form : Form
    {
        public Moderator_SemesterManage_Form()
        {
            InitializeComponent();
            this.AllSemesters_Dict = new Dictionary<string, Semester>();
        }

        private void NewSemester_btn_Click(object sender, EventArgs e)
        {
            Moderator_Define_Semester moderator_Define_Semester = new Moderator_Define_Semester();
            moderator_Define_Semester.Show();
        }

        private Dictionary<string, Semester> AllSemesters_Dict;
        private Moderator LinkedModerator { get; set; }

        private void ShowSemester_Listview()
        {
            this.Semesters_listView.Items.Clear();

            AllSemesters_Dict = new Info().RetAllSemesters();
            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach (Semester semester in AllSemesters_Dict.Values)
            {
                ListViewItem item = new ListViewItem("ترم " + " " + semester.GetSemesterId()) { };
                items_list.Add(item);
            }
            this.Semesters_listView.Items.AddRange(items_list.ToArray());
        }
        private void Moderator_SemesterManage_Form_Load(object sender, EventArgs e)
        {
            ShowSemester_Listview();

        }

        private void RemoveSemester_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.Semesters_listView.SelectedItems;

            if (Semesters_listView.SelectedItems.Count > 0)
            {
                
                Info.RemoveSemester(new Info().RetSemester(selected_items[0].Text.Split()[2]));

                this.ShowSemester_Listview();
                MessageBox.Show("ترم با موفقیت حذف شد");
            }
            else
            {
                MessageBox.Show("لطفا یکی از ترم ها را انتخاب کنید");
            }
            
        }

        private void UpdateList_btn_Click(object sender, EventArgs e)
        {
            this.ShowSemester_Listview();
        }

        private void show_semester_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.Semesters_listView.SelectedItems;

            if (Semesters_listView.SelectedItems.Count > 0)
            {
                
                Moderator_ShowSemesterClass_Form moderator_ShowSemesterClass_Form = new
                    Moderator_ShowSemesterClass_Form(new Info().RetSemester(selected_items[0].Text.Split()[2]));

                moderator_ShowSemesterClass_Form.Show();
                
            }
            else
            {
                MessageBox.Show("لطفا یکی از ترم ها را انتخاب کنید");
            }
        }
    }
}
