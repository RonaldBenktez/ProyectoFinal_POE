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
    public class SubjectRepository : ISubjectRepository
    {
        private ISqlConnect _dbConnection;

        public SubjectRepository(ISqlConnect dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable GetGrades()
        {
            DataTable gradesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                        	GradeId AS ID,
                            GradeName AS Grado
                        FROM Grades";


                using (var reader = connection.ExecuteReader(query))
                {

                    gradesTable.Load(reader);
                }
            }

            return gradesTable;
        }

        public void AddGrade(string gradeName)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Grades (GradeName)
                         VALUES (@GradeName)";

                // Ejecutar la consulta, pasando el parámetro GradeName
                connection.Execute(query, new { GradeName = gradeName });
            }
        }

        public void EditGrade(int gradeId, string gradeName)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Grades 
                         SET GradeName = @GradeName
                         WHERE GradeId = @GradeId";

                // Ejecutar la consulta, pasando el parámetro GradeName y GradeId
                connection.Execute(query, new { GradeName = gradeName, GradeId = gradeId });
            }
        }

        public DataTable GetSections()
        {
            DataTable sectionsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                Sections.SectionId AS ID,
	                            Grades.GradeName AS Grado,
                                Sections.SectionName AS Sección
                                 FROM 
                                 Sections
                                 JOIN 
                                Grades ON Sections.GradeId = Grades.GradeId";

                using (var reader = connection.ExecuteReader(query))
                {
                    sectionsTable.Load(reader); // Carga los resultados en el DataTable
                }
            }

            return sectionsTable;
        }

        public void AddSection(string sectionName, int gradeId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Sections (SectionName, GradeId)
                         VALUES (@SectionName, @GradeId)";

                // Ejecuta la consulta con los parámetros sectionName y gradeId
                connection.Execute(query, new { SectionName = sectionName, GradeId = gradeId });
            }
        }

        public void UpdateSection(int sectionId, string sectionName, int gradeId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Sections
                         SET SectionName = @SectionName,
                             GradeId = @GradeId
                         WHERE SectionId = @SectionId";

                // Ejecuta la consulta con los parámetros sectionId, sectionName y gradeId
                connection.Execute(query, new { SectionId = sectionId, SectionName = sectionName, GradeId = gradeId });
            }
        }

        public DataTable GetSubjects()
        {
            DataTable subjectsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                            SU.SubjectId as Id, 
                            SU.SubjectName as Materia, 
                            G.GradeName as Grado,
                            SE.SectionName as Seccion,
                            SU.Year  as año
                         FROM Subjects AS SU
                         INNER JOIN Sections AS SE
                             ON SU.SectionId = SE.SectionId
                         INNER JOIN Grades AS G
                             ON SE.GradeId = G.GradeId";

                using (var reader = connection.ExecuteReader(query))
                {
                    subjectsTable.Load(reader);  
                }
            }

            return subjectsTable;  
        }

        public DataTable GetSectionsforCombobox ()
        {
            DataTable sectionsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                  string query = @"SELECT 
                                 SE.SectionId AS ID,
                                 CONCAT (G.GradeName ,' ' ,SE.SectionName) AS Seccion
                             FROM Sections AS SE
                             INNER JOIN Grades AS G 
                                 ON SE.GradeId = G.GradeId";

                using (var reader = connection.ExecuteReader(query))
                {
                    sectionsTable.Load(reader);  
                }
            }

            return sectionsTable;  
        }

        public void AddSubject(Subjects subject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
            INSERT INTO Subjects (SubjectName, SectionId, Year)
            VALUES (@SubjectName, @SectionId, @Year)";

                // Ejecutar la consulta con los parámetros correspondientes
                connection.Execute(query, new
                {
                    SubjectName = subject.SubjectName,
                    SectionId = subject.SectionId,
                    Year = subject.Year
                });
            }
        }

        public void EditSubject(Subjects subjectEdited)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
            UPDATE Subjects
            SET 
                SubjectName = @SubjectName,
                SectionId = @SectionId,
                Year = @Year
            WHERE SubjectId = @SubjectId";  // Se asegura de que solo se actualice el registro correcto

                // Ejecutar la consulta con los parámetros correspondientes
                connection.Execute(query, new
                {
                    SubjectName = subjectEdited.SubjectName,
                    SectionId = subjectEdited.SectionId,
                    Year = subjectEdited.Year,
                    SubjectId = subjectEdited.SubjectId  // Se pasa el ID de la materia para identificar el registro
                });
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE FROM Subjects WHERE SubjectId = @SubjectId";

                connection.Execute(query, new { SubjectId = subjectId });
            }
        }

        public DataTable GetTeacherAndSubject()
        {
            DataTable teachersAndSubjectTable= new DataTable();
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    TS.TeacherAndSubjectId AS Id,
                                    CONCAT(M.Names,' ',M.LastNames) AS Docente,
                                    CONCAT(S.SubjectName,' ',G.GradeName,' ',Sec.SectionName) AS Materia
                                FROM TeacherAndSubjects AS TS
                                INNER JOIN Members AS M ON TS.TeacherId = M.MemberId
                                INNER JOIN Subjects AS S ON TS.SubjectId = S.SubjectId
                                INNER JOIN Sections AS Sec ON S.SectionId = Sec.SectionId
                                INNER JOIN Grades AS G ON SEC.GradeId=G.GradeId";

                using (var reader = connection.ExecuteReader(query))
                {
                    teachersAndSubjectTable.Load(reader);  
                }
            }
            return teachersAndSubjectTable;
        }

        public DataTable GetTeachers()
        {
            DataTable teachersTable = new DataTable();
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    MemberId AS Id,
                                	CONCAT(Names,' ',LastNames) AS Maestros
                                FROM Members 
                                WHERE RolId=1";

                using (var reader = connection.ExecuteReader(query))
                {
                    teachersTable.Load(reader);
                }
            }
            return teachersTable;
        }

        public DataTable GetSubjectsForComboBox()
        {
            DataTable subjectsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                            SU.SubjectId AS Id,
                            CONCAT(SU.SubjectName,' ', G.GradeName,' ',SE.SectionName) AS Materias
                         FROM Subjects AS SU
                         INNER JOIN Sections AS SE
                             ON SU.SectionId = SE.SectionId
                         INNER JOIN Grades AS G
                             ON SE.GradeId = G.GradeId";

                using (var reader = connection.ExecuteReader(query))
                {
                    subjectsTable.Load(reader);  
                }
            }

            return subjectsTable;  
        }

        public void AddTeacherAndSubject(int teacherId,int subjectId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO TeacherAndSubjects
                               values(@teacherId,@subjectId)";

                connection.Execute(query, new { teacherId, subjectId });
            }
        }

        public void EditTeacherAndSubject(int teacherAndSubjectId, int teacherId, int subjectId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE TeacherAndSubjects
                        SET TeacherId = @teacherId,
                            SubjectId = @subjectId
                        WHERE TeacherAndSubjectId = @teacherAndSubjectId";

                connection.Execute(query, new { teacherAndSubjectId, teacherId, subjectId });
            }
        }

        public void DeleteTeacherAndSubject(int TeacherAndSubjectId)
        {

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE TeacherAndSubjects  WHERE TeacherAndSubjectId = @teacherAndSubjectId ";

                connection.Execute(query, new { TeacherAndSubjectId });
            }
                
        }
    }
}
