using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.DTOs.Request;

public class AvailabilityDTO
{
    [Required(ErrorMessage = "El campo StartTime es obligatorio.")]
    [DataType(DataType.Date, ErrorMessage = "El formato de la fecha no es válido.")]
    [CustomValidation(typeof(AvailabilityDTO), "ValidateDateNotInThePast")]
    public DateTime StartTime { get; set; }


    [Required(ErrorMessage = "El campo EndTime es obligatorio.")]
    [DataType(DataType.Date, ErrorMessage = "El formato de la fecha no es válido.")]
    [CustomValidation(typeof(AvailabilityDTO), "ValidateDateNotInThePast")]
    public DateTime EndTime { get; set; }


    [Required(ErrorMessage = "El campo MedicateId es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "MedicateId debe ser un número mayor que 0.")]
    public int MedicateId { get; set; }


    public static ValidationResult ValidateDateNotInThePast(DateTime date, ValidationContext context)
    {
        if (date < DateTime.Now.Date)
        {
            return new ValidationResult("La fecha no puede ser anterior a la fecha actual.");
        }
        return ValidationResult.Success!;
    }
}
