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
    public partial class Edit_User_Information : Form
    {
        public Edit_User_Information(IUser student)
        {
            InitializeComponent();
            LinkedIUser = student;
        }
        private IUser LinkedIUser { get; set; }
        private void Edit_Student_Information_Load(object sender, EventArgs e)
        {
            this.Name_tbox.Text = LinkedIUser.Name;
            this.ID_tbox.Text = LinkedIUser.Id;
            this.password_tbox.Text = LinkedIUser.GetPassword();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (ID_tbox.Text.Trim() == "" || Name_tbox.Text.Trim() == "" || password_tbox.Text.Trim() == "")
            {
                MessageBox.Show("هیچ فیلدی نباید خالی باشد");
            }
           
            else
            {
                
                if(new Info().PIdExictence(this.ID_tbox.Text) && this.ID_tbox.Text != LinkedIUser.Id)
                {
                    MessageBox.Show("این کد ملی قبلا در سامانه ثبت شده است");
                }
                else
                {
                    LinkedIUser.Name = this.Name_tbox.Text;
                    LinkedIUser.Id = this.ID_tbox.Text;
                    LinkedIUser.SetPassword(this.password_tbox.Text);
                    MessageBox.Show("تغییرات با موفقیت اعمال شد");
                }
                
                this.Close();

            }
            

        }
    }
}
