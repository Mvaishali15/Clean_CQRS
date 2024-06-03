using Mapster;
using StudentAPI.Application.Student.Response.Queries;
using StudentAPI.Contract.Student.GetStudents;

namespace StudentAPI.Mapping
{
    public class TGetStudentsMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<TGetStudentsResult, TGetStudentsResponse>()
                .Map(dest => dest.Students, src => src.Stu);
        }
    }
}
