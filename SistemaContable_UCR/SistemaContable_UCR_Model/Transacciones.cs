using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable_UCR_Model
{
    class Transacciones
    {

        public int ID { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public float Total { get; set; }

        public DateTime Fecha { get; set; }

        public int IdTipo { get; set; }
    }
}
