using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ClassesRepository : IClassesRepository
    {
        private ISqlConnect _dbConnection;

        public ClassesRepository(ISqlConnect dbconnection)
        {
            _dbConnection = dbconnection;
        }

        public DataTable GetClasses(int TeacherId)
        {
            DataTable classesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                            c.ClassID AS 'ID de Clase',                    
                            s.SubjectName AS 'Nombre de la Materia',
							g.GradeName AS 'Grado',
							se.SectionName AS 'Seccion',           
                            c.ClassContent AS 'Contenido de la Clase'      
                             FROM 
                                 Classes c
                             JOIN 
                                 Subjects s ON c.SubjectID = s.SubjectID 
						        JOIN 
						        	Sections se ON S.SectionId=se.SectionId
						        JOIN 
						        	Grades g ON se.GradeId=g.GradeId
                             JOIN 
                                 Members m ON c.TeacherID = m.MemberID

						        WHERE TeacherId=@TeacherId";

                using (var reader = connection.ExecuteReader(query, new { TeacherId }))
                {
                    classesTable.Load(reader);
                }

            }

            return classesTable;
        }

        public DataTable GetSubjects(int TeacherId)
        {
            DataTable subjectTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
                                    SU.SubjectId,
                                	SU.SubjectName AS Materia,
                                	G.GradeName AS Grado,
                                	SE.SectionName AS Seccion
                                FROM TeacherAndSubjects AS TS
                                INNER JOIN Subjects AS SU ON TS.SubjectId= SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId= G.GradeId
                                WHERE TS.TeacherId=@TeacherId";


                using (var reader = connection.ExecuteReader(query, new { TeacherId }))
                {
                    subjectTable.Load(reader);
                }
            }
            return subjectTable;
        }

        public DataTable GetStudentsForSubjects(int SubjectId)
        {
            DataTable studentsForSubjectsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
									SU.SubjectId 'Materia Id',
                                	ME.Names AS NOMBRE,
									ME.LastNames AS Apellidos,
									ME.MemberUser AS Usuario,
									ME.Phone AS Telefono,
									ME.Email AS Email
                                FROM Enrollments AS E
                                INNER JOIN TeacherAndSubjects AS TE ON E.SubjectId=TE.TeacherAndSubjectId
                                INNER JOIN Members AS ME ON E.StudentId=ME.MemberId
                                INNER JOIN Subjects AS SU ON TE.SubjectId=SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId=G.GradeId
								WHERE SU.SubjectId=@SubjectId";

                using (var reader = connection.ExecuteReader(query, new { SubjectId }))
                {
                    studentsForSubjectsTable.Load(reader);
                }

                return studentsForSubjectsTable;
            }
        }

        public DataTable GetSubjectsForComboBox(int TeacherId)
        {
            DataTable subjectsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
                                    SU.SubjectId AS Id,
									CONCAT(SU.SubjectName,' ',G.GradeNamE,' ',SE.SectionName) AS Materias
                                FROM TeacherAndSubjects AS TS
                                INNER JOIN Subjects AS SU ON TS.SubjectId= SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId= G.GradeId
                                WHERE TS.TeacherId=@TeacherId";

                using (var reader = connection.ExecuteReader(query, new { TeacherId }))
                {
                    subjectsTable.Load(reader);
                }

                return subjectsTable;
            }
        }

        public void AddClass(Classes classAdded)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Classes
                                VALUES(@SubjectId,@TeacherId,@Content)";

                connection.Query<Classes>(query, new
                {
                    classAdded.SubjectId,
                    classAdded.TeacherId,
                    classAdded.Content,
                });
            }
        }

        public void EditClass(Classes classEdited)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Classes 
                                SET SubjectId = @SubjectId,
                                    TeacherId = @TeacherId,
                                    ClassContent = @Content
                                WHERE ClassId = @ClassId";

                connection.Query<Classes>(query, new
                {
                    classEdited.ClassId,
                    classEdited.SubjectId,
                    classEdited.TeacherId,
                    classEdited.Content,
                });
            }
        }

        public void DeleteClass(int ClassId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE Classes WHERE ClassId=@ClassId";

                connection.Execute(query, new { ClassId });
            }
        }

    }
}
