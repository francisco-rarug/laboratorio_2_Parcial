namespace Rarug.Francisco.Parcial
{
    partial class FormVerStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerStock));
            label1 = new Label();
            btnCerrar = new Button();
            dataGridView1 = new DataGridView();
            btnXml = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(156, 47);
            label1.Name = "label1";
            label1.Size = new Size(267, 42);
            label1.TabIndex = 1;
            label1.Text = "Stock restante";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.Control;
            btnCerrar.Location = new Point(31, 334);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(121, 50);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(158, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(265, 182);
            dataGridView1.TabIndex = 0;
            // 
            // btnXml
            // 
            btnXml.BackColor = Color.DarkOliveGreen;
            btnXml.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXml.ForeColor = SystemColors.Control;
            btnXml.Location = new Point(420, 336);
            btnXml.Name = "btnXml";
            btnXml.Size = new Size(121, 50);
            btnXml.TabIndex = 3;
            btnXml.Text = "Guardar en xml el stock";
            btnXml.UseVisualStyleBackColor = false;
            btnXml.Click += btnXml_Click;
            // 
            // FormVerStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(571, 395);
            Controls.Add(btnXml);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVerStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock disponible";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnCerrar;
        private DataGridView dataGridView1;
        private Button btnXml;
    }
}