namespace Rarug.Francisco.Parcial
{
    partial class FormModal3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModal3));
            Timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 WGL4 BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(133, 118);
            label1.Name = "label1";
            label1.Size = new Size(571, 35);
            label1.TabIndex = 1;
            label1.Text = "El operario Mathi esta terminando su pedido...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(163, 186);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(484, 30);
            progressBar1.TabIndex = 2;
            // 
            // FormModal3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormModal3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terminando el producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Label label1;
        private ProgressBar progressBar1;
    }
}