using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EvasaoEscolar.Enum;

namespace EvasaoEscolar.MODELS
{
    public class TurmaDomain : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string NomeTurma { get; set; }

        [Required]
        [StringLength(1)] 
        public EnPeriodo Periodo { get; set; }

        public ICollection<DisciplinaTurmaDomain> DisciplinaTurma { get; set; }

    }
}