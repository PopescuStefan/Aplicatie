using System;
using AplicatieMedicala.Domain.Entities;
using AplicatieMedicala.Application.Contracts.Specializari;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AplicatieMedicala.Application.Specializari
{
    public class SpecializareAppService :
        CrudAppService<Specializare, SpecializareDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSpecializareDto>,
        ISpecializareAppService
    {
        public SpecializareAppService(IRepository<Specializare, Guid> repository) : base(repository)
        {
        }
    }
}
