﻿using Fabrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rarug.Francisco.Parcial
{
    public partial class FormFabricaOperario : Form, IFormFabrica
    {
        public FormFabricaOperario()
        {
            InitializeComponent();
        }
        public void CrearChocolateDefault()
        {
            try
            {
                Chocolate chocolate = Chocolate.CrearChocolateDefault();

                if (chocolate != null)
                {
                    FormModal1 formProduct = new FormModal1();
                    formProduct.ShowDialog();

                    MessageBox.Show("Chocolate creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al crear el chocolate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CrearDonaDefault()
        {
            try
            {
                Dona dona = Dona.CrearDonaDefault();

                if (dona != null)
                {
                    FormModal1 formProduct = new FormModal1();
                    formProduct.ShowDialog();

                    MessageBox.Show("Dona creada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al crear la dona: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDonaDefault_Click(object sender, EventArgs e)
        {
            CrearDonaDefault();
        }

        private void btnChocoDefault_Click(object sender, EventArgs e)
        {
            CrearChocolateDefault();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormProductosCreados formProductosCreados = new FormProductosCreados();
            Hide();
            DialogResult result = formProductosCreados.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            FormVerStock formVerStock = new FormVerStock();
            Hide();
            DialogResult result = formVerStock.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            FormCrearProducto formProduct = new FormCrearProducto();
            Hide();
            DialogResult result = formProduct.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
