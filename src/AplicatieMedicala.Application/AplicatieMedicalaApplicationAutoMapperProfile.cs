using AplicatieMedicala.Application.Contracts.Medici;
using AplicatieMedicala.Application.Contracts.Pacienti;
using AplicatieMedicala.Application.Contracts.Programari;
using AplicatieMedicala.Application.Contracts.Specializari;
using AplicatieMedicala.Domain.Entities;
using AutoMapper;



public class AplicatieMedicalaApplicationAutoMapperProfile : Profile
{
    public AplicatieMedicalaApplicationAutoMapperProfile()
    {
        CreateMap<Pacient, PacientDto>().ReverseMap();
        CreateMap<Pacient, CreateUpdatePacientDto>().ReverseMap();

        CreateMap<Medic, MedicDto>().ReverseMap();
        CreateMap<Specializare, SpecializareDto>().ReverseMap();

        CreateMap<Programare, ProgramareDto>().ReverseMap();
        CreateMap<CreateProgramareDto, Programare>().ReverseMap();
    }
}
