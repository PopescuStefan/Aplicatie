using System;
using Volo.Abp.Application.Dtos;

namespace AplicatieMedicala.Application.Contracts.Programari
{
    public class GetProgramariInput : PagedAndSortedResultRequestDto
    {
        public Guid? SpecializareId { get; set; }
        public Guid? MedicId { get; set; }
        public DateTime? Data { get; set; }
    }
}
