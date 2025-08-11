using System;
using System.Linq;
using System.Threading.Tasks;
using AplicatieMedicala.Application.Contracts.Programari;
using AplicatieMedicala.Domain.Entities;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AplicatieMedicala.Application.Programari
{
    public class ProgramareAppService :
        CrudAppService<Programare, ProgramareDto, Guid, PagedAndSortedResultRequestDto, CreateProgramareDto>,
        IProgramareAppService
    {
        private readonly IRepository<Programare, Guid> _programareRepository;

        public ProgramareAppService(IRepository<Programare, Guid> repository) : base(repository)
        {
            _programareRepository = repository;
        }

        public override async Task<ProgramareDto> CreateAsync(CreateProgramareDto input)
        {
            if (input.DataOra <= Clock.Now)
            {
                throw new UserFriendlyException("Data și ora programării trebuie să fie în viitor.");
            }

            return await base.CreateAsync(input);
        }

        public async Task<PagedResultDto<ProgramareDto>> GetFilteredListAsync(GetProgramariInput input)
        {
            var query = (await _programareRepository.WithDetailsAsync(
                x => x.Medic,
                x => x.Pacient,
                x => x.Specializare
            )).AsQueryable();

            if (input.SpecializareId.HasValue)
                query = query.Where(x => x.SpecializareId == input.SpecializareId.Value);

            if (input.MedicId.HasValue)
                query = query.Where(x => x.MedicId == input.MedicId.Value);

            if (input.Data.HasValue)
                query = query.Where(x => x.DataOra.Date == input.Data.Value.Date);

            var totalCount = await query.CountAsync();

            var items = await query
                .OrderByDescending(x => x.DataOra)
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .Select(x => new ProgramareDto
                {
                    Id = x.Id,
                    DataOra = x.DataOra,
                    //Status = x.Status,
                    MedicId = x.MedicId,
                    MedicName = x.Medic.Nume,
                    PacientId = x.PacientId,
                    PacientName = x.Pacient.Nume,
                    SpecializareId = x.SpecializareId,
                    SpecializareName = x.Specializare.Denumire
                })
                .ToListAsync();

            return new PagedResultDto<ProgramareDto>(totalCount, items);
        }
    }
}
