﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("admin")]
    public class Admin
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("Surname")]
        public string Surname { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("e-mail")]
        public string Email { get; set; }

        [Column("phoneNumber")]
        public string PhoneNumber { get; set; }
    }
}