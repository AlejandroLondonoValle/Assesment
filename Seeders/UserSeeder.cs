using Assesment.Helpers;
using Assesment.Models;
using Assesment.Data;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Seeders;

public class UserSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(

                new User
                {
                    Id = 1,
                    Name = "Medico 1",
                    LastName = "Mosquera",
                    Email = "medico.1@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "medicate"
                },
                new User
                {
                    Id = 2,
                    Name = "Medico 2",
                    LastName = "Londoño",
                    Email = "medico.2@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "medicate"
                },
                new User
                {
                    Id = 3,
                    Name = "Medico 3",
                    LastName = "Garcia",
                    Email = "medico.3@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "medicate"
                },new User
                {
                    Id = 4,
                    Name = "Medico 4",
                    LastName = "Yepes",
                    Email = "medico.4@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "medicate"
                },new User
                {
                    Id = 5,
                    Name = "Medico 5",
                    LastName = "Alvarez",
                    Email = "medico.5@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "medicate"
                },new User
                {
                    Id = 6,
                    Name = "Medico 6",
                    LastName = "Jimenez",
                    Email = "medico.6@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "medicate"
                },new User
                {
                    Id = 7,
                    Name = "Alejandro",
                    LastName = "Londoño Valle",
                    Email = "alejandro.londono@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "patient"
                },new User
                {
                    Id = 8,
                    Name = "Kevin",
                    LastName = "Alvarez Diaz",
                    Email = "kevin.alvarez@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "patient"
                },new User
                {
                    Id = 9,
                    Name = "Nataly",
                    LastName = "Jimenez Cardozo",
                    Email = "nataly.jimenez@gmail.com",
                    IdentificationNumber = "1027809836",
                    Password = PasswordHasher.HashPassword("123456789"),
                    Address = "Cra 45 67 89",
                    Role = "patient"
                }
            );
    }
}
