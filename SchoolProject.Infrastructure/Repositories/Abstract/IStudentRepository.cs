﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Data.Entities;

namespace SchoolProject.Infrastructure.Repositories.Abstract
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudentsAsync();

    }
}
