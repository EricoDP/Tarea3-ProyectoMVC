using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    class DatosProducto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public int stock { get; set; }
        public DateTime fecha_Vencimiento { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public bool estado { get; set; }

        public DatosProducto() { }
        public DatosProducto(int pid, string pnombre, string pcodigo, int pstock, DateTime pfecha_vencimiento, string pdescripcion, string pcategoria, bool pestado)
        {
            id = pid;
            nombre = pnombre;
            codigo = pcodigo;
            stock = pstock;
            fecha_Vencimiento = pfecha_vencimiento;
            descripcion = pdescripcion;
            categoria = pcategoria;
            estado = pestado;
        }
    }
}
