using MediatR;
using StudentAPI.Application.Common.Interfaces.Persistence;
using StudentAPI.Application.Student.Response.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Commands.UpdateStudent
{
    public class TUpdateStudentCommandHandler : IRequestHandler<TUpdateStudentCommand, TUpdateStudentResult>
    {
        public ITStudentRepository StudentRepository;
        public TUpdateStudentCommandHandler(ITStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public async Task<TUpdateStudentResult> Handle(TUpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var result = await StudentRepository.UpdateStudent(request.StudentId, request.FirstName, request.LastName, request.College, request.City, request.Marks);
            return new TUpdateStudentResult(result);
        }
    }
}
