namespace GOLESTAN_PROJECT
{
    partial class Professor_ShowSemseterClass_Form
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
            this.ViewClassInfo_btn = new System.Windows.Forms.Button();
            this.Update_ClassListview_btn = new System.Windows.Forms.Button();
            this.semester_lbl = new System.Windows.Forms.Label();
            this.form_title_lbl = new System.Windows.Forms.Label();
            this.Semester_display_panel = new System.Windows.Forms.Panel();
            this.SemesterClass_listView = new System.Windows.Forms.ListView();
            this.classname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.field = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registration_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester_display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewClassInfo_btn
            // 
            this.ViewClassInfo_btn.AutoSize = true;
            this.ViewClassInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewClassInfo_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ViewClassInfo_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.ViewClassInfo_btn.Location = new System.Drawing.Point(755, 272);
            this.ViewClassInfo_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewClassInfo_btn.Name = "ViewClassInfo_btn";
            this.ViewClassInfo_btn.Size = new System.Drawing.Size(192, 54);
            this.ViewClassInfo_btn.TabIndex = 32;
            this.ViewClassInfo_btn.Text = "مشاهده اطلاعات درس";
            this.ViewClassInfo_btn.UseVisualStyleBackColor = true;
            this.ViewClassInfo_btn.Click += new System.EventHandler(this.ViewClassInfo_btn_Click);
            // 
            // Update_ClassListview_btn
            // 
            this.Update_ClassListview_btn.AutoSize = true;
            this.Update_ClassListview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_ClassListview_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Update_ClassListview_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Update_ClassListview_btn.Location = new System.Drawing.Point(755, 198);
            this.Update_ClassListview_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update_ClassListview_btn.Name = "Update_ClassListview_btn";
            this.Update_ClassListview_btn.Size = new System.Drawing.Size(192, 54);
            this.Update_ClassListview_btn.TabIndex = 31;
            this.Update_ClassListview_btn.Text = "به روز رسانی";
            this.Update_ClassListview_btn.UseVisualStyleBackColor = true;
            this.Update_ClassListview_btn.Click += new System.EventHandler(this.Update_ClassListview_btn_Click);
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.semester_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.semester_lbl.Location = new System.Drawing.Point(29, 77);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semester_lbl.Size = new System.Drawing.Size(121, 34);
            this.semester_lbl.TabIndex = 30;
            this.semester_lbl.Text = "ترم تحصیلی:";
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(10, 20);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(109, 45);
            this.form_title_lbl.TabIndex = 29;
            this.form_title_lbl.Text = "کلاس ها";
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.SemesterClass_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(12, 120);
            this.Semester_display_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(704, 374);
            this.Semester_display_panel.TabIndex = 28;
            // 
            // SemesterClass_listView
            // 
            this.SemesterClass_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.classname,
            this.classid,
            this.field,
            this.registration_num});
            this.SemesterClass_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemesterClass_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterClass_listView.HideSelection = false;
            this.SemesterClass_listView.Location = new System.Drawing.Point(0, 0);
            this.SemesterClass_listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SemesterClass_listView.MultiSelect = false;
            this.SemesterClass_listView.Name = "SemesterClass_listView";
            this.SemesterClass_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SemesterClass_listView.RightToLeftLayout = true;
            this.SemesterClass_listView.Size = new System.Drawing.Size(704, 374);
            this.SemesterClass_listView.TabIndex = 0;
            this.SemesterClass_listView.UseCompatibleStateImageBehavior = false;
            this.SemesterClass_listView.View = System.Windows.Forms.View.Details;
            // 
            // classname
            // 
            this.classname.Text = "نام درس";
            this.classname.Width = 200;
            // 
            // classid
            // 
            this.classid.Text = "کد درس";
            this.classid.Width = 77;
            // 
            // field
            // 
            this.field.Text = "رشته";
            this.field.Width = 150;
            // 
            // registration_num
            // 
            this.registration_num.Text = "تعداد ثبت نام";
            this.registration_num.Width = 104;
            // 
            // Professor_ShowSemseterClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.ViewClassInfo_btn);
            this.Controls.Add(this.Update_ClassListview_btn);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Semester_display_panel);
            this.Name = "Professor_ShowSemseterClass_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Professor_ShowSemseterClass_Form";
            this.Load += new System.EventHandler(this.Professor_ShowSemseterClass_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewClassInfo_btn;
        private System.Windows.Forms.Button Update_ClassListview_btn;
        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.ListView SemesterClass_listView;
        private System.Windows.Forms.ColumnHeader classname;
        private System.Windows.Forms.ColumnHeader classid;
        private System.Windows.Forms.ColumnHeader field;
        private System.Windows.Forms.ColumnHeader registration_num;
    }
}