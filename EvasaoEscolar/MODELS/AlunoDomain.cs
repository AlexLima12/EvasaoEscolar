using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvasaoEscolar.MODELS
{
    public class AlunoDomain : BaseDomain
    {
        [Required]
        [StringLength(15)]
        public string Matricula { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeAluno { get; set; }

        [Required]        
        public bool StatusUsuario { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Celular { get; set; }


        public ICollection<AlunoDisciplinaTurmaDomain> AlunoDisciplinaTurma { get; set; }
        public ICollection<PlanilhaDadosDomain> PlanilhaDados { get; set; }
        public ICollection<AlertasDomain> Alertas{ get; set; }

    }
}