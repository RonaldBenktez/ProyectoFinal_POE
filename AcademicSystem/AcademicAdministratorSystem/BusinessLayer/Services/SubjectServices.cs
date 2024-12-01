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
    public class SubjectServices : ISubjectServices
    {
        private ISubjectRepository _subjectRepository;

        public SubjectServices(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public DataTable GetGrades()
        {
            return _subjectRepository.GetGrades();
        }

        public void AddGrade(string gradeName)
        {
            _subjectRepository.AddGrade(gradeName);
        }

        public void EditGrade(int gradeId, string gradeName)
        {
            _subjectRepository.EditGrade(gradeId, gradeName);
        }

        public DataTable GetSections()
        {
            return _subjectRepository.GetSections();
        }

        public void AddSection(string sectionName, int gradeId)
        {
            _subjectRepository.AddSection(sectionName, gradeId);
        }
        public void UpdateSection(int sectionId, string sectionName, int gradeId)
        {
            _subjectRepository.UpdateSection(sectionId, sectionName, gradeId);
        }

       public  DataTable GetSubjects()
        {
            return _subjectRepository.GetSubjects();
        }

        public DataTable GetSectionsforCombobox()
        {
            return _subjectRepository.GetSectionsforCombobox();
        }

        public void AddSubject(Subjects subject)
        {
            _subjectRepository.AddSubject(subject);
        }

        public void EditSubject(Subjects subjectEdited)
        {
            _subjectRepository.EditSubject(subjectEdited);
        }

        public void DeleteSubject(int subjectId)
        {
            _subjectRepository.DeleteSubject(subjectId);
        }

        public DataTable GetTeacherAndSubjects()
        {
           return  _subjectRepository.GetTeacherAndSubject();
        }

        public DataTable GetTeachers()
        {
            return _subjectRepository.GetTeachers();
        }

        public DataTable GetSubjectForComboBox()
        {
            return _subjectRepository.GetSubjectsForComboBox();
        }

        public void AddTeacherAndSubject(int teacherId,int subjectId)
        {
            _subjectRepository.AddTeacherAndSubject(teacherId,subjectId);
        }

        public void EditTacherAndSubject(int teacherAndSubjectId, int teacherId, int subjectId)
        {
            _subjectRepository.EditTeacherAndSubject(teacherAndSubjectId,teacherId,subjectId);
        }

        public void DeleteTeacherAndSubject(int TeacherAndSubjectId)
        {
            _subjectRepository.DeleteTeacherAndSubject(TeacherAndSubjectId);
        }
    }
}
