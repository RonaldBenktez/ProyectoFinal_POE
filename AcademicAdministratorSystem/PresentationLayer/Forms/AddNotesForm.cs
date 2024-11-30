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
    public partial class AddNotesForm : Form
    {
        private INotesServices _notesServices;
        private Members _memberSession;
        public AddNotesForm(INotesServices notesServices, Members memberSession)
        {
            _notesServices = notesServices;
            _memberSession = memberSession;
            InitializeComponent();
            LoadSubjectsForComboBox();
        }

        public void LoadSubjectsForComboBox()
        {
            int TeacherId = Convert.ToInt32(_memberSession.MemberId);
            subjectComboBox.DataSource = _notesServices.GetSubjectsForComboBox(TeacherId);
            subjectComboBox.DisplayMember = "Materias";
            subjectComboBox.ValueMember = "Id";
            subjectComboBox.SelectedIndex = -1;

        }

        public void LoadNotes(int subjectId)
        {
            studentsNotesDataGridView.DataSource = _notesServices.GetStudentsForSubjects(subjectId);
        }
        private void selectSubjectButton_Click(object sender, EventArgs e)
        {
            int subjectId = Convert.ToInt32(subjectComboBox.SelectedValue);

            LoadNotes(subjectId);
        }

        private void studentsNotesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studentsNotesDataGridView.Rows.Count > 0)
            {
                string name = studentsNotesDataGridView.CurrentRow.Cells[1].Value.ToString();
                string lastName = studentsNotesDataGridView.CurrentRow.Cells[2].Value.ToString();

                studentNameLabel.Text = name + " " + lastName;

                firstNoteTextBox.Text = studentsNotesDataGridView.CurrentRow.Cells[4].Value.ToString();
                secondNoteTextBox.Text = studentsNotesDataGridView.CurrentRow.Cells[5].Value.ToString();

            }
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            if (studentsNotesDataGridView.Rows.Count > 0)
            {

                decimal note1TextBox;
                decimal note2TextBox;

                bool isValid = true;

                if (!decimal.TryParse(firstNoteTextBox.Text, out note1TextBox) || note1TextBox < 0 || note1TextBox > 10)
                {
                    notesErrorProvider.SetError(firstNoteTextBox, "Por favor ingrese una nota válida (0 - 10)");
                    isValid = false;
                }


                if (!decimal.TryParse(secondNoteTextBox.Text, out note2TextBox) || note2TextBox < 0 || note2TextBox > 10)
                {
                    notesErrorProvider.SetError(secondNoteTextBox, "Por favor ingrese una nota válida (0 - 10)");
                    isValid = false;
                }


                if (!isValid)
                {
                    return;
                }


                var studentNotes = new Notes()
                {
                    NoteId = Convert.ToInt32(studentsNotesDataGridView.CurrentRow.Cells[0].Value),
                    Note1 = note1TextBox,
                    Note2 = note2TextBox,
                    FinalNote = (note1TextBox + note2TextBox) / 2
                };

                _notesServices.EditNotes(studentNotes);

                int subjectId = Convert.ToInt32(subjectComboBox.SelectedValue);

                LoadNotes(subjectId);


            }
        }

        private void firstNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            notesErrorProvider.Clear();
        }

        private void secondNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            notesErrorProvider.Clear();
        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            if(studentsNotesDataGridView.Rows.Count ==0)
            {
                MessageBox.Show("no ha seleccionado ninguna materia","error",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrWhiteSpace(searchStudentTextBox.Text))
            {
                int subjectId = Convert.ToInt32(subjectComboBox.SelectedValue);

                LoadNotes(subjectId);
            }
            else
            {
                string searchTerm = searchStudentTextBox.Text;
                int subjectId = Convert.ToInt32(subjectComboBox.SelectedValue);

                studentsNotesDataGridView.DataSource = _notesServices.SearchStudent(subjectId, searchTerm);

            }
        }

        private void searchStudentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchStudentTextBox.Text == "")
            {
                int subjectId = Convert.ToInt32(subjectComboBox.SelectedValue);
                LoadNotes(subjectId);
            }
        }
    }
}
