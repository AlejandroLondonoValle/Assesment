using Assesment.DTOs.Request;
using Assesment.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Users;


public partial class UsersController : ControllerBase
{
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UserDTO updatedUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var checkUser = await _userRepository.CheckExistence(id);
        if (checkUser == false)
        {
            return NotFound();
        }

        var user = await _userRepository.GetById(id);

        if (user == null)
        {
            return NotFound();
        }

        user.Name = updatedUser.Name;
        user.LastName = updatedUser.LastName;
        user.IdentificationNumber = updatedUser.IdentificationNumber;
        user.Address = updatedUser.Address;
        user.Email = updatedUser.Email;
        user.Password = updatedUser.Password = PasswordHasher.HashPassword(updatedUser.Password);
        user.Role = updatedUser.Role;


        await _userRepository.Update(user);
        return NoContent();
    }
}
