namespace Rarug.Francisco.Parcial
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            gbRango = new GroupBox();
            rbSupervisor = new RadioButton();
            rbOperario = new RadioButton();
            botonIngresar = new Button();
            btnCerrar = new Button();
            label3 = new Label();
            HardSuper = new Button();
            HardOper = new Button();
            btnNuevoOperario = new Button();
            btnNuevoSupervisor = new Button();
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(278, 149);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(326, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio de sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 177);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 57);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(107, 217);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(114, 29);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(107, 105);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(114, 29);
            textBoxUsername.TabIndex = 0;
            // 
            // gbRango
            // 
            gbRango.Controls.Add(rbSupervisor);
            gbRango.Controls.Add(rbOperario);
            gbRango.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbRango.Location = new Point(672, 237);
            gbRango.Margin = new Padding(3, 4, 3, 4);
            gbRango.Name = "gbRango";
            gbRango.Padding = new Padding(3, 4, 3, 4);
            gbRango.Size = new Size(229, 133);
            gbRango.TabIndex = 1;
            gbRango.TabStop = false;
            gbRango.Text = "Rangos";
            // 
            // rbSupervisor
            // 
            rbSupervisor.AutoSize = true;
            rbSupervisor.Location = new Point(25, 91);
            rbSupervisor.Margin = new Padding(3, 4, 3, 4);
            rbSupervisor.Name = "rbSupervisor";
            rbSupervisor.Size = new Size(121, 28);
            rbSupervisor.TabIndex = 1;
            rbSupervisor.Text = "Supervisor";
            rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // rbOperario
            // 
            rbOperario.AutoSize = true;
            rbOperario.Checked = true;
            rbOperario.Location = new Point(25, 44);
            rbOperario.Margin = new Padding(3, 4, 3, 4);
            rbOperario.Name = "rbOperario";
            rbOperario.Size = new Size(105, 28);
            rbOperario.TabIndex = 0;
            rbOperario.TabStop = true;
            rbOperario.Text = "Operario";
            rbOperario.UseVisualStyleBackColor = true;
            // 
            // botonIngresar
            // 
            botonIngresar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            botonIngresar.Location = new Point(375, 504);
            botonIngresar.Margin = new Padding(3, 4, 3, 4);
            botonIngresar.Name = "botonIngresar";
            botonIngresar.Size = new Size(125, 45);
            botonIngresar.TabIndex = 2;
            botonIngresar.Text = "Ingresar";
            botonIngresar.UseVisualStyleBackColor = true;
            botonIngresar.Click += botonIngresar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(61, 505);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(146, 45);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CadetBlue;
            label3.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(199, 95);
            label3.Name = "label3";
            label3.Size = new Size(531, 25);
            label3.TabIndex = 4;
            label3.Text = "Bienvenido a la fabrica MísticaMousse";
            // 
            // HardSuper
            // 
            HardSuper.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            HardSuper.Location = new Point(697, 412);
            HardSuper.Margin = new Padding(3, 4, 3, 4);
            HardSuper.Name = "HardSuper";
            HardSuper.Size = new Size(146, 56);
            HardSuper.TabIndex = 5;
            HardSuper.Text = "Hardcode supervisor";
            HardSuper.UseVisualStyleBackColor = true;

            // 
            // HardOper
            // 
            HardOper.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            HardOper.Location = new Point(697, 476);
            HardOper.Margin = new Padding(3, 4, 3, 4);
            HardOper.Name = "HardOper";
            HardOper.Size = new Size(146, 56);
            HardOper.TabIndex = 6;
            HardOper.Text = "Hardcode operario";
            HardOper.UseVisualStyleBackColor = true;

            // 
            // btnNuevoOperario
            // 
            btnNuevoOperario.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoOperario.Location = new Point(61, 237);
            btnNuevoOperario.Margin = new Padding(3, 4, 3, 4);
            btnNuevoOperario.Name = "btnNuevoOperario";
            btnNuevoOperario.Size = new Size(146, 56);
            btnNuevoOperario.TabIndex = 7;
            btnNuevoOperario.Text = "Agregar operario";
            btnNuevoOperario.UseVisualStyleBackColor = true;
            btnNuevoOperario.Click += btnNuevoOperario_Click;
            // 
            // btnNuevoSupervisor
            // 
            btnNuevoSupervisor.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoSupervisor.Location = new Point(61, 328);
            btnNuevoSupervisor.Margin = new Padding(3, 4, 3, 4);
            btnNuevoSupervisor.Name = "btnNuevoSupervisor";
            btnNuevoSupervisor.Size = new Size(146, 56);
            btnNuevoSupervisor.TabIndex = 8;
            btnNuevoSupervisor.Text = "Agregar supervisor";
            btnNuevoSupervisor.UseVisualStyleBackColor = true;
            btnNuevoSupervisor.Click += btnNuevoSupervisor_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnNuevoSupervisor);
            Controls.Add(btnNuevoOperario);
            Controls.Add(HardOper);
            Controls.Add(HardSuper);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(botonIngresar);
            Controls.Add(gbRango);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MísticaMousse";
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
        private Button btnCerrar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button HardSuper;
        private Button HardOper;
        private Button btnNuevoOperario;
        private Button btnNuevoSupervisor;
    }
}