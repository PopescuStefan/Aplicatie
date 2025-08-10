using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AplicatieMedicala.Pacienti
{
    public interface IPacientAppService :
        ICrudAppService<PacientDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePacientDto>
    {
    }
}
