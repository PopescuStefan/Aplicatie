using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace AplicatieMedicala.Entities
{
    public class Specializare : FullAuditedAggregateRoot<Guid>
    {
        public string Denumire { get; set; }
        public ICollection<Medic> Medici { get; set; }
    }
}
