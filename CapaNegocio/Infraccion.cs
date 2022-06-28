using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Infraccion : IDatos
    {
        private static int CantidadDiasVencimiento = 30;
        private static int UltimaInfraccion;
        public static void RecuperarUltimaInfraccion()
        {
            List<Dictionary<string, string>> datosInfracciones = DatosBD.Recuperar(
                "infraccion"    //SELECT * FROM infraccion
                );

            UltimaInfraccion = DatosBD.GetUltimoId("infraccion", "numInfraccion");
        }

        public int NumeroInfraccion { get; internal set; }
        public DateTime FechaInfraccion { get; internal set; }
        public DateTime FechaVencimiento { get; internal set; }
        public DateTime? FechaPago { get; internal set; }
        public TipoInfraccion TipoInfraccion { get; internal set; }
        public Vehiculo Vehiculo { get; internal set; }
        /// <summary>
        /// Monto inicial al momento de generada la infraccion
        /// </summary>
        public double ImporteBase { get; internal set; }
        /// <summary>
        /// Monto final al momento del pago
        /// </summary>
        public double MontoInfraccion { get { return GetMontoInfraccion(); } }
        private double MontoInfraccionPagado = 0;

        /// <summary>
        /// Metodo utilizado para recuperar de la base de datos, NO IMPLEMENTAR!!
        /// </summary>
        public Infraccion(int nroInfraccion, DateTime fechaInfraccion, DateTime fechaVencimiento, DateTime? fechaPago, TipoInfraccion tipoInfraccion, Vehiculo vehiculo, double importeBase, double montoInfraccion)
        {
            FechaInfraccion = fechaInfraccion;
            FechaVencimiento = fechaVencimiento;
            FechaPago = fechaPago;
            TipoInfraccion = tipoInfraccion ?? throw new ArgumentNullException(nameof(tipoInfraccion));
            Vehiculo = vehiculo ?? throw new ArgumentNullException(nameof(vehiculo));
            ImporteBase = importeBase; //congelar el importe cuando se crea la infraccion
            MontoInfraccionPagado = montoInfraccion;
            NumeroInfraccion = nroInfraccion;
        }
        public Infraccion(DateTime fechaInfraccion, TipoInfraccion tipoInfraccion, Vehiculo vehiculo)
        {
            FechaInfraccion = fechaInfraccion;
            FechaVencimiento = fechaInfraccion + new TimeSpan(CantidadDiasVencimiento,0,0,0);
            FechaPago = null;
            TipoInfraccion = tipoInfraccion ?? throw new ArgumentNullException(nameof(tipoInfraccion));
            Vehiculo = vehiculo ?? throw new ArgumentNullException(nameof(vehiculo));
            ImporteBase = tipoInfraccion.Importe; //congelar el importe cuando se crea la infraccion
            NumeroInfraccion = ++UltimaInfraccion;
        }

        private double GetMontoInfraccion()
        {
            if(MontoInfraccionPagado == 0)
            {
                TimeSpan timeDiff = FechaVencimiento - DateTime.Now;
                return TipoInfraccion.GetMontoInfraccion(timeDiff.Days, ImporteBase);
            }
            else
                return MontoInfraccionPagado;
        }
        public void RegistrarPago(DateTime fechaPago)
        {
            FechaPago = !EstaPaga() ? fechaPago : throw new InvalidOperationException("ya esta registrado el pago");
            MontoInfraccionPagado = GetMontoInfraccion();
        }
        public bool EstaPaga()
        {
            return FechaPago != null;
        }
        public override string ToString()
        {
            return FechaInfraccion.ToString(("dd/MM/yyyy")) + " - " + TipoInfraccion.Descripcion + " - " + Vehiculo.Dominio + " - " + "S" + ImporteBase;
        }
        public void Registrar()
        {
            DatosBD.Registrar(
                "infraccion",
                new Dictionary<string, object> { 
                    { "numInfraccion", NumeroInfraccion }, 
                    { "fechaInfraccion", FechaInfraccion }, 
                    { "fechaVencimiento", FechaVencimiento },
                    { "tipoInfraccion", TipoInfraccion.Codigo },
                    { "vehiculo", Vehiculo.Dominio },
                    { "importeBase", TipoInfraccion.Importe }
                    }
                );
        }
        public void Actualizar()
        {
            DatosBD.Actualizar(
            "infraccion",
            new Dictionary<string, object> {
                { "fechaPago", FechaPago },
                { "montoInfraccion", MontoInfraccion } 
                },
            new Dictionary<string, object> {
                { "numInfraccion", NumeroInfraccion }}
            );
        }
        public void Eliminar()
        {
            DatosBD.Eliminar(
            "infraccion",
            new Dictionary<string, object> {{ "numInfraccion", NumeroInfraccion }});
        }
    }
}
