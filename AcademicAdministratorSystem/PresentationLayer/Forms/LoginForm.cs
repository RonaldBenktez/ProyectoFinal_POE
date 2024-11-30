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
    public partial class LoginForm : Form
    {
        private ILoginServices _membersServices;
        private IMembersServices _adminServices;
        private ISubjectServices _subjectServices;
        private IClassesServices _classesServices;
        private IEnrollStudentServices _enrollStudentServices;
        private INotesServices _noteServices;
        private IStudentServices _studentServices;
        public LoginForm(ILoginServices membersServices,
            IMembersServices adminServices,
            ISubjectServices subjectServices,
            IClassesServices classesServices,
            IEnrollStudentServices enrollStudentServices,
            INotesServices notesServices,
            IStudentServices studentServices)

        {
            _membersServices = membersServices;
            _adminServices = adminServices;
            _subjectServices = subjectServices;
            _enrollStudentServices = enrollStudentServices;
            _noteServices = notesServices;
            _studentServices = studentServices;
            InitializeComponent();
            userTextBox.TextChanged += (s, e) => loginErrorProvider.SetError(userTextBox, "");
            passwordTextBox.TextChanged += (s, e) => loginErrorProvider.SetError(passwordTextBox, "");
            _classesServices = classesServices;
            _studentServices = studentServices;
        }
        // este codigo hace una busqueda en la base de datos y trae un objeto del tipo members ya sea estudiante o docente
        //si el usuer ingresado no existe en la base de datos esta objeto viene basio y si esta vacio muestra un mensaje que no existe
        private void LoginButton_Click(object sender, EventArgs e)
        {
            var memberInput = new Members()
            {
                MemberUser = userTextBox.Text,
                Password = passwordTextBox.Text,
            };

            if (ValidateUser(memberInput))
            {
                Members SesionMember = _membersServices.FindUser(memberInput);

                if (SesionMember == null)
                {
                    MessageBox.Show("usuario no encontrado");
                }
                else
                {
                    if (SesionMember.Password == memberInput.Password)
                    {
                        this.Hide();    
                        HomeForm homeForm = new HomeForm(
                             SesionMember,
                            _adminServices,
                            _subjectServices,
                            _classesServices,
                            _enrollStudentServices,
                            _noteServices,
                            _studentServices);

                        homeForm.FormClosed += (s, arg) =>
                        {
                            this.Show();
                            userTextBox.Text = "";
                            passwordTextBox.Text = "";
                        };

                        homeForm.Show();
                    }

                    else
                    {
                        MessageBox.Show("contraseña invalida");
                    }
                }

            }
        }

        //esta funcion valida que el campo de usuario y contraseña siempre tengan datos
        public bool ValidateUser(Members memberInput)
        {
            bool isValid = true;

            // Limpia cualquier error previo
            loginErrorProvider.Clear();

            // Verifica si el campo MemberUser está vacío
            if (string.IsNullOrEmpty(memberInput.MemberUser))
            {
                loginErrorProvider.SetError(userTextBox, "El nombre de usuario no puede estar vacío.");
                isValid = false;
            }

            // Verifica si el campo Password está vacío
            if (string.IsNullOrEmpty(memberInput.Password))
            {
                loginErrorProvider.SetError(passwordTextBox, "La contraseña no puede estar vacía.");
                isValid = false;
            }

            return isValid;
        }
    }

}
