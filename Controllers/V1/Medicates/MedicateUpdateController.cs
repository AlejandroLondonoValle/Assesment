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
    // PUT: api/Medicate/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMedicate(int id, [FromBody] Medicate medicate)
    {
        if (id != medicate.Id)
            return BadRequest("El ID no coincide con el del médico.");

        try
        {
            await _medicateService.UpdateMedicateAsync(medicate);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
