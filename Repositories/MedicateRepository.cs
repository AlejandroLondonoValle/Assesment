using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Data;
using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Repositories;

public class MedicateRepository : IMedicateRepository
{
    private readonly ApplicationDbContext _context;

    public MedicateRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Medicate?> GetMedicateById(int id)
    {
        return await _context.Medicates.Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Appointment>> GetAppointmentsByMedicateId(int medicateId)
    {
        return await _context.Appointments
            .Where(a => a.MedicateId == medicateId)
            .ToListAsync();
    }

    public async Task AddMedicate(Medicate medicate)
    {
        await _context.Medicates.AddAsync(medicate);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateMedicate(Medicate medicate)
    {
        _context.Entry(medicate).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMedicate(int id)
    {
        var medicate = await _context.Medicates.FindAsync(id);
        if (medicate != null)
        {
            _context.Medicates.Remove(medicate);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Availability>> GetMedicateAvailability(int medicateId)
    {
        return await _context.Availabilities
            .Where(a => a.MedicateId == medicateId)
            .ToListAsync();
    }
}
