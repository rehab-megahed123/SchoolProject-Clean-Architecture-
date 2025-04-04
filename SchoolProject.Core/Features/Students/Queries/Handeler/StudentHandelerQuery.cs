using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstract;

namespace SchoolProject.Core.Features.Students.Queries.Handeler
{
    public class StudentHandelerQuery : IRequestHandler<GetStudentListQuery, List<GetStudentListResponse>>
    {

        private readonly IStudentService studentService;
        private readonly IMapper mapper;

        public StudentHandelerQuery(IStudentService studentService,IMapper mapper)
        {
            this.studentService = studentService;
            this.mapper = mapper;
        }
        public async  Task<List<GetStudentListResponse>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
              var studentList= await studentService.GetAllStudentsAync();
              var studentListMapper = mapper.Map<List<GetStudentListResponse>>(studentList);
              return studentListMapper;
        }
    }

}
