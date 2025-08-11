using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AplicatieMedicala.Application.Contracts.Specializari
{
    public interface ISpecializareAppService :
        ICrudAppService<SpecializareDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSpecializareDto>
    {
    }
}
