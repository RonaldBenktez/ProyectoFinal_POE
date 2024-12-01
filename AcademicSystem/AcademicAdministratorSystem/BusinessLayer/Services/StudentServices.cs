using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
namespace BusinessLayer.Services
{
    public class StudentServices : IStudentServices
    {
        private IStudentRepository _studentRepository;

        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public DataTable GetSubjects(int StudentId)
        {
            return _studentRepository.GetSubjects(StudentId);
        }

        public DataTable GetNotes(int StudentId)
        {
            return _studentRepository.GetNotes(StudentId);
        }

        public DataTable GetSubjectForComboBox(int StudentId)
        {
            return _studentRepository.GetSubjectForComboBox(StudentId);
        }

        public DataTable GetClasses(int SubjectId)
        {
            return _studentRepository.GetClasses(SubjectId);
        }
    }
}
