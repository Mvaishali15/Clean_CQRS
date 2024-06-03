using Dapper;
using StudentAPI.Application.Common.Interfaces.Persistence;
using StudentAPI.Application.Student.Commands.CreateStudent;
using StudentAPI.Domain.Models;
using StudentAPI.Infrastructure.DbContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Infrastructure.Presistence
{
    public class TStudentRepository : ITStudentRepository
    {
        private readonly DapperContext _context;

        public TStudentRepository(DapperContext context)
        {
            _context = context;
        }

        //public async Task<TStudent?> CreateStudent(int StudentId, string FirstName, string LastName, string College, string City, int Marks)
        //{
        //    using (var db = _context.CreateConnection())
        //    {
        //        try
        //        {
        //            DynamicParameters parameters = new DynamicParameters();
        //            parameters.Add("@firstName", FirstName);
        //            parameters.Add("@lastName", LastName);
        //            parameters.Add("@college", College);
        //            parameters.Add("@city", City);
        //            parameters.Add("@marks", Marks);
        //            var result = await db.QuerySingleOrDefaultAsync<TStudent>("CreateStudent", parameters, commandType: CommandType.StoredProcedure);
        //            return result;
        //        }
        //        catch (Exception)
        //        {
        //            return null;
        //        }
        //    }
        //}

        public async Task<TStudent?> CreateStudent(TCreateStudentCommand stu)
        {
            using (var db = _context.CreateConnection())
            {
                try
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@firstName", stu.FirstName);
                    parameters.Add("@lastName", stu.LastName);
                    parameters.Add("@college", stu.College);
                    parameters.Add("@city", stu.City);
                    parameters.Add("@marks", stu.Marks);
                    var result = await db.QuerySingleOrDefaultAsync<TStudent>("CreateStudent", parameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async Task<TStudent?> DeleteStudent(int StudentId)
        {
            using (var db = _context.CreateConnection())
            {
                try
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@studentId", StudentId, DbType.Int32);

                    return await db.QuerySingleOrDefaultAsync<TStudent>("DeleteStudent", parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async Task<TStudent> GetStudentById(int StudentId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@studentId", StudentId, DbType.Int32);
            using (var db = _context.CreateConnection())
            {
                return await db.QuerySingleAsync<TStudent>("GetStuById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<TStudent>> GetStudents()
        {
            using (var db = _context.CreateConnection())
            {
                return await db.QueryAsync<TStudent>("GetStudents", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<TStudent?> UpdateStudent(int StudentId, string FirstName, string LastName, string College, string City, int Marks)
        {
            using (var db = _context.CreateConnection())
            {
                try
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@studentId", StudentId, DbType.Int32);
                    parameters.Add("@firstName", FirstName);
                    parameters.Add("@lastName", LastName);
                    parameters.Add("@college", College);
                    parameters.Add("@city", City);
                    parameters.Add("@marks", Marks);
                    var result = await db.QuerySingleOrDefaultAsync<TStudent>("EditStudent", parameters, commandType: CommandType.StoredProcedure);
                    return result;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
