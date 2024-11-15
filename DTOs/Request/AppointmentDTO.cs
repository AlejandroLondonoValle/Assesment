using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.DTOs.Request;

public class AppointmentDTO
{

    [Required(ErrorMessage = "El campo Date es obligatorio.")]
    [DataType(DataType.Date, ErrorMessage = "El formato de la fecha no es válido.")]
    [CustomValidation(typeof(AppointmentDTO), "ValidateDateNotInThePast")]
    public DateTime Date { get; set; }


    [MaxLength(500, ErrorMessage = "El campo Reason no puede tener más de 500 caracteres.")]
    public string? Reason { get; set; }


    [MaxLength(1000, ErrorMessage = "El campo Note no puede tener más de 1000 caracteres.")]
    public string? Note { get; set; }


    [MaxLength(50, ErrorMessage = "El campo Status no puede tener más de 50 caracteres.")]
    [ValidStatus(ErrorMessage = "El estado debe ser 'cancelada', 'pendiente' o 'confirmada'.")]
    public string? Status { get; set; }


    [Required(ErrorMessage = "El campo MedicateId es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "MedicateId debe ser un número mayor que 0.")]
    public int MedicateId { get; set; }


    [Required(ErrorMessage = "El campo PatientId es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "PatientId debe ser un número mayor que 0.")]
    public int PatientId { get; set; }


    public static ValidationResult ValidateDateNotInThePast(DateTime date, ValidationContext context)
    {
        if (date < DateTime.Now.Date)
        {
            return new ValidationResult("La fecha no puede ser anterior a la fecha actual.");
        }
        return ValidationResult.Success!;
    }

}

public class ValidStatusAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string role)
        {
            if (
                role.Equals("cancelada", StringComparison.OrdinalIgnoreCase) ||
                role.Equals("pendiente", StringComparison.OrdinalIgnoreCase) ||
                role.Equals("confirmada", StringComparison.OrdinalIgnoreCase))
            {
                return ValidationResult.Success;
            }
        }
        return new ValidationResult(ErrorMessage);
    }
}