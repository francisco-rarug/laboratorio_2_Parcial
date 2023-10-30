namespace Rarug.Francisco.Parcial
{
    partial class VerOperarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerOperarios));
            dataOperarios = new DataGridView();
            label1 = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataOperarios).BeginInit();
            SuspendLayout();
            // 
            // dataOperarios
            // 
            dataOperarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataOperarios.Location = new Point(130, 95);
            dataOperarios.Margin = new Padding(3, 4, 3, 4);
            dataOperarios.Name = "dataOperarios";
            dataOperarios.RowHeadersWidth = 51;
            dataOperarios.RowTemplate.Height = 25;
            dataOperarios.Size = new Size(406, 252);
            dataOperarios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 35);
            label1.Name = "label1";
            label1.Size = new Size(286, 31);
            label1.TabIndex = 1;
            label1.Text = "Operarios Conectados";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.Location = new Point(26, 387);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(115, 47);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // VerOperarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(669, 463);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(dataOperarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerOperarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operarios Conectados";
            ((System.ComponentModel.ISupportInitialize)dataOperarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataOperarios;
        private Label label1;
        private Button btnCerrar;
    }
}