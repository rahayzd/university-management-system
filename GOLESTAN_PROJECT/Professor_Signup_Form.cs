using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Golestan_Graphic.add_student_Form;

namespace Golestan_Graphic
{
    
    public partial class add_professor_Form : Form
    {
        public add_professor_Form()
        {
            InitializeComponent();

            this.field_combo.Items.AddRange(Enum.GetNames(typeof(fields_enum)));

        }

        private void add_professor_Form_Load(object sender, EventArgs e)
        {
            this.field_combo.SelectedIndex = -1;
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
                string commmand = "register_professor " + Name_tbox.Text + " " + ID_tbox.Text + " "  + field_combo.SelectedIndex.ToString() + " " + password_tbox.Text;
                string result = Commandcenter.Action(commmand); // register professor
                MessageBox.Show(result);
                if(result == "به گلستان خوش آمدید")
                {
                    this.Name_tbox.Clear();
                    this.ID_tbox.Clear();
                    this.field_combo.SelectedIndex = -1;
                    this.password_tbox.Clear();

                }
                
            }
        }

        
    }
}
