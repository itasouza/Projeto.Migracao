using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Migracao.Models
{
    public class Usuario
    {
        [Key]
        public double iid { get; set; }
        public double locIid { get; set; }
        public double activeVersion { get; set; }
        public string ativo { get; set; }
        public DateTime? criacao { get; set; }
        public double usuarioIid { get; set; }
        public double usuarioLocIid { get; set; }
        public double version { get; set; }

        [Required(ErrorMessage ="O nome de login e requerido")]
        public string login { get; set; }

        [Required(ErrorMessage = "A senha e requerido")]
        public string senha { get; set; }
        public DateTime? ativacao { get; set; }
        public DateTime? expira { get; set; }
        public string email { get; set; }
        public string desabilitado { get; set; }

    }
}
