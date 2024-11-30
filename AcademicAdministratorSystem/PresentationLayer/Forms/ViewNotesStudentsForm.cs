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
    public partial class ViewNotesStudentsForm : Form
    {
        private IStudentServices _studentServices;
        private Members _memberSession;
        public ViewNotesStudentsForm(IStudentServices studentServices,Members members)
        {
            _studentServices = studentServices;
            _memberSession = members;
            InitializeComponent();
            LoadSubjects();
            LoadNotes();
            studentNameLabel.Text=_memberSession.Names+" "+_memberSession.LastNames;
        }

        public void LoadSubjects()
        {
            int StudentId= Convert.ToInt32(_memberSession.MemberId);

            subjectsDataGridView.DataSource = _studentServices.GetSubjects(StudentId);
        }

        public void LoadNotes()
        {
            int StudentId = Convert.ToInt32(_memberSession.MemberId);
            notesDataGridView.DataSource=_studentServices.GetNotes(StudentId);
        }
    }
}
