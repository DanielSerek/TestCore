using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestCore.Models
{
    [Table("AGENDA_SABLONA")]
    public partial class CisAgendaSablona
    {
        [Key]
        [Column("ID_AGENDA_SABLONA")]
        public int IdAgendaSablona { get; set; }
        [Column("GID_PROJEKT")]
        public Guid GidProjekt { get; set; }
        [Column("GID_SABLONA")]
        public Guid GidSablona { get; set; }
        [Required]
        [Column("KOD_SABLONA")]
        [StringLength(16)]
        [Unicode(false)]
        public string KodSablona { get; set; }

        [ForeignKey(nameof(GidProjekt))]
        [InverseProperty(nameof(CisAgenda.AgendaSablonas))]
        public virtual CisAgenda GidProjektNavigation { get; set; }
    }
}
