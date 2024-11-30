using CommonLayer.Entities;
using System.Data;

namespace BusinessLayer.Services
{
    public interface INotesServices
    {
        void EditNotes(Notes notes);
        DataTable GetStudentsForSubjects(int TeacherAndSubjectId);
        DataTable GetSubjectsForComboBox(int TeacherId);
        DataTable SearchStudent(int TeacherAndSubjectId, string SearchTerm);
    }
}