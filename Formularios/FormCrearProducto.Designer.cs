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
            btnCerrar = new Button();
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
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.ImeMode = ImeMode.NoControl;
            btnCerrar.Location = new Point(394, 531);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(109, 35);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // gbDonas
            // 
            gbDonas.Controls.Add(radioButton6);
            gbDonas.Controls.Add(radioButton7);
            gbDonas.Controls.Add(radioButton8);
            gbDonas.Controls.Add(radioButton5);
            gbDonas.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbDonas.Location = new Point(6, 335);
            gbDonas.Margin = new Padding(3, 4, 3, 4);
            gbDonas.Name = "gbDonas";
            gbDonas.Padding = new Padding(3, 4, 3, 4);
            gbDonas.Size = new Size(588, 117);
            gbDonas.TabIndex = 14;
            gbDonas.TabStop = false;
            gbDonas.Text = "Tipo de dona";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(142, 57);
            radioButton6.Margin = new Padding(3, 4, 3, 4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(110, 28);
            radioButton6.TabIndex = 4;
            radioButton6.Text = "Cubiertas";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.ImeMode = ImeMode.NoControl;
            radioButton7.Location = new Point(263, 57);
            radioButton7.Margin = new Padding(3, 4, 3, 4);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(135, 28);
            radioButton7.TabIndex = 3;
            radioButton7.Text = "Con chispas";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.ImeMode = ImeMode.NoControl;
            radioButton8.Location = new Point(404, 57);
            radioButton8.Margin = new Padding(3, 4, 3, 4);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(178, 28);
            radioButton8.TabIndex = 1;
            radioButton8.Text = "Chocolate blanco";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.ImeMode = ImeMode.NoControl;
            radioButton5.Location = new Point(17, 57);
            radioButton5.Margin = new Padding(3, 4, 3, 4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(119, 28);
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
            gbChocolate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbChocolate.Location = new Point(23, 59);
            gbChocolate.Margin = new Padding(3, 4, 3, 4);
            gbChocolate.Name = "gbChocolate";
            gbChocolate.Padding = new Padding(3, 4, 3, 4);
            gbChocolate.Size = new Size(565, 105);
            gbChocolate.TabIndex = 13;
            gbChocolate.TabStop = false;
            gbChocolate.Text = "Tipo de chocolate";
            // 
            // gbMani
            // 
            gbMani.AutoSize = true;
            gbMani.ImeMode = ImeMode.NoControl;
            gbMani.Location = new Point(246, 56);
            gbMani.Margin = new Padding(3, 4, 3, 4);
            gbMani.Name = "gbMani";
            gbMani.Size = new Size(112, 28);
            gbMani.TabIndex = 3;
            gbMani.Text = "Con mani";
            gbMani.UseVisualStyleBackColor = true;
            // 
            // gbVegano
            // 
            gbVegano.AutoSize = true;
            gbVegano.ImeMode = ImeMode.NoControl;
            gbVegano.Location = new Point(125, 56);
            gbVegano.Margin = new Padding(3, 4, 3, 4);
            gbVegano.Name = "gbVegano";
            gbVegano.Size = new Size(98, 28);
            gbVegano.TabIndex = 2;
            gbVegano.Text = "Vegano";
            gbVegano.UseVisualStyleBackColor = true;
            // 
            // gbBlanco
            // 
            gbBlanco.AutoSize = true;
            gbBlanco.ImeMode = ImeMode.NoControl;
            gbBlanco.Location = new Point(380, 56);
            gbBlanco.Margin = new Padding(3, 4, 3, 4);
            gbBlanco.Name = "gbBlanco";
            gbBlanco.Size = new Size(179, 28);
            gbBlanco.TabIndex = 1;
            gbBlanco.Text = "Chocolate Blanco";
            gbBlanco.UseVisualStyleBackColor = true;
            // 
            // gbAmargo
            // 
            gbAmargo.AutoSize = true;
            gbAmargo.Checked = true;
            gbAmargo.ImeMode = ImeMode.NoControl;
            gbAmargo.Location = new Point(10, 56);
            gbAmargo.Margin = new Padding(3, 4, 3, 4);
            gbAmargo.Name = "gbAmargo";
            gbAmargo.Size = new Size(98, 28);
            gbAmargo.TabIndex = 0;
            gbAmargo.TabStop = true;
            gbAmargo.Text = "Amargo";
            gbAmargo.UseVisualStyleBackColor = true;
            // 
            // btnCrearChocolate
            // 
            btnCrearChocolate.BackColor = Color.PeachPuff;
            btnCrearChocolate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearChocolate.ImeMode = ImeMode.NoControl;
            btnCrearChocolate.Location = new Point(696, 198);
            btnCrearChocolate.Margin = new Padding(3, 4, 3, 4);
            btnCrearChocolate.Name = "btnCrearChocolate";
            btnCrearChocolate.Size = new Size(159, 40);
            btnCrearChocolate.TabIndex = 4;
            btnCrearChocolate.Text = "Crear chocolate";
            btnCrearChocolate.UseVisualStyleBackColor = false;
            btnCrearChocolate.Click += btnCrearChocolate_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(349, 288);
            label2.Name = "label2";
            label2.Size = new Size(116, 39);
            label2.TabIndex = 12;
            label2.Text = "Donas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(349, 12);
            label1.Name = "label1";
            label1.Size = new Size(188, 39);
            label1.TabIndex = 11;
            label1.Text = "Chocolates";
            // 
            // gbTamaño
            // 
            gbTamaño.Controls.Add(radioButton2);
            gbTamaño.Controls.Add(radioButton1);
            gbTamaño.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbTamaño.Location = new Point(654, 59);
            gbTamaño.Margin = new Padding(3, 4, 3, 4);
            gbTamaño.Name = "gbTamaño";
            gbTamaño.Padding = new Padding(3, 4, 3, 4);
            gbTamaño.Size = new Size(229, 105);
            gbTamaño.TabIndex = 16;
            gbTamaño.TabStop = false;
            gbTamaño.Text = "Tamaño";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(117, 40);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 28);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "6x6";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(10, 40);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 28);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "2x2";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbRelleno
            // 
            gbRelleno.Controls.Add(radioButton4);
            gbRelleno.Controls.Add(radioButton3);
            gbRelleno.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbRelleno.Location = new Point(654, 335);
            gbRelleno.Margin = new Padding(3, 4, 3, 4);
            gbRelleno.Name = "gbRelleno";
            gbRelleno.Padding = new Padding(3, 4, 3, 4);
            gbRelleno.Size = new Size(229, 117);
            gbRelleno.TabIndex = 0;
            gbRelleno.TabStop = false;
            gbRelleno.Text = "Relleno";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(6, 77);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(159, 28);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Dulce de leche";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 37);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(91, 28);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "Cereza";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnCrearDona
            // 
            btnCrearDona.BackColor = Color.PeachPuff;
            btnCrearDona.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearDona.ImeMode = ImeMode.NoControl;
            btnCrearDona.Location = new Point(696, 476);
            btnCrearDona.Margin = new Padding(3, 4, 3, 4);
            btnCrearDona.Name = "btnCrearDona";
            btnCrearDona.Size = new Size(159, 40);
            btnCrearDona.TabIndex = 17;
            btnCrearDona.Text = "Crear Dona";
            btnCrearDona.UseVisualStyleBackColor = false;
            btnCrearDona.Click += btnCrearDona_Click_1;
            // 
            // FormCrearProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(962, 617);
            Controls.Add(btnCrearDona);
            Controls.Add(btnCrearChocolate);
            Controls.Add(label2);
            Controls.Add(gbRelleno);
            Controls.Add(gbTamaño);
            Controls.Add(btnCerrar);
            Controls.Add(gbDonas);
            Controls.Add(gbChocolate);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCrearProducto";
            StartPosition = FormStartPosition.CenterScreen;
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

        private Button btnCerrar;
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