using System;
using Volo.Abp.Application.Dtos;


namespace STD.Students
{
    public class StudentDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Email { get; set; }


        public string RollNo { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }

    }
}
