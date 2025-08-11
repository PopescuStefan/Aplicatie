using AplicatieMedicala.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace AplicatieMedicala.Domain.Entities
{
    public class Specializare : FullAuditedAggregateRoot<Guid>
    {
        [Required]
        public string Denumire { get; set; }

        public ICollection<Medic> Medici { get; set; } = new List<Medic>();

        public Specializare(Guid id, string denumire) : base(id)
        {
            Denumire = denumire;
        }

        protected Specializare() { }
    }
}
