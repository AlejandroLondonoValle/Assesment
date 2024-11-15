using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Models;


[Table("medicates")]
public class Medicate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("specialty")]
    public string? Specialty { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; }

    [Column("availability_id")]
    public int AvailabilityId { get; set; }

    [ForeignKey("AvailabilityId")]
    public Availability? Availability { get; set; }


    public Medicate()
    {
        
    }

}
