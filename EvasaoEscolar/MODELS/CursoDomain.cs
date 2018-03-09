using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EvasaoEscolar.MODELS
{
    public class CursoDomain : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string NomeCurso { get; set; }


        public ICollection<DisciplinasDomain> Disciplinas { get; set; }
    }
}