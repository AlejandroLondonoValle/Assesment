using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Medicates;


public partial class MedicateController : ControllerBase
{
    // DELETE: api/Medicate/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMedicate(int id)
    {
        try
        {
            await _medicateService.DeleteMedicateAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // DELETE: api/Medicate/{id}/availability
    [HttpDelete("{id}/availability")]
    public async Task<IActionResult> RemoveAvailability(int id, [FromBody] Availability availability)
    {
        availability.MedicateId = id;
        try
        {
            await _medicateService.RemoveMedicateAvailabilityAsync(availability);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
