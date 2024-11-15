using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Medicates;

[ApiController]
[Route("api/v1/medicates")]
public partial class MedicateController(MedicateService medicateService) : ControllerBase
{
    protected readonly MedicateService _medicateService = medicateService;
}
