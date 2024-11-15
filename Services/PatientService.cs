using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Repositories;

namespace Assesment.Services;

public class PatientService
{
    private readonly IPatientRepository _patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    // Get patient by ID
    public async Task<Patient?> GetPatientByIdAsync(int id)
    {
        return await _patientRepository.GetPatientById(id);
    }

    // Get appointments by patient ID
    public async Task<IEnumerable<Appointment>> GetAppointmentsByPatientIdAsync(int patientId)
    {
        return await _patientRepository.GetAppointmentsByPatientId(patientId);
    }

    // Update patient information
    public async Task UpdatePatientAsync(Patient patient)
    {
        if (patient == null)
            throw new ArgumentNullException(nameof(patient), "El paciente no puede ser nulo.");

        await _patientRepository.UpdatePatient(patient);
    }

    // Delete patient
    public async Task DeletePatientAsync(int id)
    {
        var patient = await _patientRepository.GetPatientById(id);
        if (patient == null)
            throw new InvalidOperationException("El paciente no existe.");

        await _patientRepository.DeletePatient(id);
    }
}
