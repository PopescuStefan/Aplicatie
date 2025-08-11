using AplicatieMedicala.Application.Contracts.Pacienti;
using AplicatieMedicala.Domain.Entities;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

public class PacientAppService : CrudAppService<
    Pacient, PacientDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePacientDto, CreateUpdatePacientDto>,
    IPacientAppService
{
    public PacientAppService(IRepository<Pacient, Guid> repository) : base(repository)
    {
        // custom logic if needed
    }
}
