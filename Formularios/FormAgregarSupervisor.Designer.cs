namespace Rarug.Francisco.Parcial
{
    partial class FormAgregarSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarSupervisor));
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombre = new TextBox();
            tbLegajo = new TextBox();
            tbPassword = new TextBox();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 49);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(26, 59);
            label5.Name = "label5";
            label5.Size = new Size(251, 34);
            label5.TabIndex = 7;
            label5.Text = "Agregar Supervisor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(115, 131);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 8;
            label6.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(115, 217);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 9;
            label2.Text = "Legajo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(115, 324);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(73, 172);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(163, 27);
            tbNombre.TabIndex = 11;
            // 
            // tbLegajo
            // 
            tbLegajo.Location = new Point(73, 272);
            tbLegajo.Name = "tbLegajo";
            tbLegajo.Size = new Size(163, 27);
            tbLegajo.TabIndex = 12;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(73, 369);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(163, 27);
            tbPassword.TabIndex = 13;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.CadetBlue;
            btnRegistro.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistro.Location = new Point(90, 436);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(130, 32);
            btnRegistro.TabIndex = 14;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            // 
            // FormAgregarSupervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(300, 496);
            Controls.Add(btnRegistro);
            Controls.Add(tbPassword);
            Controls.Add(tbLegajo);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAgregarSupervisor";
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
        private Button btnRegistro;
    }
}