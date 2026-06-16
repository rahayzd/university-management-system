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
    public partial class Moderator_Define_Semester : Form
    {
        public Moderator_Define_Semester()
        {
            InitializeComponent();
        }

        private void Add_semester_btn_Click(object sender, EventArgs e)
        {
            string semesterYear = this.semester_year_nUD.Value.ToString();
            string semseterTerm = this.semester_term_nUD.Value.ToString();
            string semesterFirstday = this.Semester_FirstDay_DT.Value.ToString("dd/MM/yyyy");
            string semesterLastday = this.Semester_LastDay_DT.Value.ToString("dd/MM/yyyy");
            string semesterRegFirstday = this.Semester_RegFirtsDay_DT.Value.ToString("dd/MM/yyyy");
            string semesterRegLastday = this.Semester_RegLastDay_DT.Value.ToString("dd/MM/yyyy");

            
            string command ="make_semester" + " " + semesterYear + "-" + semseterTerm + " " + 
                semesterFirstday + " " + semesterLastday + " " + semesterRegFirstday + " " + semesterRegLastday;

            string res = Commandcenter.Action(command);
            MessageBox.Show(res);
            if (res == "ترم با موفقیت اضافه شد")
            {
                this.Close();
            }


        }

        private void Moderator_Define_Semester_Load(object sender, EventArgs e)
        {

        }
    }
}
