namespace Rarug.Francisco.Parcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            gbRango = new GroupBox();
            rbSupervisor = new RadioButton();
            rbOperario = new RadioButton();
            botonIngresar = new Button();
            button2 = new Button();
            label3 = new Label();
            HardSuper = new Button();
            HardOper = new Button();
            groupBox1.SuspendLayout();
            gbRango.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(243, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio de sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 133);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 43);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(94, 163);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(100, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(94, 79);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(100, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // gbRango
            // 
            gbRango.Controls.Add(rbSupervisor);
            gbRango.Controls.Add(rbOperario);
            gbRango.Font = new Font("Swis721 WGL4 BT", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbRango.Location = new Point(588, 178);
            gbRango.Name = "gbRango";
            gbRango.Size = new Size(200, 100);
            gbRango.TabIndex = 1;
            gbRango.TabStop = false;
            gbRango.Text = "Rangos";
            // 
            // rbSupervisor
            // 
            rbSupervisor.AutoSize = true;
            rbSupervisor.Location = new Point(22, 68);
            rbSupervisor.Name = "rbSupervisor";
            rbSupervisor.Size = new Size(97, 24);
            rbSupervisor.TabIndex = 1;
            rbSupervisor.Text = "Supervisor";
            rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // rbOperario
            // 
            rbOperario.AutoSize = true;
            rbOperario.Checked = true;
            rbOperario.Location = new Point(22, 33);
            rbOperario.Name = "rbOperario";
            rbOperario.Size = new Size(86, 24);
            rbOperario.TabIndex = 0;
            rbOperario.TabStop = true;
            rbOperario.Text = "Operario";
            rbOperario.UseVisualStyleBackColor = true;
            // 
            // botonIngresar
            // 
            botonIngresar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            botonIngresar.Location = new Point(328, 378);
            botonIngresar.Name = "botonIngresar";
            botonIngresar.Size = new Size(109, 34);
            botonIngresar.TabIndex = 2;
            botonIngresar.Text = "Ingresar";
            botonIngresar.UseVisualStyleBackColor = true;
            botonIngresar.Click += botonIngresar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(53, 379);
            button2.Name = "button2";
            button2.Size = new Size(109, 34);
            button2.TabIndex = 3;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CadetBlue;
            label3.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(174, 71);
            label3.Name = "label3";
            label3.Size = new Size(436, 19);
            label3.TabIndex = 4;
            label3.Text = "Bienvenido a la fabrica MísticaMousse";
            // 
            // HardSuper
            // 
            HardSuper.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            HardSuper.Location = new Point(610, 309);
            HardSuper.Name = "HardSuper";
            HardSuper.Size = new Size(128, 42);
            HardSuper.TabIndex = 5;
            HardSuper.Text = "Hardcode supervisor";
            HardSuper.UseVisualStyleBackColor = true;
            HardSuper.Click += HardSuper_Click;
            // 
            // HardOper
            // 
            HardOper.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            HardOper.Location = new Point(610, 357);
            HardOper.Name = "HardOper";
            HardOper.Size = new Size(128, 42);
            HardOper.TabIndex = 6;
            HardOper.Text = "Hardcode operario";
            HardOper.UseVisualStyleBackColor = true;
            HardOper.Click += HardOper_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HardOper);
            Controls.Add(HardSuper);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(botonIngresar);
            Controls.Add(gbRango);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MísticaMousse";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbRango.ResumeLayout(false);
            gbRango.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private GroupBox gbRango;
        private RadioButton rbSupervisor;
        private RadioButton rbOperario;
        private Button botonIngresar;
        private Button button2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button HardSuper;
        private Button HardOper;
    }
}