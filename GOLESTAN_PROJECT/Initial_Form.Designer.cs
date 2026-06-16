namespace GOLESTAN_PROJECT
{
    partial class Initial_Form
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
            this.Title_panel = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.signup_subpanel = new System.Windows.Forms.Panel();
            this.signupAs_moderator = new System.Windows.Forms.Button();
            this.signupAs_professor = new System.Windows.Forms.Button();
            this.signupAs_student = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.login_subpanel = new System.Windows.Forms.Panel();
            this.loginAs_moderator = new System.Windows.Forms.Button();
            this.loginAs_professor = new System.Windows.Forms.Button();
            this.loginAs_student = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.display_panel = new System.Windows.Forms.Panel();
            this.Title_panel.SuspendLayout();
            this.side_panel.SuspendLayout();
            this.signup_subpanel.SuspendLayout();
            this.login_subpanel.SuspendLayout();
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
            this.Golestan_lbl.Location = new System.Drawing.Point(141, 9);
            this.Golestan_lbl.Name = "Golestan_lbl";
            this.Golestan_lbl.Size = new System.Drawing.Size(239, 113);
            this.Golestan_lbl.TabIndex = 0;
            this.Golestan_lbl.Text = "گلستان";
            // 
            // Title_panel
            // 
            this.Title_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_panel.Controls.Add(this.Golestan_lbl);
            this.Title_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.Title_panel.Location = new System.Drawing.Point(105, 0);
            this.Title_panel.Name = "Title_panel";
            this.Title_panel.Size = new System.Drawing.Size(416, 115);
            this.Title_panel.TabIndex = 0;
            // 
            // side_panel
            // 
            this.side_panel.AutoScroll = true;
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.side_panel.Controls.Add(this.exit_btn);
            this.side_panel.Controls.Add(this.signup_subpanel);
            this.side_panel.Controls.Add(this.signup_btn);
            this.side_panel.Controls.Add(this.login_subpanel);
            this.side_panel.Controls.Add(this.login_btn);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.side_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(62)))), ((int)(((byte)(133)))));
            this.side_panel.Location = new System.Drawing.Point(651, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.side_panel.Size = new System.Drawing.Size(210, 615);
            this.side_panel.TabIndex = 1;
            this.side_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.side_panel_Paint);
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
            this.exit_btn.Location = new System.Drawing.Point(0, 360);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.exit_btn.Size = new System.Drawing.Size(210, 57);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "خروج";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // signup_subpanel
            // 
            this.signup_subpanel.BackColor = System.Drawing.Color.Transparent;
            this.signup_subpanel.Controls.Add(this.signupAs_moderator);
            this.signup_subpanel.Controls.Add(this.signupAs_professor);
            this.signup_subpanel.Controls.Add(this.signupAs_student);
            this.signup_subpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.signup_subpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.signup_subpanel.Location = new System.Drawing.Point(0, 240);
            this.signup_subpanel.Name = "signup_subpanel";
            this.signup_subpanel.Size = new System.Drawing.Size(210, 120);
            this.signup_subpanel.TabIndex = 3;
            this.signup_subpanel.Visible = false;
            // 
            // signupAs_moderator
            // 
            this.signupAs_moderator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.signupAs_moderator.Dock = System.Windows.Forms.DockStyle.Top;
            this.signupAs_moderator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.signupAs_moderator.FlatAppearance.BorderSize = 0;
            this.signupAs_moderator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupAs_moderator.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.signupAs_moderator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.signupAs_moderator.Location = new System.Drawing.Point(0, 80);
            this.signupAs_moderator.Name = "signupAs_moderator";
            this.signupAs_moderator.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.signupAs_moderator.Size = new System.Drawing.Size(210, 40);
            this.signupAs_moderator.TabIndex = 2;
            this.signupAs_moderator.Text = "کارمند";
            this.signupAs_moderator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signupAs_moderator.UseVisualStyleBackColor = false;
            this.signupAs_moderator.Click += new System.EventHandler(this.signupAs_moderator_Click);
            // 
            // signupAs_professor
            // 
            this.signupAs_professor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.signupAs_professor.Dock = System.Windows.Forms.DockStyle.Top;
            this.signupAs_professor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.signupAs_professor.FlatAppearance.BorderSize = 0;
            this.signupAs_professor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupAs_professor.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.signupAs_professor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.signupAs_professor.Location = new System.Drawing.Point(0, 40);
            this.signupAs_professor.Name = "signupAs_professor";
            this.signupAs_professor.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.signupAs_professor.Size = new System.Drawing.Size(210, 40);
            this.signupAs_professor.TabIndex = 1;
            this.signupAs_professor.Text = "استاد";
            this.signupAs_professor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signupAs_professor.UseVisualStyleBackColor = false;
            this.signupAs_professor.Click += new System.EventHandler(this.signupAs_professor_Click);
            // 
            // signupAs_student
            // 
            this.signupAs_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.signupAs_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.signupAs_student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.signupAs_student.FlatAppearance.BorderSize = 0;
            this.signupAs_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupAs_student.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.signupAs_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.signupAs_student.Location = new System.Drawing.Point(0, 0);
            this.signupAs_student.Name = "signupAs_student";
            this.signupAs_student.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.signupAs_student.Size = new System.Drawing.Size(210, 40);
            this.signupAs_student.TabIndex = 0;
            this.signupAs_student.Text = "دانشجو";
            this.signupAs_student.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signupAs_student.UseVisualStyleBackColor = false;
            this.signupAs_student.Click += new System.EventHandler(this.signupAs_student_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.signup_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.signup_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.signup_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.signup_btn.Location = new System.Drawing.Point(0, 180);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.signup_btn.Size = new System.Drawing.Size(210, 60);
            this.signup_btn.TabIndex = 1;
            this.signup_btn.Text = "ثبت نام";
            this.signup_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // login_subpanel
            // 
            this.login_subpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.login_subpanel.Controls.Add(this.loginAs_moderator);
            this.login_subpanel.Controls.Add(this.loginAs_professor);
            this.login_subpanel.Controls.Add(this.loginAs_student);
            this.login_subpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_subpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.login_subpanel.Location = new System.Drawing.Point(0, 60);
            this.login_subpanel.Name = "login_subpanel";
            this.login_subpanel.Size = new System.Drawing.Size(210, 120);
            this.login_subpanel.TabIndex = 4;
            this.login_subpanel.Visible = false;
            // 
            // loginAs_moderator
            // 
            this.loginAs_moderator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.loginAs_moderator.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginAs_moderator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loginAs_moderator.FlatAppearance.BorderSize = 0;
            this.loginAs_moderator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginAs_moderator.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loginAs_moderator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.loginAs_moderator.Location = new System.Drawing.Point(0, 80);
            this.loginAs_moderator.Name = "loginAs_moderator";
            this.loginAs_moderator.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.loginAs_moderator.Size = new System.Drawing.Size(210, 40);
            this.loginAs_moderator.TabIndex = 2;
            this.loginAs_moderator.Text = "کارمند";
            this.loginAs_moderator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginAs_moderator.UseVisualStyleBackColor = false;
            this.loginAs_moderator.Click += new System.EventHandler(this.loginAs_moderator_Click);
            // 
            // loginAs_professor
            // 
            this.loginAs_professor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.loginAs_professor.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginAs_professor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loginAs_professor.FlatAppearance.BorderSize = 0;
            this.loginAs_professor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginAs_professor.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loginAs_professor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.loginAs_professor.Location = new System.Drawing.Point(0, 40);
            this.loginAs_professor.Name = "loginAs_professor";
            this.loginAs_professor.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.loginAs_professor.Size = new System.Drawing.Size(210, 40);
            this.loginAs_professor.TabIndex = 1;
            this.loginAs_professor.Text = "استاد";
            this.loginAs_professor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginAs_professor.UseVisualStyleBackColor = false;
            this.loginAs_professor.Click += new System.EventHandler(this.loginAs_professor_Click);
            // 
            // loginAs_student
            // 
            this.loginAs_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.loginAs_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginAs_student.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loginAs_student.FlatAppearance.BorderSize = 0;
            this.loginAs_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginAs_student.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loginAs_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.loginAs_student.Location = new System.Drawing.Point(0, 0);
            this.loginAs_student.Name = "loginAs_student";
            this.loginAs_student.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.loginAs_student.Size = new System.Drawing.Size(210, 40);
            this.loginAs_student.TabIndex = 0;
            this.loginAs_student.Text = "دانشجو";
            this.loginAs_student.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginAs_student.UseVisualStyleBackColor = false;
            this.loginAs_student.Click += new System.EventHandler(this.loginAs_student_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.login_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Dubai Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.login_btn.Location = new System.Drawing.Point(0, 0);
            this.login_btn.Name = "login_btn";
            this.login_btn.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.login_btn.Size = new System.Drawing.Size(210, 60);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "ورود";
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // display_panel
            // 
            this.display_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.display_panel.ForeColor = System.Drawing.Color.White;
            this.display_panel.Location = new System.Drawing.Point(0, 115);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(651, 500);
            this.display_panel.TabIndex = 2;
            // 
            // Initial_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 574);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.Title_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.MinimizeBox = false;
            this.Name = "Initial_Form";
            this.Text = "صفحه ورود";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Initial_Form_FormClosing);
            this.Load += new System.EventHandler(this.Initial_Form_Load);
            this.Title_panel.ResumeLayout(false);
            this.Title_panel.PerformLayout();
            this.side_panel.ResumeLayout(false);
            this.signup_subpanel.ResumeLayout(false);
            this.login_subpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Golestan_lbl;
        private System.Windows.Forms.Panel Title_panel;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel signup_subpanel;
        private System.Windows.Forms.Button loginAs_moderator;
        private System.Windows.Forms.Button loginAs_professor;
        private System.Windows.Forms.Button loginAs_student;
        private System.Windows.Forms.Panel login_subpanel;
        private System.Windows.Forms.Button signupAs_moderator;
        private System.Windows.Forms.Button signupAs_professor;
        private System.Windows.Forms.Button signupAs_student;
        private System.Windows.Forms.Panel display_panel;
    }
}

