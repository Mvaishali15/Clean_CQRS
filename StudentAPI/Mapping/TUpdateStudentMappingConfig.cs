using Mapster;
using StudentAPI.Application.Student.Response.Commands;
using StudentAPI.Contract.Student.CreateStudent;
using StudentAPI.Contract.Student.UpdateStudent;

namespace StudentAPI.Mapping
{
    public class TUpdateStudentMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<TUpdateStudentResult, TUpdateStudentResponse>()
                .Map(dest => dest.Stu, src => src.Student);
        }
    }
}
