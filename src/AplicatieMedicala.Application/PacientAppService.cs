using AplicatieMedicala.Entities;
using AplicatieMedicala.Pacienti;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MedicalAppointments.Pacienti
{
    public class PacientAppService :
        CrudAppService<Pacient, PacientDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePacientDto>,
        IPacientAppService
    {
        public PacientAppService(IRepository<Pacient, Guid> repository)
            : base(repository)
        {
        }
    }
}
