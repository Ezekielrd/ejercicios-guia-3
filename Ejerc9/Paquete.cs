using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc9
{
    class Paquete
    {
        int codigo;
        string descricion;
        string destinatario;
        string direccion;
        Ciudad Ciudad;

        public Paquete(int codigo, string descricion, string destinatario, string direccion, Ciudad ciudad)
        {
            this.Codigo = codigo;
            this.Descricion = descricion;
            this.Destinatario = destinatario;
            this.Direccion = direccion;
            Ciudad1 = ciudad;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricion { get => descricion; set => descricion = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal Ciudad Ciudad1 { get => Ciudad; set => Ciudad = value; }
    }
}
