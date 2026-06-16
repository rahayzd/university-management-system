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
    public partial class Login_Form : Form
    {
        public Login_Form(int role)
        {
            InitializeComponent();
            LoginRole = role;
        }

        private int LoginRole;
        private void ID_tbox_Validating(object sender, CancelEventArgs e)
        {
            if (this.ID_tbox.Text.Length != 10)
            {
                this.errorProvider_ID.SetError(ID_tbox, "کد ملی باید 10 رقمی باشد!");
            }
            else
            {
                this.errorProvider_ID.Clear();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            IUser user = new Info().UserLogin(this.password_tbox.Text, this.ID_tbox.Text);

            if (user != null)
            {
                if (this.LoginRole == 1 && user is Student) // student
                {
                    Student_Form student_Form = new Student_Form(user as Student);
                    student_Form.Show();

                    this.ID_tbox.Clear();
                    this.password_tbox.Clear();
                }
                else if (this.LoginRole == 2 && user is Teacher) // professor
                {
                    Professor_Form professor_Form = new Professor_Form(user as Teacher);
                    professor_Form.Show();
                    this.ID_tbox.Clear();
                    this.password_tbox.Clear();

                }
                else if (this.LoginRole == 3 && user is Moderator) // moderator
                {
                    Moderator_Form moderator_Form = new Moderator_Form(user as Moderator);
                    moderator_Form.Show();

                    this.ID_tbox.Clear();
                    this.password_tbox.Clear();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمزعبور نادرست است");
                }
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمزعبور نادرست است");
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
