using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private ISqlConnect _dbConnection;

        public NotesRepository(ISqlConnect dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable GetSubjectsForComboBox(int TeacherId)
        {
            DataTable subjectTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                	TeacherAndSubjectId AS Id,
                                	CONCAT(SU.SubjectName,' ',G.GradeName,' ',SE.SectionName) AS Materias
                                FROM TeacherAndSubjects AS TE
                                INNER JOIN Members AS ME ON TE.TeacherId=ME.MemberId
                                INNER JOIN Subjects AS SU ON TE.SubjectId=SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId=G.GradeId
								WHERE TE.TeacherId=@TeacherId";

                using (var reader = connection.ExecuteReader(query, new { TeacherId }))
                {
                    subjectTable.Load(reader);
                }
            }
            return subjectTable;
        }

        public DataTable GetStudentsForSubjects(int TeacherAndSubjectId)
        {
            DataTable studentTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                	N.NoteId AS Id,
                                	M.Names AS Nombres,
                                	M.LastNames AS Apellidos,
                                	CONCAT(SU.SubjectName,' ',G.GradeName,' ',SE.SectionName) AS Materia,
                                	N.Note1 AS 'priemer nota',
                                	N.Note2 AS 'Segunda nota',
                                	N.FinalNote as 'Nota Final'
                                FROM Notes AS N
                                INNER JOIN Enrollments AS EN ON N.EnrollmentsId=EN.EnrollmentsId
                                INNER JOIN Members AS M ON EN.StudentId=M.MemberId
                                INNER JOIN TeacherAndSubjects AS TE ON EN.SubjectId=TE.TeacherAndSubjectId
                                INNER JOIN Subjects AS SU ON TE.SubjectId=SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId=G.GradeId
                                WHERE TE.TeacherAndSubjectId=@TeacherAndSubjectId";

                using (var reader = connection.ExecuteReader(query, new { TeacherAndSubjectId }))
                {
                    studentTable.Load(reader);
                }
            }
            return studentTable;
        }

        public void EditNotes(Notes notes)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Notes SET
                                	Note1=@Note1,
                                	Note2=@Note2,
                                	FinalNote=@FinalNote
                                WHERE NoteId=@NoteId";

                connection.Execute(query, notes);
            }
        }

        public DataTable SearchStudent(int TeacherAndSubjectId, string SearchTerm)
        {
            DataTable studentTable = new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
            SELECT 
                N.NoteId AS Id,
                M.Names AS Nombres,
                M.LastNames AS Apellidos,
                CONCAT(SU.SubjectName, ' ', G.GradeName, ' ', SE.SectionName) AS Materia,
                N.Note1 AS 'Primer Nota',
                N.Note2 AS 'Segunda Nota',
                N.FinalNote 'AS Nota Final'
            FROM Notes AS N
            INNER JOIN Enrollments AS EN ON N.EnrollmentsId = EN.EnrollmentsId
            INNER JOIN Members AS M ON EN.StudentId = M.MemberId
            INNER JOIN TeacherAndSubjects AS TE ON EN.SubjectId = TE.TeacherAndSubjectId
            INNER JOIN Subjects AS SU ON TE.SubjectId = SU.SubjectId
            INNER JOIN Sections AS SE ON SU.SectionId = SE.SectionId
            INNER JOIN Grades AS G ON SE.GradeId = G.GradeId
            WHERE TE.TeacherAndSubjectId = @TeacherAndSubjectId
            AND (M.Names LIKE '%' + @SearchTerm + '%' OR M.LastNames LIKE '%' + @SearchTerm + '%')";

                using (var reader = connection.ExecuteReader(query, new { TeacherAndSubjectId, SearchTerm }))
                {
                    studentTable.Load(reader);
                }
            }
            return studentTable;
        }
    }

}
