using System;
using System.ComponentModel.DataAnnotations;

namespace AplicatieMedicala.Application.Contracts.Pacienti
{
    public class CreateUpdatePacientDto
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
    }
}
