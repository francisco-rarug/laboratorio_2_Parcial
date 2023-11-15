using System;
using System.Collections.Generic;
using System.Linq;

namespace Fabrica
{
    public static class Produccion
    {
        public static Dictionary<string, int> Materiales = new Dictionary<string, int>()
        {
            {"Amargo", 100 },
            {"Vegano", 100 },
            {"Con mani", 100 },
            {"Chocolate Blanco", 50 },
            {"2x2", 50 },
            {"6x6", 50 },
            {"Glaseadas", 100 },
            {"Cubiertas", 100 },
            {"Con chispas", 100 },
            {"Cereza", 50 },
            {"Dulce de leche", 50 }
        };

        private static void DecrementarStock(string tipoProducto, int cantidad)
        {
            foreach (var componente in Materiales)
            {
                if (componente.Key == tipoProducto && componente.Value >= cantidad)
                {
                    Materiales[componente.Key] -= cantidad;
                    break;
                }
            }
        }

        public static void Stock(string tipoProducto, string item)
        {
            try
            {
                DecrementarStock(tipoProducto, 30);
                DecrementarStock(item, 20);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el stock: " + ex.Message);
            }
        }

        public static bool HayStockSuficiente(string tipoProducto, string item, int cantidadTipo, int cantidadItem)
        {
            bool tieneStockTipo = false;
            bool tieneStockItem = false;

            foreach (var componente in Materiales)
            {
                if (componente.Key == tipoProducto && componente.Value >= cantidadTipo)
                {
                    tieneStockTipo = true;
                }
                if (componente.Key == item && componente.Value >= cantidadItem)
                {
                    tieneStockItem = true;
                }
            }

            return tieneStockTipo && tieneStockItem;
        }

        public static List<object> ObtenerMaterialesOrdenados()
        {
            var materialesOrdenados = Materiales.ToList();
            materialesOrdenados.Sort((clave, valor) => valor.Value - clave.Value);

            var resultado = new List<object>();

            foreach (var material in materialesOrdenados)
            {
                var elemento = new
                {
                    Componente = material.Key,
                    Cantidad = material.Value
                };
                resultado.Add(elemento);
            }

            return resultado;
        }


    }
}






