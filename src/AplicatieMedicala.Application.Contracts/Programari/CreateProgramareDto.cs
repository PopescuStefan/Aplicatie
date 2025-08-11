using System;
using System.ComponentModel.DataAnnotations;
//using AplicatieMedicala.Domain.Entities;

namespace AplicatieMedicala.Application.Contracts.Programari
{
    public class CreateProgramareDto
    {
        [Required]
        public DateTime DataOra { get; set; }

      //  public ProgramareStatus Status { get; set; }

        [Required]
        public Guid MedicId { get; set; }

        [Required]
        public Guid PacientId { get; set; }

        [Required]
        public Guid SpecializareId { get; set; }
    }
}
