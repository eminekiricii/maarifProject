using Abp.Application.Services;
using maarif.myproject.Student.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace maarif.myproject.Student
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto,long>
    {
        public void CreateStudent(StudentDto input);
    }
}
