namespace Rarug.Francisco.Parcial
{
    partial class Finalizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finalizado));
            label1 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 WGL4 BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 91);
            label1.Name = "label1";
            label1.Size = new Size(430, 31);
            label1.TabIndex = 0;
            label1.Text = "Su producto ha sido creado con exito!";
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Swis721 WGL4 BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(314, 228);
            button1.Name = "button1";
            button1.Size = new Size(160, 34);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(162, 149);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(484, 30);
            progressBar1.TabIndex = 2;
            progressBar1.Value = 100;
            // 
            // Finalizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Finalizado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finalizado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ProgressBar progressBar1;
    }
}