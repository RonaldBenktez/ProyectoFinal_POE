using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EnrollStudentRepository : IEnrollStudentRepository
    {
        private ISqlConnect _dbConnection;

        public EnrollStudentRepository(ISqlConnect dbconnection)
        {
            _dbConnection = dbconnection;
        }

        public DataTable GetAlllStudents()
        {
            DataTable StudentsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    MemberId AS ID,
                                	Names AS Nombre,
                                	LastNames AS Apellidos,
                                	MemberUser AS Usuario,
                                	Phone AS Telefono,
                                	Email
                                FROM Members
                                WHERE RolId=2";

                using (var reader = connection.ExecuteReader(query))
                {

                    StudentsTable.Load(reader);
                }
            }

            return StudentsTable;
        }

        public DataTable GetSubjectsForStudent(int StudentId)
        {
            DataTable SubjectsTable = new DataTable();
            
            using(var  connection = _dbConnection.GetConnection())
            {
                string query = @"select 
                                    E.EnrollmentsId AS Id,
                                	CONCAT(SU.SubjectName,' ',G.GradeName,' ', SE.SectionName) AS Materia,
                                	CONCAT(ME.Names,' ', ME.LastNames) AS Docente
                                FROM Enrollments AS E
                                INNER JOIN TeacherAndSubjects AS TE ON E.SubjectId=TE.TeacherAndSubjectId
                                INNER JOIN Members AS ME ON TE.TeacherId=ME.MemberId
                                INNER JOIN Subjects AS SU ON TE.SubjectId=SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId=G.GradeId
                                WHERE StudentId=@StudentId";

                var parameters = new { StudentId };

                using (var reader = connection.ExecuteReader(query, parameters))
                {

                    SubjectsTable.Load(reader);
                }

                return SubjectsTable;
            }
        }

        public DataTable GetSubjectsForComboBox()
        {
            DataTable subjectTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                	TeacherAndSubjectId AS Id,
                                	CONCAT(SU.SubjectName,' ',G.GradeName,' ',SE.SectionName,' : Con ', ME.Names) AS Materias
                                FROM TeacherAndSubjects AS TE
                                INNER JOIN Members AS ME ON TE.TeacherId=ME.MemberId
                                INNER JOIN Subjects AS SU ON TE.SubjectId=SU.SubjectId
                                INNER JOIN Sections AS SE ON SU.SectionId=SE.SectionId
                                INNER JOIN Grades AS G ON SE.GradeId=G.GradeId";

                using (var reader = connection.ExecuteReader(query))
                {
                    subjectTable.Load(reader);
                }
            }
            return subjectTable;
        }

        public int AddEnrollStudent(int StudentId, int SubjectId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
            INSERT INTO Enrollments (StudentId, SubjectId)
            VALUES (@StudentId, @SubjectId);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                int enrollmentId = connection.QuerySingle<int>(query, new { StudentId, SubjectId });
                return enrollmentId;
            }
        }

        public void EditEnrollStudent(int EnrollmentId, int SubjectId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Enrollments SET SubjectId=@SubjectId Where EnrollmentsId=@EnrollmentId";

                connection.Execute(query, new { EnrollmentId, SubjectId });
            }
        }

        public void DeleteEnrollStudent(int EnrollmentId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"Delete Enrollments WHERE EnrollmentsId=@EnrollmentId";

                connection.Execute(query, new { EnrollmentId});
            }
        }

        public DataTable SearchStudent(string SearchTerm)
        {
            DataTable SearchStudentsTable= new DataTable();

            using( var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    MemberId AS ID,
                                    Names AS Nombre,
                                    LastNames AS Apellidos,
                                    MemberUser AS Usuario,
                                    Phone AS Telefono,
                                    Email
                                FROM 
                                    Members
                                WHERE 
                                    RolId = 2 
                                    AND 
                                    (Names LIKE '%' + @SearchTerm + '%' OR LastNames LIKE '%' + @SearchTerm + '%')";

                var parameters = new { SearchTerm };

                using (var reader = connection.ExecuteReader(query, parameters))
                {
                    SearchStudentsTable.Load(reader);
                }
            }
            return SearchStudentsTable;
        }

        public void AddStudentNotes(int EnrollmentsId)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Notes(EnrollmentsId)
                                 VALUES (@EnrollmentsId)";

                connection.Execute(query, new { EnrollmentsId });
            }
        }

    }
}
