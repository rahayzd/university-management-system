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
    public partial class Moderator_UserList_Form : Form
    {
        public Moderator_UserList_Form(string tabletype)
        {
            InitializeComponent();
            TableType = tabletype;
            
        }

        private Dictionary<string, IUser> AllUser_Dict { get; set; }
        

        private string TableType { get; set; }
         
        private void ShowStudentTable()
        {
            this.Users_listView.Items.Clear();
            AllUser_Dict = new Info().RetAllMembers();
            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach(IUser user in AllUser_Dict.Values)
            {
                if (user is Student)
                {
                    ListViewItem item = new ListViewItem(user.Name, 0) { };
                    
                    Enum.TryParse((user as Student).GetField().ToString(), out fields_enum value);
                    item.SubItems.Add(value.ToString()) ;
                    item.SubItems.Add(user.Id);

                    items_list.Add(item);
                }

            }
            this.Users_listView.Items.AddRange(items_list.ToArray());
        }
        private void ShowProfessorTable()
        {
            this.Users_listView.Items.Clear();
            AllUser_Dict = new Info().RetAllMembers();
            List<ListViewItem> items_list = new List<ListViewItem>();

            foreach(IUser user in AllUser_Dict.Values)
            {
                if (user is Teacher)
                {
                    
                    ListViewItem item = new ListViewItem(user.Name, 0) { };
                    
                    Enum.TryParse((user as Teacher).GetField().ToString(), out fields_enum value);
                    item.SubItems.Add(value.ToString()) ;
                    item.SubItems.Add(user.Id);

                    items_list.Add(item);
                }

            }
            this.Users_listView.Items.AddRange(items_list.ToArray());
        }

        private void Moderator_StudentList_Form_Load(object sender, EventArgs e)
        {
            if(this.TableType == "Student")
            {
                this.form_title_lbl.Text = "دانشجویان";
                this.regEnable_btn.Visible = true;
                ShowStudentTable();
            }
            else if(this.TableType == "Professor")
            {
                this.form_title_lbl.Text = "اساتید";
                this.regEnable_btn.Visible = false;
                ShowProfessorTable();
            }
            
        }

        

        private void remove_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.Users_listView.SelectedItems;
            if (selected_items.Count > 0)
            {
                IUser user = new Info().RetPerson(selected_items[0].SubItems[2].Text);
                Info.RemoveUser(user);
                MessageBox.Show("کاربر با موفقیت حذف شد");
            }
            else
            {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");
            }

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            var selected_items = this.Users_listView.SelectedItems;
            if(selected_items.Count > 0)
            {
               
                IUser user = new Info().RetPerson(selected_items[0].SubItems[2].Text);
                Edit_User_Information edit_User_Information = new Edit_User_Information(user) ;
                edit_User_Information.Show();
            }
            else
            {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");
            }
        }

        private void update_userlist_btn_Click(object sender, EventArgs e)
        {

            if (this.TableType == "Student")
            {

                this.form_title_lbl.Text = "دانشجویان";
                ShowStudentTable();
            }
            else if (this.TableType == "Professor")
            {
                this.form_title_lbl.Text = "اساتید";
                ShowProfessorTable();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected_items = this.Users_listView.SelectedItems;
            if (selected_items.Count > 0)
            {
                
                IUser user = new Info().RetPerson(selected_items[0].SubItems[2].Text);
                if(user is Student)
                {
                    if((user as Student).GetRegisterEnable() == true)
                    {
                        (user as Student).SetRegisterEnable(false);
                        MessageBox.Show("منع ثبت نام دانشجو اعمال شد");
                    }
                    else
                    {
                        (user as Student).SetRegisterEnable(true);
                        MessageBox.Show("منع ثبت نام دانشجو برداشته شد");
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");
            }
        }
    }
}
