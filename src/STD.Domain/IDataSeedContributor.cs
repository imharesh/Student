using System;
using System.Threading.Tasks;
using STD.Students;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace STD
{
    public class STDDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Student, Guid> _studentRepository;

        public STDDataSeederContributor(IRepository<Student, Guid> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _studentRepository.GetCountAsync() > 0)
            {
                return;
            }

            await _studentRepository.InsertAsync(
                new Student
                {
                    Name = "Haresh",
                    Email = "h@abp.io",
                    RollNo = "20",
                    City = "Bhavnagar",
                    Branch = "CE"
                },
                autoSave: true
            );

            await _studentRepository.InsertAsync(
                new Student
                {
                    Name = "Chirag",
                    Email = "c@abp.io",
                    RollNo = "40",
                    City = "Vadodara",
                    Branch = "UX"
                },
                autoSave: true
            );
        }
    }
}
