namespace Rarug.Francisco.Parcial
{
    partial class FormCrudSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrudSupervisor));
            dataGridView1 = new DataGridView();
            btnModificar = new Button();
            button3 = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(376, 150);
            dataGridView1.TabIndex = 1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.GradientActiveCaption;
            btnModificar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(24, 32);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 30);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(179, 32);
            button3.Name = "button3";
            button3.Size = new Size(75, 30);
            button3.TabIndex = 8;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RosyBrown;
            btnEliminar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(325, 32);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 30);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(325, 262);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 33);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormCrudSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(424, 319);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(button3);
            Controls.Add(btnModificar);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrudSupervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crud Supervisor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnModificar;
        private Button button3;
        private Button btnEliminar;
        private Button btnCerrar;
    }
}