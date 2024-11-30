using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BusinessLayer.Services
{
    public class ClassesServices : IClassesServices
    {
        private IClassesRepository _classesRepository;

        public ClassesServices(IClassesRepository classesRepository)
        {
            _classesRepository = classesRepository;
        }

        public DataTable GetClasses(int TeacherId)
        {
            return _classesRepository.GetClasses(TeacherId);
        }

        public DataTable GetSubjects(int TeacherId)
        {
            return _classesRepository.GetSubjects(TeacherId);
        }
        public DataTable GetStudentsForSubjects(int SubjectId)
        {
            return _classesRepository.GetStudentsForSubjects(SubjectId);
        }

        public DataTable GetSubjectsForComboBox(int TeacherId)
        {
           return  _classesRepository.GetSubjectsForComboBox(TeacherId);
        }

        public void AddClass(Classes classAdded)
        {
            _classesRepository.AddClass(classAdded);
        }

        public void EditClass(Classes classEdited)
        {
            _classesRepository.EditClass(classEdited);
        }

        public void DeleteClass(int ClassId)
        {
            _classesRepository.DeleteClass(ClassId);
        }

    }
}
