using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Modelo
{
    public class NegocioProducto
    {
        static Dictionary<int, DatosProducto> Registros = new Dictionary<int, DatosProducto>();
        int cant = 0;

        public bool AgregarProducto(string nombre_p, string codigo_p, int stock_p, DateTime fecha_vencimiento_p, string descripcion_p, string categoria_p, bool estado_p)
        {
            try
            {
                DatosProducto ObjDatos = new DatosProducto();

                ObjDatos.id = cant + 1;
                ObjDatos.nombre = nombre_p;
                ObjDatos.codigo = codigo_p;
                ObjDatos.stock = stock_p;
                ObjDatos.fecha_Vencimiento = fecha_vencimiento_p;
                ObjDatos.descripcion = descripcion_p;
                ObjDatos.categoria = categoria_p;
                ObjDatos.estado = estado_p;

                Registros.Add(ObjDatos.id, ObjDatos);
                cant++;
                return true;
            }
            catch { return false; }
        }

        public ArrayList BuscarProducto(int id)
        {
            ArrayList ObjDatos = new ArrayList();

            if (Registros.ContainsKey(id) == true)
            {
                ObjDatos.Add(Registros[id].id);
                ObjDatos.Add(Registros[id].nombre);
                ObjDatos.Add(Registros[id].codigo);
                ObjDatos.Add(Registros[id].stock);
                ObjDatos.Add(Registros[id].fecha_Vencimiento);
                ObjDatos.Add(Registros[id].descripcion);
                ObjDatos.Add(Registros[id].categoria);
                ObjDatos.Add(Registros[id].estado);
            }

            return ObjDatos;
        }

        public bool ModificarProducto(int id, string nombre_p, string codigo_p, int stock_p, DateTime fecha_vencimiento_p, string descripcion_p, string categoria_p, bool estado_p)
        {
            if (Registros.ContainsKey(id) == true)
            {
                DatosProducto ObjDatos = new DatosProducto();
                ObjDatos.id = id;
                ObjDatos.nombre = nombre_p;
                ObjDatos.codigo = codigo_p;
                ObjDatos.stock = stock_p;
                ObjDatos.fecha_Vencimiento = fecha_vencimiento_p;
                ObjDatos.descripcion = descripcion_p;
                ObjDatos.categoria = categoria_p;
                ObjDatos.estado = estado_p;

                Registros[id] = ObjDatos;
                return true;
            }
            else { return false; }
        }

        public bool EliminarProducto(int id)
        {
            if (Registros.ContainsKey(id) == true)
            {
                Registros.Remove(id);
                return true;
            }
            else { return false; }
        }

        public DataTable ListarProducto()
        {
            DataTable Productos = new DataTable();

            Productos.Columns.Add("ID");
            Productos.Columns.Add("Nombre");
            Productos.Columns.Add("Codigo");
            Productos.Columns.Add("Existencia");
            Productos.Columns.Add("Fecha de Vencimiento");
            Productos.Columns.Add("Descripcion");
            Productos.Columns.Add("Categoria");
            Productos.Columns.Add("Estado");

            foreach(DatosProducto reg in Registros.Values)
            {
                string estado;
                if(reg.estado == true) { estado = "Activo"; } else { estado="Inactivo"; }
                Productos.Rows.Add(reg.id,reg.nombre,reg.codigo,reg.stock, (reg.fecha_Vencimiento).ToString("dd/MM/yyyy"),reg.descripcion,reg.categoria,estado);
            }

            return Productos;
        }
    }
}
