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
            groupBox2 = new GroupBox();
            btnCrearDona = new Button();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton5 = new RadioButton();
            gbChocolate = new GroupBox();
            btnCrearChocolate = new Button();
            gbMani = new RadioButton();
            gbVegano = new RadioButton();
            gbBlanco = new RadioButton();
            gbAmargo = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            gbChocolate.SuspendLayout();
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCrearDona);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(481, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 319);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de dona";
            // 
            // btnCrearDona
            // 
            btnCrearDona.ImeMode = ImeMode.NoControl;
            btnCrearDona.Location = new Point(75, 274);
            btnCrearDona.Name = "btnCrearDona";
            btnCrearDona.Size = new Size(132, 26);
            btnCrearDona.TabIndex = 9;
            btnCrearDona.Text = "Crear Dona";
            btnCrearDona.UseVisualStyleBackColor = true;
            btnCrearDona.Click += btnCrearDona_Click;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.ImeMode = ImeMode.NoControl;
            radioButton7.Location = new Point(6, 160);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(109, 24);
            radioButton7.TabIndex = 3;
            radioButton7.TabStop = true;
            radioButton7.Text = "Con chispas";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.ImeMode = ImeMode.NoControl;
            radioButton6.Location = new Point(6, 103);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(103, 24);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Con relleno";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.ImeMode = ImeMode.NoControl;
            radioButton8.Location = new Point(6, 218);
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
            gbChocolate.Controls.Add(btnCrearChocolate);
            gbChocolate.Controls.Add(gbMani);
            gbChocolate.Controls.Add(gbVegano);
            gbChocolate.Controls.Add(gbBlanco);
            gbChocolate.Controls.Add(gbAmargo);
            gbChocolate.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbChocolate.Location = new Point(47, 75);
            gbChocolate.Name = "gbChocolate";
            gbChocolate.Size = new Size(272, 319);
            gbChocolate.TabIndex = 13;
            gbChocolate.TabStop = false;
            gbChocolate.Text = "Tipo de chocolate";
            // 
            // btnCrearChocolate
            // 
            btnCrearChocolate.ImeMode = ImeMode.NoControl;
            btnCrearChocolate.Location = new Point(61, 274);
            btnCrearChocolate.Name = "btnCrearChocolate";
            btnCrearChocolate.Size = new Size(132, 26);
            btnCrearChocolate.TabIndex = 4;
            btnCrearChocolate.Text = "Crear chocolate";
            btnCrearChocolate.UseVisualStyleBackColor = true;
            btnCrearChocolate.Click += btnCrearChocolate_Click_1;
            // 
            // gbMani
            // 
            gbMani.AutoSize = true;
            gbMani.ImeMode = ImeMode.NoControl;
            gbMani.Location = new Point(9, 159);
            gbMani.Name = "gbMani";
            gbMani.Size = new Size(90, 24);
            gbMani.TabIndex = 3;
            gbMani.TabStop = true;
            gbMani.Text = "Con mani";
            gbMani.UseVisualStyleBackColor = true;
            // 
            // gbVegano
            // 
            gbVegano.AutoSize = true;
            gbVegano.ImeMode = ImeMode.NoControl;
            gbVegano.Location = new Point(9, 101);
            gbVegano.Name = "gbVegano";
            gbVegano.Size = new Size(77, 24);
            gbVegano.TabIndex = 2;
            gbVegano.TabStop = true;
            gbVegano.Text = "Vegano";
            gbVegano.UseVisualStyleBackColor = true;
            // 
            // gbBlanco
            // 
            gbBlanco.AutoSize = true;
            gbBlanco.ImeMode = ImeMode.NoControl;
            gbBlanco.Location = new Point(6, 218);
            gbBlanco.Name = "gbBlanco";
            gbBlanco.Size = new Size(145, 24);
            gbBlanco.TabIndex = 1;
            gbBlanco.TabStop = true;
            gbBlanco.Text = "Chocolate Blanco";
            gbBlanco.UseVisualStyleBackColor = true;
            // 
            // gbAmargo
            // 
            gbAmargo.AutoSize = true;
            gbAmargo.ImeMode = ImeMode.NoControl;
            gbAmargo.Location = new Point(9, 42);
            gbAmargo.Name = "gbAmargo";
            gbAmargo.Size = new Size(79, 24);
            gbAmargo.TabIndex = 0;
            gbAmargo.TabStop = true;
            gbAmargo.Text = "Amargo";
            gbAmargo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 LtEx BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(570, 26);
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
            label1.Location = new Point(99, 26);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 11;
            label1.Text = "Chocolates";
            // 
            // FormCrearProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(gbChocolate);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrearProducto";
            Text = "Crear producto";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbChocolate.ResumeLayout(false);
            gbChocolate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private GroupBox groupBox2;
        private Button btnCrearDona;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
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
    }
}