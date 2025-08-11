using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace AplicatieMedicala.Domain.Entities
{
    public class Medic : FullAuditedAggregateRoot<Guid>
    {
        [Required]
        public string Nume { get; set; }

        [Required]
        public Guid SpecializareId { get; set; }
        public Specializare Specializare { get; set; }

        public Medic(Guid id, string nume, Guid specializareId) : base(id)
        {
            Nume = nume;
            SpecializareId = specializareId;
        }

        protected Medic() { }
    }
}
