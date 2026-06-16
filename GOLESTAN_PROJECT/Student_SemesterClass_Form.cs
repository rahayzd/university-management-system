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
    public partial class Student_SemesterClass_Form : Form
    {
        public Student_SemesterClass_Form(Student student , Semester semester)
        {
            InitializeComponent();
            LinkedStudent = student;
            LinkedSemester = semester;
            LinkedStudent_Classes = LinkedStudent.RetRegisteredClasses(LinkedSemester);
            this.semester_lbl.Text += LinkedSemester.GetSemesterId();

        }
        private Student LinkedStudent { get; set; }
        private Semester LinkedSemester { get; set; }

        private List<Class> LinkedStudent_Classes { get; set; }

        private void ShowSemester_Listview()
        {
            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach (Class _class in LinkedStudent_Classes)
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

               
                item.SubItems.Add(_class.RetStudentMark(LinkedStudent, LinkedStudent.Id, LinkedSemester));

                

                items_list.Add(item);



            }
            this.semester_listView.Items.AddRange(items_list.ToArray());
        }

        private void Student_SemesterClass_Form_Load(object sender, EventArgs e)
        {
            this.ShowSemester_Listview();
        }
    }
}
