
using System;
using AplicatieMedicala.Domain.Entities;
using AplicatieMedicala.Application.Contracts.Medici;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AplicatieMedicala.Application.Medici
{
    public class MedicAppService :
        CrudAppService<Medic, MedicDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMedicDto>,
        IMedicAppService
    {
        public MedicAppService(IRepository<Medic, Guid> repository) : base(repository)
        {
        }
    }
}
