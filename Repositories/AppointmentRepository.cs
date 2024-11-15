using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Data;
using Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly ApplicationDbContext _context;

    public AppointmentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    //Add new appointment
    public async Task Add(Appointment appointment)
    {
        await _context.Appointments.AddAsync(appointment);
        await _context.SaveChangesAsync();
    }

    //Verify existence of appointment
    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Appointments.AnyAsync(c => c.Id == id);
    }

    //Delete appointment in the database
    public async Task Delete(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment != null)
        {
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
        }
    }

    //Get All Appointments
    public async Task<IEnumerable<Appointment>> GetAll()
    {
        return await _context.Appointments.ToListAsync();
    }

    //Get Appointment by specified id
    public async Task<Appointment?> GetById(int id)
    {
        return await _context.Appointments.FindAsync(id);
    }

    //Get appointment by medicate id
    public async Task<IEnumerable<Appointment>> GetCitasByMedico(int medicateId)
    {
        return await _context.Appointments.Where(c => c.MedicateId == medicateId).ToListAsync();
    }

    //Get appointment by patient id
    public async Task<IEnumerable<Appointment>> GetCitasByPaciente(int patientId)
    {
        return await _context.Appointments.Where(c => c.PatientId == patientId).ToListAsync();
    }
}
