namespace GOLESTAN_PROJECT
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.ID_tbox = new System.Windows.Forms.TextBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider_ID
            // 
            this.errorProvider_ID.ContainerControl = this;
            // 
            // password_tbox
            // 
            this.password_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tbox.Location = new System.Drawing.Point(215, 223);
            this.password_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password_tbox.Size = new System.Drawing.Size(191, 33);
            this.password_tbox.TabIndex = 15;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.password_lbl.Location = new System.Drawing.Point(45, 223);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password_lbl.Size = new System.Drawing.Size(37, 29);
            this.password_lbl.TabIndex = 14;
            this.password_lbl.Text = "رمز";
            // 
            // ID_tbox
            // 
            this.ID_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_tbox.Location = new System.Drawing.Point(215, 112);
            this.ID_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ID_tbox.MaxLength = 10;
            this.ID_tbox.Name = "ID_tbox";
            this.ID_tbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_tbox.Size = new System.Drawing.Size(191, 33);
            this.ID_tbox.TabIndex = 13;
            this.ID_tbox.Validating += new System.ComponentModel.CancelEventHandler(this.ID_tbox_Validating);
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.ID_lbl.Location = new System.Drawing.Point(45, 112);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lbl.Size = new System.Drawing.Size(65, 29);
            this.ID_lbl.TabIndex = 12;
            this.ID_lbl.Text = "کد ملی";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.login.Location = new System.Drawing.Point(461, 322);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(160, 70);
            this.login.TabIndex = 16;
            this.login.Text = "ورود";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password_tbox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.ID_tbox);
            this.Controls.Add(this.ID_lbl);
            this.Name = "Login_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Student_Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox ID_tbox;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.ErrorProvider errorProvider_ID;
        private System.Windows.Forms.Button login;
    }
}