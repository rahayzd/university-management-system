namespace GOLESTAN_PROJECT
{
    partial class Moderator_SemesterManage_Form
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
            this.Semesters_listView = new System.Windows.Forms.ListView();
            this.semesterId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.show_semester_btn = new System.Windows.Forms.Button();
            this.NewSemester_btn = new System.Windows.Forms.Button();
            this.RemoveSemester_btn = new System.Windows.Forms.Button();
            this.UpdateList_btn = new System.Windows.Forms.Button();
            this.Semester_display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(12, 9);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(279, 45);
            this.form_title_lbl.TabIndex = 15;
            this.form_title_lbl.Text = "لیست ترم های تحصیلی";
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.Semesters_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(52, 66);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(239, 298);
            this.Semester_display_panel.TabIndex = 14;
            // 
            // Semesters_listView
            // 
            this.Semesters_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.semesterId});
            this.Semesters_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Semesters_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semesters_listView.HideSelection = false;
            this.Semesters_listView.Location = new System.Drawing.Point(0, 0);
            this.Semesters_listView.Name = "Semesters_listView";
            this.Semesters_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Semesters_listView.RightToLeftLayout = true;
            this.Semesters_listView.Size = new System.Drawing.Size(239, 298);
            this.Semesters_listView.TabIndex = 0;
            this.Semesters_listView.UseCompatibleStateImageBehavior = false;
            this.Semesters_listView.View = System.Windows.Forms.View.Details;
            // 
            // semesterId
            // 
            this.semesterId.Text = "ترم های تحصیلی ";
            this.semesterId.Width = 200;
            // 
            // show_semester_btn
            // 
            this.show_semester_btn.AutoSize = true;
            this.show_semester_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_semester_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.show_semester_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.show_semester_btn.Location = new System.Drawing.Point(307, 247);
            this.show_semester_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.show_semester_btn.Name = "show_semester_btn";
            this.show_semester_btn.Size = new System.Drawing.Size(150, 50);
            this.show_semester_btn.TabIndex = 18;
            this.show_semester_btn.Text = "مشاهده ترم";
            this.show_semester_btn.UseVisualStyleBackColor = true;
            this.show_semester_btn.Click += new System.EventHandler(this.show_semester_btn_Click);
            // 
            // NewSemester_btn
            // 
            this.NewSemester_btn.AutoSize = true;
            this.NewSemester_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSemester_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewSemester_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.NewSemester_btn.Location = new System.Drawing.Point(307, 175);
            this.NewSemester_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewSemester_btn.Name = "NewSemester_btn";
            this.NewSemester_btn.Size = new System.Drawing.Size(150, 50);
            this.NewSemester_btn.TabIndex = 19;
            this.NewSemester_btn.Text = "ترم جدید";
            this.NewSemester_btn.UseVisualStyleBackColor = true;
            this.NewSemester_btn.Click += new System.EventHandler(this.NewSemester_btn_Click);
            // 
            // RemoveSemester_btn
            // 
            this.RemoveSemester_btn.AutoSize = true;
            this.RemoveSemester_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSemester_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RemoveSemester_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.RemoveSemester_btn.Location = new System.Drawing.Point(307, 314);
            this.RemoveSemester_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveSemester_btn.Name = "RemoveSemester_btn";
            this.RemoveSemester_btn.Size = new System.Drawing.Size(150, 50);
            this.RemoveSemester_btn.TabIndex = 20;
            this.RemoveSemester_btn.Text = "حذف ترم";
            this.RemoveSemester_btn.UseVisualStyleBackColor = true;
            this.RemoveSemester_btn.Click += new System.EventHandler(this.RemoveSemester_btn_Click);
            // 
            // UpdateList_btn
            // 
            this.UpdateList_btn.AutoSize = true;
            this.UpdateList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateList_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UpdateList_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.UpdateList_btn.Location = new System.Drawing.Point(52, 385);
            this.UpdateList_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateList_btn.Name = "UpdateList_btn";
            this.UpdateList_btn.Size = new System.Drawing.Size(135, 41);
            this.UpdateList_btn.TabIndex = 21;
            this.UpdateList_btn.Text = "به روز رسانی";
            this.UpdateList_btn.UseVisualStyleBackColor = true;
            this.UpdateList_btn.Click += new System.EventHandler(this.UpdateList_btn_Click);
            // 
            // Moderator_SemesterManage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateList_btn);
            this.Controls.Add(this.RemoveSemester_btn);
            this.Controls.Add(this.NewSemester_btn);
            this.Controls.Add(this.show_semester_btn);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Semester_display_panel);
            this.Name = "Moderator_SemesterManage_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Moderator_SemesterManage_Form";
            this.Load += new System.EventHandler(this.Moderator_SemesterManage_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.ListView Semesters_listView;
        private System.Windows.Forms.ColumnHeader semesterId;
        private System.Windows.Forms.Button show_semester_btn;
        private System.Windows.Forms.Button NewSemester_btn;
        private System.Windows.Forms.Button RemoveSemester_btn;
        private System.Windows.Forms.Button UpdateList_btn;
    }
}