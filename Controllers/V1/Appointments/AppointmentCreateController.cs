using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Appointments;


public partial class AppointmentController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> ScheduleCita([FromBody] Appointment appointment)
    {
        if (appointment == null)
        {
            return BadRequest("La cita no puede ser nula.");
        }

        try
        {
            var success = await _appointmentService.ScheduleCitaAsync(appointment);
            if (success)
            {
                return CreatedAtAction(nameof(GetCitaById), new { id = appointment.Id }, appointment);
            }
            else
            {
                return BadRequest("No se pudo agendar la cita.");
            }
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Hubo un error al agendar la cita: " + ex.Message);
        }
    }
}
