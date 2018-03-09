using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvasaoEscolar.MODELS
{
    public class UsuarioDomain : BaseDomain
    {
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Senha { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Celular { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeUsuario { get; set; }


        public ICollection<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }
        

    }
}