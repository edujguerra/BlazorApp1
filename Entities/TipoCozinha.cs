using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Entities
{
    [Table("tb_tipocozinha")]
    public class TipoCozinha
    {
        [Key]
        [Column("id_tipo_cozinha")]
        public long id { get; set; }

        [Column("ds_tipo")]
        public String nome { get; set; }


        public TipoCozinha(long id, String nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public TipoCozinha()
        {

        }



    }
}
