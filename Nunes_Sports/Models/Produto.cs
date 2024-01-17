using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nunes_Sports.Models
{
    [Table("Produtos Sports")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public String Descricao { get; set; }

        [Column("Preco")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }
    }
}
