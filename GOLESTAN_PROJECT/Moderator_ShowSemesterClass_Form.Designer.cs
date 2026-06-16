namespace GOLESTAN_PROJECT
{
    partial class Moderator_ShowSemesterClass_Form
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
            this.field = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registration_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.field_filter_cbox = new System.Windows.Forms.ComboBox();
            this.field_filter_lbl = new System.Windows.Forms.Label();
            this.Add_class_btn = new System.Windows.Forms.Button();
            this.RemoveClass_btn = new System.Windows.Forms.Button();
            this.Update_ClassListview_btn = new System.Windows.Forms.Button();
            this.classId_tbox = new System.Windows.Forms.TextBox();
            this.addclass_Id_lbl = new System.Windows.Forms.Label();
            this.ViewClassInfo_btn = new System.Windows.Forms.Button();
            this.report1_pdf_btn = new System.Windows.Forms.Button();
            this.Semester_display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.semester_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.semester_lbl.Location = new System.Drawing.Point(31, 66);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semester_lbl.Size = new System.Drawing.Size(121, 34);
            this.semester_lbl.TabIndex = 19;
            this.semester_lbl.Text = "ترم تحصیلی:";
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(12, 9);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(109, 45);
            this.form_title_lbl.TabIndex = 18;
            this.form_title_lbl.Text = "کلاس ها";
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.SemesterClass_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(14, 109);
            this.Semester_display_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(704, 374);
            this.Semester_display_panel.TabIndex = 17;
            // 
            // SemesterClass_listView
            // 
            this.SemesterClass_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.classname,
            this.classid,
            this.class_professor,
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
            // class_professor
            // 
            this.class_professor.Text = "استاد درس";
            this.class_professor.Width = 150;
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
            // field_filter_cbox
            // 
            this.field_filter_cbox.FormattingEnabled = true;
            this.field_filter_cbox.Location = new System.Drawing.Point(456, 70);
            this.field_filter_cbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.field_filter_cbox.Name = "field_filter_cbox";
            this.field_filter_cbox.Size = new System.Drawing.Size(183, 30);
            this.field_filter_cbox.TabIndex = 20;
            // 
            // field_filter_lbl
            // 
            this.field_filter_lbl.AutoSize = true;
            this.field_filter_lbl.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.field_filter_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.field_filter_lbl.Location = new System.Drawing.Point(341, 66);
            this.field_filter_lbl.Name = "field_filter_lbl";
            this.field_filter_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.field_filter_lbl.Size = new System.Drawing.Size(109, 34);
            this.field_filter_lbl.TabIndex = 21;
            this.field_filter_lbl.Text = "فیلتر رشته:";
            // 
            // Add_class_btn
            // 
            this.Add_class_btn.AutoSize = true;
            this.Add_class_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_class_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_class_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Add_class_btn.Location = new System.Drawing.Point(768, 417);
            this.Add_class_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_class_btn.Name = "Add_class_btn";
            this.Add_class_btn.Size = new System.Drawing.Size(192, 54);
            this.Add_class_btn.TabIndex = 22;
            this.Add_class_btn.Text = "اضافه کردن درس";
            this.Add_class_btn.UseVisualStyleBackColor = true;
            this.Add_class_btn.Click += new System.EventHandler(this.Add_class_btn_Click);
            // 
            // RemoveClass_btn
            // 
            this.RemoveClass_btn.AutoSize = true;
            this.RemoveClass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveClass_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RemoveClass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.RemoveClass_btn.Location = new System.Drawing.Point(768, 190);
            this.RemoveClass_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveClass_btn.Name = "RemoveClass_btn";
            this.RemoveClass_btn.Size = new System.Drawing.Size(192, 54);
            this.RemoveClass_btn.TabIndex = 23;
            this.RemoveClass_btn.Text = "حذف درس از ترم ";
            this.RemoveClass_btn.UseVisualStyleBackColor = true;
            this.RemoveClass_btn.Click += new System.EventHandler(this.RemoveClass_btn_Click);
            // 
            // Update_ClassListview_btn
            // 
            this.Update_ClassListview_btn.AutoSize = true;
            this.Update_ClassListview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_ClassListview_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Update_ClassListview_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Update_ClassListview_btn.Location = new System.Drawing.Point(768, 110);
            this.Update_ClassListview_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update_ClassListview_btn.Name = "Update_ClassListview_btn";
            this.Update_ClassListview_btn.Size = new System.Drawing.Size(192, 54);
            this.Update_ClassListview_btn.TabIndex = 24;
            this.Update_ClassListview_btn.Text = "به روز رسانی";
            this.Update_ClassListview_btn.UseVisualStyleBackColor = true;
            this.Update_ClassListview_btn.Click += new System.EventHandler(this.Update_ClassListview_btn_Click);
            // 
            // classId_tbox
            // 
            this.classId_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classId_tbox.Location = new System.Drawing.Point(823, 359);
            this.classId_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classId_tbox.MaxLength = 20;
            this.classId_tbox.Name = "classId_tbox";
            this.classId_tbox.Size = new System.Drawing.Size(121, 33);
            this.classId_tbox.TabIndex = 26;
            // 
            // addclass_Id_lbl
            // 
            this.addclass_Id_lbl.AutoSize = true;
            this.addclass_Id_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addclass_Id_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.addclass_Id_lbl.Location = new System.Drawing.Point(747, 359);
            this.addclass_Id_lbl.Name = "addclass_Id_lbl";
            this.addclass_Id_lbl.Size = new System.Drawing.Size(70, 29);
            this.addclass_Id_lbl.TabIndex = 25;
            this.addclass_Id_lbl.Text = "کد درس";
            // 
            // ViewClassInfo_btn
            // 
            this.ViewClassInfo_btn.AutoSize = true;
            this.ViewClassInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewClassInfo_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ViewClassInfo_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.ViewClassInfo_btn.Location = new System.Drawing.Point(768, 262);
            this.ViewClassInfo_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewClassInfo_btn.Name = "ViewClassInfo_btn";
            this.ViewClassInfo_btn.Size = new System.Drawing.Size(192, 54);
            this.ViewClassInfo_btn.TabIndex = 27;
            this.ViewClassInfo_btn.Text = "مشاهده اطلاعات درس";
            this.ViewClassInfo_btn.UseVisualStyleBackColor = true;
            this.ViewClassInfo_btn.Click += new System.EventHandler(this.ViewClassInfo_btn_Click);
            // 
            // report1_pdf_btn
            // 
            this.report1_pdf_btn.AutoSize = true;
            this.report1_pdf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report1_pdf_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.report1_pdf_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.report1_pdf_btn.Location = new System.Drawing.Point(37, 499);
            this.report1_pdf_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.report1_pdf_btn.Name = "report1_pdf_btn";
            this.report1_pdf_btn.Size = new System.Drawing.Size(108, 41);
            this.report1_pdf_btn.TabIndex = 28;
            this.report1_pdf_btn.Text = "pdf گزارش ";
            this.report1_pdf_btn.UseVisualStyleBackColor = true;
            this.report1_pdf_btn.Click += new System.EventHandler(this.report1_pdf_btn_Click);
            // 
            // Moderator_ShowSemesterClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.report1_pdf_btn);
            this.Controls.Add(this.ViewClassInfo_btn);
            this.Controls.Add(this.classId_tbox);
            this.Controls.Add(this.addclass_Id_lbl);
            this.Controls.Add(this.Update_ClassListview_btn);
            this.Controls.Add(this.RemoveClass_btn);
            this.Controls.Add(this.Add_class_btn);
            this.Controls.Add(this.field_filter_lbl);
            this.Controls.Add(this.field_filter_cbox);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Semester_display_panel);
            this.Font = new System.Drawing.Font("Dubai Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Moderator_ShowSemesterClass_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.Moderator_ShowSemesterClass_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.ListView SemesterClass_listView;
        private System.Windows.Forms.ColumnHeader classname;
        private System.Windows.Forms.ColumnHeader class_professor;
        private System.Windows.Forms.ColumnHeader field;
        private System.Windows.Forms.ComboBox field_filter_cbox;
        private System.Windows.Forms.Label field_filter_lbl;
        private System.Windows.Forms.Button Add_class_btn;
        private System.Windows.Forms.Button RemoveClass_btn;
        private System.Windows.Forms.Button Update_ClassListview_btn;
        private System.Windows.Forms.TextBox classId_tbox;
        private System.Windows.Forms.Label addclass_Id_lbl;
        private System.Windows.Forms.Button ViewClassInfo_btn;
        private System.Windows.Forms.ColumnHeader registration_num;
        private System.Windows.Forms.Button report1_pdf_btn;
        private System.Windows.Forms.ColumnHeader classid;
    }
}