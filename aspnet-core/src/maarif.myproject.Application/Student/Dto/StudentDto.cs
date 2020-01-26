using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace maarif.myproject.Student.Dto
{
    public class StudentDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string ExtensionData { get; set; }
    }
}
