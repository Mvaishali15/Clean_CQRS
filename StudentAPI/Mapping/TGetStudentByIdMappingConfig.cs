using Mapster;
using StudentAPI.Application.Student.Response.Queries;
using StudentAPI.Contract.Student.GetStudentById;
using StudentAPI.Contract.Student.GetStudents;

namespace StudentAPI.Mapping
{
    public class TGetStudentByIdMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<TGetStudentByIdResult, TGetStudentByIdResponse>()
               .Map(dest => dest.Stu, src => src.Student);
        }
    }
}
