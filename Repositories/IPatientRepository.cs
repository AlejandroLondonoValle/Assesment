using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;

namespace Assesment.Repositories;

public interface IPatientRepository
{
    Task<Patient?> GetPatientById(int id);
    Task<IEnumerable<Appointment>> GetAppointmentsByPatientId(int patientId);
    Task AddPatient(Patient patient);
    Task UpdatePatient(Patient patient);
    Task DeletePatient(int id);
}
