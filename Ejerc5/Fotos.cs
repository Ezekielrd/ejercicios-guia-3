using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc5
{
    class Fotos
    {
        int id;
        int tam;
        DateTime fecha;
        string coment;

        public Fotos(int id, int tam, DateTime fecha, string coment)
        {
            this.id = id;
            this.tam = tam;
            this.fecha = fecha;
            this.coment = coment;
        }

        public int Id { get => id; set => id = value; }
        public int Tam { get => tam; set => tam = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Coment { get => coment; set => coment = value; }

        public override string ToString()
        {
            return $"Id: {Id},\nTamaño: {Tam}, \nFecha: {Fecha},\nComentario: {Coment}";
        }
    }
}
