using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Patients;


public partial class PatientController : ControllerBase
{
    // GET: api/Patient/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatientById(int id)
    {
        var patient = await _patientService.GetPatientByIdAsync(id);
        if (patient == null)
            return NotFound($"Paciente con ID {id} no encontrado.");
        return Ok(patient);
    }

    // GET: api/Patient/{id}/appointments
    [HttpGet("{id}/appointments")]
    public async Task<IActionResult> GetAppointmentsByPatientId(int id)
    {
        var appointments = await _patientService.GetAppointmentsByPatientIdAsync(id);
        return Ok(appointments);
    }
}
