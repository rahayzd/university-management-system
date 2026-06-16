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
    public partial class Professor_Form : Form
    {
        public Professor_Form(Teacher professor)
        {
            InitializeComponent();
            LinkedProfessor = professor;
        }
        private Teacher LinkedProfessor { get; set; }

        private void Show_Form_inPanel(Panel panel, Form form)
        {
            panel.Controls.Clear();

            panel.Controls.Add(form);
            form.Show();
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void professor_information_btn_Click(object sender, EventArgs e)
        {
            Edit_User_Information edit_User_Information = new Edit_User_Information(LinkedProfessor) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, edit_User_Information);
            edit_User_Information.Show();
        }

        private void ShowSemesters_btn_Click(object sender, EventArgs e)
        {
            Professor_Semester_Form professor_Semester_Form = new Professor_Semester_Form(LinkedProfessor) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel , professor_Semester_Form);
            professor_Semester_Form.Show();
        }
    }
}
