using Mapster;
using StudentAPI.Application.Student.Response.Commands;
using StudentAPI.Application.Student.Response.Queries;
using StudentAPI.Contract.Student.CreateStudent;
using StudentAPI.Contract.Student.GetStudents;

namespace StudentAPI.Mapping
{
    public class TCreateStudentConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<TCreateStudentResult, TCreateStudentResponse>()
               .Map(dest => dest.Stu, src => src.Student);
        }
    }
}
