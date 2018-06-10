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
    public partial class frmCourseInfo : Form
    {
       public Cours CourseInfo
        {
            get { return coursBindingSource.Current as Cours; }
        }
       public frmCourseInfo(Cours obj)
        {
            InitializeComponent();
            coursBindingSource.DataSource = obj;
       }
        private void button1_Click(object sender, EventArgs e)
        {
            coursBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void frmCourseInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
