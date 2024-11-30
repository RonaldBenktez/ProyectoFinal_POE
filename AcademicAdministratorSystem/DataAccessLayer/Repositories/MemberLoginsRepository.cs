using DataAccessLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using Dapper;

namespace DataAccessLayer.Repositories
{
    public class MemberLoginsRepository : IMembersLoginRepository
    {
        private ISqlConnect _dbConnection;

        public MemberLoginsRepository(ISqlConnect dbconnection)
        {
            _dbConnection = dbconnection;
        }

        //metoedo para crear un objeto con los atributos del empleado usando dapper

        public Members FindUser(Members mebersInput)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
               		M.MemberId,
               		R.RolId, 
               		M.Names,
               		M.LastNames,
               		M.MemberUser,
               		M.Password,
               		M.Email,
               		M.Phone,
               		M.DateEntry
                FROM Members AS M
                INNER JOIN Roles AS R 
                ON M.RolId=R.RolId
                WHERE MemberUser=@MemberUser";


                return connection.QueryFirstOrDefault<Members>(query, new { mebersInput.MemberUser });
            }
        }
    }
}

