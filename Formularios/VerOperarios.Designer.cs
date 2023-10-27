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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataOperarios).BeginInit();
            SuspendLayout();
            // 
            // dataOperarios
            // 
            dataOperarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataOperarios.Location = new Point(114, 71);
            dataOperarios.Name = "dataOperarios";
            dataOperarios.RowTemplate.Height = 25;
            dataOperarios.Size = new Size(355, 189);
            dataOperarios.TabIndex = 0;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Font = new Font("Swis721 LtEx BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 26);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 1;
            label1.Text = "Operarios Conectados";
            
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Swis721 WGL4 BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(23, 290);
            button1.Name = "button1";
            button1.Size = new Size(101, 35);
            button1.TabIndex = 2;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // VerOperarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(585, 347);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataOperarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button button1;
    }
}