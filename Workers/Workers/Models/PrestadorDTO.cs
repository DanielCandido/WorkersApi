﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workers.Models
{
    public class PrestadorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
    }
}