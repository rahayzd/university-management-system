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
    public partial class Moderator_Signup_Form : Form
    {
        public Moderator_Signup_Form()
        {
            InitializeComponent();
        }

        private void Name_tbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.Name_tbox.Text))
            {
                this.errorProvider_Name.SetError(Name_tbox, "این فیلد نمی تواند خالی باشد");
            }
            else if (this.Name_tbox.Text.Length > 20)
            {
                this.errorProvider_Name.SetError(Name_tbox, "حداکثر 20 کاراکتر");
            }
            else
            {
                this.errorProvider_Name.Clear();
            }
        }

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

        private void Register_Click(object sender, EventArgs e)
        {
            if (this.Name_tbox.Text.Length < 1)
            {
                MessageBox.Show("فیلد نام نباید خالی باشد");
            }
            else if (this.ID_tbox.Text.Length != 10)
            {
                MessageBox.Show("کدملی باید 10 رقمی باشد");
            }
            else if (password_tbox.Text.Trim().Length < 8)
            {
                MessageBox.Show("رمز نباید کمتر از 8 کاراکتر باشد");
            }
            else
            {


                string commmand = "register_moderator" + " " + Name_tbox.Text + " " + ID_tbox.Text + " "  + password_tbox.Text;
                string result = Commandcenter.Action(commmand); // register student
                MessageBox.Show(result);
                if (result == "به گلستان خوش آمدید")
                {
                    Name_tbox.Clear();
                    ID_tbox.Clear();
                    password_tbox.Clear();
                }

            }
        }

        private void Moderator_Signup_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
