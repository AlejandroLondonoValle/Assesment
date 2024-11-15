using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Availabilities;

public partial class AvailabilityController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> AddAvailability([FromBody] Availability availability)
    {
        if (availability == null)
        {
            return BadRequest("La disponibilidad no puede ser nula.");
        }

        try
        {
            await _availabilityService.AddDisponibilidadAsync(availability);
            return CreatedAtAction(nameof(GetAvailabilityById), new { id = availability.Id }, availability);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Hubo un error al agregar la disponibilidad: " + ex.Message);
        }
    }

}
