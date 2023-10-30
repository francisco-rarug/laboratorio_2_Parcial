namespace Rarug.Francisco.Parcial
{
    partial class FormFabricaSupervisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFabricaSupervisor));
            label3 = new Label();
            btnVerStock = new Button();
            btnVerProductos = new Button();
            groupBox1 = new GroupBox();
            btnDonaDefault = new Button();
            btnChocolateDefault = new Button();
            buttonCreate = new Button();
            btnCerrar = new Button();
            btnOperariosConectados = new Button();
            btnRellenarStock = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CadetBlue;
            label3.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(203, 64);
            label3.Name = "label3";
            label3.Size = new Size(531, 25);
            label3.TabIndex = 9;
            label3.Text = "Bienvenido a la fabrica MísticaMousse";
            // 
            // btnVerStock
            // 
            btnVerStock.BackColor = Color.MediumPurple;
            btnVerStock.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerStock.Location = new Point(373, 512);
            btnVerStock.Margin = new Padding(3, 4, 3, 4);
            btnVerStock.Name = "btnVerStock";
            btnVerStock.Size = new Size(174, 35);
            btnVerStock.TabIndex = 8;
            btnVerStock.Text = "Ver stock";
            btnVerStock.UseVisualStyleBackColor = false;
            btnVerStock.Click += btnVerStock_Click;
            // 
            // btnVerProductos
            // 
            btnVerProductos.BackColor = Color.DarkSeaGreen;
            btnVerProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerProductos.Location = new Point(673, 512);
            btnVerProductos.Margin = new Padding(3, 4, 3, 4);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(227, 35);
            btnVerProductos.TabIndex = 7;
            btnVerProductos.Text = "Ver Productos creados";
            btnVerProductos.UseVisualStyleBackColor = false;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDonaDefault);
            groupBox1.Controls.Add(btnChocolateDefault);
            groupBox1.Controls.Add(buttonCreate);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(249, 140);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(406, 311);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Linea produccion";
            // 
            // btnDonaDefault
            // 
            btnDonaDefault.Location = new Point(101, 67);
            btnDonaDefault.Margin = new Padding(3, 4, 3, 4);
            btnDonaDefault.Name = "btnDonaDefault";
            btnDonaDefault.Size = new Size(197, 41);
            btnDonaDefault.TabIndex = 2;
            btnDonaDefault.Text = "Crear dona default";
            btnDonaDefault.UseVisualStyleBackColor = true;
            btnDonaDefault.Click += btnDonaDefault_Click;
            // 
            // btnChocolateDefault
            // 
            btnChocolateDefault.Location = new Point(101, 144);
            btnChocolateDefault.Margin = new Padding(3, 4, 3, 4);
            btnChocolateDefault.Name = "btnChocolateDefault";
            btnChocolateDefault.Size = new Size(197, 43);
            btnChocolateDefault.TabIndex = 1;
            btnChocolateDefault.Text = "Crear chocolate default";
            btnChocolateDefault.UseVisualStyleBackColor = true;
            btnChocolateDefault.Click += btnChocolateDefault_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(101, 227);
            buttonCreate.Margin = new Padding(3, 4, 3, 4);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(197, 41);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Crear producto";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(38, 512);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(141, 39);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar sesion";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnOperariosConectados
            // 
            btnOperariosConectados.BackColor = Color.LightGoldenrodYellow;
            btnOperariosConectados.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperariosConectados.Location = new Point(688, 271);
            btnOperariosConectados.Margin = new Padding(3, 4, 3, 4);
            btnOperariosConectados.Name = "btnOperariosConectados";
            btnOperariosConectados.Size = new Size(213, 93);
            btnOperariosConectados.TabIndex = 11;
            btnOperariosConectados.Text = "Ver operarios conectados";
            btnOperariosConectados.UseVisualStyleBackColor = false;
            btnOperariosConectados.Click += btnOperariosConectados_Click;
            // 
            // btnRellenarStock
            // 
            btnRellenarStock.BackColor = Color.LightGoldenrodYellow;
            btnRellenarStock.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRellenarStock.Location = new Point(14, 271);
            btnRellenarStock.Margin = new Padding(3, 4, 3, 4);
            btnRellenarStock.Name = "btnRellenarStock";
            btnRellenarStock.Size = new Size(213, 93);
            btnRellenarStock.TabIndex = 12;
            btnRellenarStock.Text = "Rellenar stock";
            btnRellenarStock.UseVisualStyleBackColor = false;
            btnRellenarStock.Click += btnRellenarStock_Click;
            // 
            // FormFabricaSupervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(914, 600);
            Controls.Add(btnRellenarStock);
            Controls.Add(btnOperariosConectados);
            Controls.Add(btnCerrar);
            Controls.Add(label3);
            Controls.Add(btnVerStock);
            Controls.Add(btnVerProductos);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFabricaSupervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supervisor";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnVerStock;
        private Button btnVerProductos;
        private GroupBox groupBox1;
        private Button btnDonaDefault;
        private Button btnChocolateDefault;
        private Button buttonCreate;
        private Button btnCerrar;
        private Button btnOperariosConectados;
        private Button btnRellenarStock;
    }
}