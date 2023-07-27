using System.ComponentModel.DataAnnotations;

namespace Imoveis.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime? DataDaCriacao { get; set; }
        public DateTime? DataDaAlteracao { get; set; }
    }
}
