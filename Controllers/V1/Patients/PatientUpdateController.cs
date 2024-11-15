using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Patients;


public partial class PatientController : ControllerBase
{
    // PUT: api/Patient/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePatient(int id, [FromBody] Patient patient)
    {
        if (id != patient.Id)
            return BadRequest("El ID no coincide con el del paciente.");

        try
        {
            await _patientService.UpdatePatientAsync(patient);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
