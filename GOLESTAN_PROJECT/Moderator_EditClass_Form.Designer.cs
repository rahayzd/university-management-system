namespace GOLESTAN_PROJECT
{
    partial class Moderator_EditClass_Form
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
            this.editclass_btn = new System.Windows.Forms.Button();
            this.classfield_combo = new System.Windows.Forms.ComboBox();
            this.classfield_lbl = new System.Windows.Forms.Label();
            this.classId_tbox = new System.Windows.Forms.TextBox();
            this.classId_lbl = new System.Windows.Forms.Label();
            this.classname_tbox = new System.Windows.Forms.TextBox();
            this.Class_name_lbl = new System.Windows.Forms.Label();
            this.errorProvider_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.credits_numUD = new System.Windows.Forms.NumericUpDown();
            this.credits_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // editclass_btn
            // 
            this.editclass_btn.AutoSize = true;
            this.editclass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editclass_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editclass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.editclass_btn.Location = new System.Drawing.Point(527, 341);
            this.editclass_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editclass_btn.Name = "editclass_btn";
            this.editclass_btn.Size = new System.Drawing.Size(154, 66);
            this.editclass_btn.TabIndex = 35;
            this.editclass_btn.Text = "ویرایش کلاس";
            this.editclass_btn.UseVisualStyleBackColor = true;
            this.editclass_btn.Click += new System.EventHandler(this.editclass_btn_Click);
            // 
            // classfield_combo
            // 
            this.classfield_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classfield_combo.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classfield_combo.FormattingEnabled = true;
            this.classfield_combo.ItemHeight = 25;
            this.classfield_combo.Location = new System.Drawing.Point(188, 243);
            this.classfield_combo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classfield_combo.Name = "classfield_combo";
            this.classfield_combo.Size = new System.Drawing.Size(191, 33);
            this.classfield_combo.TabIndex = 34;
            // 
            // classfield_lbl
            // 
            this.classfield_lbl.AutoSize = true;
            this.classfield_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.classfield_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.classfield_lbl.Location = new System.Drawing.Point(76, 247);
            this.classfield_lbl.Name = "classfield_lbl";
            this.classfield_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classfield_lbl.Size = new System.Drawing.Size(90, 29);
            this.classfield_lbl.TabIndex = 33;
            this.classfield_lbl.Text = "رشته درس";
            // 
            // classId_tbox
            // 
            this.classId_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classId_tbox.Location = new System.Drawing.Point(188, 150);
            this.classId_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classId_tbox.MaxLength = 20;
            this.classId_tbox.Name = "classId_tbox";
            this.classId_tbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classId_tbox.Size = new System.Drawing.Size(191, 33);
            this.classId_tbox.TabIndex = 32;
            // 
            // classId_lbl
            // 
            this.classId_lbl.AutoSize = true;
            this.classId_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.classId_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.classId_lbl.Location = new System.Drawing.Point(76, 154);
            this.classId_lbl.Name = "classId_lbl";
            this.classId_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classId_lbl.Size = new System.Drawing.Size(73, 29);
            this.classId_lbl.TabIndex = 31;
            this.classId_lbl.Text = "کد کلاس";
            // 
            // classname_tbox
            // 
            this.classname_tbox.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classname_tbox.Location = new System.Drawing.Point(188, 67);
            this.classname_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classname_tbox.MaxLength = 20;
            this.classname_tbox.Name = "classname_tbox";
            this.classname_tbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classname_tbox.Size = new System.Drawing.Size(191, 33);
            this.classname_tbox.TabIndex = 30;
            // 
            // Class_name_lbl
            // 
            this.Class_name_lbl.AutoSize = true;
            this.Class_name_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Class_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Class_name_lbl.Location = new System.Drawing.Point(76, 71);
            this.Class_name_lbl.Name = "Class_name_lbl";
            this.Class_name_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Class_name_lbl.Size = new System.Drawing.Size(95, 29);
            this.Class_name_lbl.TabIndex = 29;
            this.Class_name_lbl.Text = "عنوان درس";
            // 
            // errorProvider_ID
            // 
            this.errorProvider_ID.ContainerControl = this;
            // 
            // errorProvider_Name
            // 
            this.errorProvider_Name.ContainerControl = this;
            // 
            // credits_numUD
            // 
            this.credits_numUD.Font = new System.Drawing.Font("Dubai Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits_numUD.Location = new System.Drawing.Point(188, 323);
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
            this.credits_numUD.TabIndex = 37;
            this.credits_numUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // credits_lbl
            // 
            this.credits_lbl.AutoSize = true;
            this.credits_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.credits_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.credits_lbl.Location = new System.Drawing.Point(76, 323);
            this.credits_lbl.Name = "credits_lbl";
            this.credits_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.credits_lbl.Size = new System.Drawing.Size(91, 29);
            this.credits_lbl.TabIndex = 36;
            this.credits_lbl.Text = "تعداد واحد";
            // 
            // Moderator_EditClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.credits_numUD);
            this.Controls.Add(this.credits_lbl);
            this.Controls.Add(this.editclass_btn);
            this.Controls.Add(this.classfield_combo);
            this.Controls.Add(this.classfield_lbl);
            this.Controls.Add(this.classId_tbox);
            this.Controls.Add(this.classId_lbl);
            this.Controls.Add(this.classname_tbox);
            this.Controls.Add(this.Class_name_lbl);
            this.Name = "Moderator_EditClass_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Moderator_EditClass_Form";
            this.Load += new System.EventHandler(this.Moderator_EditClass_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editclass_btn;
        private System.Windows.Forms.ComboBox classfield_combo;
        private System.Windows.Forms.Label classfield_lbl;
        private System.Windows.Forms.TextBox classId_tbox;
        private System.Windows.Forms.Label classId_lbl;
        private System.Windows.Forms.TextBox classname_tbox;
        private System.Windows.Forms.Label Class_name_lbl;
        private System.Windows.Forms.ErrorProvider errorProvider_ID;
        private System.Windows.Forms.ErrorProvider errorProvider_Name;
        private System.Windows.Forms.NumericUpDown credits_numUD;
        private System.Windows.Forms.Label credits_lbl;
    }
}