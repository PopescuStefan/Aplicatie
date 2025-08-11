using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AplicatieMedicala.Application.Contracts.Medici
{
    public interface IMedicAppService :
        ICrudAppService<MedicDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMedicDto>
    {
    }
}
