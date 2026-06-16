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
    public partial class Moderator_DefineClass_Form : Form
    {
        public Moderator_DefineClass_Form()
        {
            InitializeComponent();
            this.classfield_combo.Items.AddRange(Enum.GetNames(typeof(fields_enum)));
        }

        

        private void classname_tbox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void classId_tbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void RegisterClass_btn_Click(object sender, EventArgs e)
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
                MessageBox.Show("رشته خود را انتخاب نمایید");
            }
            
            else
            {


                string commmand = "make_class " + classname_tbox.Text + " " + classId_tbox.Text + " " + classfield_combo.SelectedIndex.ToString()+ " " + credits_numUD.Value.ToString();
                string result = Commandcenter.Action(commmand); // make class
                MessageBox.Show(result);

                if (result == "کلاس با موفقیت اضافه شد")
                {
                    classname_tbox.Clear();
                    classId_tbox.Clear();
                    classfield_combo.SelectedIndex = -1;
                    credits_numUD.Value = 1;
                    ShowClasses_Listview();
                }
            }
        }

        private void Moderator_DefineClass_Form_Load(object sender, EventArgs e)
        {
            this.classfield_combo.SelectedIndex = -1;
            this.ShowClasses_Listview();
        }

        private void ShowClasses_Listview()
        {

            this.classes_listView.Items.Clear();

            

            List<ListViewItem> items_list = new List<ListViewItem>();

            List<string> classes = new Info().RetAllClasses();
            
            foreach (string _class in classes)
            {

                string class_name = _class.Split(',')[0];
                string class_id = _class.Split(',')[1];
                string class_field = _class.Split(',')[2];
                string class_credits = _class.Split(',')[3];

                ListViewItem item = new ListViewItem(class_name) { };

                item.SubItems.Add(class_id);

                Enum.TryParse(class_field, out fields_enum value);
                item.SubItems.Add(value.ToString());

                item.SubItems.Add(class_credits);
                items_list.Add(item);
            }
            this.classes_listView.Items.AddRange(items_list.ToArray());
        }
        private void editclass_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.classes_listView.SelectedItems;

            if (classes_listView.SelectedItems.Count > 0)
            {
                
                Moderator_EditClass_Form moderator_EditClass_Form 
                    = new Moderator_EditClass_Form(new Info().RetClass(selected_items[0].SubItems[1].Text));
                moderator_EditClass_Form.Show();

            }
            else
            {
                MessageBox.Show("لطفا یکی از کلاس ها را انتخاب کنید");
            }
        }

        private void removeClass_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.classes_listView.SelectedItems;

            if (classes_listView.SelectedItems.Count > 0)
            {
                
                Info.RemoveClass(new Info().RetClass(selected_items[0].SubItems[1].Text));
                this.ShowClasses_Listview();
                MessageBox.Show("کلاس با موفقیت حذف شد");

            }
            else
            {
                MessageBox.Show("لطفا یکی ازکلاس ها را انتخاب کنید");
            }
        }

        private void UpdateList_btn_Click(object sender, EventArgs e)
        {
            this.ShowClasses_Listview();
        }
    }
}
