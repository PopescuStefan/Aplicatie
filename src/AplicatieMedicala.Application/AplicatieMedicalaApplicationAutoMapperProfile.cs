using AutoMapper;
using AplicatieMedicala.Entities;
using AplicatieMedicala.Pacienti;

namespace AplicatieMedicala;

public class AplicatieMedicalaApplicationAutoMapperProfile : Profile
{
    public AplicatieMedicalaApplicationAutoMapperProfile()
    {
        CreateMap<Pacient, PacientDto>();
        CreateMap<CreateUpdatePacientDto, Pacient>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}



