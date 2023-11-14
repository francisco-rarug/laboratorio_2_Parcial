using Fabrica;
using Rarug.Francisco.Parcial;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Rarug.Francisco.Parcial
{
    public class ModoOscuro
    {
        private FormFabricaSupervisor form;
        private ConfigSettings configuracionInicial;

        public ModoOscuro(FormFabricaSupervisor form)
        {
            this.form = form;
            configuracionInicial = ObtenerConfiguracionActual();
        }

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

        private void AplicarModo(string rutaArchivo)
        {
            ConfigSettings configuracion;

            if (File.Exists(rutaArchivo))
            {
                var archivosManager = new Archivos<string>();
                configuracion = archivosManager.Leer_JSON<ConfigSettings>(rutaArchivo);

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

                try
                {
                    form.BackColor = ColorTranslator.FromHtml(configuracion.Form);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al aplicar el color de fondo al formulario: " + ex.Message);
                }

                try
                {
                    form.LabelTitulo.ForeColor = ColorTranslator.FromHtml(configuracion.LabelTitulo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al aplicar el color del label: " + ex.Message);
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
            AplicarModo(rutaArchivo);
            MessageBox.Show("Modo oscuro aplicado", "Modo Oscuro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AplicarModoClaro()
        {
            AplicarModoInicial();
        }

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

