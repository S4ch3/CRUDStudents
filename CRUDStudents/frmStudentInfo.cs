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
    public partial class frmStudentInfo : Form
    {
        public Student StudentInfo
        {
            get { return studentBindingSource.Current as Student; }
        }
        public frmStudentInfo(Student obj)
        {
            InitializeComponent();
            studentBindingSource.DataSource = obj;
            //
            if (chkForm.CheckState == CheckState.Checked)
                chkForm.Text = "Full Time";
            else if (chkForm.CheckState == CheckState.Unchecked)
                chkForm.Text = "Part Time";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void chkForm_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkForm_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkForm.CheckState == CheckState.Checked)
                chkForm.Text = "Full Time";
            else if (chkForm.CheckState == CheckState.Unchecked)
                chkForm.Text = "Part Time"; 
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
