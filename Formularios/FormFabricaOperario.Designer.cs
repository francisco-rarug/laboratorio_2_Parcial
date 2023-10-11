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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(202, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Linea produccion";
            // 
            // button6
            // 
            button6.Location = new Point(117, 61);
            button6.Name = "button6";
            button6.Size = new Size(172, 31);
            button6.TabIndex = 2;
            button6.Text = "Crear dona default";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(117, 117);
            button5.Name = "button5";
            button5.Size = new Size(172, 32);
            button5.TabIndex = 1;
            button5.Text = "Crear chocolate default";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(117, 173);
            button4.Name = "button4";
            button4.Size = new Size(172, 31);
            button4.TabIndex = 0;
            button4.Text = "Crear producto";
            button4.UseVisualStyleBackColor = true;
            
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(46, 388);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 1;
            button1.Text = "Cerrar sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(616, 193);
            button2.Name = "button2";
            button2.Size = new Size(152, 26);
            button2.TabIndex = 2;
            button2.Text = "Ver materia prima";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumPurple;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(616, 252);
            button3.Name = "button3";
            button3.Size = new Size(152, 30);
            button3.TabIndex = 3;
            button3.Text = "Ver stock";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CadetBlue;
            label3.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(182, 46);
            label3.Name = "label3";
            label3.Size = new Size(436, 19);
            label3.TabIndex = 5;
            label3.Text = "Bienvenido a la fabrica MísticaMousse";
            // 
            // FormFabricaOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormFabricaOperario";
            Text = "Operario";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button6;
        private Label label3;
    }
}