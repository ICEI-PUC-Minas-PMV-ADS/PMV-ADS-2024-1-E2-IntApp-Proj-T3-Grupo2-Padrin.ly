﻿using Padrinly.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrinly.Domain.Entities
{
    public class Document : BaseEntity
    {
        [Required]
        public int Type { get; set; }

        public string? FileName { get; set; }

        public string? InternalName { get; set; }

        [ForeignKey(nameof(IdPerson))]
        public Person Person { get; set; }

        public int IdPerson { get; set; }
    }
}
