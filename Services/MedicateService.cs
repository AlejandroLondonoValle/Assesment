using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Repositories;

namespace Assesment.Services;

public class MedicateService
{
    private readonly IMedicateRepository _medicateRepository;
    private readonly AvailabilityService _availabilityService;

    public MedicateService(IMedicateRepository medicateRepository, AvailabilityService availabilityService)
    {
        _medicateRepository = medicateRepository;
        _availabilityService = availabilityService;
    }

    // Get medicate by ID
    public async Task<Medicate?> GetMedicateByIdAsync(int id)
    {
        return await _medicateRepository.GetMedicateById(id);
    }

    // Get all appointments for a specific medicate
    public async Task<IEnumerable<Appointment>> GetAppointmentsByMedicateIdAsync(int medicateId)
    {
        return await _medicateRepository.GetAppointmentsByMedicateId(medicateId);
    }

    // Add a new medicate
    public async Task AddMedicateAsync(Medicate medicate)
    {
        if (medicate == null)
            throw new ArgumentNullException(nameof(medicate), "El médico no puede ser nulo.");

        await _medicateRepository.AddMedicate(medicate);
    }

    // Update a medicate's details
    public async Task UpdateMedicateAsync(Medicate medicate)
    {
        if (medicate == null)
            throw new ArgumentNullException(nameof(medicate), "El médico no puede ser nulo.");

        var existingMedicate = await _medicateRepository.GetMedicateById(medicate.Id);
        if (existingMedicate == null)
            throw new InvalidOperationException("El médico no existe.");

        await _medicateRepository.UpdateMedicate(medicate);
    }

    // Delete a medicate
    public async Task DeleteMedicateAsync(int id)
    {
        var medicate = await _medicateRepository.GetMedicateById(id);
        if (medicate == null)
            throw new InvalidOperationException("El médico no existe.");

        await _medicateRepository.DeleteMedicate(id);
    }

    // Get availability for a specific medicate
    public async Task<IEnumerable<Availability>> GetMedicateAvailabilityAsync(int medicateId)
    {
        return await _medicateRepository.GetMedicateAvailability(medicateId);
    }

    // Add availability for the medicate
    public async Task AddMedicateAvailabilityAsync(Availability availability)
    {
        if (availability == null)
            throw new ArgumentNullException(nameof(availability), "La disponibilidad no puede ser nula.");

        var isAvailable = await _availabilityService.IsMedicoAvailableAsync(availability.MedicateId, availability.StartTime, availability.EndTime);
        if (!isAvailable)
            throw new InvalidOperationException("El médico no está disponible en este horario.");

        await _availabilityService.AddDisponibilidadAsync(availability);
    }

    // Remove availability for the medicate
    public async Task RemoveMedicateAvailabilityAsync(Availability availability)
    {
        if (availability == null)
            throw new ArgumentNullException(nameof(availability), "La disponibilidad no puede ser nula.");

        await _availabilityService.RemoveDisponibilidadAsync(availability);
    }
}
