using System.Data;

namespace BusinessLayer.Services
{
    public interface IStudentServices
    {
        DataTable GetClasses(int SubjectId);
        DataTable GetNotes(int StudentId);
        DataTable GetSubjectForComboBox(int StudentId);
        DataTable GetSubjects(int StudentId);
    }
}