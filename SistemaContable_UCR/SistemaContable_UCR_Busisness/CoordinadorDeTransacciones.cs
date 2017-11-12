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

        public int Save(SistemaContable_UCR_Model.Transacciones laNuevaTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();

            Productos producto = coordinadorDeProductos.getById(laNuevaTransaccion.IdProducto);

            laNuevaTransaccion.Total = laNuevaTransaccion.Cantidad * producto.Precio;
            laNuevaTransaccion.Fecha = DateTimeSQLite(DateTime.Now);

            return gestor.Save(laNuevaTransaccion);
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";

            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day);
        }

        public int Update(SistemaContable_UCR_Model.Transacciones laTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();

            Productos producto = coordinadorDeProductos.getById(laTransaccion.IdProducto);

            laTransaccion.Total = laTransaccion.Cantidad * producto.Precio;

            DateTime fecha = DateTime.Parse(laTransaccion.Fecha);
            laTransaccion.Fecha = DateTimeSQLite(fecha);

            return gestor.Update(laTransaccion);
        }

        public Transacciones getById(int Id)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getById(Id);
        }

        public int Delete(int Id)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.Delete(Id);
        }

        public List<Transacciones> getAll() {

            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getAll();
        }

        public List<Transacciones> getComprasByDate(DateTime Desde, DateTime Hasta)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            string buscarDesde = DateTimeSQLite(Desde);
            string buscarHasta = DateTimeSQLite(Hasta.AddDays(1));
            int tipo = (int)Tipos.Compra;

            return gestor.getByDate(buscarDesde, buscarHasta, tipo);
        }

        public List<Transacciones> getVentasByDate(DateTime Desde, DateTime Hasta)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            string buscarDesde = DateTimeSQLite(Desde);
            string buscarHasta = DateTimeSQLite(Hasta.AddDays(1));
            int tipo = (int)Tipos.Venta;

            return gestor.getByDate(buscarDesde, buscarHasta, tipo);
        }

        public List<Transacciones> getByType(int Tipo)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getByType(Tipo);
        }

        public List<Transacciones> getComprasByProductName(string Nombre)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getByProductName(Nombre, 2);
        }

        public List<Transacciones> getVentasByProductName(string Nombre)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getByProductName(Nombre, 1);
        }
    }
}
