using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.DTOs.Request;

public class UserDTO
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
    public required string Name { get; set; }


    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")]
    public required string LastName { get; set; }


    [Required(ErrorMessage = "El número de identificación es obligatorio.")]
    [StringLength(15, ErrorMessage = "El número de identificación no puede exceder los 15 caracteres.")]
    public required string IdentificationNumber { get; set; }


    [Required(ErrorMessage = "la direccion es obligatoria.")]
    [StringLength(250, ErrorMessage = "la direccion no puede exceder los 250 caracteres.")]
    public required string Address { get; set; }


    [Required(ErrorMessage = "El email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El email no es valido.")]
    public required string Email { get; set; }


    [Required(ErrorMessage = "la contraseña es obligatoria.")]
    [StringLength(550, ErrorMessage = "la contraseña no puede exceder los 550 caracteres.")]
    public required string Password { get; set; }


    [Required(ErrorMessage = "El rol es requerido.")]
    [ValidRole(ErrorMessage = "El rol debe ser 'medicate' o 'patient'.")]
    public required string Role { get; set; }

}

public class ValidRoleAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string role)
        {
            if (role.Equals("medicate", StringComparison.OrdinalIgnoreCase) ||
                role.Equals("patient", StringComparison.OrdinalIgnoreCase))
            {
                return ValidationResult.Success;
            }
        }
        return new ValidationResult(ErrorMessage);
    }
}
