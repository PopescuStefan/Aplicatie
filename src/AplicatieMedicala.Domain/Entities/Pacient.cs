using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace AplicatieMedicala.Entities
{

    public class Pacient : FullAuditedAggregateRoot<Guid>
    {
        public string Nume { get; private set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        [RegularExpression(@"\d{13}", ErrorMessage = "CNP-ul trebuie sã aibã 13 cifre.")]
        public string CNP { get; set; }
    }

}