using AutoMapper;
using Transflo.Entity.Driver;
using Transflo.Models;


public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TblDriver, DriverEntity>().ReverseMap();
    }
}
