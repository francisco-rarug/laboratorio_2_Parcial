namespace Rarug.Francisco.Parcial
{
    partial class FormCrudOperario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrudOperario));
            dgOperario = new DataGridView();
            btnCerrar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgOperario).BeginInit();
            SuspendLayout();
            // 
            // dgOperario
            // 
            dgOperario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOperario.Location = new Point(24, 87);
            dgOperario.Name = "dgOperario";
            dgOperario.RowTemplate.Height = 25;
            dgOperario.Size = new Size(376, 150);
            dgOperario.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(325, 280);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 33);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.GradientActiveCaption;
            btnModificar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(24, 40);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 30);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(182, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 30);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RosyBrown;
            btnEliminar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(325, 40);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 30);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormCrudOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(425, 325);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnCerrar);
            Controls.Add(dgOperario);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrudOperario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD Operario";
            ((System.ComponentModel.ISupportInitialize)dgOperario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgOperario;
        private Button btnCerrar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}