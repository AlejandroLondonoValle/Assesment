using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;

namespace Assesment.Repositories;

public interface IAppointmentRepository
{
    Task Add(Appointment appointment);
    Task<IEnumerable<Appointment>> GetAll();
    Task<Appointment?> GetById(int id);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
    Task<IEnumerable<Appointment>> GetCitasByMedico(int medicateId);
    Task<IEnumerable<Appointment>> GetCitasByPaciente(int patientId);
}
