using System;
using System.Collections.Generic;

namespace Fabrica
{
    /// <summary>
    /// Clase estática que representa la producción y gestión de stock de materiales en la fábrica.
    /// </summary>
    public static class Produccion
    {
        /// <summary>
        /// Diccionario que mapea los materiales con su respectivo stock.
        /// </summary>
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

        /// <summary>
        /// Decrementa el stock del tipo de producto proporcionado.
        /// </summary>
        /// <param name="tipoProducto">Tipo de producto a decrementar.</param>
        /// <param name="cantidad">Cantidad a decrementar.</param>
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

        /// <summary>
        /// Disminuye el stock de un tipo de producto específico.
        /// </summary>
        /// <param name="tipoProducto">El tipo de producto a decrementar.</param>
        public static void Stock(string tipoProducto)
        {
            DecrementarStock(tipoProducto, 30);
        }
        /// <summary>
        /// Disminuye el stock de un tipo de producto y un ítem específicos.
        /// </summary>
        /// <param name="tipoProducto">El tipo de producto a decrementar.</param>
        /// <param name="item">El ítem a decrementar.</param>
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


        /// <summary>
        /// Verifica si hay stock suficiente para el tipo de producto y el ítem proporcionados.
        /// </summary>
        /// <param name="tipoProducto">Tipo de producto a verificar.</param>
        /// <param name="item">Ítem a verificar.</param>
        /// <param name="cantidadTipo">Cantidad requerida del tipo de producto.</param>
        /// <param name="cantidadItem">Cantidad requerida del ítem.</param>
        /// <returns>True si hay stock suficiente; de lo contrario, False.</returns>
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

        /// <summary>
        /// Obtiene una copia del diccionario de materiales con sus stocks actuales.
        /// </summary>
        /// <returns>Diccionario con los materiales y sus stocks.</returns>
        public static Dictionary<string, int> ObtenerMateriales()
        {
            return new Dictionary<string, int>(Materiales);
        }
    }
}





