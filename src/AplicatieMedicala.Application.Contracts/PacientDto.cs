using System;
using Volo.Abp.Application.Dtos;

namespace AplicatieMedicala.Pacienti
{
    public class PacientDto : AuditedEntityDto<Guid>
    {
        public string Nume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string CNP { get; set; }
    }
}
