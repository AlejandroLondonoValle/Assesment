using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Appointments;

[ApiController]
[Route("api/v1/appointments")]

public partial class AppointmentController(AppointmentService appointmentService) : ControllerBase
{
    protected readonly AppointmentService _appointmentService = appointmentService;
}
