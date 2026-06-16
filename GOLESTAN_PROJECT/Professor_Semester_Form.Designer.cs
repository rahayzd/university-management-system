namespace GOLESTAN_PROJECT
{
    partial class Professor_Semester_Form
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
            this.show_semester_btn = new System.Windows.Forms.Button();
            this.form_title_lbl = new System.Windows.Forms.Label();
            this.Semester_display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.semester_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(54, 126);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(473, 176);
            this.Semester_display_panel.TabIndex = 20;
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
            this.semester_listView.Size = new System.Drawing.Size(473, 176);
            this.semester_listView.TabIndex = 0;
            this.semester_listView.UseCompatibleStateImageBehavior = false;
            this.semester_listView.View = System.Windows.Forms.View.Details;
            // 
            // semester
            // 
            this.semester.Text = "ترم های تحصیلی ";
            this.semester.Width = 200;
            // 
            // show_semester_btn
            // 
            this.show_semester_btn.AutoSize = true;
            this.show_semester_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_semester_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.show_semester_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.show_semester_btn.Location = new System.Drawing.Point(54, 337);
            this.show_semester_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.show_semester_btn.Name = "show_semester_btn";
            this.show_semester_btn.Size = new System.Drawing.Size(125, 46);
            this.show_semester_btn.TabIndex = 22;
            this.show_semester_btn.Text = "مشاهده";
            this.show_semester_btn.UseVisualStyleBackColor = true;
            this.show_semester_btn.Click += new System.EventHandler(this.show_semester_btn_Click);
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(32, 40);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(159, 45);
            this.form_title_lbl.TabIndex = 21;
            this.form_title_lbl.Text = "لیست ترم ها";
            // 
            // Professor_Semester_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Semester_display_panel);
            this.Controls.Add(this.show_semester_btn);
            this.Controls.Add(this.form_title_lbl);
            this.Name = "Professor_Semester_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Professor_Semester_Form";
            this.Load += new System.EventHandler(this.Professor_Semester_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.ListView semester_listView;
        private System.Windows.Forms.ColumnHeader semester;
        private System.Windows.Forms.Button show_semester_btn;
        private System.Windows.Forms.Label form_title_lbl;
    }
}