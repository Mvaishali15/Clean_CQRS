using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Contract.Student.DeleteStudent
{
    public record TDeleteStudentResponse(DeleteStudent Stu);
    public record DeleteStudent(
        int StudentId,
        string FirstName,
        string LastName,
        string College,
        string City,
        int Marks
    );
}
