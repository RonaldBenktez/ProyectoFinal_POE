using CommonLayer.Entities;
using System.Data;

namespace BusinessLayer.Services
{
    public interface ISubjectServices
    {
        void AddGrade(string gradeName);
        DataTable GetGrades();
        void EditGrade(int gradeId, string gradeName);

        DataTable GetSections();

        void AddSection(string sectionName, int gradeId);

        void UpdateSection(int sectionId, string sectionName, int gradeId);

        DataTable GetSubjects();

        DataTable GetSectionsforCombobox();

        void AddSubject(Subjects subject);

        void EditSubject(Subjects subjectEdited);

        void DeleteSubject(int subjectId);
        DataTable GetTeacherAndSubjects();
        DataTable GetTeachers();
        DataTable GetSubjectForComboBox();
        void AddTeacherAndSubject(int teacherId, int subjectId);
        void EditTacherAndSubject(int teacherAndSubjectId, int teacherId, int subjectId);
        void DeleteTeacherAndSubject(int TeacherAndSubjectId);
    }
}