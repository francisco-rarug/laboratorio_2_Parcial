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
            button3 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            buttonCreate = new Button();
            button1 = new Button();
            buttonOperariosConectados = new Button();
            button8 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CadetBlue;
            label3.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(178, 48);
            label3.Name = "label3";
            label3.Size = new Size(436, 19);
            label3.TabIndex = 9;
            label3.Text = "Bienvenido a la fabrica MísticaMousse";
            // 
            // button3
            // 
            button3.BackColor = Color.MediumPurple;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(326, 384);
            button3.Name = "button3";
            button3.Size = new Size(152, 26);
            button3.TabIndex = 8;
            button3.Text = "Ver stock";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(589, 384);
            button2.Name = "button2";
            button2.Size = new Size(199, 26);
            button2.TabIndex = 7;
            button2.Text = "Ver Productos creados";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(buttonCreate);
            groupBox1.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(218, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 233);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Linea produccion";
            // 
            // button6
            // 
            button6.Location = new Point(88, 50);
            button6.Name = "button6";
            button6.Size = new Size(172, 31);
            button6.TabIndex = 2;
            button6.Text = "Crear dona default";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(88, 108);
            button5.Name = "button5";
            button5.Size = new Size(172, 32);
            button5.TabIndex = 1;
            button5.Text = "Crear chocolate default";
            button5.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(88, 170);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(172, 31);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Crear producto";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(33, 384);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 10;
            button1.Text = "Cerrar sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonOperariosConectados
            // 
            buttonOperariosConectados.BackColor = Color.LightGoldenrodYellow;
            buttonOperariosConectados.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOperariosConectados.Location = new Point(602, 203);
            buttonOperariosConectados.Name = "buttonOperariosConectados";
            buttonOperariosConectados.Size = new Size(186, 70);
            buttonOperariosConectados.TabIndex = 11;
            buttonOperariosConectados.Text = "Ver operarios conectados";
            buttonOperariosConectados.UseVisualStyleBackColor = false;
            buttonOperariosConectados.Click += buttonOperariosConectados_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightGoldenrodYellow;
            button8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(12, 203);
            button8.Name = "button8";
            button8.Size = new Size(186, 70);
            button8.TabIndex = 12;
            button8.Text = "Rellenar stock";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // FormFabricaSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(buttonOperariosConectados);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormFabricaSupervisor";
            Text = "Supervisor";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button3;
        private Button button2;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button buttonCreate;
        private Button button1;
        private Button buttonOperariosConectados;
        private Button button8;
    }
}