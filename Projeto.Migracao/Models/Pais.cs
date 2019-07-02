using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Migracao.Models
{
    public class Pais
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
        public string nome { get; set; }
        public string sigla { get; set; }
        public DateTime? alteracao { get; set; }
        public double usuarioCriacaoIid { get; set; }
        public double usuarioCriacaoLocIid { get; set; }
        public string desabilitado { get; set; }
        public double? tipoDocPFIid { get; set; }
        public double? tipoDocPFLocIid { get; set; }
        public double? tipoDocPFActiveVersion { get; set; }
        public double? tipoDocPJIid { get; set; }
        public double? tipoDocPJLocIid { get; set; }
        public double? tipoDocPJActiveVersion { get; set; }
        public string codInterface { get; set; }
        public string locInterface { get; set; }
        public DateTime? dataInterface { get; set; }
        public DateTime? dataSincronizacao { get; set; }
        public string cd_erp { get; set; }
    }
}
