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
    public partial class HomeForm : Form
    {
        private IMembersServices _adminServices;
        private ISubjectServices _subjectServices;
        private IClassesServices _classesServices;
        private IEnrollStudentServices _enrollStudentServices;
        private INotesServices _noteServices;
        private IStudentServices _studentServices;
        private Members _memberSession;
        public HomeForm(Members memberSession,
            IMembersServices adminServices,
            ISubjectServices subjectServices,
            IClassesServices classesServices,
            IEnrollStudentServices enrollStudentServices,
            INotesServices noteServices,
            IStudentServices studentServices)
        {
            InitializeComponent();
            _memberSession = memberSession;
            _adminServices = adminServices;
            _subjectServices = subjectServices;
            _classesServices = classesServices;
            _enrollStudentServices = enrollStudentServices;
            _noteServices = noteServices;
            _studentServices = studentServices;
            Permissions();
        }
        private void Permissions()
        {
            if (_memberSession.RolId == 3)
            {
                addNotesButton.Enabled = false;
                addNotesButton.Visible = false;
                showSubjectsAndStudentsButton.Enabled = false;
                showSubjectsAndStudentsButton.Visible = false;
                showStudentClassButton.Enabled = false;
                showStudentClassButton.Visible = false;
                showStudentsSubjectButton.Enabled = false;
                showStudentsSubjectButton.Visible = false;
                openChildForm(new studentsAndSubjectsForm(_enrollStudentServices));

            }
            else if (_memberSession.RolId == 1)
            {
                showMembersButton.Enabled = false;
                showMembersButton.Visible = false;
                gradesAndSectionsButton.Enabled = false;
                gradesAndSectionsButton.Visible = false;
                addSubjectsButton.Enabled = false;
                addSubjectsButton.Visible = false;
                showStudentsSubjectButton.Enabled = false;
                showStudentsSubjectButton.Visible = false;
                showStudentClassButton.Enabled = false;
                showStudentClassButton.Visible = false;
                enrollStudentsButton.Enabled = false;
                enrollStudentsButton.Visible = false;
                openChildForm(new TeacherClassForm(_classesServices, _memberSession));
            }
            else
            {
                addNotesButton.Enabled = false;
                addNotesButton.Visible = false;
                showSubjectsAndStudentsButton.Enabled = false;
                showSubjectsAndStudentsButton.Visible = false;
                showMembersButton.Enabled = false;
                showMembersButton.Visible = false;
                gradesAndSectionsButton.Enabled = false;
                gradesAndSectionsButton.Visible = false;
                addSubjectsButton.Enabled = false;
                addSubjectsButton.Visible = false;

                enrollStudentsButton.Enabled = false;
                enrollStudentsButton.Visible = false;
                openChildForm(new ViewStudentsClassForm(_studentServices, _memberSession));
            }
        }
        private void openChildForm(object _childForm)
        {
            if (this.contentPanel.Controls.Count > 0)
            {
                this.contentPanel.Controls.RemoveAt(0);
            }

            Form childForm = _childForm as Form;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(childForm);
            this.contentPanel.Tag = childForm;
            childForm.Show();

            AdjustChildFormSize();
        }


        private void AdjustChildFormSize()
        {
            if (contentPanel.Controls.Count > 0)
            {
                var childForm = contentPanel.Controls[0] as Form;
                if (childForm != null)
                {
                    childForm.Dock = DockStyle.Fill;
                    childForm.Refresh();
                }
            }
        }



        private void showMembersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new MembersForm(_adminServices));
        }
        private void gradesAndSectionsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new GradesAndSectionsForm(_subjectServices));
        }

        private void addSubjectsButton_Click_1(object sender, EventArgs e)
        {
            openChildForm(new SubjectsForm(_subjectServices));
        }



        private void showSubjectsAndStudentsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new TeacherClassForm(_classesServices, _memberSession));
        }

        private void addNotesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new AddNotesForm(_noteServices, _memberSession));
        }

        private void enrollStudentsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new studentsAndSubjectsForm(_enrollStudentServices));
        }

        private void showStudentsSubjectButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewNotesStudentsForm(_studentServices,_memberSession));
        }

        private void showStudentClassButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewStudentsClassForm(_studentServices,_memberSession));
        }
    }
}
