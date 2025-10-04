﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleManager.Model
{
    [Table(nameof(Person))]
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public int? FunctionId { get; set; }
        public Function? Function { get; set; }
    }
}
