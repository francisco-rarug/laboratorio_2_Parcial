namespace Rarug.Francisco.Parcial
{
    partial class FormProductosCreados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductosCreados));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 172);
            dataGridView1.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(299, 25);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 2;
            label1.Text = "Productos creados";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Swis721 WGL4 BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 404);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 3;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 LtEx BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 113);
            label2.Name = "label2";
            label2.Size = new Size(230, 25);
            label2.TabIndex = 4;
            label2.Text = "Chocolates creados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 LtEx BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(560, 113);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 5;
            label3.Text = "Donas creadas";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(527, 170);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 171);
            dataGridView2.TabIndex = 6;
            
            // 
            // FormProductosCreados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProductosCreados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitoreo de productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView2;
    }
}