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

namespace PresentationLayer.Forms
{
    public partial class TeacherClassForm : Form
    {
        IClassesServices _classServices;
        private Members _meberSession;
        public TeacherClassForm(IClassesServices classesServices, Members memberSession)
        {
            _classServices = classesServices;
            _meberSession = memberSession;
            InitializeComponent();
            LoadSubjects();
            LoadClasses();
            LoadSubjectsForComboBox();
        }

        public void LoadSubjects()
        {
            int TeacherId = Convert.ToInt32(_meberSession.MemberId);
            subjectDataGridView.DataSource = _classServices.GetSubjects(TeacherId);
        }


        private void selectionSubjectButton_Click_1(object sender, EventArgs e)
        {
            int SubjectId = Convert.ToInt32(subjectDataGridView.CurrentRow.Cells[0].Value);

            studentsDataGridView.DataSource = _classServices.GetStudentsForSubjects(SubjectId);
        }

        public void LoadClasses()
        {
            int TeacherId = Convert.ToInt32(_meberSession.MemberId);

            classesDataGridView.DataSource = _classServices.GetClasses(TeacherId);
        }

        public void LoadSubjectsForComboBox()
        {
            int TeacherId = Convert.ToInt32(_meberSession.MemberId);
            addSubjectComboBox.DataSource = _classServices.GetSubjectsForComboBox(TeacherId);
            addSubjectComboBox.DisplayMember = "Materias";
            addSubjectComboBox.ValueMember = "Id";

            editSubjectComboBox.DataSource = _classServices.GetSubjectsForComboBox(TeacherId);
            editSubjectComboBox.DisplayMember = "Materias";
            editSubjectComboBox.ValueMember = "Id";
            editSubjectComboBox.SelectedIndex = -1;

        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addContentTextBox.Text))
            {

                var classAdded = new Classes()
                {
                    SubjectId = Convert.ToInt32(addSubjectComboBox.SelectedValue),
                    TeacherId = Convert.ToInt32(_meberSession.MemberId),
                    Content = addContentTextBox.Text,
                };

                _classServices.AddClass(classAdded);
                addContentTextBox.Text = "";
                LoadClasses();
            }
            else
            {
                contentErrorProvider.SetError(addContentTextBox, "por favor ingrese un contenido");
            }
        }

        private void classesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (classesDataGridView.Rows.Count > 0)
            {
                editContentTextBox.Text = classesDataGridView.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void editClassButton_Click(object sender, EventArgs e)
        {
            if (classesDataGridView.Rows.Count > 0)
            {
                bool isValid = true;

                if (string.IsNullOrWhiteSpace(editContentTextBox.Text))
                {
                    contentErrorProvider.SetError(editContentTextBox, "Por favor ingrese un contenido");
                    isValid = false;
                }
                else
                {
                    contentErrorProvider.SetError(editContentTextBox, string.Empty);
                }

                // Validar la selección de la materia
                if (editSubjectComboBox.SelectedIndex < 0)
                {
                    contentErrorProvider.SetError(editSubjectComboBox, "Por favor seleccione una materia");
                    isValid = false;
                }
                else
                {
                    contentErrorProvider.SetError(editSubjectComboBox, string.Empty);
                }


                if (isValid)
                {
                    var classEdited = new Classes()
                    {
                        ClassId = Convert.ToInt32(classesDataGridView.CurrentRow.Cells[0].Value),
                        SubjectId = Convert.ToInt32(editSubjectComboBox.SelectedValue),
                        TeacherId = Convert.ToInt32(_meberSession.MemberId),
                        Content = editContentTextBox.Text,
                    };

                    _classServices.EditClass(classEdited);


                    editContentTextBox.Text = "";
                    editSubjectComboBox.SelectedIndex = -1;
                    LoadClasses();
                }
            }
        }

        private void deleteClassButton_Click(object sender, EventArgs e)
        {
            if (classesDataGridView.CurrentRow != null)
            {
                int classId = Convert.ToInt32(classesDataGridView.CurrentRow.Cells[0].Value);

                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta clase?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    _classServices.DeleteClass(classId);
                    MessageBox.Show("Clase eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadClasses();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una clase para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addContentTextBox_TextChanged(object sender, EventArgs e)
        {
            contentErrorProvider.Clear();
        }

        private void editSubjectComboBox_Click(object sender, EventArgs e)
        {
            contentErrorProvider.Clear();
        }

        private void editContentTextBox_TextChanged(object sender, EventArgs e)
        {
            contentErrorProvider.Clear();
        }
    }
}
