using Assesment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Users;

    [ApiController]
    [Route("api/v1/users")]
    public partial class UsersController(IUserRepository userRepository) : ControllerBase
    {
        protected readonly IUserRepository _userRepository = userRepository;
    }
