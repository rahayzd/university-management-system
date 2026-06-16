namespace GOLESTAN_PROJECT
{
    partial class Student_Form
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
            this.side_panel = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.student_information_btn = new System.Windows.Forms.Button();
            this.ShowSemesters_btn = new System.Windows.Forms.Button();
            this.Golestan_lbl = new System.Windows.Forms.Label();
            this.display_panel = new System.Windows.Forms.Panel();
            this.title_panel = new System.Windows.Forms.Panel();
            this.enroll_btn = new System.Windows.Forms.Button();
            this.side_panel.SuspendLayout();
            this.title_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // side_panel
            // 
            this.side_panel.AutoScroll = true;
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.side_panel.Controls.Add(this.exit_btn);
            this.side_panel.Controls.Add(this.student_information_btn);
            this.side_panel.Controls.Add(this.enroll_btn);
            this.side_panel.Controls.Add(this.ShowSemesters_btn);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.side_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(62)))), ((int)(((byte)(133)))));
            this.side_panel.Location = new System.Drawing.Point(817, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.side_panel.Size = new System.Drawing.Size(210, 669);
            this.side_panel.TabIndex = 3;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.exit_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.exit_btn.Location = new System.Drawing.Point(0, 177);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.exit_btn.Size = new System.Drawing.Size(210, 57);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "خروج";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // student_information_btn
            // 
            this.student_information_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.student_information_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_information_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.student_information_btn.FlatAppearance.BorderSize = 0;
            this.student_information_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_information_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.student_information_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.student_information_btn.Location = new System.Drawing.Point(0, 120);
            this.student_information_btn.Name = "student_information_btn";
            this.student_information_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.student_information_btn.Size = new System.Drawing.Size(210, 57);
            this.student_information_btn.TabIndex = 2;
            this.student_information_btn.Text = "ویرایش اطلاعات ";
            this.student_information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.student_information_btn.UseVisualStyleBackColor = false;
            this.student_information_btn.Click += new System.EventHandler(this.student_information_btn_Click);
            // 
            // ShowSemesters_btn
            // 
            this.ShowSemesters_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ShowSemesters_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowSemesters_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ShowSemesters_btn.FlatAppearance.BorderSize = 0;
            this.ShowSemesters_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowSemesters_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowSemesters_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.ShowSemesters_btn.Location = new System.Drawing.Point(0, 0);
            this.ShowSemesters_btn.Name = "ShowSemesters_btn";
            this.ShowSemesters_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ShowSemesters_btn.Size = new System.Drawing.Size(210, 60);
            this.ShowSemesters_btn.TabIndex = 0;
            this.ShowSemesters_btn.Text = "لیست ترم ها";
            this.ShowSemesters_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowSemesters_btn.UseVisualStyleBackColor = false;
            this.ShowSemesters_btn.Click += new System.EventHandler(this.ShowSemesters_btn_Click);
            // 
            // Golestan_lbl
            // 
            this.Golestan_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Golestan_lbl.AutoSize = true;
            this.Golestan_lbl.Font = new System.Drawing.Font("Dubai", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Golestan_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Golestan_lbl.Location = new System.Drawing.Point(93, 0);
            this.Golestan_lbl.Name = "Golestan_lbl";
            this.Golestan_lbl.Size = new System.Drawing.Size(239, 113);
            this.Golestan_lbl.TabIndex = 2;
            this.Golestan_lbl.Text = "گلستان";
            // 
            // display_panel
            // 
            this.display_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.display_panel.Location = new System.Drawing.Point(0, 144);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(817, 525);
            this.display_panel.TabIndex = 4;
            // 
            // title_panel
            // 
            this.title_panel.Controls.Add(this.Golestan_lbl);
            this.title_panel.Location = new System.Drawing.Point(230, 12);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(421, 126);
            this.title_panel.TabIndex = 5;
            // 
            // enroll_btn
            // 
            this.enroll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.enroll_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.enroll_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.enroll_btn.FlatAppearance.BorderSize = 0;
            this.enroll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enroll_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.enroll_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.enroll_btn.Location = new System.Drawing.Point(0, 60);
            this.enroll_btn.Name = "enroll_btn";
            this.enroll_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.enroll_btn.Size = new System.Drawing.Size(210, 60);
            this.enroll_btn.TabIndex = 1;
            this.enroll_btn.Text = "ثبت نام";
            this.enroll_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enroll_btn.UseVisualStyleBackColor = false;
            this.enroll_btn.Click += new System.EventHandler(this.enroll_btn_Click_1);
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1027, 669);
            this.Controls.Add(this.title_panel);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.side_panel);
            this.Name = "Student_Form";
            this.Text = "Student_Form";
            this.Load += new System.EventHandler(this.Student_Form_Load);
            this.side_panel.ResumeLayout(false);
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button student_information_btn;
        private System.Windows.Forms.Button ShowSemesters_btn;
        private System.Windows.Forms.Label Golestan_lbl;
        private System.Windows.Forms.Panel display_panel;
        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button enroll_btn;
    }
}