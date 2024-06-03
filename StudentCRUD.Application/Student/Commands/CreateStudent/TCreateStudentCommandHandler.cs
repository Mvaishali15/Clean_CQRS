using MediatR;
using StudentAPI.Application.Common.Interfaces.Persistence;
using StudentAPI.Application.Student.Response.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Commands.CreateStudent
{
    public class TCreateStudentCommandHandler : IRequestHandler<TCreateStudentCommand, TCreateStudentResult>
    {
        public ITStudentRepository StudentRepository;
        public TCreateStudentCommandHandler(ITStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }
        public async Task<TCreateStudentResult> Handle(TCreateStudentCommand request, CancellationToken cancellationToken)
        {
            var result = await StudentRepository.CreateStudent(request);
            return new TCreateStudentResult(result);
        }
    }
}
