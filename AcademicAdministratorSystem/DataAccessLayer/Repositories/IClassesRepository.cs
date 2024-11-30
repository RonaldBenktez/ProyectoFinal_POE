using CommonLayer.Entities;
using System.Data;

namespace DataAccessLayer.Repositories
{
    public interface IClassesRepository
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