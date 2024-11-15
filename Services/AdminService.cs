using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Services;

public class AdminService
{
    private readonly IAdminRepository _adminRepository;

    public AdminService(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }

    // Get all users
    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _adminRepository.GetAllUsers();
    }

    // Get user by id
    public async Task<User?> GetUserByIdAsync(int id)
    {
        return await _adminRepository.GetUserById(id);
    }

    // Add a new user (admin can create any user)
    public async Task AddUserAsync(User user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user), "El usuario no puede ser nulo.");

        await _adminRepository.AddUser(user);
    }

    // Update an existing user
    public async Task UpdateUserAsync(User user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user), "El usuario no puede ser nulo.");


        var existingUser = await _adminRepository.GetUserById(user.Id);
        if (existingUser == null)
            throw new InvalidOperationException("El usuario no existe.");


        await _adminRepository.UpdateUser(user);

    }

    // Delete a user
    public async Task DeleteUserAsync(int id)
    {
        var user = await _adminRepository.GetUserById(id);
        if (user == null)
            throw new InvalidOperationException("El usuario no existe.");

        await _adminRepository.DeleteUser(id);
    }

    // Get users by role
    public async Task<IEnumerable<User>> GetUsersByRoleAsync(string role)
    {
        return await _adminRepository.GetUsersByRole(role);
    }

}
