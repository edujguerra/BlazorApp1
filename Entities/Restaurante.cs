using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace BlazorApp1.Entities
{
    [Table("tb_restaurante")]
    public class Restaurante
    {

        [Key]
        [Column("id_restaurante")]
        public long id { get; set; }

        [Column("nm_nome")]
        public string nome { get; set; }

        [Column("ds_enderec")]
        public string endereco { get; set; }

        [Column("id_tipo_cozinha")]
        public long idTipoCozinha { get; set; }

        [Column("hr_inicio")]
        public string horaInicio { get; set; }

        [Column("hr_final")]
        public string horaFinal { get; set; }

        [Column("nr_mesas")]
        public int numMesas;

        public virtual TipoCozinha tipoCozinha { get; set; }
    }
}
