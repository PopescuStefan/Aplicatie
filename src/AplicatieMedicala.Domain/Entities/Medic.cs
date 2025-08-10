using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AplicatieMedicala.Entities
{
    public class Medic : FullAuditedAggregateRoot<Guid>
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public Guid SpecializareId { get; set; }
        public Specializare Specializare { get; set; }
    }
}
