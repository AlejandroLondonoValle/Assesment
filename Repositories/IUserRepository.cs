using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;

namespace Assesment.Repositories;

public interface IUserRepository
{
    Task Add(User user);
    Task<IEnumerable<User>> GetAll();
    Task<User?> GetById(int id);
    Task Update(User user);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
    Task<string?> login(string email, string password, string secretKey);
    Task<User?> ValidateUser(string email, string password);
    Task<IEnumerable<User>> GetUsersByRole(string role);
}
