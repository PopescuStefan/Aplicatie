using System;
using Volo.Abp.Application.Dtos;

namespace AplicatieMedicala.Application.Contracts.Pacienti
{
    public class PacientDto : EntityDto<Guid>
    {
        public string Nume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string CNP { get; set; }
    }
}
