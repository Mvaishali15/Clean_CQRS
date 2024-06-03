using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Contract.Student.CreateStudent
{
    public record TCreateStudentResponse(NewStudent Stu);

    public record NewStudent(
        int StudentId,
        string FirstName,
        string LastName,
        string College,
        string City,
        int Marks
    );
}
