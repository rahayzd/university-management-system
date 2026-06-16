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
    public partial class Moderator_Form : Form
    {
        public Moderator_Form(Moderator moderator)
        {
            InitializeComponent();
            this.LinkedModerator = moderator;

        }
        private Moderator LinkedModerator { get; set; }

        private void HideSubpanel(List<Panel> panels)
        {
            foreach (Panel p in panels)
            {
                p.Hide();
            }
        }
        private void ShowSubpanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Form_inPanel(Panel panel, Form form)
        {
            panel.Controls.Clear();

            panel.Controls.Add(form);
            form.Show();
        }

        private void userlist_btn_Click(object sender, EventArgs e)
        {
            HideSubpanel(new List<Panel> { userlist_subpanel });
            ShowSubpanel(userlist_subpanel);
        }

        private void studentslist_btn_Click(object sender, EventArgs e)
        {
            Moderator_UserList_Form moderator_StudentList_Form = new Moderator_UserList_Form("Student") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, moderator_StudentList_Form);
            moderator_StudentList_Form.Show();
        }

        private void professorslist_btn_Click(object sender, EventArgs e)
        {
            Moderator_UserList_Form moderator_UserList_Form = new Moderator_UserList_Form("Professor") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel , moderator_UserList_Form);
            moderator_UserList_Form.Show();
        }

        private void semester_manager_btn_Click(object sender, EventArgs e)
        {
            Moderator_SemesterManage_Form moderator_SemesterManage_Form = new Moderator_SemesterManage_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Show_Form_inPanel(display_panel, moderator_SemesterManage_Form);
            moderator_SemesterManage_Form.Show();
        }

        private void add_class_btn_Click(object sender, EventArgs e)
        {
            Moderator_DefineClass_Form moderator_DefineClass_Form = new Moderator_DefineClass_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Show_Form_inPanel(display_panel , moderator_DefineClass_Form);
            moderator_DefineClass_Form.Show();
        }
    }
}
