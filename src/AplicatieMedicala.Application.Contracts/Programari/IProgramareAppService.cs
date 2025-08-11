using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AplicatieMedicala.Application.Contracts.Programari
{
    public interface IProgramareAppService :
        ICrudAppService<ProgramareDto, Guid, PagedAndSortedResultRequestDto, CreateProgramareDto>
    {
        Task<PagedResultDto<ProgramareDto>> GetFilteredListAsync(GetProgramariInput input);
    }
}
