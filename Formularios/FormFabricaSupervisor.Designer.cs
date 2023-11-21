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
            labelTitulo = new Label();
            btnVerStock = new Button();
            btnVerProductos = new Button();
            groupBox1 = new GroupBox();
            btnDonaDefault = new Button();
            btnChocolateDefault = new Button();
            buttonCreate = new Button();
            btnCerrar = new Button();
            btnOperariosConectados = new Button();
            btnRellenarStock = new Button();
            btnCrud = new Button();
            btnOscuro = new Button();
            btnClaro = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.CadetBlue;
            labelTitulo.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(178, 48);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(436, 19);
            labelTitulo.TabIndex = 9;
            labelTitulo.Text = "Bienvenido a la fabrica MísticaMousse";
            // 
            // btnVerStock
            // 
            btnVerStock.BackColor = Color.MediumPurple;
            btnVerStock.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerStock.Location = new Point(326, 384);
            btnVerStock.Name = "btnVerStock";
            btnVerStock.Size = new Size(152, 26);
            btnVerStock.TabIndex = 8;
            btnVerStock.Text = "Ver stock";
            btnVerStock.UseVisualStyleBackColor = false;
            btnVerStock.Click += btnVerStock_Click;
            // 
            // btnVerProductos
            // 
            btnVerProductos.BackColor = Color.DarkSeaGreen;
            btnVerProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerProductos.Location = new Point(589, 384);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(199, 26);
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
            groupBox1.Location = new Point(218, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 233);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Linea produccion";
            // 
            // btnDonaDefault
            // 
            btnDonaDefault.BackColor = Color.LightSkyBlue;
            btnDonaDefault.Location = new Point(88, 50);
            btnDonaDefault.Name = "btnDonaDefault";
            btnDonaDefault.Size = new Size(172, 31);
            btnDonaDefault.TabIndex = 2;
            btnDonaDefault.Text = "Crear dona default";
            btnDonaDefault.UseVisualStyleBackColor = false;
            btnDonaDefault.Click += btnDonaDefault_Click;
            // 
            // btnChocolateDefault
            // 
            btnChocolateDefault.BackColor = Color.LightSkyBlue;
            btnChocolateDefault.Location = new Point(88, 108);
            btnChocolateDefault.Name = "btnChocolateDefault";
            btnChocolateDefault.Size = new Size(172, 32);
            btnChocolateDefault.TabIndex = 1;
            btnChocolateDefault.Text = "Crear chocolate default";
            btnChocolateDefault.UseVisualStyleBackColor = false;
            btnChocolateDefault.Click += btnChocolateDefault_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.LightSkyBlue;
            buttonCreate.Location = new Point(88, 170);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(172, 31);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Crear producto";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(33, 384);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(123, 29);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar sesion";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnOperariosConectados
            // 
            btnOperariosConectados.BackColor = Color.LightGoldenrodYellow;
            btnOperariosConectados.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperariosConectados.Location = new Point(589, 155);
            btnOperariosConectados.Name = "btnOperariosConectados";
            btnOperariosConectados.Size = new Size(199, 70);
            btnOperariosConectados.TabIndex = 11;
            btnOperariosConectados.Text = "Ver operarios conectados";
            btnOperariosConectados.UseVisualStyleBackColor = false;
            btnOperariosConectados.Click += btnOperariosConectados_Click;
            // 
            // btnRellenarStock
            // 
            btnRellenarStock.BackColor = Color.LightGoldenrodYellow;
            btnRellenarStock.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRellenarStock.Location = new Point(1, 155);
            btnRellenarStock.Name = "btnRellenarStock";
            btnRellenarStock.Size = new Size(199, 70);
            btnRellenarStock.TabIndex = 12;
            btnRellenarStock.Text = "Rellenar stock";
            btnRellenarStock.UseVisualStyleBackColor = false;
            btnRellenarStock.Click += btnRellenarStock_Click;
            // 
            // btnCrud
            // 
            btnCrud.BackColor = Color.ForestGreen;
            btnCrud.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrud.Location = new Point(589, 275);
            btnCrud.Name = "btnCrud";
            btnCrud.Size = new Size(199, 26);
            btnCrud.TabIndex = 13;
            btnCrud.Text = "CRUD";
            btnCrud.UseVisualStyleBackColor = false;
            btnCrud.Click += btnCrud_Click;
            // 
            // btnOscuro
            // 
            btnOscuro.BackColor = Color.MediumOrchid;
            btnOscuro.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnOscuro.Location = new Point(33, 252);
            btnOscuro.Name = "btnOscuro";
            btnOscuro.Size = new Size(123, 33);
            btnOscuro.TabIndex = 14;
            btnOscuro.Text = "Modo oscuro";
            btnOscuro.UseVisualStyleBackColor = false;
            btnOscuro.Click += btnOscuro_Click;
            // 
            // btnClaro
            // 
            btnClaro.BackColor = Color.PaleVioletRed;
            btnClaro.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnClaro.Location = new Point(33, 307);
            btnClaro.Name = "btnClaro";
            btnClaro.Size = new Size(123, 31);
            btnClaro.TabIndex = 15;
            btnClaro.Text = "Modo Claro";
            btnClaro.UseVisualStyleBackColor = false;
            btnClaro.Click += btnClaro_Click;
            // 
            // FormFabricaSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClaro);
            Controls.Add(btnOscuro);
            Controls.Add(btnCrud);
            Controls.Add(btnRellenarStock);
            Controls.Add(btnOperariosConectados);
            Controls.Add(btnCerrar);
            Controls.Add(labelTitulo);
            Controls.Add(btnVerStock);
            Controls.Add(btnVerProductos);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormFabricaSupervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supervisor";
            Load += FormFabricaSupervisor_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button btnVerStock;
        private Button btnVerProductos;
        private GroupBox groupBox1;
        private Button btnDonaDefault;
        private Button btnChocolateDefault;
        private Button buttonCreate;
        private Button btnCerrar;
        private Button btnOperariosConectados;
        private Button btnRellenarStock;
        private Button btnCrud;
        private Button btnOscuro;
        private Button btnClaro;

        public Label LabelTitulo { get => labelTitulo; set => labelTitulo = value; }
        public Button BtnVerStock { get => btnVerStock; set => btnVerStock = value; }
        public Button BtnVerProductos { get => btnVerProductos; set => btnVerProductos = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Button BtnDonaDefault { get => btnDonaDefault; set => btnDonaDefault = value; }
        public Button BtnChocolateDefault { get => btnChocolateDefault; set => btnChocolateDefault = value; }
        public Button ButtonCreate { get => buttonCreate; set => buttonCreate = value; }
        public Button BtnCerrar { get => btnCerrar; set => btnCerrar = value; }
        public Button BtnOperariosConectados { get => btnOperariosConectados; set => btnOperariosConectados = value; }
        public Button BtnRellenarStock { get => btnRellenarStock; set => btnRellenarStock = value; }
        public Button BtnCrud { get => btnCrud; set => btnCrud = value; }
        public Button BtnOscuro { get => btnOscuro; set => btnOscuro = value; }
        public Button BtnClaro { get => btnClaro; set => btnClaro = value; }
    }
}