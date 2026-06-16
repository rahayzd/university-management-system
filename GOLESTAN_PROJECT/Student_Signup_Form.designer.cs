namespace Golestan_Graphic
{
    partial class add_student_Form
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.Year_lbl = new System.Windows.Forms.Label();
            this.field_lbl = new System.Windows.Forms.Label();
            this.Name_tbox = new System.Windows.Forms.TextBox();
            this.ID_tbox = new System.Windows.Forms.TextBox();
            this.field_combo = new System.Windows.Forms.ComboBox();
            this.Register = new System.Windows.Forms.Button();
            this.Year_tbox = new System.Windows.Forms.TextBox();
            this.errorProvider_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.errorProvider_Year = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Year)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.name_lbl.Location = new System.Drawing.Point(45, 36);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(33, 29);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "نام";
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.ID_lbl.Location = new System.Drawing.Point(45, 119);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(65, 29);
            this.ID_lbl.TabIndex = 1;
            this.ID_lbl.Text = "کد ملی";
            // 
            // Year_lbl
            // 
            this.Year_lbl.AutoSize = true;
            this.Year_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Year_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Year_lbl.Location = new System.Drawing.Point(45, 202);
            this.Year_lbl.Name = "Year_lbl";
            this.Year_lbl.Size = new System.Drawing.Size(96, 29);
            this.Year_lbl.TabIndex = 2;
            this.Year_lbl.Text = "سال ورودی";
            // 
            // field_lbl
            // 
            this.field_lbl.AutoSize = true;
            this.field_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.field_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.field_lbl.Location = new System.Drawing.Point(45, 285);
            this.field_lbl.Name = "field_lbl";
            this.field_lbl.Size = new System.Drawing.Size(50, 29);
            this.field_lbl.TabIndex = 3;
            this.field_lbl.Text = "رشته";
            // 
            // Name_tbox
            // 
            this.Name_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_tbox.Location = new System.Drawing.Point(215, 36);
            this.Name_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name_tbox.MaxLength = 20;
            this.Name_tbox.Name = "Name_tbox";
            this.Name_tbox.Size = new System.Drawing.Size(191, 33);
            this.Name_tbox.TabIndex = 4;
            this.Name_tbox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_tbox_Validating);
            // 
            // ID_tbox
            // 
            this.ID_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_tbox.Location = new System.Drawing.Point(215, 119);
            this.ID_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ID_tbox.MaxLength = 10;
            this.ID_tbox.Name = "ID_tbox";
            this.ID_tbox.Size = new System.Drawing.Size(191, 33);
            this.ID_tbox.TabIndex = 6;
            this.ID_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_tbox_KeyPress);
            this.ID_tbox.Validating += new System.ComponentModel.CancelEventHandler(this.ID_tbox_Validating);
            // 
            // field_combo
            // 
            this.field_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.field_combo.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_combo.FormattingEnabled = true;
            this.field_combo.ItemHeight = 25;
            this.field_combo.Location = new System.Drawing.Point(215, 285);
            this.field_combo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.field_combo.Name = "field_combo";
            this.field_combo.Size = new System.Drawing.Size(191, 33);
            this.field_combo.TabIndex = 7;
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Register.Location = new System.Drawing.Point(450, 350);
            this.Register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(160, 70);
            this.Register.TabIndex = 8;
            this.Register.Text = "ثبت نام";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Year_tbox
            // 
            this.Year_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_tbox.Location = new System.Drawing.Point(215, 202);
            this.Year_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Year_tbox.Name = "Year_tbox";
            this.Year_tbox.Size = new System.Drawing.Size(191, 33);
            this.Year_tbox.TabIndex = 9;
            this.Year_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Year_tbox_KeyPress);
            this.Year_tbox.Validating += new System.ComponentModel.CancelEventHandler(this.Year_tbox_Validating);
            // 
            // errorProvider_Name
            // 
            this.errorProvider_Name.ContainerControl = this;
            // 
            // errorProvider_ID
            // 
            this.errorProvider_ID.ContainerControl = this;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.password_lbl.Location = new System.Drawing.Point(45, 368);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(37, 29);
            this.password_lbl.TabIndex = 10;
            this.password_lbl.Text = "رمز";
            // 
            // password_tbox
            // 
            this.password_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tbox.Location = new System.Drawing.Point(215, 368);
            this.password_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.Size = new System.Drawing.Size(191, 33);
            this.password_tbox.TabIndex = 11;
            // 
            // errorProvider_Year
            // 
            this.errorProvider_Year.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_Year.ContainerControl = this;
            // 
            // add_student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.password_tbox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.Year_tbox);
            this.Controls.Add(this.field_combo);
            this.Controls.Add(this.ID_tbox);
            this.Controls.Add(this.Name_tbox);
            this.Controls.Add(this.field_lbl);
            this.Controls.Add(this.Year_lbl);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.name_lbl);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "add_student_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ثبت نام دانشجو";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_student_Form_FormClosed);
            this.Load += new System.EventHandler(this.add_student_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label Year_lbl;
        private System.Windows.Forms.Label field_lbl;
        private System.Windows.Forms.TextBox Name_tbox;
        private System.Windows.Forms.TextBox ID_tbox;
        private System.Windows.Forms.ComboBox field_combo;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox Year_tbox;
        private System.Windows.Forms.ErrorProvider errorProvider_Name;
        private System.Windows.Forms.ErrorProvider errorProvider_ID;
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.ErrorProvider errorProvider_Year;
    }
}

