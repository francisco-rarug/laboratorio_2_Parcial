namespace Rarug.Francisco.Parcial
{
    partial class FormFabricaOperario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFabricaOperario));
            groupBox1 = new GroupBox();
            btnDonaDefault = new Button();
            btnChocoDefault = new Button();
            btnCrearProducto = new Button();
            btnCerrar = new Button();
            btnVerProductos = new Button();
            btnVerStock = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDonaDefault);
            groupBox1.Controls.Add(btnChocoDefault);
            groupBox1.Controls.Add(btnCrearProducto);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(231, 137);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(429, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Linea produccion";
            // 
            // btnDonaDefault
            // 
            btnDonaDefault.Location = new Point(134, 81);
            btnDonaDefault.Margin = new Padding(3, 4, 3, 4);
            btnDonaDefault.Name = "btnDonaDefault";
            btnDonaDefault.Size = new Size(197, 41);
            btnDonaDefault.TabIndex = 2;
            btnDonaDefault.Text = "Crear dona default";
            btnDonaDefault.UseVisualStyleBackColor = true;
            btnDonaDefault.Click += btnDonaDefault_Click;
            // 
            // btnChocoDefault
            // 
            btnChocoDefault.Location = new Point(134, 156);
            btnChocoDefault.Margin = new Padding(3, 4, 3, 4);
            btnChocoDefault.Name = "btnChocoDefault";
            btnChocoDefault.Size = new Size(197, 43);
            btnChocoDefault.TabIndex = 1;
            btnChocoDefault.Text = "Crear chocolate default";
            btnChocoDefault.UseVisualStyleBackColor = true;
            btnChocoDefault.Click += btnChocoDefault_Click;
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(134, 231);
            btnCrearProducto.Margin = new Padding(3, 4, 3, 4);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(197, 41);
            btnCrearProducto.TabIndex = 0;
            btnCrearProducto.Text = "Crear producto";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(53, 517);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(141, 39);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar sesion";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnVerProductos
            // 
            btnVerProductos.BackColor = Color.DarkSeaGreen;
            btnVerProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerProductos.Location = new Point(704, 265);
            btnVerProductos.Margin = new Padding(3, 4, 3, 4);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(197, 71);
            btnVerProductos.TabIndex = 2;
            btnVerProductos.Text = "Ver productos creados";
            btnVerProductos.UseVisualStyleBackColor = false;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // btnVerStock
            // 
            btnVerStock.BackColor = Color.MediumPurple;
            btnVerStock.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerStock.Location = new Point(704, 375);
            btnVerStock.Margin = new Padding(3, 4, 3, 4);
            btnVerStock.Name = "btnVerStock";
            btnVerStock.Size = new Size(197, 73);
            btnVerStock.TabIndex = 3;
            btnVerStock.Text = "Ver stock";
            btnVerStock.UseVisualStyleBackColor = false;
            btnVerStock.Click += btnVerStock_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CadetBlue;
            label3.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(208, 61);
            label3.Name = "label3";
            label3.Size = new Size(531, 25);
            label3.TabIndex = 5;
            label3.Text = "Bienvenido a la fabrica MísticaMousse";
            // 
            // FormFabricaOperario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(btnVerStock);
            Controls.Add(btnVerProductos);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFabricaOperario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operario";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCerrar;
        private Button btnChocoDefault;
        private Button btnCrearProducto;
        private Button btnVerProductos;
        private Button btnVerStock;
        private Button btnDonaDefault;
        private Label label3;
    }
}