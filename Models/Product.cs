using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt16 Id { get; set; }

        [Display(Name= "Nome")]
        [StringLength(30, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        public string Name { get; set; }

        [Display(Name= "Descrição")]
        [StringLength(2000, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        public string Description { get; set; }

        [Display(Name= "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "Informe a {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        [Display(Name = "Data de Cadastro")]
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Categoria")]
        public byte CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Display(Name = "Imagem")]
        [StringLength(400)]

        public string Image { get; set; }

    }
}