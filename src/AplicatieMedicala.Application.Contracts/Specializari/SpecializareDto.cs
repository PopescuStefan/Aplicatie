using System;
using Volo.Abp.Application.Dtos;

namespace AplicatieMedicala.Application.Contracts.Specializari
{
    public class SpecializareDto : EntityDto<Guid>
    {
        public string Denumire { get; set; }
    }
}
