using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;
using CommonLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class ViewStudentsClassForm : Form
    {
        private IStudentServices _studentServices;
        private Members _memberSession;
        public ViewStudentsClassForm(IStudentServices studentServices, Members memberSession)
        {
            _studentServices = studentServices;
            _memberSession = memberSession;
            InitializeComponent();
            LoadSubjectForComboBox();
        }

        public void LoadSubjectForComboBox()
        {
            int StudentId = Convert.ToInt32(_memberSession.MemberId);
            subjectsComboBox.DataSource = _studentServices.GetSubjectForComboBox(StudentId);
            subjectsComboBox.DisplayMember = "Materias";
            subjectsComboBox.ValueMember = "Id";
            subjectsComboBox.SelectedIndex = -1;
        }

        public void LoadClasses(int SubjectId)
        {
            clasesDataGridView.DataSource = _studentServices.GetClasses(SubjectId);
        }

        private void selectionSubjectButton_Click(object sender, EventArgs e)
        {
            int SubjectId = Convert.ToInt32(subjectsComboBox.SelectedValue);
            LoadClasses(SubjectId);
        }
    }
}
