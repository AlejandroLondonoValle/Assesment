using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Assesment.Controllers.V1.Users;


public partial class UsersController : ControllerBase
{
    [HttpDelete("{id}")]
    [Authorize(Roles = "admin")]
    public async Task<IActionResult> Delete(int id)
    {
        var user = await _userRepository.CheckExistence(id);
        if (!user)
        {
            return NotFound();
        }

        await _userRepository.Delete(id);

        return NoContent();
    }

}
