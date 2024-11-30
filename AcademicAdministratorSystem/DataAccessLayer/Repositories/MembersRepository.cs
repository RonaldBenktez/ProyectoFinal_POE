
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class MembersRepository : IMembersRepository
    {
        private ISqlConnect _dbConnection;

        public MembersRepository(ISqlConnect dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable GetAllMembers()
        {
            DataTable membersTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                        	M.MemberId AS Id,
                        	R.RoleType AS Rol,
                        	M.Names AS Nombres,
                        	M.LastNames AS Apellidos,
                        	M.MemberUser AS Usuario,
                        	M.Password AS Contraseña,
                        	M.Email AS Email,
                        	M.Phone AS Telefono,
                        	CONVERT(varchar, M.DateEntry, 23) AS 'Fecha de registro'
                        FROM Members AS M
                        INNER JOIN Roles AS	R
                        ON M.RolId=R.RolId";


                using (var reader = connection.ExecuteReader(query))
                {

                    membersTable.Load(reader);
                }
            }

            return membersTable;
        }

        public DataTable GEtEstudentsOrTeachers(int rolId)
        {
            DataTable membersTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                        	M.MemberId AS Id,
                        	R.RoleType AS Rol,
                        	M.Names AS Nombres,
                        	M.LastNames AS Apellidos,
                        	M.MemberUser AS Usuario,
                        	M.Password AS Contraseña,
                        	M.Email AS Email,
                        	M.Phone AS Telefono,
                        	CONVERT(varchar, M.DateEntry, 23) AS 'Fecha de registro'
                        FROM Members AS M
                        INNER JOIN Roles AS	R
                        ON M.RolId=R.RolId
                    WHERE R.RolId=@rolId";

                var parameters = new { rolId };

                using (var reader = connection.ExecuteReader(query, parameters))
                {

                    membersTable.Load(reader);
                }
            }

            return membersTable;
        }

        public DataTable SearchMember(string searchTerm)
        {
            DataTable membersTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                            M.MemberId AS Id,
                            R.RoleType AS Rol,
                            M.Names AS Nombres,
                            M.LastNames AS Apellidos,
                            M.MemberUser AS Usuario,
                            M.Password AS Contraseña,
                            M.Email AS Email,
                            M.Phone AS Telefono,
                            CONVERT(varchar, M.DateEntry, 23) AS 'Fecha de registro'
                        FROM Members AS M
                        INNER JOIN Roles AS R
                        ON M.RolId = R.RolId
                        WHERE 
                            M.Names LIKE '%' + @searchTerm + '%' OR
                            M.LastNames LIKE '%' + @searchTerm + '%' OR
                            M.MemberUser LIKE '%' + @searchTerm + '%'";

                // Crear un objeto de parámetros
                var parameters = new { searchTerm };

                using (var reader = connection.ExecuteReader(query, parameters))
                {
                    membersTable.Load(reader);
                }
            }

            return membersTable;
        }

        public DataTable GetRoles()
        {
            DataTable rolesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT RolId,RoleType AS 'Roles' FROM Roles";

                using (var reader = connection.ExecuteReader(query))
                {
                    rolesTable.Load(reader);
                }
            }

            return rolesTable;
        }

        public void AddMembers(Members memberAddData)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Members (RolId, Names, LastNames, MemberUser, Password, Email, Phone, DateEntry)
                 VALUES (@RolId, @Names, @LastNames, @MemberUser, @Password, @Email, @Phone, @DateEntry)";

                connection.Query(query, new
                {
                    memberAddData.RolId,
                    memberAddData.Names,
                    memberAddData.LastNames,
                    memberAddData.MemberUser,
                    memberAddData.Password,
                    memberAddData.Email,
                    memberAddData.Phone,
                    memberAddData.DateEntry
                });
            }
        }

        public void EditMember(Members memberEdited)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Members
                 SET RolId = @RolId, 
                     Names = @Names, 
                     LastNames = @LastNames, 
                     MemberUser = @MemberUser, 
                     Password = @Password, 
                     Email = @Email, 
                     Phone = @Phone, 
                     DateEntry = @DateEntry
                 WHERE MemberId = @MemberId";

                connection.Query<Members>(query,
                    new
                    {
                        memberEdited.MemberId,
                        memberEdited.RolId,
                        memberEdited.Names,
                        memberEdited.LastNames,
                        memberEdited.MemberUser,
                        memberEdited.Password,
                        memberEdited.Email,
                        memberEdited.Phone,
                        memberEdited.DateEntry
                    });
            }
        }

        public void DeleteMember(int MemberId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Members WHERE MemberId = @MemberId";

                connection.Query<Members>(query, new { MemberId });
            }
        }
    }
}


