using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imoveis.Models
{
    [Table("Imoveis")]
    public class ImovelModel : BaseModel
    {
        public ImovelModel(TipoImovelEnum tipoImovel, string titulo, decimal valor, string descricao, TipoAnuncioEnum tipoAnuncio,
        decimal metragemTerreno, decimal metragemConstruida, string proprietario, string bairro, string cidade, string estado)
        {
            TipoImovel = tipoImovel;
            Titulo = titulo;
            Valor = valor;
            Descricao = descricao;
            TipoAnuncio = tipoAnuncio;
            MetragemTerreno = metragemTerreno;
            MetragemConstruida = metragemConstruida;
            Proprietario = proprietario;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        [Required]
        public TipoImovelEnum TipoImovel { get; set; }

        [Required]
        [MaxLength(80)]
        public string Titulo { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descricao { get; set; }

        [Required]
        public TipoAnuncioEnum TipoAnuncio { get; set; }

        [Required]
        public decimal MetragemTerreno { get; set; }

        [Required]
        public decimal MetragemConstruida { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "O Campo deve ter no máximo {1} caracteres")]
        public string Proprietario { get; set; }

        [Required]
        [MaxLength(50)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(50)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }
    }
}