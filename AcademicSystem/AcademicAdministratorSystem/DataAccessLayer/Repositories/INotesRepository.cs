using CommonLayer.Entities;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public interface INotesRepository
    {
        void EditNotes(Notes notes);
        DataTable GetStudentsForSubjects(int TeacherAndSubjectId);
        DataTable GetSubjectsForComboBox(int TeacherId);
        DataTable SearchStudent(int TeacherAndSubjectId, string SearchTerm);
    }
}