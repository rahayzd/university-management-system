namespace GOLESTAN_PROJECT
{
    partial class Moderator_Form
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
            this.Golestan_lbl = new System.Windows.Forms.Label();
            this.side_panel = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.userlist_subpanel = new System.Windows.Forms.Panel();
            this.professorslist_btn = new System.Windows.Forms.Button();
            this.studentslist_btn = new System.Windows.Forms.Button();
            this.userlist_btn = new System.Windows.Forms.Button();
            this.reporst_btn = new System.Windows.Forms.Button();
            this.semester_manager_btn = new System.Windows.Forms.Button();
            this.add_class_btn = new System.Windows.Forms.Button();
            this.display_panel = new System.Windows.Forms.Panel();
            this.title_panel = new System.Windows.Forms.Panel();
            this.side_panel.SuspendLayout();
            this.userlist_subpanel.SuspendLayout();
            this.title_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Golestan_lbl
            // 
            this.Golestan_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Golestan_lbl.AutoSize = true;
            this.Golestan_lbl.Font = new System.Drawing.Font("Dubai", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Golestan_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Golestan_lbl.Location = new System.Drawing.Point(62, 0);
            this.Golestan_lbl.Name = "Golestan_lbl";
            this.Golestan_lbl.Size = new System.Drawing.Size(239, 113);
            this.Golestan_lbl.TabIndex = 2;
            this.Golestan_lbl.Text = "گلستان";
            // 
            // side_panel
            // 
            this.side_panel.AutoScroll = true;
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.side_panel.Controls.Add(this.exit_btn);
            this.side_panel.Controls.Add(this.userlist_subpanel);
            this.side_panel.Controls.Add(this.userlist_btn);
            this.side_panel.Controls.Add(this.reporst_btn);
            this.side_panel.Controls.Add(this.semester_manager_btn);
            this.side_panel.Controls.Add(this.add_class_btn);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.side_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(62)))), ((int)(((byte)(133)))));
            this.side_panel.Location = new System.Drawing.Point(899, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.side_panel.Size = new System.Drawing.Size(210, 732);
            this.side_panel.TabIndex = 3;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.exit_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.exit_btn.Location = new System.Drawing.Point(0, 313);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.exit_btn.Size = new System.Drawing.Size(210, 57);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "خروج";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // userlist_subpanel
            // 
            this.userlist_subpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.userlist_subpanel.Controls.Add(this.professorslist_btn);
            this.userlist_subpanel.Controls.Add(this.studentslist_btn);
            this.userlist_subpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userlist_subpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.userlist_subpanel.Location = new System.Drawing.Point(0, 234);
            this.userlist_subpanel.Name = "userlist_subpanel";
            this.userlist_subpanel.Size = new System.Drawing.Size(210, 79);
            this.userlist_subpanel.TabIndex = 5;
            this.userlist_subpanel.Visible = false;
            // 
            // professorslist_btn
            // 
            this.professorslist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.professorslist_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.professorslist_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.professorslist_btn.FlatAppearance.BorderSize = 0;
            this.professorslist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professorslist_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.professorslist_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.professorslist_btn.Location = new System.Drawing.Point(0, 40);
            this.professorslist_btn.Name = "professorslist_btn";
            this.professorslist_btn.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.professorslist_btn.Size = new System.Drawing.Size(210, 40);
            this.professorslist_btn.TabIndex = 1;
            this.professorslist_btn.Text = "استاد";
            this.professorslist_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.professorslist_btn.UseVisualStyleBackColor = false;
            this.professorslist_btn.Click += new System.EventHandler(this.professorslist_btn_Click);
            // 
            // studentslist_btn
            // 
            this.studentslist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.studentslist_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentslist_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.studentslist_btn.FlatAppearance.BorderSize = 0;
            this.studentslist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentslist_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.studentslist_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.studentslist_btn.Location = new System.Drawing.Point(0, 0);
            this.studentslist_btn.Name = "studentslist_btn";
            this.studentslist_btn.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.studentslist_btn.Size = new System.Drawing.Size(210, 40);
            this.studentslist_btn.TabIndex = 0;
            this.studentslist_btn.Text = "دانشجو";
            this.studentslist_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentslist_btn.UseVisualStyleBackColor = false;
            this.studentslist_btn.Click += new System.EventHandler(this.studentslist_btn_Click);
            // 
            // userlist_btn
            // 
            this.userlist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.userlist_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userlist_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userlist_btn.FlatAppearance.BorderSize = 0;
            this.userlist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userlist_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userlist_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.userlist_btn.Location = new System.Drawing.Point(0, 174);
            this.userlist_btn.Name = "userlist_btn";
            this.userlist_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.userlist_btn.Size = new System.Drawing.Size(210, 60);
            this.userlist_btn.TabIndex = 4;
            this.userlist_btn.Text = "لیست کاربران";
            this.userlist_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userlist_btn.UseVisualStyleBackColor = false;
            this.userlist_btn.Click += new System.EventHandler(this.userlist_btn_Click);
            // 
            // reporst_btn
            // 
            this.reporst_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reporst_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reporst_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.reporst_btn.FlatAppearance.BorderSize = 0;
            this.reporst_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reporst_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.reporst_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.reporst_btn.Location = new System.Drawing.Point(0, 114);
            this.reporst_btn.Name = "reporst_btn";
            this.reporst_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.reporst_btn.Size = new System.Drawing.Size(210, 60);
            this.reporst_btn.TabIndex = 1;
            this.reporst_btn.Text = "گزارش ها";
            this.reporst_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reporst_btn.UseVisualStyleBackColor = false;
            // 
            // semester_manager_btn
            // 
            this.semester_manager_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.semester_manager_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.semester_manager_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.semester_manager_btn.FlatAppearance.BorderSize = 0;
            this.semester_manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.semester_manager_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.semester_manager_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.semester_manager_btn.Location = new System.Drawing.Point(0, 60);
            this.semester_manager_btn.Name = "semester_manager_btn";
            this.semester_manager_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.semester_manager_btn.Size = new System.Drawing.Size(210, 54);
            this.semester_manager_btn.TabIndex = 3;
            this.semester_manager_btn.Text = "ترم ها";
            this.semester_manager_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.semester_manager_btn.UseVisualStyleBackColor = false;
            this.semester_manager_btn.Click += new System.EventHandler(this.semester_manager_btn_Click);
            // 
            // add_class_btn
            // 
            this.add_class_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.add_class_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_class_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.add_class_btn.FlatAppearance.BorderSize = 0;
            this.add_class_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_class_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.add_class_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.add_class_btn.Location = new System.Drawing.Point(0, 0);
            this.add_class_btn.Name = "add_class_btn";
            this.add_class_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.add_class_btn.Size = new System.Drawing.Size(210, 60);
            this.add_class_btn.TabIndex = 0;
            this.add_class_btn.Text = "کلاس ها";
            this.add_class_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_class_btn.UseVisualStyleBackColor = false;
            this.add_class_btn.Click += new System.EventHandler(this.add_class_btn_Click);
            // 
            // display_panel
            // 
            this.display_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.display_panel.Location = new System.Drawing.Point(0, 132);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(899, 600);
            this.display_panel.TabIndex = 4;
            // 
            // title_panel
            // 
            this.title_panel.Controls.Add(this.Golestan_lbl);
            this.title_panel.Location = new System.Drawing.Point(267, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(364, 126);
            this.title_panel.TabIndex = 5;
            // 
            // Moderator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1109, 732);
            this.Controls.Add(this.title_panel);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.side_panel);
            this.Name = "Moderator_Form";
            this.Text = "Moderator_Form";
            this.side_panel.ResumeLayout(false);
            this.userlist_subpanel.ResumeLayout(false);
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Golestan_lbl;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button reporst_btn;
        private System.Windows.Forms.Button semester_manager_btn;
        private System.Windows.Forms.Button add_class_btn;
        private System.Windows.Forms.Panel display_panel;
        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Button userlist_btn;
        private System.Windows.Forms.Panel userlist_subpanel;
        private System.Windows.Forms.Button professorslist_btn;
        private System.Windows.Forms.Button studentslist_btn;
    }
}