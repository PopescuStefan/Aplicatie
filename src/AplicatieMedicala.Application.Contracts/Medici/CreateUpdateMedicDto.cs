using System;
using System.ComponentModel.DataAnnotations;

namespace AplicatieMedicala.Application.Contracts.Medici
{
    public class CreateUpdateMedicDto
    {
        [Required]
        public string Nume { get; set; }

        [Required]
        public Guid SpecializareId { get; set; }
    }
}
