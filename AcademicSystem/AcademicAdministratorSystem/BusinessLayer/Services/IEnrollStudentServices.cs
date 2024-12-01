using System.Data;

namespace BusinessLayer.Services
{
    public interface IEnrollStudentServices
    {
        int AddEnrollStudent(int studentId, int subjectId);
        void AddStudentNotes(int EnrollmentsId);
        void DeleteEnrollStudent(int EnrollmentId);
        void EditEnrollStudent(int EnrollmentId, int SubjectId);
        DataTable GetAllStudents();
        DataTable GetSubjectsForComboBox();
        DataTable GetSubjectsForStudent(int StudentId);
        DataTable SearchStudent(string SearchTerm);
    }
}