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
    public partial class Initial_Form : Form
    {
        public Initial_Form()
        {
            InitializeComponent();
        }

        private void HideSubpanel(List<Panel> panels)
        {
          foreach(Panel p in panels)
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

        private void Show_Form_inPanel (Panel panel , Form form)
        {
            this.display_panel.Controls.Clear();
         
            this.display_panel.Controls.Add(form);
            form.Show();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            HideSubpanel(new List<Panel> { login_subpanel });
            ShowSubpanel(signup_subpanel);
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            HideSubpanel(new List<Panel> { signup_subpanel });
            ShowSubpanel(login_subpanel);

        }

        
        private void side_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            new Info().SaveData(new CSV_FileSaveLoader());
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        

        private void Initial_Form_Load(object sender, EventArgs e)
        {
            new Info().LoadData(new CSV_FileSaveLoader());
        }

        private void loginAs_student_Click(object sender, EventArgs e)
        { 
            Login_Form login_Form = new Login_Form(1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel , login_Form);
        }

        private void loginAs_professor_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form(2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, login_Form);
        }

        private void loginAs_moderator_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form(3) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, login_Form);
        }

        private void signupAs_student_Click(object sender, EventArgs e)
        {
            add_student_Form register_student_Form = new add_student_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, register_student_Form);
        }

        private void signupAs_professor_Click(object sender, EventArgs e)
        {
            add_professor_Form register_professor_Form = new add_professor_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, register_professor_Form);
        }

        private void signupAs_moderator_Click(object sender, EventArgs e)
        {
            Moderator_Signup_Form moderator_Signup_Form = new Moderator_Signup_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Show_Form_inPanel(display_panel, moderator_Signup_Form);
        }

        private void Initial_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Info().SaveData(new CSV_FileSaveLoader());
        }
    }

    
}

