using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Availabilities;

public partial class AvailabilityController : ControllerBase
{
    [HttpGet("medico/{medicateId}")]
        public async Task<IActionResult> GetAvailabilityById(int medicateId)
        {
            var availabilities = await _availabilityService.GetDisponibilidadByMedicoId(medicateId);
            if (availabilities == null || availabilities.Count == 0)
            {
                return NotFound($"No hay disponibilidades para el médico con ID {medicateId}.");
            }

            return Ok(availabilities);
        }
}
