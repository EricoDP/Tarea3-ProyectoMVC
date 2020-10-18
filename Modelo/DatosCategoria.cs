using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    class DatosCategoria
    {
        //Atributos
        int Id;
        string Nombre;
        bool Estado;

        //Constructores
        public DatosCategoria() {; }

        public DatosCategoria(int id_c, string nombre_c, bool estado_c)
        {
            Id = id_c;
            Nombre = nombre_c;
            Estado = estado_c;
        }

        //Setters
        public void setId(int id_c) { Id = id_c; }
        public void setNombre(string nombre_c) { Nombre = nombre_c; }
        public void setEstado(bool estado_c) { Estado = estado_c; }

        //Getters
        public int getId() { return Id; }
        public string getNombre() { return Nombre; }
        public bool getEstado() { return Estado; }
    }
}
