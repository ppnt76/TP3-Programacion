﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Categoria
    {
        public int idCategoria { get; set; }

        public string DescripcionCategoria { get; set; }

        public Categoria() { }

        public override string ToString()
        {
            return DescripcionCategoria;
        }
    }
}
