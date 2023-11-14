﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    public interface Iarchivos<T>
    {
        void CrearArchivo(string nombre, string extension, string informacion);
        void EscribirJson(string path, T objeto);
        void Escribir_XML(string path, T objeto);
        T LeerXml(string path);

        T Leer_JSON<T>(string path);
    }
}
