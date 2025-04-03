using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstract;

namespace SchoolProject.Core.Features.Students.Queries.Handeler
{
    public class StudentHandelerQuery : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentService studentService;

        public StudentHandelerQuery(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public async  Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
          return await studentService.GetAllStudentsAync();
        }
    }

}
