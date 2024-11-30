using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class EnrollStudentServices : IEnrollStudentServices
    {
        private IEnrollStudentRepository _enrollStudentRepository;

        public EnrollStudentServices(IEnrollStudentRepository enrollStudentRepository)
        {
            _enrollStudentRepository = enrollStudentRepository;
        }

        public DataTable GetAllStudents()
        {
            return _enrollStudentRepository.GetAlllStudents();
        }

        public DataTable GetSubjectsForStudent(int StudentId)
        {
            return _enrollStudentRepository.GetSubjectsForStudent(StudentId);
        }

        public DataTable GetSubjectsForComboBox()
        {
            return _enrollStudentRepository.GetSubjectsForComboBox();
        }
            
        public int AddEnrollStudent(int studentId,int subjectId)
        {
            return _enrollStudentRepository.AddEnrollStudent(studentId,subjectId); 
        }

        public void EditEnrollStudent(int EnrollmentId, int SubjectId)
        {
            _enrollStudentRepository.EditEnrollStudent(EnrollmentId, SubjectId);
        }

        public void DeleteEnrollStudent(int EnrollmentId)
        {
            _enrollStudentRepository.DeleteEnrollStudent(EnrollmentId);
        }

        public DataTable SearchStudent(string SearchTerm)
        {
            return _enrollStudentRepository.SearchStudent(SearchTerm);
        }
        public void AddStudentNotes(int EnrollmentsId)
        {
            _enrollStudentRepository.AddStudentNotes(EnrollmentsId);
        }
    }
}
