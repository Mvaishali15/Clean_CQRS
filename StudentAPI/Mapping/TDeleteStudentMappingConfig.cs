using Mapster;
using StudentAPI.Application.Student.Response.Commands;
using StudentAPI.Contract.Student.CreateStudent;
using StudentAPI.Contract.Student.DeleteStudent;

namespace StudentAPI.Mapping
{
    public class TDeleteStudentMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<TDeleteStudentResult, TDeleteStudentResponse>()
               .Map(dest => dest.Stu, src => src.Student);
        }
    }
}
