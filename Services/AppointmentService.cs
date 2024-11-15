using Assesment.Models;
using Assesment.Repositories;

namespace Assesment.Services;

public class AppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly AvailabilityService _availabilityService;

    public AppointmentService(IAppointmentRepository appointmentRepository, AvailabilityService availabilityService)
    {
        _appointmentRepository = appointmentRepository;
        _availabilityService = availabilityService;
    }

    // Schedule appointment
    public async Task<bool> ScheduleCitaAsync(Appointment appointment)
    {
        if (appointment == null)
            throw new ArgumentNullException(nameof(appointment), "La cita no puede ser nula.");

        var isAvailable = await _availabilityService.IsMedicoAvailableAsync(appointment.MedicateId, appointment.Date, appointment.Date.AddMinutes(60));
        if (!isAvailable)
        {
            throw new InvalidOperationException("El médico no está disponible en ese horario.");
        }

        await _appointmentRepository.Add(appointment);

        // delete availability of medicate to asigned hour
        var availability = new Availability
        {
            MedicateId = appointment.MedicateId,
            StartTime = appointment.Date,
            EndTime = appointment.Date.AddMinutes(60)
        };
        await _availabilityService.RemoveDisponibilidadAsync(availability);

        return true;
    }

    // Cancel appointment
    public async Task<bool> CancelCitaAsync(int appointmentId)
    {
        var appointment = await _appointmentRepository.GetById(appointmentId);
        if (appointment == null)
            throw new InvalidOperationException("La cita no existe.");

        await _appointmentRepository.Delete(appointmentId);

        // restore availabilty of medicate
        var availability = new Availability
        {
            MedicateId = appointment.MedicateId,
            StartTime = appointment.Date,
            EndTime = appointment.Date.AddMinutes(60)
        };
        await _availabilityService.AddDisponibilidadAsync(availability);

        return true;
    }

    public async Task<Appointment?> GetCitaById(int id)
    {
        try
        {
            var appointment = await _appointmentRepository.GetById(id);

            return appointment;
        }
        catch (Exception ex)
        {
            throw new Exception($"Hubo un error al obtener la disponibilidad con el ID {id}.", ex);
        }
    }

    public async Task<List<Appointment>> GetCitasByPaciente(int patientId)
    {
        try
        {
            var appointment = await _appointmentRepository.GetCitasByPaciente(patientId);

            if (appointment == null)
            {
                return new List<Appointment>();
            }


            return appointment.OrderBy(a => a.Id).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception($"Hubo un error al obtener las citas del paciente con ID {patientId}.", ex);
        }
    }

    public async Task<List<Appointment>> GetCitasByMedico(int medicateId)
    {
        try
        {

            var appointment = await _appointmentRepository.GetCitasByMedico(medicateId);

            if (appointment == null)
            {
                return new List<Appointment>();
            }

            return appointment.OrderBy(a => a.Date).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception($"Hubo un error al obtener las citas del médico con ID {medicateId}.", ex);
        }
    }

}
