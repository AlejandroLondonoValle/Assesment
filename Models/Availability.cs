using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Models;


[Table("availabilities")]
public class Availability
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("start_time")]
    public DateTime StartTime { get; set; }

    [Column("end_time")]
    public DateTime EndTime { get; set; }

    [Column("medicate_id")]
    public int MedicateId { get; set; }

    [ForeignKey("MedicateId")]
    public Medicate? Medicate { get; set; }


    public Availability()
    {
        
    }
}
