using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Patients;

[ApiController]
[Route("api/v1/patients")]
public partial class PatientController(PatientService patientService) : ControllerBase
{
    protected readonly PatientService _patientService = patientService;

}
