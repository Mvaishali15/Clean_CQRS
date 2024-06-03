using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Contract.Student.GetStudentById
{
    public record TGetStudentByIdResponse(GetSingleStudent Stu);
    public record GetSingleStudent(
        int StudentId,
        string FirstName,
        string LastName
        //string College,
        //string City,
        //int Marks
    );
}
