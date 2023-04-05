using AutoMapper;
using STD.Students;

namespace STD;

public class STDApplicationAutoMapperProfile : Profile
{
    public STDApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();
    }
}
