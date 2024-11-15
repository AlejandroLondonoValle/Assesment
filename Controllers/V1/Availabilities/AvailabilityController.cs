using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Repositories;
using Assesment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Availabilities;

[ApiController]
[Route("api/v1/availabilities")]

public partial class AvailabilityController(AvailabilityService availabilityService) : ControllerBase
{
    protected readonly AvailabilityService _availabilityService = availabilityService;
}
