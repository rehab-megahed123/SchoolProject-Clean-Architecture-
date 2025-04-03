using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.ApplicationDBContext;
using SchoolProject.Infrastructure.Repositories.Abstract;

namespace SchoolProject.Infrastructure.Repositories.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext context;

        
        public StudentRepository(ApplicationDbContext _context)
        {
            context = _context;
            
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
           return await context.Students.ToListAsync();
        }

    }
}
