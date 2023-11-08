namespace Rarug.Francisco.Parcial
{
    partial class FormActualizarSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarSupervisor));
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombre = new TextBox();
            tbLegajo = new TextBox();
            tbPassword = new TextBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(23, 44);
            label5.Name = "label5";
            label5.Size = new Size(207, 28);
            label5.TabIndex = 7;
            label5.Text = "Agregar Supervisor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(101, 98);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 8;
            label6.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 163);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 9;
            label2.Text = "Legajo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 243);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(64, 129);
            tbNombre.Margin = new Padding(3, 2, 3, 2);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(143, 23);
            tbNombre.TabIndex = 11;
            // 
            // tbLegajo
            // 
            tbLegajo.Location = new Point(64, 204);
            tbLegajo.Margin = new Padding(3, 2, 3, 2);
            tbLegajo.Name = "tbLegajo";
            tbLegajo.Size = new Size(143, 23);
            tbLegajo.TabIndex = 12;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(64, 277);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(143, 23);
            tbPassword.TabIndex = 13;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.CadetBlue;
            btnActualizar.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(79, 327);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 34);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormActualizarSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(262, 372);
            Controls.Add(btnActualizar);
            Controls.Add(tbPassword);
            Controls.Add(tbLegajo);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormActualizarSupervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Supervisor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private TextBox tbNombre;
        private TextBox tbLegajo;
        private TextBox tbPassword;
        private Button btnActualizar;
    }
}