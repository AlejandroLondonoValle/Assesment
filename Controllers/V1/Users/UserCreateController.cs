using Assesment.DTOs.Request;
using Assesment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Users;

public partial class UsersController : ControllerBase
{
    
    [HttpPost]
    public async Task<ActionResult<User>> Create(UserDTO inputUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var newUser = new User
        {
            Name = inputUser.Name,
            LastName = inputUser.LastName,
            IdentificationNumber = inputUser.IdentificationNumber,
            Address = inputUser.Address,
            Email = inputUser.Email,
            Password = inputUser.Password,
            Role = inputUser.Role
        };

        try
        {
            await _userRepository.Add(newUser);
            return Ok(newUser);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Ocurrió un error al crear el usuario: {ex.Message}");
        }
    }
}
