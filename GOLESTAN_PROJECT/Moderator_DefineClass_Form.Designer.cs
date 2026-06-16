namespace GOLESTAN_PROJECT
{
    partial class Moderator_DefineClass_Form
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
            this.classname_tbox = new System.Windows.Forms.TextBox();
            this.Class_name_lbl = new System.Windows.Forms.Label();
            this.classId_tbox = new System.Windows.Forms.TextBox();
            this.classId_lbl = new System.Windows.Forms.Label();
            this.classfield_lbl = new System.Windows.Forms.Label();
            this.RegisterClass_btn = new System.Windows.Forms.Button();
            this.classfield_combo = new System.Windows.Forms.ComboBox();
            this.Semester_display_panel = new System.Windows.Forms.Panel();
            this.classes_listView = new System.Windows.Forms.ListView();
            this.classname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateList_btn = new System.Windows.Forms.Button();
            this.form_title_lbl = new System.Windows.Forms.Label();
            this.classId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classfield = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editclass_btn = new System.Windows.Forms.Button();
            this.removeClass_btn = new System.Windows.Forms.Button();
            this.credits_lbl = new System.Windows.Forms.Label();
            this.credits_numUD = new System.Windows.Forms.NumericUpDown();
            this.classcredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester_display_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credits_numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // classname_tbox
            // 
            this.classname_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classname_tbox.Location = new System.Drawing.Point(124, 88);
            this.classname_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classname_tbox.MaxLength = 20;
            this.classname_tbox.Name = "classname_tbox";
            this.classname_tbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classname_tbox.Size = new System.Drawing.Size(191, 33);
            this.classname_tbox.TabIndex = 18;
            this.classname_tbox.Validating += new System.ComponentModel.CancelEventHandler(this.classname_tbox_Validating);
            // 
            // Class_name_lbl
            // 
            this.Class_name_lbl.AutoSize = true;
            this.Class_name_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Class_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Class_name_lbl.Location = new System.Drawing.Point(12, 92);
            this.Class_name_lbl.Name = "Class_name_lbl";
            this.Class_name_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Class_name_lbl.Size = new System.Drawing.Size(95, 29);
            this.Class_name_lbl.TabIndex = 17;
            this.Class_name_lbl.Text = "عنوان درس";
            // 
            // classId_tbox
            // 
            this.classId_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classId_tbox.Location = new System.Drawing.Point(124, 151);
            this.classId_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classId_tbox.MaxLength = 20;
            this.classId_tbox.Name = "classId_tbox";
            this.classId_tbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classId_tbox.Size = new System.Drawing.Size(191, 33);
            this.classId_tbox.TabIndex = 20;
            this.classId_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classId_tbox_KeyPress);
            // 
            // classId_lbl
            // 
            this.classId_lbl.AutoSize = true;
            this.classId_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.classId_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.classId_lbl.Location = new System.Drawing.Point(12, 155);
            this.classId_lbl.Name = "classId_lbl";
            this.classId_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classId_lbl.Size = new System.Drawing.Size(73, 29);
            this.classId_lbl.TabIndex = 19;
            this.classId_lbl.Text = "کد کلاس";
            // 
            // classfield_lbl
            // 
            this.classfield_lbl.AutoSize = true;
            this.classfield_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.classfield_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.classfield_lbl.Location = new System.Drawing.Point(12, 216);
            this.classfield_lbl.Name = "classfield_lbl";
            this.classfield_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classfield_lbl.Size = new System.Drawing.Size(90, 29);
            this.classfield_lbl.TabIndex = 21;
            this.classfield_lbl.Text = "رشته درس";
            // 
            // RegisterClass_btn
            // 
            this.RegisterClass_btn.AutoSize = true;
            this.RegisterClass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterClass_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegisterClass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.RegisterClass_btn.Location = new System.Drawing.Point(17, 335);
            this.RegisterClass_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterClass_btn.Name = "RegisterClass_btn";
            this.RegisterClass_btn.Size = new System.Drawing.Size(126, 41);
            this.RegisterClass_btn.TabIndex = 23;
            this.RegisterClass_btn.Text = "ثبت درس";
            this.RegisterClass_btn.UseVisualStyleBackColor = true;
            this.RegisterClass_btn.Click += new System.EventHandler(this.RegisterClass_btn_Click);
            // 
            // classfield_combo
            // 
            this.classfield_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classfield_combo.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classfield_combo.FormattingEnabled = true;
            this.classfield_combo.ItemHeight = 25;
            this.classfield_combo.Location = new System.Drawing.Point(124, 212);
            this.classfield_combo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classfield_combo.Name = "classfield_combo";
            this.classfield_combo.Size = new System.Drawing.Size(191, 33);
            this.classfield_combo.TabIndex = 22;
            // 
            // Semester_display_panel
            // 
            this.Semester_display_panel.Controls.Add(this.classes_listView);
            this.Semester_display_panel.Location = new System.Drawing.Point(321, 21);
            this.Semester_display_panel.Name = "Semester_display_panel";
            this.Semester_display_panel.Size = new System.Drawing.Size(549, 426);
            this.Semester_display_panel.TabIndex = 24;
            // 
            // classes_listView
            // 
            this.classes_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.classname,
            this.classId,
            this.classfield,
            this.classcredits});
            this.classes_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classes_listView.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes_listView.HideSelection = false;
            this.classes_listView.Location = new System.Drawing.Point(0, 0);
            this.classes_listView.MultiSelect = false;
            this.classes_listView.Name = "classes_listView";
            this.classes_listView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classes_listView.RightToLeftLayout = true;
            this.classes_listView.Size = new System.Drawing.Size(549, 426);
            this.classes_listView.TabIndex = 0;
            this.classes_listView.UseCompatibleStateImageBehavior = false;
            this.classes_listView.View = System.Windows.Forms.View.Details;
            // 
            // classname
            // 
            this.classname.Text = "نام درس";
            this.classname.Width = 176;
            // 
            // UpdateList_btn
            // 
            this.UpdateList_btn.AutoSize = true;
            this.UpdateList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateList_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UpdateList_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.UpdateList_btn.Location = new System.Drawing.Point(735, 474);
            this.UpdateList_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateList_btn.Name = "UpdateList_btn";
            this.UpdateList_btn.Size = new System.Drawing.Size(135, 41);
            this.UpdateList_btn.TabIndex = 27;
            this.UpdateList_btn.Text = "به روز رسانی";
            this.UpdateList_btn.UseVisualStyleBackColor = true;
            this.UpdateList_btn.Click += new System.EventHandler(this.UpdateList_btn_Click);
            // 
            // form_title_lbl
            // 
            this.form_title_lbl.AutoSize = true;
            this.form_title_lbl.Font = new System.Drawing.Font("Dubai Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.form_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.form_title_lbl.Location = new System.Drawing.Point(16, 9);
            this.form_title_lbl.Name = "form_title_lbl";
            this.form_title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.form_title_lbl.Size = new System.Drawing.Size(181, 45);
            this.form_title_lbl.TabIndex = 26;
            this.form_title_lbl.Text = "مدیریت کلاسها";
            // 
            // classId
            // 
            this.classId.Text = "کد درس";
            this.classId.Width = 114;
            // 
            // classfield
            // 
            this.classfield.Text = "رشته ";
            this.classfield.Width = 129;
            // 
            // editclass_btn
            // 
            this.editclass_btn.AutoSize = true;
            this.editclass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editclass_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editclass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.editclass_btn.Location = new System.Drawing.Point(387, 474);
            this.editclass_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editclass_btn.Name = "editclass_btn";
            this.editclass_btn.Size = new System.Drawing.Size(126, 41);
            this.editclass_btn.TabIndex = 28;
            this.editclass_btn.Text = "ویرایش کلاس";
            this.editclass_btn.UseVisualStyleBackColor = true;
            this.editclass_btn.Click += new System.EventHandler(this.editclass_btn_Click);
            // 
            // removeClass_btn
            // 
            this.removeClass_btn.AutoSize = true;
            this.removeClass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeClass_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.removeClass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.removeClass_btn.Location = new System.Drawing.Point(255, 474);
            this.removeClass_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeClass_btn.Name = "removeClass_btn";
            this.removeClass_btn.Size = new System.Drawing.Size(126, 41);
            this.removeClass_btn.TabIndex = 29;
            this.removeClass_btn.Text = "حذف کلاس";
            this.removeClass_btn.UseVisualStyleBackColor = true;
            this.removeClass_btn.Click += new System.EventHandler(this.removeClass_btn_Click);
            // 
            // credits_lbl
            // 
            this.credits_lbl.AutoSize = true;
            this.credits_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.credits_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.credits_lbl.Location = new System.Drawing.Point(12, 278);
            this.credits_lbl.Name = "credits_lbl";
            this.credits_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.credits_lbl.Size = new System.Drawing.Size(91, 29);
            this.credits_lbl.TabIndex = 30;
            this.credits_lbl.Text = "تعداد واحد";
            // 
            // credits_numUD
            // 
            this.credits_numUD.Font = new System.Drawing.Font("Dubai Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_numUD.Location = new System.Drawing.Point(124, 278);
            this.credits_numUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.credits_numUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.credits_numUD.Name = "credits_numUD";
            this.credits_numUD.Size = new System.Drawing.Size(191, 29);
            this.credits_numUD.TabIndex = 32;
            this.credits_numUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // classcredits
            // 
            this.classcredits.Text = "واحد";
            // 
            // Moderator_DefineClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.credits_numUD);
            this.Controls.Add(this.credits_lbl);
            this.Controls.Add(this.removeClass_btn);
            this.Controls.Add(this.editclass_btn);
            this.Controls.Add(this.UpdateList_btn);
            this.Controls.Add(this.form_title_lbl);
            this.Controls.Add(this.Semester_display_panel);
            this.Controls.Add(this.RegisterClass_btn);
            this.Controls.Add(this.classfield_combo);
            this.Controls.Add(this.classfield_lbl);
            this.Controls.Add(this.classId_tbox);
            this.Controls.Add(this.classId_lbl);
            this.Controls.Add(this.classname_tbox);
            this.Controls.Add(this.Class_name_lbl);
            this.Name = "Moderator_DefineClass_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Moderator_DefineClass_Form";
            this.Load += new System.EventHandler(this.Moderator_DefineClass_Form_Load);
            this.Semester_display_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.credits_numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classname_tbox;
        private System.Windows.Forms.Label Class_name_lbl;
        private System.Windows.Forms.TextBox classId_tbox;
        private System.Windows.Forms.Label classId_lbl;
        private System.Windows.Forms.Label classfield_lbl;
        private System.Windows.Forms.Button RegisterClass_btn;
        private System.Windows.Forms.ComboBox classfield_combo;
        private System.Windows.Forms.Panel Semester_display_panel;
        private System.Windows.Forms.ListView classes_listView;
        private System.Windows.Forms.ColumnHeader classname;
        private System.Windows.Forms.Button UpdateList_btn;
        private System.Windows.Forms.Label form_title_lbl;
        private System.Windows.Forms.Button editclass_btn;
        private System.Windows.Forms.ColumnHeader classId;
        private System.Windows.Forms.ColumnHeader classfield;
        private System.Windows.Forms.Button removeClass_btn;
        private System.Windows.Forms.Label credits_lbl;
        private System.Windows.Forms.NumericUpDown credits_numUD;
        private System.Windows.Forms.ColumnHeader classcredits;
    }
}