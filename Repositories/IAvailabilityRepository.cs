using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;

namespace Assesment.Repositories;

public interface IAvailabilityRepository
{
    Task Add(Availability availability);
    Task<IEnumerable<Availability>> GetAll();
    Task<Availability?> GetById(int id);
    Task<IEnumerable<Availability>> GetDisponibilidadByMedicoId(int medicateid);
    Task Update(Availability availability);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
