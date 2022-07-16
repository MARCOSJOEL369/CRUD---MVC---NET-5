using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD___MVC___NET_5.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Llenar el campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Obligatorio cumplir de 5 a 50 caracteres", MinimumLength = 5)]
        [Display(Name = "Marca")]
        public int marca { get; set; }

        [Required(ErrorMessage = "Llenar el campo es obligatorio")]
        [StringLength(50, ErrorMessage = "Obligatorio cumplir de 5 a 50 caracteres", MinimumLength = 5)]
        [Display(Name = "color")]
        public string color { get; set; }

        [Required(ErrorMessage = "Llenar el campo es obligatorio")]
        [Display(Name = "kilometraje")]
        public int kilometraje { get; set; }

        [Required(ErrorMessage = "Llenar el campo es obligatorio")]
        [Display(Name = "AñoDeLanzamineto")]
        [DataType(DataType.Date)]
        public DateTime AñoDeLanzamineto { get; set; }
    }
}
