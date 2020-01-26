using Abp.Application.Services;
using Abp.Domain.Repositories;
using maarif.myproject.Student.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace maarif.myproject.Student
{
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, long>,IStudentAppService
    {
        public StudentAppService(IRepository<Student, long> repository)
            : base(repository)
        {

        }

        public void CreateStudent(StudentDto input)
        {
        }
    }
}
