using CommonLayer.Entities;
using System.Data;

namespace BusinessLayer.Services
{
    public interface IClassesServices
    {
        void AddClass(Classes classAdded);
        void DeleteClass(int ClassId);
        void EditClass(Classes classEdited);
        DataTable GetClasses(int TeacherId);
        DataTable GetStudentsForSubjects(int SubjectId);
        DataTable GetSubjects(int TeacherId);
        DataTable GetSubjectsForComboBox(int TeacherId);
    }
}