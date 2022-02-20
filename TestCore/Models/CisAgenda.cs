using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestCore.Models
{
    [Table("AGENDA")]
    public partial class CisAgenda
    {
        public CisAgenda()
        {
            AgendaSablonas = new HashSet<CisAgendaSablona>();
        }

        public CisAgenda(string popisAgenda)
        {
            PopisAgenda = popisAgenda;
            GidProjekt = Guid.NewGuid();
        }

        [Required]
        [Column("POPIS_AGENDA")]
        [StringLength(128)]
        [Unicode(false)]
        public string PopisAgenda { get; set; }
        [Key]
        [Column("GID_PROJEKT")]
        public Guid GidProjekt { get; set; }
        [Column("DLOUHODOBE_AN")]
        public bool DlouhodobeAn { get; set; }

        [InverseProperty(nameof(CisAgendaSablona.GidProjektNavigation))]
        public virtual ICollection<CisAgendaSablona> AgendaSablonas { get; set; }
    }
}
