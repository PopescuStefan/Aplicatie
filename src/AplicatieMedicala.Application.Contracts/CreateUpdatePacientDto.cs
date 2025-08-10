using System.ComponentModel.DataAnnotations;

namespace AplicatieMedicala.Pacienti
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
        [RegularExpression(@"\d{13}", ErrorMessage = "CNP-ul trebuie sã aibã 13 cifre.")]
        public string CNP { get; set; }
    }
}
