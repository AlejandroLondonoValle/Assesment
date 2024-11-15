using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.DTOs.Request;

public class MedicateDTO
{
    [Required(ErrorMessage = "La especialidad del doctor es obligatoria.")]
    [StringLength(50, ErrorMessage = "La especialidad del doctor exceder los 50 caracteres.")]
    public required string Specialty { get; set; }


    [Required(ErrorMessage = "El campo UserId es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "El UserId debe ser un número mayor que 0.")]
    public int UserId { get; set; }


    [Required(ErrorMessage = "El campo AvailabilityId es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "El AvailabilityId debe ser un número mayor que 0.")]
    public int AvailabilityId { get; set; }

}
