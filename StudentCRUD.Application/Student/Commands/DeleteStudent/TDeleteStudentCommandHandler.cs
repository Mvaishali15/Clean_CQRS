using MediatR;
using StudentAPI.Application.Common.Interfaces.Persistence;
using StudentAPI.Application.Student.Response.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Commands.DeleteStudent
{
    public class TDeleteStudentCommandHandler : IRequestHandler<TDeleteStudentCommand, TDeleteStudentResult>
    {

        public ITStudentRepository StudentRepository;
        public TDeleteStudentCommandHandler(ITStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public async Task<TDeleteStudentResult> Handle(TDeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var result = await StudentRepository.DeleteStudent(request.StudentId);

            return new TDeleteStudentResult(result);
        }
    }
}
