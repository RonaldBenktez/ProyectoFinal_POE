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
    public class NotesServices : INotesServices
    {
        private INotesRepository _notesRepository;

        public NotesServices(INotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        public DataTable GetSubjectsForComboBox(int TeacherId)
        {
            return _notesRepository.GetSubjectsForComboBox(TeacherId);
        }

        public DataTable GetStudentsForSubjects(int TeacherAndSubjectId)
        {
            return _notesRepository.GetStudentsForSubjects(TeacherAndSubjectId);
        }

        public void EditNotes(Notes notes)
        {
            _notesRepository.EditNotes(notes);
        }

        public DataTable SearchStudent(int TeacherAndSubjectId, string SearchTerm)
        {
           return  _notesRepository.SearchStudent(TeacherAndSubjectId, SearchTerm);
        }
    }
}
