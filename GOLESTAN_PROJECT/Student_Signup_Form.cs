using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;


namespace Golestan_Graphic
{
    
    public partial class add_student_Form : Form
    {
        
        public add_student_Form()
        {
            InitializeComponent();

            this.field_combo.Items.AddRange(Enum.GetNames(typeof(fields_enum)));
           
        }



        private void add_student_Form_Load(object sender, EventArgs e)
        {
            this.field_combo.SelectedIndex = -1;
        }

        private void SetInput_Language(string language)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo(language));
        }


         
        private void Name_tbox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(this.Name_tbox.Text) )
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
            if(this.ID_tbox.Text.Length != 10)
            {
                this.errorProvider_ID.SetError(ID_tbox , "کد ملی باید 10 رقمی باشد!");
            }
            else
            {
                this.errorProvider_ID.Clear();
            }
        }

        private void ID_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void Year_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void add_student_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Year_tbox_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(this.Year_tbox.Text) < 1300)
            {
                this.errorProvider_Year.SetError(Year_tbox, "سال ورود نباید کمتر از 1300 باشد");
            }
            else
            {
                this.errorProvider_Year.Clear();
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
            else if (string.IsNullOrEmpty(this.Year_tbox.Text))
            {
                MessageBox.Show("سال ورودی خود را وارد نمایید");

            }
            else if (int.Parse(this.Year_tbox.Text) < 1300)
            {
                MessageBox.Show("سال ورودی نمیتواند از 1300 کمتر باشد");
            }
            else if (int.Parse(this.Year_tbox.Text) > 1500)
            {
                MessageBox.Show("سال ورودی نمیتواند از 1500 بیشتر باشد");
            }
            else if (string.IsNullOrEmpty(field_combo.Text))
            {
                MessageBox.Show("رشته خود را انتخاب نمایید");
            }
            else if (password_tbox.Text.Trim().Length < 8)
            {
                MessageBox.Show("رمز نباید کمتر از 8 کاراکتر باشد");
            }
            else
            {
                
                
                string commmand = "register_student" + " " + Name_tbox.Text + " " + ID_tbox.Text + " " + Year_tbox.Text + " " + field_combo.SelectedIndex.ToString() + " " + password_tbox.Text;
                string result = Commandcenter.Action(commmand); // register student
                MessageBox.Show(result);
                if (result == "به گلستان خوش آمدید")
                {

                    Name_tbox.Clear();
                    ID_tbox.Clear();
                    Year_tbox.Clear();
                    field_combo.SelectedIndex = -1;
                    password_tbox.Clear();
                }

            }
        }
    }

   
}
