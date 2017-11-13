using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable_UCR_Model
{
    public class Gastos
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}
