using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaContable_UCR_Model;
using SistemaContable_UCR_DataAccess;


namespace SistemaContable_UCR_Busisness
{
    public class CoordinadorDeTransacciones
    {

        public void Save(SistemaContable_UCR_Model.Transacciones laNuevaTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            gestor.Save(laNuevaTransaccion);
        }

        public void Update(SistemaContable_UCR_Model.Transacciones laTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            gestor.Update(laTransaccion);
        }

        public SistemaContable_UCR_Model.Transacciones ObtenerTransaccionPorId(int id)
        {
            SistemaContable_UCR_Model.Transacciones tran = new SistemaContable_UCR_Model.Transacciones();
            return tran;
        }
    }
}
