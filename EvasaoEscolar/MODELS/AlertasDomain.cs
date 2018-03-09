using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvasaoEscolar.MODELS
{
    public class AlertasDomain : BaseDomain
    {
          [Required]        
        public bool StatusAlerta { get; set; }
        public int NivelAlerta { get; set; }




        [ForeignKey("AlunoId")]
        public AlunoDomain Aluno { get; set; }
        public int AlunoId { get; set; }
    }
}