using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Models;

[Table("appointments")]
public class Appointment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("date")]
    public DateTime Date { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("status")]
    public string? Status { get; set; }

    [Column("medicate_id")]
    public int MedicateId { get; set; }

    [ForeignKey("MedicateId")]
    public Medicate? Medicate { get; set; }

    [Column("patient_id")]
    public int PatientId { get; set; }

    [ForeignKey("PatientId")]
    public Patient? Patient { get; set; }


    public Appointment()
    {
        
    }

}
