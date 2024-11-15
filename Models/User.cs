using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Models;

[Table("users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column ("name")]
    public  string? Name { get; set; }

    [Column ("last_name")]
    public  string? LastName { get; set; }

    [Column("identification_number")]
    public string? IdentificationNumber { get; set; }

    [Column ("address")]
    public string? Address { get; set; }

    [Column ("email")]
    public string? Email { get; set; }

    [Column ("password")]
    public  string? Password { get; set; }

    //Roles = "medicate" and "patient"
    [Column ("role")]
    public string? Role { get; set; }

    public User()
    {
    }

}
