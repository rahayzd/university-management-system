namespace GOLESTAN_PROJECT
{
    partial class Moderator_Define_Semester
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
            this.Term_lbl = new System.Windows.Forms.Label();
            this.SemesterYear_lbl = new System.Windows.Forms.Label();
            this.Semester_FirstDay_DT = new System.Windows.Forms.DateTimePicker();
            this.semester_year_nUD = new System.Windows.Forms.NumericUpDown();
            this.semester_term_nUD = new System.Windows.Forms.NumericUpDown();
            this.Semester_RegFirtsDay_DT = new System.Windows.Forms.DateTimePicker();
            this.Semester_LastDay_DT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Semester_FirstDay_lbl = new System.Windows.Forms.Label();
            this.Semester_RegLastDay_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Semester_RegLastDay_DT = new System.Windows.Forms.DateTimePicker();
            this.Semester_RegFirtsDay_lbl = new System.Windows.Forms.Label();
            this.Add_semester_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.semester_year_nUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semester_term_nUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Term_lbl
            // 
            this.Term_lbl.AutoSize = true;
            this.Term_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Term_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Term_lbl.Location = new System.Drawing.Point(33, 122);
            this.Term_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Term_lbl.Name = "Term_lbl";
            this.Term_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Term_lbl.Size = new System.Drawing.Size(132, 29);
            this.Term_lbl.TabIndex = 27;
            this.Term_lbl.Text = "نیمسال تحصیلی";
            // 
            // SemesterYear_lbl
            // 
            this.SemesterYear_lbl.AutoSize = true;
            this.SemesterYear_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SemesterYear_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.SemesterYear_lbl.Location = new System.Drawing.Point(33, 52);
            this.SemesterYear_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SemesterYear_lbl.Name = "SemesterYear_lbl";
            this.SemesterYear_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SemesterYear_lbl.Size = new System.Drawing.Size(45, 29);
            this.SemesterYear_lbl.TabIndex = 25;
            this.SemesterYear_lbl.Text = "سال";
            // 
            // Semester_FirstDay_DT
            // 
            this.Semester_FirstDay_DT.Location = new System.Drawing.Point(563, 62);
            this.Semester_FirstDay_DT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Semester_FirstDay_DT.Name = "Semester_FirstDay_DT";
            this.Semester_FirstDay_DT.Size = new System.Drawing.Size(200, 29);
            this.Semester_FirstDay_DT.TabIndex = 31;
            // 
            // semester_year_nUD
            // 
            this.semester_year_nUD.Location = new System.Drawing.Point(173, 62);
            this.semester_year_nUD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.semester_year_nUD.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.semester_year_nUD.Minimum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.semester_year_nUD.Name = "semester_year_nUD";
            this.semester_year_nUD.Size = new System.Drawing.Size(170, 29);
            this.semester_year_nUD.TabIndex = 32;
            this.semester_year_nUD.Value = new decimal(new int[] {
            1401,
            0,
            0,
            0});
            // 
            // semester_term_nUD
            // 
            this.semester_term_nUD.Location = new System.Drawing.Point(173, 122);
            this.semester_term_nUD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.semester_term_nUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.semester_term_nUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.semester_term_nUD.Name = "semester_term_nUD";
            this.semester_term_nUD.Size = new System.Drawing.Size(170, 29);
            this.semester_term_nUD.TabIndex = 33;
            this.semester_term_nUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Semester_RegFirtsDay_DT
            // 
            this.Semester_RegFirtsDay_DT.Location = new System.Drawing.Point(563, 200);
            this.Semester_RegFirtsDay_DT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Semester_RegFirtsDay_DT.Name = "Semester_RegFirtsDay_DT";
            this.Semester_RegFirtsDay_DT.Size = new System.Drawing.Size(200, 29);
            this.Semester_RegFirtsDay_DT.TabIndex = 34;
            // 
            // Semester_LastDay_DT
            // 
            this.Semester_LastDay_DT.Location = new System.Drawing.Point(563, 122);
            this.Semester_LastDay_DT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Semester_LastDay_DT.Name = "Semester_LastDay_DT";
            this.Semester_LastDay_DT.Size = new System.Drawing.Size(200, 29);
            this.Semester_LastDay_DT.TabIndex = 35;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(563, 266);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker4.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(405, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "پایان ترم";
            // 
            // Semester_FirstDay_lbl
            // 
            this.Semester_FirstDay_lbl.AutoSize = true;
            this.Semester_FirstDay_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Semester_FirstDay_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Semester_FirstDay_lbl.Location = new System.Drawing.Point(405, 52);
            this.Semester_FirstDay_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semester_FirstDay_lbl.Name = "Semester_FirstDay_lbl";
            this.Semester_FirstDay_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Semester_FirstDay_lbl.Size = new System.Drawing.Size(80, 29);
            this.Semester_FirstDay_lbl.TabIndex = 37;
            this.Semester_FirstDay_lbl.Text = "شروع ترم";
            // 
            // Semester_RegLastDay_lbl
            // 
            this.Semester_RegLastDay_lbl.AutoSize = true;
            this.Semester_RegLastDay_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Semester_RegLastDay_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Semester_RegLastDay_lbl.Location = new System.Drawing.Point(405, 266);
            this.Semester_RegLastDay_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semester_RegLastDay_lbl.Name = "Semester_RegLastDay_lbl";
            this.Semester_RegLastDay_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Semester_RegLastDay_lbl.Size = new System.Drawing.Size(106, 29);
            this.Semester_RegLastDay_lbl.TabIndex = 40;
            this.Semester_RegLastDay_lbl.Text = "پایان ثبت نام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(405, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "شروع ترم";
            // 
            // Semester_RegLastDay_DT
            // 
            this.Semester_RegLastDay_DT.Location = new System.Drawing.Point(563, 266);
            this.Semester_RegLastDay_DT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Semester_RegLastDay_DT.Name = "Semester_RegLastDay_DT";
            this.Semester_RegLastDay_DT.Size = new System.Drawing.Size(200, 29);
            this.Semester_RegLastDay_DT.TabIndex = 36;
            // 
            // Semester_RegFirtsDay_lbl
            // 
            this.Semester_RegFirtsDay_lbl.AutoSize = true;
            this.Semester_RegFirtsDay_lbl.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Semester_RegFirtsDay_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Semester_RegFirtsDay_lbl.Location = new System.Drawing.Point(405, 201);
            this.Semester_RegFirtsDay_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semester_RegFirtsDay_lbl.Name = "Semester_RegFirtsDay_lbl";
            this.Semester_RegFirtsDay_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Semester_RegFirtsDay_lbl.Size = new System.Drawing.Size(99, 29);
            this.Semester_RegFirtsDay_lbl.TabIndex = 39;
            this.Semester_RegFirtsDay_lbl.Text = "آغاز ثبت نام";
            // 
            // Add_semester_btn
            // 
            this.Add_semester_btn.AutoSize = true;
            this.Add_semester_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_semester_btn.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Add_semester_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.Add_semester_btn.Location = new System.Drawing.Point(38, 383);
            this.Add_semester_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_semester_btn.Name = "Add_semester_btn";
            this.Add_semester_btn.Size = new System.Drawing.Size(150, 60);
            this.Add_semester_btn.TabIndex = 41;
            this.Add_semester_btn.Text = "افزودن ترم";
            this.Add_semester_btn.UseVisualStyleBackColor = true;
            this.Add_semester_btn.Click += new System.EventHandler(this.Add_semester_btn_Click);
            // 
            // Moderator_Define_Semester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.Add_semester_btn);
            this.Controls.Add(this.Semester_RegLastDay_lbl);
            this.Controls.Add(this.Semester_RegFirtsDay_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Semester_FirstDay_lbl);
            this.Controls.Add(this.Semester_RegLastDay_DT);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.Semester_LastDay_DT);
            this.Controls.Add(this.Semester_RegFirtsDay_DT);
            this.Controls.Add(this.semester_term_nUD);
            this.Controls.Add(this.semester_year_nUD);
            this.Controls.Add(this.Semester_FirstDay_DT);
            this.Controls.Add(this.Term_lbl);
            this.Controls.Add(this.SemesterYear_lbl);
            this.Font = new System.Drawing.Font("Dubai Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Moderator_Define_Semester";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Moderator_Define_Semester";
            this.Load += new System.EventHandler(this.Moderator_Define_Semester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semester_year_nUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semester_term_nUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Term_lbl;
        private System.Windows.Forms.Label SemesterYear_lbl;
        private System.Windows.Forms.DateTimePicker Semester_FirstDay_DT;
        private System.Windows.Forms.NumericUpDown semester_year_nUD;
        private System.Windows.Forms.NumericUpDown semester_term_nUD;
        private System.Windows.Forms.DateTimePicker Semester_RegFirtsDay_DT;
        private System.Windows.Forms.DateTimePicker Semester_LastDay_DT;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Semester_FirstDay_lbl;
        private System.Windows.Forms.Label Semester_RegLastDay_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Semester_RegLastDay_DT;
        private System.Windows.Forms.Label Semester_RegFirtsDay_lbl;
        private System.Windows.Forms.Button Add_semester_btn;
    }
}