using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace AplicatieMedicala.Domain.Entities
{
    public class Pacient : FullAuditedAggregateRoot<Guid>
    {
        [Required]
        public string Nume { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefon { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        public string CNP { get; set; }

        // constructor
        public Pacient(Guid id, string nume) : base(id)
        {
            Nume = nume;
        }

        protected Pacient() { } // EF
    }
}
