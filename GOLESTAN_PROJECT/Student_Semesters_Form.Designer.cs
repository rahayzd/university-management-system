namespace GOLESTAN_PROJECT
{
    partial class Student_Semesters_Form
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
            this.Semester_display_panel = new System.Windows.Forms.Panel();
            this.semester_listView = new System.Windows.Forms.ListView();
            this.semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.form_title_lbl = new System.Windows.Forms.Label();
            this.show_semester_btn = new System.Windows.Forms.Button();
            this.average_lbl = new System.Windows.Forms.Label();
            this.Register_btn = new System.Windows.Forms.Button();
            this.Semester_display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.semester_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(49, 154);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(586, 176);
            this.Semester_display_panel.TabIndex = 0;
            // 
            // semester_listView
            // 
            this.semester_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.semester});
            this.semester_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semester_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_listView.HideSelection = false;
            this.semester_listView.Location = new System.Drawing.Point(0, 0);
            this.semester_listView.MultiSelect = false;
            this.semester_listView.Name = "semester_listView";
            this.semester_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semester_listView.RightToLeftLayout = true;
            this.semester_listView.Size = new System.Drawing.Size(586, 176);
            this.semester_listView.TabIndex = 0;
            this.semester_listView.UseCompatibleStateImageBehavior = false;
            this.semester_listView.View = System.Windows.Forms.View.Details;
            // 
            // semester
            // 
            this.semester.Text = "ترم های تحصیلی دانشجو";
            this.semester.Width = 200;
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(399, 50);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(271, 45);
            this.form_title_lbl.TabIndex = 13;
            this.form_title_lbl.Text = "لیست ترم های دانشجو";
            // 
            // show_semester_btn
            // 
            this.show_semester_btn.AutoSize = true;
            this.show_semester_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_semester_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.show_semester_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.show_semester_btn.Location = new System.Drawing.Point(49, 365);
            this.show_semester_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.show_semester_btn.Name = "show_semester_btn";
            this.show_semester_btn.Size = new System.Drawing.Size(125, 46);
            this.show_semester_btn.TabIndex = 17;
            this.show_semester_btn.Text = "مشاهده";
            this.show_semester_btn.UseVisualStyleBackColor = true;
            this.show_semester_btn.Click += new System.EventHandler(this.show_semester_btn_Click);
            // 
            // average_lbl
            // 
            this.average_lbl.AutoSize = true;
            this.average_lbl.Font = new System.Drawing.Font("Dubai Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.average_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.average_lbl.Location = new System.Drawing.Point(522, 382);
            this.average_lbl.Name = "average_lbl";
            this.average_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.average_lbl.Size = new System.Drawing.Size(118, 29);
            this.average_lbl.TabIndex = 18;
            this.average_lbl.Text = "معدل دانشجو:";
            // 
            // Register_btn
            // 
            this.Register_btn.AutoSize = true;
            this.Register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Register_btn.Location = new System.Drawing.Point(225, 365);
            this.Register_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(125, 46);
            this.Register_btn.TabIndex = 19;
            this.Register_btn.Text = "ثبت نام";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Student_Semesters_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.average_lbl);
            this.Controls.Add(this.show_semester_btn);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Semester_display_panel);
            this.Name = "Student_Semesters_Form";
            this.Text = "Student_Semesters_Form";
            this.Load += new System.EventHandler(this.Student_Semesters_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.ListView semester_listView;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.Button show_semester_btn;
        private System.Windows.Forms.Label average_lbl;
        private System.Windows.Forms.Button Register_btn;
    }
}