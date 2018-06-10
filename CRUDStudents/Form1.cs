using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDStudents
{
    public partial class Form1 : Form
    {
        StudentEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            studentBindingSource3.DataSource = db.Students.ToList();
            coursBindingSource2.DataSource = db.Courses.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
            db = new StudentEntities();
            studentBindingSource3.DataSource = db.Students.ToList();
            coursBindingSource2.DataSource = db.Courses.ToList();

        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            
            
            using(frmStudentInfo frm = new frmStudentInfo(new Student() { StudyForm = false }))
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        studentBindingSource3.Add(frm.StudentInfo);
                        db.Students.Add(frm.StudentInfo);
                        await db.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            Student obj = studentBindingSource3.Current as Student;
            if(obj!= null)
            {
                using (frmStudentInfo frm = new frmStudentInfo(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            studentBindingSource3.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    db.Students.Remove(dataGridView1.SelectedRows[i].DataBoundItem as Student);
                    studentBindingSource3.RemoveAt(dataGridView1.SelectedRows[i].Index);
                }
                for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                {
                    db.Courses.Remove(dataGridView2.SelectedRows[i].DataBoundItem as Cours);
                    coursBindingSource2.RemoveAt(dataGridView2.SelectedRows[i].Index);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    studentBindingSource3.EndEdit();
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnAddCourse_Click(object sender, EventArgs e){

            using (frmCourseInfo frm = new frmCourseInfo(new Cours()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        coursBindingSource2.Add(frm.CourseInfo);
                        db.Courses.Add(frm.CourseInfo);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }    
       
    }
}
