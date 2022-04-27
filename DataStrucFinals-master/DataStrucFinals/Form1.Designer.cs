namespace DataStrucFinals
{
    partial class Form1
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
            this.MyListView = new System.Windows.Forms.ListView();
            this.IDVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Add = new System.Windows.Forms.Button();
            this.AddTo = new System.Windows.Forms.GroupBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtIdNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textUpdateNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textUpdateCourse = new System.Windows.Forms.TextBox();
            this.textUpdateBirth = new System.Windows.Forms.TextBox();
            this.textUpdateName = new System.Windows.Forms.TextBox();
            this.textUpdateYear = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textUpdateID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddTo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyListView
            // 
            this.MyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDVar,
            this.NameVar,
            this.BirthVar,
            this.YearVar,
            this.CourseVar,
            this.columnHeader1});
            this.MyListView.FullRowSelect = true;
            this.MyListView.GridLines = true;
            this.MyListView.HideSelection = false;
            this.MyListView.Location = new System.Drawing.Point(7, 86);
            this.MyListView.Name = "MyListView";
            this.MyListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyListView.Size = new System.Drawing.Size(810, 242);
            this.MyListView.TabIndex = 0;
            this.MyListView.UseCompatibleStateImageBehavior = false;
            this.MyListView.View = System.Windows.Forms.View.Details;
            this.MyListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IDVar
            // 
            this.IDVar.Text = "No.";
            // 
            // NameVar
            // 
            this.NameVar.Text = "ID No.";
            this.NameVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BirthVar
            // 
            this.BirthVar.Text = "Name";
            this.BirthVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BirthVar.Width = 122;
            // 
            // YearVar
            // 
            this.YearVar.Text = "Date of Birth";
            this.YearVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CourseVar
            // 
            this.CourseVar.Text = "Year";
            this.CourseVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CourseVar.Width = 119;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(247, 134);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddTo
            // 
            this.AddTo.Controls.Add(this.txtCourse);
            this.AddTo.Controls.Add(this.txtBirth);
            this.AddTo.Controls.Add(this.txtName);
            this.AddTo.Controls.Add(this.txtYear);
            this.AddTo.Controls.Add(this.Add);
            this.AddTo.Controls.Add(this.txtIdNo);
            this.AddTo.Controls.Add(this.label5);
            this.AddTo.Controls.Add(this.label4);
            this.AddTo.Controls.Add(this.label3);
            this.AddTo.Controls.Add(this.label2);
            this.AddTo.Controls.Add(this.label1);
            this.AddTo.Location = new System.Drawing.Point(7, 334);
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(410, 178);
            this.AddTo.TabIndex = 15;
            this.AddTo.TabStop = false;
            this.AddTo.Text = "Add  To List";
            this.AddTo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(178, 80);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 9;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(36, 119);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(100, 20);
            this.txtBirth.TabIndex = 8;
            this.txtBirth.TextChanged += new System.EventHandler(this.txtBirth_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(36, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(178, 46);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 6;
            // 
            // txtIdNo
            // 
            this.txtIdNo.Location = new System.Drawing.Point(36, 46);
            this.txtIdNo.Name = "txtIdNo";
            this.txtIdNo.Size = new System.Drawing.Size(100, 20);
            this.txtIdNo.TabIndex = 5;
            this.txtIdNo.TextChanged += new System.EventHandler(this.txtIdNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course/Program";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID No.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textUpdateNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.textUpdateCourse);
            this.groupBox1.Controls.Add(this.textUpdateBirth);
            this.groupBox1.Controls.Add(this.textUpdateName);
            this.groupBox1.Controls.Add(this.textUpdateYear);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.textUpdateID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(423, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 180);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add  To List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // textUpdateNo
            // 
            this.textUpdateNo.Location = new System.Drawing.Point(37, 41);
            this.textUpdateNo.Name = "textUpdateNo";
            this.textUpdateNo.Size = new System.Drawing.Size(100, 20);
            this.textUpdateNo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "No.";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textUpdateCourse
            // 
            this.textUpdateCourse.Location = new System.Drawing.Point(171, 114);
            this.textUpdateCourse.Name = "textUpdateCourse";
            this.textUpdateCourse.Size = new System.Drawing.Size(100, 20);
            this.textUpdateCourse.TabIndex = 9;
            // 
            // textUpdateBirth
            // 
            this.textUpdateBirth.Location = new System.Drawing.Point(171, 41);
            this.textUpdateBirth.Name = "textUpdateBirth";
            this.textUpdateBirth.Size = new System.Drawing.Size(100, 20);
            this.textUpdateBirth.TabIndex = 8;
            // 
            // textUpdateName
            // 
            this.textUpdateName.Location = new System.Drawing.Point(37, 114);
            this.textUpdateName.Name = "textUpdateName";
            this.textUpdateName.Size = new System.Drawing.Size(100, 20);
            this.textUpdateName.TabIndex = 7;
            // 
            // textUpdateYear
            // 
            this.textUpdateYear.Location = new System.Drawing.Point(171, 80);
            this.textUpdateYear.Name = "textUpdateYear";
            this.textUpdateYear.Size = new System.Drawing.Size(100, 20);
            this.textUpdateYear.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(47, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textUpdateID
            // 
            this.textUpdateID.Location = new System.Drawing.Point(37, 80);
            this.textUpdateID.Name = "textUpdateID";
            this.textUpdateID.Size = new System.Drawing.Size(100, 20);
            this.textUpdateID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Course/Program";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID No.:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 56);
            this.panel1.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(927, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(70, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "San Beda Alabang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataStrucFinals.Properties.Resources.San_Beda_College_Alabang_logo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddTo);
            this.Controls.Add(this.MyListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AddTo.ResumeLayout(false);
            this.AddTo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView MyListView;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ColumnHeader IDVar;
        private System.Windows.Forms.ColumnHeader NameVar;
        private System.Windows.Forms.ColumnHeader BirthVar;
        private System.Windows.Forms.ColumnHeader YearVar;
        private System.Windows.Forms.ColumnHeader CourseVar;
        private System.Windows.Forms.GroupBox AddTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtIdNo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textUpdateCourse;
        private System.Windows.Forms.TextBox textUpdateBirth;
        private System.Windows.Forms.TextBox textUpdateName;
        private System.Windows.Forms.TextBox textUpdateYear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textUpdateID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textUpdateNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

