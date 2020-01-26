using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace maarif.myproject.Student
{
    public class Student:Entity<long>
    {
        public string Name { get; set; }

        public string ExtensionData { get; set; }

        public Student()
        {
        }
    }
}
