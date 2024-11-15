using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Appointments;


public partial class AppointmentController : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCitaById(int id)
    {
        var appointment = await _appointmentService.GetCitaById(id);
        if (appointment == null)
        {
            return NotFound($"No se encontró cita con el ID {id}.");
        }

        return Ok(appointment);
    }

    [HttpGet("paciente/{patientId}")]
    public async Task<IActionResult> GetCitasByPaciente(int patientId)
    {
        var appointment = await _appointmentService.GetCitasByPaciente(patientId);
        if (appointment == null || appointment.Count == 0)
        {
            return NotFound($"No se encontraron citas para el paciente con ID {patientId}.");
        }

        return Ok(appointment);
    }

    // Get all appointment of medicate
    [HttpGet("medico/{medicateId}")]
    public async Task<IActionResult> GetCitasByMedico(int medicateId)
    {
        var appointment = await _appointmentService.GetCitasByMedico(medicateId);
        if (appointment == null || appointment.Count == 0)
        {
            return NotFound($"No se encontraron citas para el médico con ID {medicateId}.");
        }

        return Ok(appointment);
    }
}
