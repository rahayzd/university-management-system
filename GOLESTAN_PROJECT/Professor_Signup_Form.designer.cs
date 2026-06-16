namespace Golestan_Graphic
{
    partial class add_professor_Form
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
            this.field_combo = new System.Windows.Forms.ComboBox();
            this.ID_tbox = new System.Windows.Forms.TextBox();
            this.Name_tbox = new System.Windows.Forms.TextBox();
            this.field_lbl = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.errorProvider_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.Register = new System.Windows.Forms.Button();
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // field_combo
            // 
            this.field_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.field_combo.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.field_combo.FormattingEnabled = true;
            this.field_combo.ItemHeight = 25;
            this.field_combo.Location = new System.Drawing.Point(215, 170);
            this.field_combo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.field_combo.Name = "field_combo";
            this.field_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.field_combo.Size = new System.Drawing.Size(170, 33);
            this.field_combo.TabIndex = 13;
            // 
            // ID_tbox
            // 
            this.ID_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ID_tbox.Location = new System.Drawing.Point(215, 100);
            this.ID_tbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ID_tbox.MaxLength = 10;
            this.ID_tbox.Name = "ID_tbox";
            this.ID_tbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_tbox.Size = new System.Drawing.Size(170, 33);
            this.ID_tbox.TabIndex = 12;
            this.ID_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_tbox_KeyPress);
            this.ID_tbox.Validating += new System.ComponentModel.CancelEventHandler(this.ID_tbox_Validating);
            // 
            // Name_tbox
            // 
            this.Name_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name_tbox.Location = new System.Drawing.Point(215, 30);
            this.Name_tbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name_tbox.MaxLength = 20;
            this.Name_tbox.Name = "Name_tbox";
            this.Name_tbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Name_tbox.Size = new System.Drawing.Size(170, 33);
            this.Name_tbox.TabIndex = 11;
            this.Name_tbox.Validating += new System.ComponentModel.CancelEventHandler(this.Name_tbox_Validating);
            // 
            // field_lbl
            // 
            this.field_lbl.AutoSize = true;
            this.field_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.field_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.field_lbl.Location = new System.Drawing.Point(45, 170);
            this.field_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.field_lbl.Name = "field_lbl";
            this.field_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.field_lbl.Size = new System.Drawing.Size(50, 29);
            this.field_lbl.TabIndex = 10;
            this.field_lbl.Text = "رشته";
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.ID_lbl.Location = new System.Drawing.Point(45, 100);
            this.ID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID_lbl.Size = new System.Drawing.Size(65, 29);
            this.ID_lbl.TabIndex = 9;
            this.ID_lbl.Text = "کد ملی";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.name_lbl.Location = new System.Drawing.Point(45, 30);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_lbl.Size = new System.Drawing.Size(33, 29);
            this.name_lbl.TabIndex = 8;
            this.name_lbl.Text = "نام";
            // 
            // errorProvider_Name
            // 
            this.errorProvider_Name.ContainerControl = this;
            // 
            // errorProvider_ID
            // 
            this.errorProvider_ID.ContainerControl = this;
            // 
            // Register
            // 
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Register.Location = new System.Drawing.Point(450, 350);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(160, 70);
            this.Register.TabIndex = 8;
            this.Register.Text = "ثبت نام";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // password_tbox
            // 
            this.password_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tbox.Location = new System.Drawing.Point(215, 240);
            this.password_tbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.Size = new System.Drawing.Size(170, 33);
            this.password_tbox.TabIndex = 16;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.password_lbl.Location = new System.Drawing.Point(45, 240);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(37, 29);
            this.password_lbl.TabIndex = 15;
            this.password_lbl.Text = "رمز";
            // 
            // add_professor_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.password_tbox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.field_combo);
            this.Controls.Add(this.ID_tbox);
            this.Controls.Add(this.Name_tbox);
            this.Controls.Add(this.field_lbl);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.name_lbl);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "add_professor_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ثبت نام استاد";
            this.Load += new System.EventHandler(this.add_professor_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox field_combo;
        private System.Windows.Forms.TextBox ID_tbox;
        private System.Windows.Forms.TextBox Name_tbox;
        private System.Windows.Forms.Label field_lbl;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.ErrorProvider errorProvider_Name;
        private System.Windows.Forms.ErrorProvider errorProvider_ID;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.Label password_lbl;
    }
}