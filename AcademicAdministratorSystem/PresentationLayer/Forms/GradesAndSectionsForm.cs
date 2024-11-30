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
using Microsoft.Data.SqlClient;
namespace PresentationLayer.Forms
{
    public partial class GradesAndSectionsForm : Form
    {
        private ISubjectServices _subjectServices;
        public GradesAndSectionsForm(ISubjectServices subjectServices)
        {
            InitializeComponent();
            _subjectServices = subjectServices;
            LoadGrades();
            LoadGradesComboBox();
            LoadSections();
        }

        public void LoadGrades()
        {
            gradesDataGridView.DataSource = _subjectServices.GetGrades();
        }

        public void LoadSections()
        {
            sectionsDataGridView.DataSource = _subjectServices.GetSections();
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addGradeNameTextBox.Text))
            {
                string gradeName = addGradeNameTextBox.Text;
                try
                {

                    _subjectServices.AddGrade(gradeName);
                    LoadGrades();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("esta grado ya existe",
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
                sectionErrorProvider.SetError(addGradeNameTextBox, "este campo no puede ser nulo");
            }
        }

        private void gradesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (gradesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = gradesDataGridView.SelectedRows[0];

                editNameGradetextBox.Text = gradesDataGridView.CurrentRow.Cells[1].Value.ToString();

            }
        }

        public void editGradeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(editNameGradetextBox.Text))
            {

                string gradeNameEdited = editNameGradetextBox.Text;
                int gradeIdEdited = Convert.ToInt32(gradesDataGridView.CurrentRow.Cells[0].Value.ToString());

                try
                {

                    _subjectServices.EditGrade(gradeIdEdited, gradeNameEdited);
                    LoadGrades();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601) // Número de error para clave única
                    {
                        MessageBox.Show("esta grado ya existe",
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
                sectionErrorProvider.SetError(editNameGradetextBox, "este campo no puede ser nulo");
            }
        }

        public void LoadGradesComboBox()
        {
            addSectionGradeComboBox.DataSource = _subjectServices.GetGrades();
            addSectionGradeComboBox.DisplayMember = "Grado";
            addSectionGradeComboBox.ValueMember = "ID";

            editSectionGradecomboBox.DataSource = _subjectServices.GetGrades();
            editSectionGradecomboBox.DisplayMember = "Grado";
            editSectionGradecomboBox.ValueMember = "ID";

        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addSectionNametextBox.Text))
            {
                int gradeId = Convert.ToInt32(addSectionGradeComboBox.SelectedValue);
                string secctionName = addSectionNametextBox.Text;

                try
                {

                    _subjectServices.AddSection(secctionName, gradeId);

                    LoadSections();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("esta seccion ya existe",
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
                sectionErrorProvider.SetError(addSectionNametextBox, "este campo no puede ser nulo");
            }


        }

        private void sectionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (gradesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = gradesDataGridView.SelectedRows[0];

                editSectionGradecomboBox.Text = sectionsDataGridView.CurrentRow.Cells[1].Value.ToString();
                editSectionNameTextBox.Text = sectionsDataGridView.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void editSectionButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(editSectionNameTextBox.Text))
            {

                int sectionId = Convert.ToInt32(sectionsDataGridView.CurrentRow.Cells[0].Value.ToString());
                string sectionNameedited = editSectionNameTextBox.Text;
                int gradeIdEdted = Convert.ToInt32(editSectionGradecomboBox.SelectedValue);

                try
                {

                    _subjectServices.UpdateSection(sectionId, sectionNameedited, gradeIdEdted);

                    LoadSections();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601) // Número de error para clave única
                    {
                        MessageBox.Show("esta seccion ya existe",
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
                sectionErrorProvider.SetError(editSectionNameTextBox, "este campo no puede ser nulo");
            }
        }

        private void gradesDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (gradesDataGridView.CurrentRow != null)
            {
                var currentRow = gradesDataGridView.CurrentRow;
                editNameGradetextBox.Text = currentRow.Cells[1].Value.ToString();
            }
        }

        private void addGradeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionErrorProvider.Clear();
        }

        private void editNameGradetextBox_TextChanged(object sender, EventArgs e)
        {
            sectionErrorProvider.Clear();
        }

        private void addSectionNametextBox_TextChanged(object sender, EventArgs e)
        {
            sectionErrorProvider.Clear();
        }

        private void editSectionNameTextBox_TextChanged(object sender, EventArgs e)
        {
            sectionErrorProvider.Clear();
        }
    }
}
