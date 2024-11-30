using BusinessLayer.Services;
using CommonLayer.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class studentsAndSubjectsForm : Form
    {
        private IEnrollStudentServices _enrollStudentServices;
        public studentsAndSubjectsForm(IEnrollStudentServices enrollStudentServices)
        {
            _enrollStudentServices = enrollStudentServices;
            InitializeComponent();
            LoadAllStudents();
            LoadSubjectsForComboBox();
            studentsDataGridView.SelectionChanged += studentsDataGridView_SelectionChanged;
            subjectDataGridView.SelectionChanged += subjectDataGridView_SelectionChanged;
        }

        public void LoadAllStudents()
        {

            studentsDataGridView.DataSource = _enrollStudentServices.GetAllStudents();

        }

        public void LoadSubjectsForComboBox()
        {
            addSubjectComboBox.DataSource = _enrollStudentServices.GetSubjectsForComboBox();
            addSubjectComboBox.DisplayMember = "Materias";
            addSubjectComboBox.ValueMember = "Id";
        }

        public void LoadSubjectForStudent(int studentId)
        {
            subjectDataGridView.DataSource = _enrollStudentServices.GetSubjectsForStudent(studentId);
        }

        private void studentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studentsDataGridView.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(studentsDataGridView.CurrentRow.Cells[0].Value.ToString());

                LoadSubjectForStudent(studentId);

                studentNamesLabel.Text = $"{studentsDataGridView.CurrentRow.Cells[1].Value.ToString()} {studentsDataGridView.CurrentRow.Cells[2].Value.ToString()}";
            }
        }

        private void enrollStudentButton_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(studentsDataGridView.CurrentRow.Cells[0].Value.ToString());
            int subjectId = Convert.ToInt32(addSubjectComboBox.SelectedValue);

            try
            {

                int enrollmentId = _enrollStudentServices.AddEnrollStudent(studentId, subjectId);
                _enrollStudentServices.AddStudentNotes(enrollmentId); 
                LoadSubjectForStudent(studentId);


            }
            catch(SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Número de error para clave única
                {
                    MessageBox.Show("el estudiante selecciona ya se encuentra inscrito en la materia",
                                    "advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                }
                else
                {

                    MessageBox.Show($"Error SQL: {ex.Message}");
                }
            }
        }

        private void subjectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (subjectDataGridView.CurrentRow != null)
            {
                var currentRow = subjectDataGridView.CurrentRow;
                addSubjectComboBox.Text = currentRow.Cells[1].Value.ToString() + " con: " + currentRow.Cells[2].Value.ToString();
            }

        }

        private void editEnrollStudentButton_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(studentsDataGridView.CurrentRow.Cells[0].Value.ToString());
            int EnrollmentId = Convert.ToInt32(subjectDataGridView.CurrentRow.Cells[0].Value.ToString());
            int SubjectEditedId = Convert.ToInt32(addSubjectComboBox.SelectedValue);

            try
            {

                 _enrollStudentServices.EditEnrollStudent(EnrollmentId, SubjectEditedId);

                 LoadSubjectForStudent(studentId);
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Número de error para clave única
                {
                    MessageBox.Show("el estudiante selecciona ya se encuentra inscrito en la materia",
                                    "advertencia",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                }
                else
                {

                    MessageBox.Show($"Error SQL: {ex.Message}");
                }
            }


        }

        private void deleteEnrollStudentButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este dato?",
                   "Warning",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                 int studentId = Convert.ToInt32(studentsDataGridView.CurrentRow.Cells[0].Value.ToString());
                 int EnrollmentId = Convert.ToInt32(subjectDataGridView.CurrentRow.Cells[0].Value.ToString());
                 _enrollStudentServices.DeleteEnrollStudent(EnrollmentId);

                 LoadSubjectForStudent(studentId);
            }
        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            if (searchStudentTextBox.Text.IsNullOrEmpty())
            {
                LoadAllStudents();
            }
            else
            {
                string SearchTerm = searchStudentTextBox.Text;
                studentsDataGridView.DataSource = _enrollStudentServices.SearchStudent(SearchTerm);
            }
        }

        private void searchStudentTextBox_TextChanged(object sender, EventArgs e)
        {
            if(searchStudentTextBox.Text.IsNullOrEmpty())
            {
                LoadAllStudents();
            }
        }
    }
}
