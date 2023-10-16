﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    /// <summary>
    /// Representa un supervisor en la fábrica, heredando las propiedades y métodos del personal.
    /// </summary>
    public class Supervisor : Personal
    {
        private string legajo;
        private static List<Supervisor> supervisor = new List<Supervisor>();

        /// <summary>
        /// Obtiene o establece la lista de supervisores en la fábrica.
        /// </summary>
        public static List<Supervisor> ListaSupervisor { get => supervisor; set => supervisor = value; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Supervisor"/> con los valores especificados.
        /// </summary>
        /// <param name="usuario">Nombre de usuario del supervisor.</param>
        /// <param name="password">Contraseña del supervisor.</param>
        /// <param name="rango">Rango del supervisor en la fábrica.</param>
        /// <param name="legajo">Número de legajo del supervisor.</param>
        public Supervisor(string usuario, string password, Rango rango, string legajo) : base(usuario, password, rango)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Proporciona una representación en texto de la información del supervisor.
        /// </summary>
        /// <returns>Una cadena que representa al supervisor.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Usuario}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Rango: {Rango}");
            return sb.ToString();
        }
    }
}
