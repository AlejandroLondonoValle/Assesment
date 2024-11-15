using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;

namespace Assesment.Repositories;

public interface IAdminRepository
{
    Task<IEnumerable<User>> GetAllUsers();
    Task<User?> GetUserById(int id);
    Task AddUser(User user);
    Task UpdateUser(User user);
    Task DeleteUser(int id);
    Task<IEnumerable<User>> GetUsersByRole(string role);
}
