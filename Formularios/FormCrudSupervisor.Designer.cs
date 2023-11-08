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
            dgSupervisor = new DataGridView();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSupervisor).BeginInit();
            SuspendLayout();
            // 
            // dgSupervisor
            // 
            dgSupervisor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSupervisor.Location = new Point(24, 84);
            dgSupervisor.Name = "dgSupervisor";
            dgSupervisor.RowTemplate.Height = 25;
            dgSupervisor.Size = new Size(376, 150);
            dgSupervisor.TabIndex = 1;
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
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(179, 32);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 30);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
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
            btnEliminar.Click += btnEliminar_Click;
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
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(dgSupervisor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrudSupervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crud Supervisor";
            ((System.ComponentModel.ISupportInitialize)dgSupervisor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgSupervisor;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnCerrar;
    }
}