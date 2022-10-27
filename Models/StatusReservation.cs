using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("StatusReservation")]
    public class StatusReservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public UInt16 Id { get; set; }

        [Display(Name= "Nome")]
        [Required(ErrorMessage = "Informe o {0}")]
        [StringLength(30, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        public string Name { get; set; }
        
        [Display(Name= "Foto Home")]
        [StringLength(400)]
        public string Image { get; set; }

        [Display(Name= "Banner")]
        [StringLength(400)]
        public string Banner { get; set; }


    }
}