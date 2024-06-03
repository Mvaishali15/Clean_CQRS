using MediatR;
using StudentAPI.Application.Common.Interfaces.Persistence;
using StudentAPI.Application.Student.Queries.GetStudents;
using StudentAPI.Application.Student.Response.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Queries.GetStudentById
{
    public class TGetStudentByIdQueryHandler : IRequestHandler<TGetStudentByIdQuery, TGetStudentByIdResult>
    {
        private readonly ITStudentRepository studentRepository;

        public TGetStudentByIdQueryHandler(ITStudentRepository studentRepository) {
            this.studentRepository = studentRepository;
        }
        public async Task<TGetStudentByIdResult> Handle(TGetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await studentRepository.GetStudentById(request.StudentId);

            return new TGetStudentByIdResult(result);
        }
    }
}
