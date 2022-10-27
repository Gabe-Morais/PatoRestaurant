using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [Display(Name= "Nome")]
        [Required(ErrorMessage = "Informe o seu {0}")]
        [StringLength(30, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        public string Name { get; set; }

        [Display(Name= "Data da reserva")]
        [Required(ErrorMessage = "Informe a {0}")]
        public DateTime ReservationDate { get; set; }

        [Display(Name= "Celular")]
        [Required(ErrorMessage = "Informe o seu {0}")]
        [StringLength(30, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        public string Phone { get; set; }

        [Display(Name= "Convidados")]
        [Required(ErrorMessage = "Informe o numero de convidados")]
        public byte Guests { get; set; }

        [Display(Name= "E-mail")]
        [StringLength(100, ErrorMessage = "O {0} deve possuir no maximo {1} caracteres")]
        [EmailAddress(ErrorMessage = "Informe um email valido!")]

        public string Email { get; set; }

        [Display(Name = "Data de Cadastro")]
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Status da Reserva")]
        public byte StatusReservationId { get; set; }

        [ForeignKey("StatusReservationId")]
        public StatusReservation StatusReservation { get; set; }
    }
}