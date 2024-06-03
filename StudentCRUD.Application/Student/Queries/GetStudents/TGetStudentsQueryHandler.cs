using MediatR;
using StudentAPI.Application.Common.Interfaces.Persistence;
using StudentAPI.Application.Student.Response.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Queries.GetStudents
{
    public class TGetStudentsQueryHandler : IRequestHandler<TGetStudentsQuery, TGetStudentsResult>
    {
        public readonly ITStudentRepository _studentRepository;

        public TGetStudentsQueryHandler(ITStudentRepository tStudentRepository)
        {
            _studentRepository = tStudentRepository;
        }
        public async Task<TGetStudentsResult> Handle(TGetStudentsQuery request, CancellationToken cancellationToken)
        {
            var result = await _studentRepository.GetStudents();

            return new TGetStudentsResult(result);
        }
    }
}
