namespace CRUDStudents
{
    partial class frmCourseInfo
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
            this.lblCourseID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseTutor = new System.Windows.Forms.Label();
            this.txtCourseTutor = new System.Windows.Forms.TextBox();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.coursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(18, 21);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(51, 13);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "CourseID";
            // 
            // txtCourseID
            // 
            this.txtCourseID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursBindingSource, "CourseID", true));
            this.txtCourseID.Location = new System.Drawing.Point(101, 18);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(42, 20);
            this.txtCourseID.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(18, 50);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(68, 13);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "CourseName";
            // 
            // txtCourseName
            // 
            this.txtCourseName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursBindingSource, "CourseName", true));
            this.txtCourseName.Location = new System.Drawing.Point(101, 43);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtCourseName.TabIndex = 1;
            // 
            // lblCourseTutor
            // 
            this.lblCourseTutor.AutoSize = true;
            this.lblCourseTutor.Location = new System.Drawing.Point(18, 76);
            this.lblCourseTutor.Name = "lblCourseTutor";
            this.lblCourseTutor.Size = new System.Drawing.Size(65, 13);
            this.lblCourseTutor.TabIndex = 0;
            this.lblCourseTutor.Text = "CourseTutor";
            // 
            // txtCourseTutor
            // 
            this.txtCourseTutor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursBindingSource, "CourseTutor", true));
            this.txtCourseTutor.Location = new System.Drawing.Point(101, 73);
            this.txtCourseTutor.Name = "txtCourseTutor";
            this.txtCourseTutor.Size = new System.Drawing.Size(100, 20);
            this.txtCourseTutor.TabIndex = 1;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Location = new System.Drawing.Point(126, 134);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCourse.TabIndex = 2;
            this.btnSaveCourse.Text = "&Save";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // coursBindingSource
            // 
            this.coursBindingSource.DataSource = typeof(CRUDStudents.Cours);
            // 
            // frmCourseInfo
            // 
            this.AcceptButton = this.btnSaveCourse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.btnSaveCourse);
            this.Controls.Add(this.txtCourseTutor);
            this.Controls.Add(this.lblCourseTutor);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseID);
            this.Name = "frmCourseInfo";
            this.Text = "frmCourseInfo";
            this.Load += new System.EventHandler(this.frmCourseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseTutor;
        private System.Windows.Forms.TextBox txtCourseTutor;
        private System.Windows.Forms.Button btnSaveCourse;
        private System.Windows.Forms.BindingSource coursBindingSource;
    }
}