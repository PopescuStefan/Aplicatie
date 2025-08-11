using System;
using System.ComponentModel.DataAnnotations;

namespace AplicatieMedicala.Application.Contracts.Specializari
{
    public class CreateUpdateSpecializareDto
    {
        [Required]
        public string Denumire { get; set; }
    }
}
