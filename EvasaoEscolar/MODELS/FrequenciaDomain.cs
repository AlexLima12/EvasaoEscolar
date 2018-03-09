using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvasaoEscolar.MODELS
{
    public class FrequenciaDomain : BaseDomain
    {

        public int DiasFrequencia { get; set; }

        public int FaltaFrequencia { get; set; }

        public int NumeroAula { get; set; }

        public int Atraso { get; set; }

        public int FaltaComp { get; set; }


        [ForeignKey ("AlunoDisciplinaTurmaId")]
        public AlunoDisciplinaTurmaDomain AlunoDisciplinaTurma { get; set; }
        public int AlunoDisciplinaTurmaId { get; set; }
    }
}