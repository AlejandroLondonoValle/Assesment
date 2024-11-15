using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.DTOs.Request;

public class PatientDTO
{
    [Required(ErrorMessage = "La Historia clinica del paciente es obligatoria.")]
    [StringLength(550, ErrorMessage = "La Historia clinica del paciente exceder los 550 caracteres.")]
    public required string MedicalHistory { get; set; }

    [Required(ErrorMessage = "El campo UserId es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "El UserId debe ser un número mayor que 0.")]
    public int UserId { get; set; }

}
