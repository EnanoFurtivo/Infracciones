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

            UltimaInfraccion = datosInfracciones.Count - 1;
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
            TimeSpan timeDiff = FechaVencimiento - DateTime.Now;
            return TipoInfraccion.GetMontoInfraccion(timeDiff.Days, ImporteBase);
        }
        public void RegistrarPago(DateTime fechaPago)
        {
            FechaPago = !EstaPaga() ? fechaPago : throw new InvalidOperationException("ya esta registrado el pago");
        }
        public bool EstaPaga()
        {
            return FechaPago != null;
        }

        public bool Registrar()
        {
            return DatosBD.Registrar();
        }
        public bool Actualizar()
        {
            throw new InvalidOperationException();
        }
        public bool Eliminar()
        {
            return DatosBD.Eliminar();
        }
    }
}
