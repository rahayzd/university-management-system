namespace GOLESTAN_PROJECT
{
    partial class Student_SemesterClass_Form
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
            this.form_title_lbl = new System.Windows.Forms.Label();
            this.Semester_display_panel = new System.Windows.Forms.Panel();
            this.semester_listView = new System.Windows.Forms.ListView();
            this.classname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class_professor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semester_lbl = new System.Windows.Forms.Label();
            this.classid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester_display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(34, 47);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(221, 45);
            this.form_title_lbl.TabIndex = 15;
            this.form_title_lbl.Text = "کلاس های دانشجو";
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.semester_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(60, 110);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(681, 272);
            this.Semester_display_panel.TabIndex = 14;
            // 
            // semester_listView
            // 
            this.semester_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.classname,
            this.classid,
            this.class_professor,
            this.mark});
            this.semester_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semester_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_listView.HideSelection = false;
            this.semester_listView.Location = new System.Drawing.Point(0, 0);
            this.semester_listView.MultiSelect = false;
            this.semester_listView.Name = "semester_listView";
            this.semester_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semester_listView.RightToLeftLayout = true;
            this.semester_listView.Size = new System.Drawing.Size(681, 272);
            this.semester_listView.TabIndex = 0;
            this.semester_listView.UseCompatibleStateImageBehavior = false;
            this.semester_listView.View = System.Windows.Forms.View.Details;
            // 
            // classname
            // 
            this.classname.Text = "نام کلاس";
            this.classname.Width = 200;
            // 
            // class_professor
            // 
            this.class_professor.Text = "استاد درس";
            this.class_professor.Width = 150;
            // 
            // mark
            // 
            this.mark.Text = "نمره درس        ";
            this.mark.Width = 150;
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.semester_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.semester_lbl.Location = new System.Drawing.Point(535, 54);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semester_lbl.Size = new System.Drawing.Size(121, 34);
            this.semester_lbl.TabIndex = 16;
            this.semester_lbl.Text = "ترم تحصیلی:";
            // 
            // classid
            // 
            this.classid.Text = "کد درس";
            this.classid.Width = 97;
            // 
            // Student_SemesterClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Semester_display_panel);
            this.Name = "Student_SemesterClass_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Student_SemesterClass_Form";
            this.Load += new System.EventHandler(this.Student_SemesterClass_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.ListView semester_listView;
        private System.Windows.Forms.ColumnHeader classname;
        private System.Windows.Forms.ColumnHeader class_professor;
        private System.Windows.Forms.ColumnHeader mark;
        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.ColumnHeader classid;
    }
}