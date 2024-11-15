using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Availabilities;

public partial class AvailabilityController : ControllerBase
{
    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveAvailability(int id)
    {
        try
        {
            var availabilities = await _availabilityService.GetDisponibilidadById(id);
            if (availabilities == null)
            {
                return NotFound($"No se encontró disponibilidad con el ID {id}.");
            }

            await _availabilityService.RemoveDisponibilidadAsync(availabilities);
            return NoContent(); // 204 No Content
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Hubo un error al eliminar la disponibilidad: " + ex.Message);
        }
    }
}
