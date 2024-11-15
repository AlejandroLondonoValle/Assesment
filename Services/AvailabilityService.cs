using Assesment.Models;
using Assesment.Repositories;

namespace Assesment.Services;

public class AvailabilityService
{

    private readonly IAvailabilityRepository _availabilityRepository;

    public AvailabilityService(IAvailabilityRepository availabilityRepository)
    {
        _availabilityRepository = availabilityRepository;
    }

    // Verify if medic is available in specific hours
    public async Task<bool> IsMedicoAvailableAsync(int medicateId, DateTime datehourstart, DateTime datehourend)
    {
        var availabilities = await _availabilityRepository.GetDisponibilidadByMedicoId(medicateId);
        return !availabilities.Any(d =>
            (d.StartTime >= datehourstart && d.StartTime < datehourend) ||
            (d.StartTime < datehourend && d.EndTime > datehourstart));
    }

    // Add availability of medicate
    public async Task AddDisponibilidadAsync(Availability availabilities)
    {
        if (availabilities == null)
            throw new ArgumentNullException(nameof(availabilities), "La disponibilidad no puede ser nula.");

        var isAvailable = await IsMedicoAvailableAsync(availabilities.MedicateId, availabilities.StartTime, availabilities.EndTime);
        if (!isAvailable)
        {
            throw new InvalidOperationException("El médico no está disponible en ese horario.");
        }

        await _availabilityRepository.Add(availabilities);
    }

    // delete availability
    public async Task RemoveDisponibilidadAsync(Availability availabilities)
    {
        if (availabilities == null)
            throw new ArgumentNullException(nameof(availabilities), "La disponibilidad no puede ser nula.");

        await _availabilityRepository.Delete(availabilities.Id);
    }

    public async Task<List<Availability>> GetDisponibilidadByMedicoId(int medicateId)
    {
        try
        {
            var disponibilidades = await _availabilityRepository.GetDisponibilidadByMedicoId(medicateId);

            return disponibilidades.OrderBy(a => a.StartTime).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception($"Hubo un error al obtener las disponibilidades del médico con ID {medicateId}.", ex);
        }
    }


    public async Task<Availability?> GetDisponibilidadById(int id)
    {
        try
        {
            var disponibilidad = await _availabilityRepository.GetById(id);

            return disponibilidad;
        }
        catch (Exception ex)
        {
            throw new Exception($"Hubo un error al obtener la disponibilidad con el ID {id}.", ex);
        }
    }

}