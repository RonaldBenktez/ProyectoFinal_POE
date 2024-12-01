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
    public class StudentRepository : IStudentRepository
    {
        private ISqlConnect _dbConnection;

        public StudentRepository(ISqlConnect dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable GetSubjects(int StudentId)
        {
            DataTable subjectsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                	EN.EnrollmentsId AS Id,
                                	CONCAT(ME.Names,' ',ME.LastNames) AS Docente,
                                	SU.SubjectName AS Materia,
                                	G.GradeName AS Grado,
                                	SE.SectionName AS Seccion
                                FROM Enrollments AS EN
                                INNER JOIN TeacherAndSubjects AS TE ON EN.SubjectId=TE.TeacherAndSubjectId
                                INNER JOIN Members AS ME ON TE.TeacherId=ME.MemberId
                                INNER JOIN Subjects AS SU ON TE.SubjectId=SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId=G.GradeId
                                WHERE StudentId=@StudentId";

                using (var reader = connection.ExecuteReader(query, new { StudentId }))
                {
                    subjectsTable.Load(reader);
                }
            }
            return subjectsTable;
        }

        public DataTable GetNotes(int StudentId)
        {
            DataTable notesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                           	N.NoteId AS Id,
                           	CONCAT(SU.SubjectName,' ',G.GradeName,' ',SE.SectionName) AS Materia,
                           	N.Note1 AS 'Primer Nota',
                           	N.Note2 AS 'Segunda Nota',
                           	N.FinalNote 'AS NotaFinal'
                           FROM Notes AS N
                           INNER JOIN Enrollments AS EN ON N.EnrollmentsId=EN.EnrollmentsId
                           INNER JOIN Members AS M ON EN.StudentId=M.MemberId
                           INNER JOIN TeacherAndSubjects AS TE ON EN.SubjectId=TE.TeacherAndSubjectId
                           INNER JOIN Subjects AS SU ON TE.SubjectId=SU.SubjectId
                           INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                           INNER JOIN Grades AS G ON SE.GradeId=G.GradeId
                           WHERE StudentId=@StudentId";

                using (var reader = connection.ExecuteReader(query, new { StudentId }))
                {
                    notesTable.Load(reader);
                }
            }
            return notesTable;
        }

        public DataTable GetSubjectForComboBox(int StudentId)
        {
            DataTable subjectsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                	SU.SubjectId AS Id,
                                	CONCAT(SU.SubjectName,' ',G.GradeName,' ', SE.SectionName,' : Con ',  ME.Names,' ',ME.LastNames) AS Materias
                                FROM Enrollments AS EN
                                INNER JOIN TeacherAndSubjects AS TE ON EN.SubjectId=TE.TeacherAndSubjectId
                                INNER JOIN Members AS ME ON TE.TeacherId=ME.MemberId
                                INNER JOIN Subjects AS SU ON TE.SubjectId=SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId=G.GradeId
                                WHERE EN.StudentId=@StudentId";

                using (var reader = connection.ExecuteReader(query, new { StudentId }))
                {
                    subjectsTable.Load(reader);
                }

            }

            return subjectsTable;
        }

        public DataTable GetClasses(int SubjectId)
        {
            DataTable classesTable = new DataTable();

            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                	SU.SubjectName AS Materia,
                                	G.GradeName AS Grado,
                                	SE.SectionName AS Seccion,
                                	ClassContent AS 'Contenido de la clase'
                                FROM Classes AS CL
                                INNER JOIN Subjects AS SU ON CL.SubjectId=SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId=G.GradeId
                                WHERE CL.SubjectId=@SubjectId";

                using (var reader = connection.ExecuteReader(query, new { SubjectId }))
                {
                    classesTable.Load(reader);
                }
            }
            return classesTable;
        }
    }
}
