using Fabrica;
using Rarug.Francisco.Parcial;
using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace Rarug.Francisco.Parcial
{
    /// <summary>
    /// Clase para aplicar y gestionar el modo oscuro en la interfaz de usuario.
    /// </summary>
    public class ModoOscuro
    {
        private FormFabricaSupervisor form;
        private ConfigSettings configuracionInicial;

        public ModoOscuro(FormFabricaSupervisor form)
        {
            this.form = form;
            configuracionInicial = ObtenerConfiguracionActual();
        }

        /// <summary>
        /// Obtiene la configuración actual de colores para el modo oscuro.
        /// </summary>
        /// <returns>Configuración actual de colores.</returns>
        private ConfigSettings ObtenerConfiguracionActual()
        {
            return new ConfigSettings
            {
                BotonRellenarStock = ColorTranslator.ToHtml(form.BtnRellenarStock.BackColor),
                BotonCrearChocolate = ColorTranslator.ToHtml(form.BtnChocolateDefault.BackColor),
                BotonVerStock = ColorTranslator.ToHtml(form.BtnVerStock.BackColor),
                BotonCrud = ColorTranslator.ToHtml(form.BtnCrud.BackColor),
                BotonOperariosConectados = ColorTranslator.ToHtml(form.BtnOperariosConectados.BackColor),
                BotonVerProductos = ColorTranslator.ToHtml(form.BtnVerProductos.BackColor),
                BotonCerrar = ColorTranslator.ToHtml(form.BtnCerrar.BackColor),
                BotonCrearProducto = ColorTranslator.ToHtml(form.ButtonCreate.BackColor),
                BotonCrearDona = ColorTranslator.ToHtml(form.BtnDonaDefault.BackColor),
                BotonModoOscuro = ColorTranslator.ToHtml(form.BtnOscuro.BackColor),
                BotonModoClaro = ColorTranslator.ToHtml(form.BtnClaro.BackColor),
                Form = ColorTranslator.ToHtml(form.BackColor),
                LabelTitulo = ColorTranslator.ToHtml(form.LabelTitulo.ForeColor),
            };
        }

        /// <summary>
        /// Aplica el modo oscuro utilizando la configuración guardada en un archivo JSON.
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo JSON con la configuración de colores.</param>
        private void AplicarModo(string rutaArchivo)
        {
            ConfigSettings configuracion;

            if (File.Exists(rutaArchivo))
            {
                var archivosManager = new Archivos<string>();
                configuracion = archivosManager.Leer_JSON<ConfigSettings>(rutaArchivo);

                try 
                {
                    form.BtnRellenarStock.BackColor = ColorTranslator.FromHtml(configuracion.BotonRellenarStock);
                    form.BtnVerStock.BackColor = ColorTranslator.FromHtml(configuracion.BotonVerStock);
                    form.BtnChocolateDefault.BackColor = ColorTranslator.FromHtml(configuracion.BotonCrearChocolate);
                    form.BtnCrud.BackColor = ColorTranslator.FromHtml(configuracion.BotonCrud);
                    form.BtnOperariosConectados.BackColor = ColorTranslator.FromHtml(configuracion.BotonOperariosConectados);
                    form.BtnVerProductos.BackColor = ColorTranslator.FromHtml(configuracion.BotonVerProductos);
                    form.BtnCerrar.BackColor = ColorTranslator.FromHtml(configuracion.BotonCerrar);
                    form.ButtonCreate.BackColor = ColorTranslator.FromHtml(configuracion.BotonCrearProducto);
                    form.BtnDonaDefault.BackColor = ColorTranslator.FromHtml(configuracion.BotonCrearDona);
                    form.BtnClaro.BackColor = ColorTranslator.FromHtml(configuracion.BotonModoClaro);
                    form.BtnOscuro.BackColor = ColorTranslator.FromHtml(configuracion.BotonModoOscuro);
                }catch(Exception ex)
                {
                    Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                }
                try
                {
                    form.BackColor = ColorTranslator.FromHtml(configuracion.Form);
                }
                catch (Exception ex)
                {
                    Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                }

                try
                {
                    form.LabelTitulo.ForeColor = ColorTranslator.FromHtml(configuracion.LabelTitulo);
                }
                catch (Exception ex)
                {
                    Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                }
            }
            else
            {
                configuracion = new ConfigSettings
                {
                    BotonRellenarStock = "",
                    BotonCrearChocolate = "",
                    BotonVerStock = "",
                    BotonCrud = "",
                    BotonOperariosConectados = "",
                    BotonVerProductos = "",
                    BotonCerrar = "",
                    BotonCrearProducto = "",
                    BotonCrearDona = "",
                    Form = "",
                    LabelTitulo = "",
                    BotonModoClaro = "",
                    BotonModoOscuro = "",
                };

                string configuracionString = JsonSerializer.Serialize(configuracion);
                var archivosManager = new Archivos<string>();
                archivosManager.EscribirJson(rutaArchivo, configuracionString);



                MessageBox.Show("Se creo el archivo de configuración.", "Archivo JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void AplicarModoOscuro()
        {
            string rutaArchivo = @"C:\Users\NoxiePC\source\repos\Rarug.Francisco.Parcial\Archivos\modoOscuro.json";

            try
            {
                if (PuedenAplicarseColores(rutaArchivo))
                {
                    AplicarModo(rutaArchivo);
                    MessageBox.Show("Modo oscuro aplicado", "Modo Oscuro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pueden aplicar todos los colores. Verifica la configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Verifica si se pueden aplicar los colores del modo oscuro.
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo JSON con la configuración de colores.</param>
        /// <returns>True si se pueden aplicar los colores, false en caso contrario.</returns>
        private bool PuedenAplicarseColores(string rutaArchivo)
        {
            ConfigSettings configuracion;

            if (File.Exists(rutaArchivo))
            {
                var archivosManager = new Archivos<string>();
                configuracion = archivosManager.Leer_JSON<ConfigSettings>(rutaArchivo);

                try
                {
                    ColorTranslator.FromHtml(configuracion.BotonRellenarStock);
                    ColorTranslator.FromHtml(configuracion.BotonVerStock);
                    ColorTranslator.FromHtml(configuracion.BotonCrearChocolate);
                    ColorTranslator.FromHtml(configuracion.BotonCrud);
                    ColorTranslator.FromHtml(configuracion.BotonOperariosConectados);
                    ColorTranslator.FromHtml(configuracion.BotonVerProductos);
                    ColorTranslator.FromHtml(configuracion.BotonCerrar);
                    ColorTranslator.FromHtml(configuracion.BotonCrearProducto);
                    ColorTranslator.FromHtml(configuracion.BotonCrearDona);
                    ColorTranslator.FromHtml(configuracion.BotonModoClaro);
                    ColorTranslator.FromHtml(configuracion.BotonModoOscuro);
                    ColorTranslator.FromHtml(configuracion.Form);
                    ColorTranslator.FromHtml(configuracion.LabelTitulo);
                    return true;
                }
                catch (Exception ex)
                {
                    Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Aplica el modo claro utilizando la configuración inicial.
        /// </summary>
        public void AplicarModoClaro()
        {
            AplicarModoInicial();
        }

        /// <summary>
        /// Aplica el modo claro restaurando la configuración inicial de colores.
        /// </summary>
        private void AplicarModoInicial()
        {
            form.BtnRellenarStock.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonRellenarStock);
            form.BtnChocolateDefault.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonCrearChocolate);
            form.BtnVerStock.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonVerStock);
            form.BtnCrud.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonCrud);
            form.BtnOperariosConectados.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonOperariosConectados);
            form.BtnVerProductos.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonVerProductos);
            form.BtnCerrar.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonCerrar);
            form.ButtonCreate.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonCrearProducto);
            form.BtnDonaDefault.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonCrearDona);
            form.BtnOscuro.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonModoOscuro);
            form.BtnClaro.BackColor = ColorTranslator.FromHtml(configuracionInicial.BotonModoClaro);

            form.BackColor = ColorTranslator.FromHtml(configuracionInicial.Form);
            form.LabelTitulo.ForeColor = ColorTranslator.FromHtml(configuracionInicial.LabelTitulo);

            MessageBox.Show("Modo claro aplicado.", "Modo claro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

