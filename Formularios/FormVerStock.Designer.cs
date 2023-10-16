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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(274, 54);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 1;
            label1.Text = "Stock restante";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Swis721 WGL4 BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(25, 349);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 2;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(246, 174);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormVerStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(702, 395);
            Controls.Add(button1);
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
        private Button button1;
        private DataGridView dataGridView1;
    }
}