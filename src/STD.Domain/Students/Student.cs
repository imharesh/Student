using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace STD.Students
{
    public class Student : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

         public string Email { get; set; }


        public string RollNo  { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }



    }
}
