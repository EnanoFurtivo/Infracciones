using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TipoInfraccion : IDatos
    {
        public static List<TipoInfraccion> TiposInfraccion;
        private static int UltimoTipoInfraccion;
        public static void RecuperarTiposInfraccion()
        {
            List<TipoInfraccion> tiposInfraccion = new List<TipoInfraccion>();

            List<Dictionary<string, string>> datosTiposInfraccion = DatosBD.Recuperar(
                "tipoInfraccion",                                       //FROM tiposInfraccion
                new string[] {"codigo","descripcion","importe","tipo"}  //SELECT codigo, descripcion, importe, tipo
                );

            foreach (Dictionary<string, string> datosTipoInfraccion in datosTiposInfraccion)
            {
                int codigo = int.Parse(datosTipoInfraccion["codigo"]);
                string descripcion = datosTipoInfraccion["descripcion"];
                double importe = double.Parse(datosTipoInfraccion["importe"]);
                string tipoStr = datosTipoInfraccion["tipo"];
                char tipo = tipoStr[0];
                tiposInfraccion.Add(new TipoInfraccion(codigo, descripcion, importe, tipo));
            }

            TiposInfraccion = tiposInfraccion;
            UltimoTipoInfraccion = DatosBD.GetUltimoId("tipoInfraccion", "codigo");
        }
        public static TipoInfraccion GetTipoInfraccion(int codigo)
        {
            return TiposInfraccion.Find(u => u.Codigo == codigo);
        }
        
        private enum Descuento : int
        {
            Leve20Dias = 25, //%
            Leve10Dias = 15, //%
            Grave25Dias = 20  //%
        }

        public int Codigo { get; internal set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }
        public char Tipo { get; set; }

        public TipoInfraccion(string descripcion, double importe, char tipo)
        {
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Importe = importe > 0 ? importe : throw new ArgumentOutOfRangeException(nameof(importe));
            Tipo = tipo;
            Codigo = ++UltimoTipoInfraccion;
            TiposInfraccion.Add(this);
        }
        private TipoInfraccion(int codigo, string descripcion, double importe, char tipo)
        {
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Importe = importe > 0 ? importe : throw new ArgumentOutOfRangeException(nameof(importe));
            Tipo = tipo;
            Codigo = codigo;
        }

        /// <summary>
        /// Calcula el monto a pagar de la infraccion dado el importe base y la cantidad de dias restantes hasta el vencimiento. El resultado depende del tipo de infraccion.
        /// </summary>
        public double GetMontoInfraccion(int diasRestantes, double importeBase)
        {
            if (diasRestantes <= 0) 
                throw new ArgumentOutOfRangeException(nameof(diasRestantes));
            if (importeBase <= 0) 
                throw new ArgumentOutOfRangeException(nameof(importeBase));
            
            //En caso de infraccion leve//
            if (Tipo == 'L')
            {
                if (diasRestantes >= 20)
                    return importeBase * (double)(100 - Descuento.Leve20Dias) / 100;
                else if (diasRestantes >= 10)
                    return importeBase * (double)(100 - Descuento.Leve10Dias) / 100;
                else
                    return importeBase;
            }
            //En caso de infraccion grave//
            else
            {
                if (diasRestantes >= 25)
                    return importeBase * (double)(100 - Descuento.Grave25Dias) / 100;
                else
                    return importeBase;
            }
        }
        public override string ToString()
        {
            string tipo = null;

            if (Tipo == 'L')
                tipo = "Leve";
            else if (Tipo == 'G')
                tipo = "Grave";

            return Descripcion + " - " + "$" + Importe + " - " + tipo;
        }
        public void Registrar()
        {
            DatosBD.Registrar(
                "tipoInfraccion",
                new Dictionary<string, object> { 
                    { "codigo", Codigo }, 
                    { "descripcion", Descripcion }, 
                    { "importe", Importe }, 
                    { "tipo", Tipo } }
                );
        }
        public void Actualizar()
        {
            DatosBD.Actualizar(
                "tipoInfraccion",
                new Dictionary<string, object>
                {
                    { "codigo", Codigo },
                    { "descripcion", Descripcion },
                    { "importe", Importe },
                    { "tipo", Tipo } 
                },
                new Dictionary<string, object>
                {
                    { "codigo", Codigo }
                }
            );
        }
        public void Eliminar()
        {
            throw new NotImplementedException();
        }
    }
}
