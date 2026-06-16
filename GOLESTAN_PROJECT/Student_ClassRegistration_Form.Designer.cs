namespace GOLESTAN_PROJECT
{
    partial class Student_ClassRegistration_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.semester_lbl = new System.Windows.Forms.Label();
            this.form_title_lbl = new System.Windows.Forms.Label();
            this.Semester_display_panel = new System.Windows.Forms.Panel();
            this.SemesterClass_listView = new System.Windows.Forms.ListView();
            this.classname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class_professor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisteredClass_listView = new System.Windows.Forms.ListView();
            this.regclassname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regclassid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regclassprof = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.average_lbl = new System.Windows.Forms.Label();
            this.RegInClass_btn = new System.Windows.Forms.Button();
            this.classcredit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regclasscredit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeclass_btn = new System.Windows.Forms.Button();
            this.Semester_display_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.semester_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.semester_lbl.Location = new System.Drawing.Point(516, 26);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semester_lbl.Size = new System.Drawing.Size(121, 34);
            this.semester_lbl.TabIndex = 19;
            this.semester_lbl.Text = "ترم تحصیلی:";
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(34, 20);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(175, 40);
            this.form_title_lbl.TabIndex = 18;
            this.form_title_lbl.Text = "دروس ارائه شده";
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.SemesterClass_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(41, 82);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(681, 186);
            this.Semester_display_panel.TabIndex = 17;
            // 
            // SemesterClass_listView
            // 
            this.SemesterClass_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.classname,
            this.classid,
            this.class_professor,
            this.classcredit});
            this.SemesterClass_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemesterClass_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterClass_listView.HideSelection = false;
            this.SemesterClass_listView.Location = new System.Drawing.Point(0, 0);
            this.SemesterClass_listView.MultiSelect = false;
            this.SemesterClass_listView.Name = "SemesterClass_listView";
            this.SemesterClass_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SemesterClass_listView.RightToLeftLayout = true;
            this.SemesterClass_listView.Size = new System.Drawing.Size(681, 186);
            this.SemesterClass_listView.TabIndex = 0;
            this.SemesterClass_listView.UseCompatibleStateImageBehavior = false;
            this.SemesterClass_listView.View = System.Windows.Forms.View.Details;
            // 
            // classname
            // 
            this.classname.Text = "نام کلاس";
            this.classname.Width = 200;
            // 
            // classid
            // 
            this.classid.Text = "کد درس";
            this.classid.Width = 97;
            // 
            // class_professor
            // 
            this.class_professor.Text = "استاد درس";
            this.class_professor.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RegisteredClass_listView);
            this.panel1.Location = new System.Drawing.Point(41, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 186);
            this.panel1.TabIndex = 20;
            // 
            // RegisteredClass_listView
            // 
            this.RegisteredClass_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regclassname,
            this.regclassid,
            this.regclassprof,
            this.regclasscredit});
            this.RegisteredClass_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisteredClass_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisteredClass_listView.HideSelection = false;
            this.RegisteredClass_listView.Location = new System.Drawing.Point(0, 0);
            this.RegisteredClass_listView.MultiSelect = false;
            this.RegisteredClass_listView.Name = "RegisteredClass_listView";
            this.RegisteredClass_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RegisteredClass_listView.RightToLeftLayout = true;
            this.RegisteredClass_listView.Size = new System.Drawing.Size(681, 186);
            this.RegisteredClass_listView.TabIndex = 0;
            this.RegisteredClass_listView.UseCompatibleStateImageBehavior = false;
            this.RegisteredClass_listView.View = System.Windows.Forms.View.Details;
            // 
            // regclassname
            // 
            this.regclassname.Text = "نام کلاس";
            this.regclassname.Width = 200;
            // 
            // regclassid
            // 
            this.regclassid.Text = "کد درس";
            this.regclassid.Width = 97;
            // 
            // regclassprof
            // 
            this.regclassprof.Text = "استاد درس";
            this.regclassprof.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(34, 301);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(206, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "ثبت نام های موفق ";
            // 
            // average_lbl
            // 
            this.average_lbl.AutoSize = true;
            this.average_lbl.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.average_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.average_lbl.Location = new System.Drawing.Point(843, 31);
            this.average_lbl.Name = "average_lbl";
            this.average_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.average_lbl.Size = new System.Drawing.Size(123, 29);
            this.average_lbl.TabIndex = 23;
            this.average_lbl.Text = "معدل دانشجو: ";
            // 
            // RegInClass_btn
            // 
            this.RegInClass_btn.AutoSize = true;
            this.RegInClass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegInClass_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegInClass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.RegInClass_btn.Location = new System.Drawing.Point(799, 249);
            this.RegInClass_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegInClass_btn.Name = "RegInClass_btn";
            this.RegInClass_btn.Size = new System.Drawing.Size(150, 60);
            this.RegInClass_btn.TabIndex = 22;
            this.RegInClass_btn.Text = "اضافه کردن";
            this.RegInClass_btn.UseVisualStyleBackColor = true;
            this.RegInClass_btn.Click += new System.EventHandler(this.RegInClass_btn_Click);
            // 
            // classcredit
            // 
            this.classcredit.Text = "واحد";
            // 
            // regclasscredit
            // 
            this.regclasscredit.Text = "واحد";
            // 
            // removeclass_btn
            // 
            this.removeclass_btn.AutoSize = true;
            this.removeclass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeclass_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.removeclass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.removeclass_btn.Location = new System.Drawing.Point(799, 335);
            this.removeclass_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeclass_btn.Name = "removeclass_btn";
            this.removeclass_btn.Size = new System.Drawing.Size(150, 60);
            this.removeclass_btn.TabIndex = 24;
            this.removeclass_btn.Text = "حذف درس";
            this.removeclass_btn.UseVisualStyleBackColor = true;
            this.removeclass_btn.Click += new System.EventHandler(this.removeclass_btn_Click);
            // 
            // Student_ClassRegistration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1083, 586);
            this.Controls.Add(this.removeclass_btn);
            this.Controls.Add(this.average_lbl);
            this.Controls.Add(this.RegInClass_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Semester_display_panel);
            this.Name = "Student_ClassRegistration_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Student_ClassRegistration_Form";
            this.Load += new System.EventHandler(this.Student_ClassRegistration_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.ListView SemesterClass_listView;
        private System.Windows.Forms.ColumnHeader classname;
        private System.Windows.Forms.ColumnHeader classid;
        private System.Windows.Forms.ColumnHeader class_professor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView RegisteredClass_listView;
        private System.Windows.Forms.ColumnHeader regclassname;
        private System.Windows.Forms.ColumnHeader regclassid;
        private System.Windows.Forms.ColumnHeader regclassprof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label average_lbl;
        private System.Windows.Forms.Button RegInClass_btn;
        private System.Windows.Forms.ColumnHeader classcredit;
        private System.Windows.Forms.ColumnHeader regclasscredit;
        private System.Windows.Forms.Button removeclass_btn;
    }
}