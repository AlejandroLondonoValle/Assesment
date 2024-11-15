using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Data;
using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Repositories;

public class AvailabilityRepository : IAvailabilityRepository
{
    private readonly ApplicationDbContext _context;

    public AvailabilityRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    //Add new availability
    public async Task Add(Availability availability)
    {
        await _context.Availabilities.AddAsync(availability);
        await _context.SaveChangesAsync();
    }

    //Verify existence of availability
    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Availabilities.AnyAsync(d => d.Id == id); ;
    }

    //Delete availability in the database
    public async Task Delete(int id)
    {
        var availability = await _context.Availabilities.FindAsync(id);
        if (availability != null)
        {
            _context.Availabilities.Remove(availability);
            await _context.SaveChangesAsync();
        }
    }

    //Get All Availabilities
    public async Task<IEnumerable<Availability>> GetAll()
    {
        return await _context.Availabilities.ToListAsync();
    }

    //Get Availability by specified id
    public async Task<Availability?> GetById(int id)
    {
        return await _context.Availabilities.FindAsync(id);
    }

    //Get availability by doctor and date
    public async Task<IEnumerable<Availability>> GetDisponibilidadByMedicoId(int medicateid)
    {
        return await _context.Availabilities
                .Where(d => d.MedicateId == medicateid)
                .ToListAsync();
    }

    //Update availability in the database
    public async Task Update(Availability availability)
    {
        _context.Entry(availability).State = EntityState.Modified;
            await _context.SaveChangesAsync();
    }
}
