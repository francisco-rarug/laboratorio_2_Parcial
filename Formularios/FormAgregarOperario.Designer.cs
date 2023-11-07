namespace Rarug.Francisco.Parcial
{
    partial class FormAgregarOperario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarOperario));
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(74, 132);
            tbNombre.Margin = new Padding(3, 2, 3, 2);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(143, 23);
            tbNombre.TabIndex = 0;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(74, 206);
            tbApellido.Margin = new Padding(3, 2, 3, 2);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(143, 23);
            tbApellido.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(74, 282);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(143, 23);
            tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 101);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(105, 173);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(105, 252);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(54, 40);
            label4.Name = "label4";
            label4.Size = new Size(185, 28);
            label4.TabIndex = 6;
            label4.Text = "Agregar operario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.CadetBlue;
            btnRegistrar.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(86, 339);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(114, 24);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormAgregarOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(281, 383);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgregarOperario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Operario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbApellido;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegistrar;
    }
}