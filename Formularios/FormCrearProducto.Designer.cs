namespace Rarug.Francisco.Parcial
{
    partial class FormCrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearProducto));
            button4 = new Button();
            gbDonas = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton5 = new RadioButton();
            gbChocolate = new GroupBox();
            gbMani = new RadioButton();
            gbVegano = new RadioButton();
            gbBlanco = new RadioButton();
            gbAmargo = new RadioButton();
            btnCrearChocolate = new Button();
            label2 = new Label();
            label1 = new Label();
            gbTamaño = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            gbRelleno = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            btnCrearDona = new Button();
            gbDonas.SuspendLayout();
            gbChocolate.SuspendLayout();
            gbTamaño.SuspendLayout();
            gbRelleno.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(345, 398);
            button4.Name = "button4";
            button4.Size = new Size(95, 26);
            button4.TabIndex = 15;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // gbDonas
            // 
            gbDonas.Controls.Add(radioButton6);
            gbDonas.Controls.Add(radioButton7);
            gbDonas.Controls.Add(radioButton8);
            gbDonas.Controls.Add(radioButton5);
            gbDonas.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbDonas.Location = new Point(24, 251);
            gbDonas.Name = "gbDonas";
            gbDonas.Size = new Size(477, 88);
            gbDonas.TabIndex = 14;
            gbDonas.TabStop = false;
            gbDonas.Text = "Tipo de dona";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(110, 43);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(90, 24);
            radioButton6.TabIndex = 4;
            radioButton6.TabStop = true;
            radioButton6.Text = "Cubiertas";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.ImeMode = ImeMode.NoControl;
            radioButton7.Location = new Point(217, 43);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(109, 24);
            radioButton7.TabIndex = 3;
            radioButton7.TabStop = true;
            radioButton7.Text = "Con chispas";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.ImeMode = ImeMode.NoControl;
            radioButton8.Location = new Point(332, 43);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(144, 24);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "Chocolate blanco";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.ImeMode = ImeMode.NoControl;
            radioButton5.Location = new Point(6, 43);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(96, 24);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "Glaseadas";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // gbChocolate
            // 
            gbChocolate.Controls.Add(gbMani);
            gbChocolate.Controls.Add(gbVegano);
            gbChocolate.Controls.Add(gbBlanco);
            gbChocolate.Controls.Add(gbAmargo);
            gbChocolate.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbChocolate.Location = new Point(30, 44);
            gbChocolate.Name = "gbChocolate";
            gbChocolate.Size = new Size(457, 79);
            gbChocolate.TabIndex = 13;
            gbChocolate.TabStop = false;
            gbChocolate.Text = "Tipo de chocolate";
            // 
            // gbMani
            // 
            gbMani.AutoSize = true;
            gbMani.ImeMode = ImeMode.NoControl;
            gbMani.Location = new Point(193, 42);
            gbMani.Name = "gbMani";
            gbMani.Size = new Size(90, 24);
            gbMani.TabIndex = 3;
            gbMani.Text = "Con mani";
            gbMani.UseVisualStyleBackColor = true;
            // 
            // gbVegano
            // 
            gbVegano.AutoSize = true;
            gbVegano.ImeMode = ImeMode.NoControl;
            gbVegano.Location = new Point(110, 42);
            gbVegano.Name = "gbVegano";
            gbVegano.Size = new Size(77, 24);
            gbVegano.TabIndex = 2;
            gbVegano.Text = "Vegano";
            gbVegano.UseVisualStyleBackColor = true;
            // 
            // gbBlanco
            // 
            gbBlanco.AutoSize = true;
            gbBlanco.ImeMode = ImeMode.NoControl;
            gbBlanco.Location = new Point(289, 42);
            gbBlanco.Name = "gbBlanco";
            gbBlanco.Size = new Size(145, 24);
            gbBlanco.TabIndex = 1;
            gbBlanco.Text = "Chocolate Blanco";
            gbBlanco.UseVisualStyleBackColor = true;
            // 
            // gbAmargo
            // 
            gbAmargo.AutoSize = true;
            gbAmargo.Checked = true;
            gbAmargo.ImeMode = ImeMode.NoControl;
            gbAmargo.Location = new Point(9, 42);
            gbAmargo.Name = "gbAmargo";
            gbAmargo.Size = new Size(79, 24);
            gbAmargo.TabIndex = 0;
            gbAmargo.TabStop = true;
            gbAmargo.Text = "Amargo";
            gbAmargo.UseVisualStyleBackColor = true;
            // 
            // btnCrearChocolate
            // 
            btnCrearChocolate.BackColor = Color.PeachPuff;
            btnCrearChocolate.Font = new Font("Swis721 WGL4 BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearChocolate.ImeMode = ImeMode.NoControl;
            btnCrearChocolate.Location = new Point(572, 149);
            btnCrearChocolate.Name = "btnCrearChocolate";
            btnCrearChocolate.Size = new Size(139, 30);
            btnCrearChocolate.TabIndex = 4;
            btnCrearChocolate.Text = "Crear chocolate";
            btnCrearChocolate.UseVisualStyleBackColor = false;
            btnCrearChocolate.Click += btnCrearChocolate_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 LtEx BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(305, 216);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 12;
            label2.Text = "Donas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 LtEx BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 11;
            label1.Text = "Chocolates";
            // 
            // gbTamaño
            // 
            gbTamaño.Controls.Add(radioButton2);
            gbTamaño.Controls.Add(radioButton1);
            gbTamaño.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbTamaño.Location = new Point(539, 44);
            gbTamaño.Name = "gbTamaño";
            gbTamaño.Size = new Size(200, 79);
            gbTamaño.TabIndex = 16;
            gbTamaño.TabStop = false;
            gbTamaño.Text = "Tamaño";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(102, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "6x6";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(9, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "2x2";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbRelleno
            // 
            gbRelleno.Controls.Add(radioButton4);
            gbRelleno.Controls.Add(radioButton3);
            gbRelleno.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbRelleno.Location = new Point(539, 251);
            gbRelleno.Name = "gbRelleno";
            gbRelleno.Size = new Size(200, 88);
            gbRelleno.TabIndex = 0;
            gbRelleno.TabStop = false;
            gbRelleno.Text = "Relleno";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(5, 58);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(125, 24);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Dulce de leche";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(5, 28);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 24);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cereza";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnCrearDona
            // 
            btnCrearDona.BackColor = Color.PeachPuff;
            btnCrearDona.Font = new Font("Swis721 WGL4 BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearDona.ImeMode = ImeMode.NoControl;
            btnCrearDona.Location = new Point(572, 363);
            btnCrearDona.Name = "btnCrearDona";
            btnCrearDona.Size = new Size(139, 30);
            btnCrearDona.TabIndex = 17;
            btnCrearDona.Text = "Crear Dona";
            btnCrearDona.UseVisualStyleBackColor = false;
            btnCrearDona.Click += btnCrearDona_Click_1;
            // 
            // FormCrearProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(842, 463);
            Controls.Add(btnCrearDona);
            Controls.Add(btnCrearChocolate);
            Controls.Add(label2);
            Controls.Add(gbRelleno);
            Controls.Add(gbTamaño);
            Controls.Add(button4);
            Controls.Add(gbDonas);
            Controls.Add(gbChocolate);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrearProducto";
            Text = "Crear producto";
            gbDonas.ResumeLayout(false);
            gbDonas.PerformLayout();
            gbChocolate.ResumeLayout(false);
            gbChocolate.PerformLayout();
            gbTamaño.ResumeLayout(false);
            gbTamaño.PerformLayout();
            gbRelleno.ResumeLayout(false);
            gbRelleno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private GroupBox gbDonas;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton5;
        private GroupBox gbChocolate;
        private Button btnCrearChocolate;
        private RadioButton gbMani;
        private RadioButton gbVegano;
        private RadioButton gbBlanco;
        private RadioButton gbAmargo;
        private Label label2;
        private Label label1;
        private GroupBox gbTamaño;
        private GroupBox gbRelleno;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnCrearDona;
        private RadioButton radioButton6;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
    }
}