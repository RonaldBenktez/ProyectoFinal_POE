using System.Data;

namespace DataAccessLayer.Repositories
{
    public interface IStudentRepository
    {
        DataTable GetClasses(int SubjectId);
        DataTable GetNotes(int StudentId);
        DataTable GetSubjectForComboBox(int StudentId);
        DataTable GetSubjects(int StudentId);
    }
}