﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Base.Domain.Entidades.Escuela;

namespace Base.Domain.Entidades.Core
{
    public abstract class BaseEntity
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool EsBorrado { get; set; }
    }
}
