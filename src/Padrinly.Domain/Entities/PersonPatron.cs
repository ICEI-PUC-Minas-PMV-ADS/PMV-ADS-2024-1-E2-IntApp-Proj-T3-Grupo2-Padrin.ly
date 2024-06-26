﻿using Microsoft.AspNetCore.Identity;
using Padrinly.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrinly.Domain.Entities
{
    public class PersonPatron : BaseEntity
    {
        [ForeignKey(nameof(IdPatron))]
        public User Patron { get; set; }

        public int IdPatron { get; set; }

        [ForeignKey(nameof(IdStudent))]
        public User Student { get; set; }

        public int IdStudent { get; set; }
    }
}
