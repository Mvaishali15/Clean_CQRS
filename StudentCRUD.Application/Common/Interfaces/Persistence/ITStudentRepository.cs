using StudentAPI.Application.Student.Commands.CreateStudent;
using StudentAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Common.Interfaces.Persistence
{
    public interface ITStudentRepository
    {
        Task<IEnumerable<TStudent>> GetStudents();

        Task<TStudent> GetStudentById(int StudentId);

        //Task<TStudent?> CreateStudent(int StudentId, string FirstName, string LastName, string College, string City, int Marks);
        Task<TStudent?> CreateStudent(TCreateStudentCommand std);
        Task<TStudent?> DeleteStudent(int StudentId);
        Task<TStudent?> UpdateStudent(int StudentId, string FirstName, string LastName, string College, string City, int Marks);
    }
}
