namespace Rarug.Francisco.Parcial
{
    partial class FormActualizarOperario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarOperario));
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(85, 176);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(163, 27);
            tbNombre.TabIndex = 0;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(85, 275);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(163, 27);
            tbApellido.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(85, 376);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(163, 27);
            tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(121, 135);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 231);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(120, 336);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(42, 63);
            label4.Name = "label4";
            label4.Size = new Size(251, 34);
            label4.TabIndex = 6;
            label4.Text = "Actualizar operario";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.CadetBlue;
            btnActualizar.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(99, 443);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(130, 32);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormActualizarOperario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(321, 511);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormActualizarOperario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Operario";
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
        private Button btnActualizar;
    }
}