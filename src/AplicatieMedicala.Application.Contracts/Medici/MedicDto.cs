using System;
using Volo.Abp.Application.Dtos;

namespace AplicatieMedicala.Application.Contracts.Medici
{
    public class MedicDto : EntityDto<Guid>
    {
        public string Nume { get; set; }
        public Guid SpecializareId { get; set; }
        public string SpecializareDenumire { get; set; }
    }
}
