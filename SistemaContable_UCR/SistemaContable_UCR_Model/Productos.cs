﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable_UCR_Model
{
    public class Productos
    {
        public int ID { get; set; }
        public string Producto { get; set; }
        public float Precio { get; set; }
        public Tipos IdTipo { get; set; }
        public string Descripcion { get; set; }
    }
}
