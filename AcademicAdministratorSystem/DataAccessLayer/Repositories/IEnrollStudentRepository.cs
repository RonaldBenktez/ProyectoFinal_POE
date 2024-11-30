using System.Data;

namespace DataAccessLayer.Repositories
{
    public interface IEnrollStudentRepository
    {
        int AddEnrollStudent(int StudentId, int SubjectId);
        void AddStudentNotes(int EnrollmentsId);
        void DeleteEnrollStudent(int EnrollmentId);
        void EditEnrollStudent(int EnrollmentId, int SubjectId);
        DataTable GetAlllStudents();
        DataTable GetSubjectsForComboBox();
        DataTable GetSubjectsForStudent(int StudentId);
        DataTable SearchStudent(string SearchTerm);
    }
}