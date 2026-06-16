namespace GOLESTAN_PROJECT
{
    partial class Edit_User_Information
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
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.ID_tbox = new System.Windows.Forms.TextBox();
            this.Name_tbox = new System.Windows.Forms.TextBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_tbox
            // 
            this.password_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tbox.Location = new System.Drawing.Point(223, 206);
            this.password_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.Size = new System.Drawing.Size(191, 33);
            this.password_tbox.TabIndex = 17;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.password_lbl.Location = new System.Drawing.Point(53, 206);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(37, 29);
            this.password_lbl.TabIndex = 16;
            this.password_lbl.Text = "رمز";
            // 
            // ID_tbox
            // 
            this.ID_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_tbox.Location = new System.Drawing.Point(223, 119);
            this.ID_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ID_tbox.MaxLength = 10;
            this.ID_tbox.Name = "ID_tbox";
            this.ID_tbox.Size = new System.Drawing.Size(191, 33);
            this.ID_tbox.TabIndex = 15;
            // 
            // Name_tbox
            // 
            this.Name_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_tbox.Location = new System.Drawing.Point(223, 36);
            this.Name_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name_tbox.MaxLength = 20;
            this.Name_tbox.Name = "Name_tbox";
            this.Name_tbox.Size = new System.Drawing.Size(191, 33);
            this.Name_tbox.TabIndex = 14;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.ID_lbl.Location = new System.Drawing.Point(53, 119);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(65, 29);
            this.ID_lbl.TabIndex = 13;
            this.ID_lbl.Text = "کد ملی";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.name_lbl.Location = new System.Drawing.Point(53, 36);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(33, 29);
            this.name_lbl.TabIndex = 12;
            this.name_lbl.Text = "نام";
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Edit.Location = new System.Drawing.Point(534, 296);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(160, 70);
            this.Edit.TabIndex = 18;
            this.Edit.Text = "ویرایش";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Edit_User_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.password_tbox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.ID_tbox);
            this.Controls.Add(this.Name_tbox);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.name_lbl);
            this.Name = "Edit_User_Information";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش اطلاعات کاربر";
            this.Load += new System.EventHandler(this.Edit_Student_Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox ID_tbox;
        private System.Windows.Forms.TextBox Name_tbox;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button Edit;
    }
}