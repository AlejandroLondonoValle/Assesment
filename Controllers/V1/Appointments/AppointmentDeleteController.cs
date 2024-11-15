using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Appointments;


public partial class AppointmentController : ControllerBase
{
    [HttpDelete("{id}")]
    public async Task<IActionResult> CancelCita(int id)
    {
        try
        {
            var success = await _appointmentService.CancelCitaAsync(id);
            if (success)
            {
                return NoContent(); // 204 No Content
            }
            else
            {
                return NotFound($"No se encontró cita con el ID {id}.");
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Hubo un error al cancelar la cita: " + ex.Message);
        }
    }
}
