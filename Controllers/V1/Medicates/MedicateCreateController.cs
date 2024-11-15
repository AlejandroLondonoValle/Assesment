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
    // POST: api/Medicate/{id}/availability
    [HttpPost("{id}/availability")]
    public async Task<IActionResult> AddAvailability(int id, [FromBody] Availability availability)
    {
        availability.MedicateId = id;
        try
        {
            await _medicateService.AddMedicateAvailabilityAsync(availability);
            return CreatedAtAction(nameof(GetMedicateAvailability), new { id }, availability);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
