using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;

namespace Assesment.Repositories;

public interface IMedicateRepository
{
    Task<Medicate?> GetMedicateById(int id);
    Task<IEnumerable<Appointment>> GetAppointmentsByMedicateId(int medicateId);
    Task AddMedicate(Medicate medicate);
    Task UpdateMedicate(Medicate medicate);
    Task DeleteMedicate(int id);
    Task<IEnumerable<Availability>> GetMedicateAvailability(int medicateId);
}
