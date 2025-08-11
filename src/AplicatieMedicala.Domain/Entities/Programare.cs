using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;
namespace AplicatieMedicala.Domain.Entities
    {
       /* public enum ProgramareStatus
        {
            Planificata = 0,
            Confirmata = 1,
            Anulata = 2
        }*/

        public class Programare : FullAuditedAggregateRoot<Guid>
        {
            [Required]
            public DateTime DataOra { get; set; }

            //public ProgramareStatus Status { get; set; }

            [Required]
            public Guid MedicId { get; set; }
            public Medic Medic { get; set; }

            [Required]
            public Guid PacientId { get; set; }
            public Pacient Pacient { get; set; }

            [Required]
            public Guid SpecializareId { get; set; }
            public Specializare Specializare { get; set; }

            public Programare(Guid id) : base(id) { }
            protected Programare() { }
        }
    }


