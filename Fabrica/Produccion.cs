using System;
using System.Collections.Generic;

namespace Fabrica
{
    public class Produccion
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
            DecrementarStock(tipoProducto, 30);
            DecrementarStock(item, 20);
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

        public static Dictionary<string, int> ObtenerMateriales()
        {
            return new Dictionary<string, int>(Materiales);
        }
    }
}




