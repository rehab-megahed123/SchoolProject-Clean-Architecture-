using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Repositories.Abstract;
using SchoolProject.Service.Abstract;

namespace SchoolProject.Service.Implementation
{
   
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public async Task<List<Student>> GetAllStudentsAync()
        {
            return await studentRepository.GetStudentsAsync();
        }
    }
}
