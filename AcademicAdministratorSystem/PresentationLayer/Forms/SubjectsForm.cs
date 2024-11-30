using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLayer.Entities;
using Microsoft.Data.SqlClient;

namespace PresentationLayer.Forms
{
    public partial class SubjectsForm : Form
    {
        private ISubjectServices _subjectServices;
        public SubjectsForm(ISubjectServices subjectServices)
        {
            InitializeComponent();
            _subjectServices = subjectServices;
            addYearDateTimePicker.CustomFormat = "yyyy";
            editYearDateTimePicker.CustomFormat = "yyyy";
            LoadSubjects();
            LoadSections();
            LoadTeachersAndSubject();
            LoadTeachers();
            LoadSubjectForComboBox();
        }

        public void LoadSubjects()
        {
            subjectDataGridView.DataSource = _subjectServices.GetSubjects();
        }

        public void LoadTeachersAndSubject()
        {
            teachersAndSubjectDataGridView.DataSource = _subjectServices.GetTeacherAndSubjects();
        }

        public void LoadTeachers()
        {
            teacherComboBox.DataSource = _subjectServices.GetTeachers();
            teacherComboBox.DisplayMember = "Maestros";
            teacherComboBox.ValueMember = "Id";
        }
        public void LoadSubjectForComboBox()
        {
            SubjectComboBox.DataSource = _subjectServices.GetSubjectForComboBox();
            SubjectComboBox.DisplayMember = "Materias";
            SubjectComboBox.ValueMember = "Id";
        }

        public void LoadSections()
        {
            addSectionComboBox.DataSource = _subjectServices.GetSectionsforCombobox();
            addSectionComboBox.DisplayMember = "Seccion";
            addSectionComboBox.ValueMember = "ID";

            editSectionComboBox.DataSource = _subjectServices.GetSectionsforCombobox();
            editSectionComboBox.DisplayMember = "Seccion";
            editSectionComboBox.ValueMember = "ID";
            editSectionComboBox.SelectedIndex = -1;
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addSujectNameTextBox.Text))
            {

                var SubjectAdded = new Subjects()
                {
                    SubjectName = addSujectNameTextBox.Text,
                    SectionId = Convert.ToInt32(addSectionComboBox.SelectedValue),
                    Year = addYearDateTimePicker.Value.Year,
                };

                try
                {

                    _subjectServices.AddSubject(SubjectAdded);

                    LoadSubjects();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601) // Número de error para clave única
                    {
                        MessageBox.Show("esta combinacion de materia y seccion ya fue creada",
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
            else
            {
                subjectsErrorProvider.SetError(addSujectNameTextBox, "por favor ingresar un nombre");
            }


        }

        private void subjectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (subjectDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = subjectDataGridView.SelectedRows[0];


                editNameSubjectTextBox.Text = selectedRow.Cells[1].Value.ToString();
                editSectionComboBox.Text = $"{selectedRow.Cells[2].Value.ToString()} {selectedRow.Cells[3].Value.ToString()}";

                int year = Convert.ToInt32(selectedRow.Cells[4].Value);
                editYearDateTimePicker.Value = new DateTime(year, 1, 1);
            }
        }

        private void editSubjectButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(editNameSubjectTextBox.Text))
            {

                var SubjectEdited = new Subjects()
                {
                    SubjectId = Convert.ToInt32(subjectDataGridView.CurrentRow.Cells[0].Value.ToString()),
                    SubjectName = editNameSubjectTextBox.Text,
                    SectionId = Convert.ToInt32(editSectionComboBox.SelectedValue),
                    Year = editYearDateTimePicker.Value.Year,
                };
                try
                {
                    _subjectServices.EditSubject(SubjectEdited);

                    LoadSubjects();

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601) // Número de error para clave única
                    {
                        MessageBox.Show("esta combinacion de materia y seccion ya fue creada",
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
            else
            {
                subjectsErrorProvider.SetError(editNameSubjectTextBox, "por favor ingresar un nombre");
            }


        }

        private void deleteSubjectButton_Click(object sender, EventArgs e)
        {
            int subjectId = Convert.ToInt32(subjectDataGridView.SelectedRows[0].Cells[0].Value);

            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta materia?",
                                                 "Confirmar Eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {

                    _subjectServices.DeleteSubject(subjectId);

                    LoadSubjects();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Error: No se puede eliminar la materia porque ya tiene un docente asignado.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Console.WriteLine($"Error general de la base de datos: {ex.Message}");
                    }
                }

            }
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            try
            {

                int teacherId = Convert.ToInt32(teacherComboBox.SelectedValue);
                int subjectId = Convert.ToInt32(SubjectComboBox.SelectedValue);

                _subjectServices.AddTeacherAndSubject(teacherId, subjectId);

                LoadTeachersAndSubject();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Número de error para clave única
                {
                    MessageBox.Show("la materia ya se encuentra añadida al docente",
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

        private void editTeacherButton_Click(object sender, EventArgs e)
        {
            int teacherAndSubjectId = Convert.ToInt32(teachersAndSubjectDataGridView.CurrentRow.Cells[0].Value.ToString());
            int teacherId = Convert.ToInt32(teacherComboBox.SelectedValue);
            int subjectId = Convert.ToInt32(SubjectComboBox.SelectedValue);

            try
            {
                _subjectServices.EditTacherAndSubject(teacherAndSubjectId, teacherId, subjectId);
                LoadTeachersAndSubject();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Número de error para clave única
                {
                    MessageBox.Show("la materia ya se encuentra añadida al docente",
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



        private void deleteTaeacherAndSubjectButton_Click(object sender, EventArgs e)
        {
            if (teachersAndSubjectDataGridView.SelectedRows.Count == 0)
            {

                MessageBox.Show("Por favor, seleccione un empleado a eliminar",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este dato?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        int teacherAndSubjecId = Convert.ToInt32(teachersAndSubjectDataGridView.CurrentRow.Cells[0].Value.ToString());

                        _subjectServices.DeleteTeacherAndSubject(teacherAndSubjecId);

                        LoadTeachersAndSubject();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547) 
                        {
                            MessageBox.Show("Error: No se puede eliminar la materia porque tiene alumnos asignados.","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            Console.WriteLine($"Error general de la base de datos: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void teachersAndSubjectDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (teachersAndSubjectDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = teachersAndSubjectDataGridView.SelectedRows[0];

                teacherComboBox.Text = selectedRow.Cells[1].Value.ToString();
                SubjectComboBox.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void addSujectNameTextBox_TextChanged(object sender, EventArgs e)
        {
            subjectsErrorProvider.Clear();
        }

        private void editNameSubjectTextBox_TextChanged(object sender, EventArgs e)
        {
            subjectsErrorProvider.Clear();
        }
    }
}
