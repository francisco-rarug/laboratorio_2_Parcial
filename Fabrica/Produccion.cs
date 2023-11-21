using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Fabrica
{
    /// <summary>
    /// Clase estática que gestiona la producción y stock de materiales en la fábrica.
    /// </summary>
    public static class Produccion
    {
        /// <summary>
        /// Diccionario que almacena la cantidad disponible de cada material.
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
        /// Decrementa la cantidad de stock de un tipo de producto.
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
        /// Actualiza el stock después de producir un conjunto de productos.
        /// </summary>
        /// <param name="tipoProducto">Tipo de producto a decrementar.</param>
        /// <param name="item">Item específico del producto a decrementar.</param>
        public static void Stock(string tipoProducto, string item)
        {
            try
            {
                DecrementarStock(tipoProducto, 30);
                DecrementarStock(item, 20);
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Verifica si hay suficiente stock de un tipo específico de producto y item.
        /// </summary>
        /// <param name="tipoProducto">Tipo de producto.</param>
        /// <param name="item">Item específico del producto.</param>
        /// <param name="cantidadTipo">Cantidad necesaria del tipo de producto.</param>
        /// <param name="cantidadItem">Cantidad necesaria del item.</param>
        /// <returns>True si hay suficiente stock, False en caso contrario.</returns>
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
        /// Obtiene la lista de materiales ordenada por cantidad descendente.
        /// </summary>
        /// <returns>Lista de materiales ordenada.</returns>
        public static List<object> ObtenerMaterialesOrdenados()
        {
            var materialesOrdenados = Materiales.ToList();
            materialesOrdenados.Sort((x, y) => y.Value - x.Value);

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

        /// <summary>
        /// Actualiza la cantidad de materiales después de producir un lote de productos.
        /// </summary>
        /// <param name="cantidad">Cantidad a agregar a cada material.</param>
        /// <param name="productosSeleccionados">Lista de productos seleccionados.</param>
        public static void ActualizarMateriales(int cantidad, List<string> productosSeleccionados)
        {
            foreach (string producto in productosSeleccionados)
            {
                if (Materiales.ContainsKey(producto))
                {
                    Materiales[producto] += cantidad;
                }
                else
                {
                    Materiales.Add(producto, cantidad);
                }
            }
        }
    }
}
