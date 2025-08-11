using System;
using Volo.Abp.Application.Dtos;


namespace AplicatieMedicala.Application.Contracts.Programari
{
    public class ProgramareDto : EntityDto<Guid>
    {
        public DateTime DataOra { get; set; }
        
        public Guid MedicId { get; set; }
        public string MedicName { get; set; }
        public Guid PacientId { get; set; }
        public string PacientName { get; set; }
        public Guid SpecializareId { get; set; }
        public string SpecializareName { get; set; }
    }
}
