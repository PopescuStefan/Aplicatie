using System;
using Volo.Abp.Domain.Entities;

namespace AplicatieMedicala.Entities
{
    public enum StatusProgramare { Planificata, Confirmata, Anulata }

    public class Programare : Entity<Guid>
    {
        public DateTime DataOra { get; set; }
        public StatusProgramare Status { get; set; }

        public Guid MedicId { get; set; }
        public Medic Medic { get; set; }

        public Guid PacientId { get; set; }
        public Pacient Pacient { get; set; }

        public Guid SpecializareId { get; set; }
        public Specializare Specializare { get; set; }
    }
}

