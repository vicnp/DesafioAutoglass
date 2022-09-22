using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autoglass.Models
{
    public class Produto
    {

        [Key]
        [DisplayName("Código:")]
        public int CodProduto { get; set; }


        [Column(TypeName ="nvarchar(100)")]
        [DisplayName("Descrição do Produto:")]
        [Required]
        public string DescProd { get; set; }


        [DisplayName("Estatus:")]
        public int status { get; set; }

        [DisplayName("Data de fabricação:")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        
        public DateTime Frabricacao { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data de validade:")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [ValidExpireDate(ErrorMessage = "Erro")]

        public DateTime validade { get; set; }

        [DisplayName("Código do Fornecedor:")]
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string CodForne { get; set; }

        [DisplayName("Descrição do Fornecedor:")]
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string DescFornec { get; set; }

        [DisplayName("CNPJ do Forn.:")]
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        [ValidCNPJ]
        public string? CNPJ {get; set; }

        [DisplayName("Quantidade:")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade não pode ser zero.")]
        public int quantidade { get; set; } 



    }
}


