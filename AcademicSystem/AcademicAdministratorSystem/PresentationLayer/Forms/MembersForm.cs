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
using Microsoft.IdentityModel.Tokens;
using CommonLayer.Entities;
using PresentationLayer.Validations;
using FluentValidation.Results;
using FluentValidation;
using Microsoft.Data.SqlClient;


namespace PresentationLayer.Forms
{
    public partial class MembersForm : Form
    {
        private IMembersServices _adminServices;
        public MembersForm(IMembersServices adminServices)
        {
            InitializeComponent();
            _adminServices = adminServices;
            LoadAllMembers();
            LoadRoles();

        }

        public void LoadAllMembers()
        {
            membersDataGridView.DataSource = _adminServices.GetAllMembers();
        }

        public void LoadRoles()
        {

            addRolComboBox.DataSource = _adminServices.GetRoles();
            addRolComboBox.DisplayMember = "Roles";
            addRolComboBox.ValueMember = "RolId";
            addRolComboBox.SelectedIndex = -1;

            editRolComboBox.DataSource = _adminServices.GetRoles();
            editRolComboBox.DisplayMember = "Roles";
            editRolComboBox.ValueMember = "RolId";
            editRolComboBox.SelectedIndex = -1;
        }

        private void showStudentsButton_Click(object sender, EventArgs e)
        {
            int rolType = 2;
            TitleMemberLabel.Text = "estudiantes";

            membersDataGridView.DataSource = _adminServices.GetEstudentsOrTeachers(rolType);
        }

        private void showTeacherButton_Click(object sender, EventArgs e)
        {
            int rolType = 1;
            TitleMemberLabel.Text = "docentes";

            membersDataGridView.DataSource = _adminServices.GetEstudentsOrTeachers(rolType);
        }

        private void showAdminButton_Click(object sender, EventArgs e)
        {
            int rolType = 3;
            TitleMemberLabel.Text = "administradores";

            membersDataGridView.DataSource = _adminServices.GetEstudentsOrTeachers(rolType);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            TitleMemberLabel.Text = "todos los miembros";
            LoadAllMembers();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.IsNullOrEmpty())
            {
                LoadAllMembers();
            }
            else
            {
                TitleMemberLabel.Text = "busqueda especifica";
                string searchTerm = searchTextBox.Text;
                membersDataGridView.DataSource = _adminServices.SearchMember(searchTerm);
                if (membersDataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("no se encontraron datos con respecto a la busqueda",
                        "informacion",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
            }
        }



        private void addMemberButton_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dateTime = DateTime.Now;

                var MemberAdd = new Members()
                {
                    RolId = Convert.ToInt32(addRolComboBox.SelectedValue),
                    Names = addNameTextBox.Text,
                    LastNames = addLastNameTextBox.Text,
                    MemberUser = addUserTextBox.Text,
                    Password = addPasswordTextBox.Text,
                    Email = addEmailTextBox.Text,
                    Phone = addPhoneTextBox.Text,
                    DateEntry = dateTime
                };

                MembersValidations membersValidator = new MembersValidations();

                ValidationResult result = membersValidator.Validate(MemberAdd);

                if(!result.IsValid)
                {
                    AddDisplayValidations(result);
                    return;
                }
                else
                {
                    _adminServices.AddMebers(MemberAdd);
                    LoadAllMembers();
                    membersErrorProvider.Clear();

                }
            }
            catch(SqlException ex)
            {
                if (ex.Number == 2627) 
                {
                    MessageBox.Show("El MemberUser ya está en uso. Por favor, elija otro.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    
                    MessageBox.Show($"Error al agregar miembro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void membersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (membersDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = membersDataGridView.SelectedRows[0];

                editRolComboBox.Text = membersDataGridView.CurrentRow.Cells[1].Value.ToString();
                editNameTextBox.Text = membersDataGridView.CurrentRow.Cells[2].Value.ToString();
                editLastNamesTextBox.Text = membersDataGridView.CurrentRow.Cells[3].Value.ToString();
                editUserTextBox.Text = membersDataGridView.CurrentRow.Cells[4].Value.ToString();
                editPasswordTextBox.Text = membersDataGridView.CurrentRow.Cells[5].Value.ToString();
                editEmailTextBox.Text = membersDataGridView.CurrentRow.Cells[6].Value.ToString();
                editPhoneTextBox.Text = membersDataGridView.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    DateTime dateTime = DateTime.Now;
                    var memberEdited = new Members()
                    {
                        MemberId = Convert.ToInt32(membersDataGridView.CurrentRow.Cells[0].Value.ToString()),
                        RolId = Convert.ToInt32(editRolComboBox.SelectedValue),
                        Names = editNameTextBox.Text,
                        LastNames = editLastNamesTextBox.Text,
                        MemberUser = editUserTextBox.Text,
                        Password = editPasswordTextBox.Text,
                        Email = editEmailTextBox.Text,
                        Phone = editPhoneTextBox.Text,
                        DateEntry = dateTime

                    };

                    MembersValidations membersValidator = new MembersValidations();

                    ValidationResult result = membersValidator.Validate(memberEdited);

                    if (!result.IsValid)
                    {
                        EditDisplayValidations(result);
                        return;
                    }
                    else
                    {
                        _adminServices.EditMember(memberEdited);
                        TitleMemberLabel.Text = "todos los miembros";
                        membersErrorProvider.Clear();

                        LoadAllMembers();

                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("El MemberUser ya está en uso. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        MessageBox.Show($"Error al agregar miembro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            if (membersDataGridView.SelectedRows.Count == 0)
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

                    int MemberId = Convert.ToInt32(membersDataGridView.CurrentRow.Cells[0].Value.ToString());

                    _adminServices.DeleteMember(MemberId);
                    LoadAllMembers();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Este Usuario no se puede eliminar porque se encuentra relacionado con alguna materia",
                                "advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        public void AddDisplayValidations(ValidationResult result)
        {
            membersErrorProvider.Clear();

            foreach(var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Members.RolId):
                        membersErrorProvider.SetError(addRolComboBox, error.ErrorMessage);
                        break;

                    case nameof(Members.Names):
                        membersErrorProvider.SetError(addNameTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.LastNames):
                        membersErrorProvider.SetError(addLastNameTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.MemberUser):
                        membersErrorProvider.SetError(addUserTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.Password):
                        membersErrorProvider.SetError(addPasswordTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.Phone):
                        membersErrorProvider.SetError(addPhoneTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.Email):
                        membersErrorProvider.SetError(addEmailTextBox, error.ErrorMessage);
                        break;
                }
            }
        }

        public void EditDisplayValidations(ValidationResult result)
        {
            membersErrorProvider.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Members.RolId):
                        membersErrorProvider.SetError(editRolComboBox, error.ErrorMessage);
                        break;

                    case nameof(Members.Names):
                        membersErrorProvider.SetError(editNameTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.LastNames):
                        membersErrorProvider.SetError(addLastNameTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.MemberUser):
                        membersErrorProvider.SetError(editUserTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.Password):
                        membersErrorProvider.SetError(editPasswordTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.Phone):
                        membersErrorProvider.SetError(editPhoneTextBox, error.ErrorMessage);
                        break;

                    case nameof(Members.Email):
                        membersErrorProvider.SetError(editEmailTextBox, error.ErrorMessage);
                        break;
                }
            }
        }
    }
}
