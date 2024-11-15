using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Medicates;


public partial class MedicateController : ControllerBase
{
    // GET: api/Medicate/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetMedicateById(int id)
    {
        var medicate = await _medicateService.GetMedicateByIdAsync(id);
        if (medicate == null)
            return NotFound($"Médico con ID {id} no encontrado.");
        return Ok(medicate);
    }

    // GET: api/Medicate/{id}/appointments
    [HttpGet("{id}/appointments")]
    public async Task<IActionResult> GetAppointmentsByMedicateId(int id)
    {
        var appointments = await _medicateService.GetAppointmentsByMedicateIdAsync(id);
        return Ok(appointments);
    }

    // GET: api/Medicate/{id}/availability
    [HttpGet("{id}/availability")]
    public async Task<IActionResult> GetMedicateAvailability(int id)
    {
        var availability = await _medicateService.GetMedicateAvailabilityAsync(id);
        return Ok(availability);
    }
}
