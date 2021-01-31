namespace MSGCP.View
{
    partial class Export
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
            this.cmb_Section = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Grade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            this.mSGCPADataSetStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSGCPADataSetStudent = new MSGCP.MSGCPADataSetStudent();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.students = new MSGCP.Students();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityStudent = new MSGCP.EntityStudent();
            this.studentTableAdapter = new MSGCP.EntityStudentTableAdapters.StudentTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.studentTableAdapter1 = new MSGCP.StudentsTableAdapters.StudentTableAdapter();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parentsname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parentphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendance_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.school_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSGCPADataSetStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSGCPADataSetStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityStudent)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Section
            // 
            this.cmb_Section.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Section.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Section.FormattingEnabled = true;
            this.cmb_Section.Location = new System.Drawing.Point(392, 16);
            this.cmb_Section.Name = "cmb_Section";
            this.cmb_Section.Size = new System.Drawing.Size(90, 21);
            this.cmb_Section.TabIndex = 36;
            this.cmb_Section.SelectedIndexChanged += new System.EventHandler(this.loadstudent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(310, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Section";
            // 
            // cmb_Grade
            // 
            this.cmb_Grade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Grade.FormattingEnabled = true;
            this.cmb_Grade.Location = new System.Drawing.Point(79, 14);
            this.cmb_Grade.Name = "cmb_Grade";
            this.cmb_Grade.Size = new System.Drawing.Size(90, 21);
            this.cmb_Grade.TabIndex = 37;
            this.cmb_Grade.SelectedIndexChanged += new System.EventHandler(this.loadstudent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Class";
            // 
            // dgv_Student
            // 
            this.dgv_Student.AllowUserToAddRows = false;
            this.dgv_Student.AllowUserToDeleteRows = false;
            this.dgv_Student.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.fullName,
            this.address,
            this.DOB,
            this.gender,
            this.phone,
            this.Parentsname,
            this.Email,
            this.Parentphone,
            this.grade,
            this.section,
            this.rollno,
            this.attendance_Id,
            this.school_Id});
            this.dgv_Student.GridColor = System.Drawing.Color.White;
            this.dgv_Student.Location = new System.Drawing.Point(13, 132);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.ReadOnly = true;
            this.dgv_Student.Size = new System.Drawing.Size(806, 428);
            this.dgv_Student.TabIndex = 38;
            this.dgv_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Student_CellContentClick);
            // 
            // mSGCPADataSetStudentBindingSource
            // 
            this.mSGCPADataSetStudentBindingSource.DataSource = this.mSGCPADataSetStudent;
            this.mSGCPADataSetStudentBindingSource.Position = 0;
            // 
            // mSGCPADataSetStudent
            // 
            this.mSGCPADataSetStudent.DataSetName = "MSGCPADataSetStudent";
            this.mSGCPADataSetStudent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.students;
            // 
            // students
            // 
            this.students.DataSetName = "Students";
            this.students.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.entityStudent;
            // 
            // entityStudent
            // 
            this.entityStudent.DataSetName = "EntityStudent";
            this.entityStudent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(111)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 39);
            this.panel2.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(372, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 25);
            this.label16.TabIndex = 9;
            this.label16.Text = "View Student  ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cmb_Section);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_Grade);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(176, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 56);
            this.panel1.TabIndex = 44;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(698, 565);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 30);
            this.btn_Add.TabIndex = 45;
            this.btn_Add.Text = "EXPORT TO EXCEL";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 565);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(677, 29);
            this.progressBar.TabIndex = 46;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(16)))), ((int)(((byte)(54)))));
            this.lbl_Status.Location = new System.Drawing.Point(339, 597);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(133, 19);
            this.lbl_Status.TabIndex = 38;
            this.lbl_Status.Text = "Processing...0%";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "student_Id";
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "full_Name";
            this.fullName.HeaderText = "Student Full Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // Parentsname
            // 
            this.Parentsname.DataPropertyName = "parents_Name";
            this.Parentsname.HeaderText = "Parents Name";
            this.Parentsname.Name = "Parentsname";
            this.Parentsname.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Parentphone
            // 
            this.Parentphone.DataPropertyName = "parent_Phone";
            this.Parentphone.HeaderText = "Parent Phone";
            this.Parentphone.Name = "Parentphone";
            this.Parentphone.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // section
            // 
            this.section.DataPropertyName = "section";
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            this.section.ReadOnly = true;
            // 
            // rollno
            // 
            this.rollno.DataPropertyName = "roll_No";
            this.rollno.HeaderText = "RollNo";
            this.rollno.Name = "rollno";
            this.rollno.ReadOnly = true;
            // 
            // attendance_Id
            // 
            this.attendance_Id.DataPropertyName = "attendance_Id";
            this.attendance_Id.HeaderText = "attendance_Id";
            this.attendance_Id.Name = "attendance_Id";
            this.attendance_Id.ReadOnly = true;
            this.attendance_Id.Visible = false;
            // 
            // school_Id
            // 
            this.school_Id.DataPropertyName = "school_Id";
            this.school_Id.HeaderText = "school_Id";
            this.school_Id.Name = "school_Id";
            this.school_Id.ReadOnly = true;
            this.school_Id.Visible = false;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 620);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_Student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Export";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudent";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSGCPADataSetStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSGCPADataSetStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityStudent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Section;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Student;
        private EntityStudent entityStudent;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private EntityStudentTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Add;
        private Students students;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private StudentsTableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.BindingSource mSGCPADataSetStudentBindingSource;
        private MSGCPADataSetStudent mSGCPADataSetStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parentsname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parentphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollno;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendance_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn school_Id;
    }
}