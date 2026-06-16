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
    public partial class Moderator_EditClass_Form : Form
    {
        public Moderator_EditClass_Form(Class linkedclass)
        {
            InitializeComponent();
            this.classfield_combo.Items.AddRange(Enum.GetNames(typeof(fields_enum)));

            LinkedClass = linkedclass;
            this.classname_tbox.Text = linkedclass.ClassName;
            this.classId_tbox.Text = linkedclass.GetClassId();
            this.classfield_combo.SelectedIndex = linkedclass.ClassField;
            this.credits_numUD.Value = linkedclass.GetClassCredits();
        }


        private Class LinkedClass { get; set; }
        private void Moderator_EditClass_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void editclass_btn_Click(object sender, EventArgs e)
        {
            if (this.classname_tbox.Text.Length < 1)
            {
                MessageBox.Show("فیلد نام نباید خالی باشد");
            }
            else if (this.classId_tbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("کد کلاس را وارد کنید");
            }
            else if (string.IsNullOrEmpty(classfield_combo.Text))
            {
                MessageBox.Show("رشته مربوط به درس را انتخاب نمایید");
            }
            

            else
            {
                
                
                LinkedClass.ClassName = this.classname_tbox.Text;
                LinkedClass.SetClassId (this.classId_tbox.Text);
                LinkedClass.ClassField = (this.classfield_combo.SelectedIndex);
                LinkedClass.SetClassCredits((int)credits_numUD.Value);

                MessageBox.Show("تغییرات با موفقیت اعمال شد");
                this.Close();

                
            }
        }
    }
}

