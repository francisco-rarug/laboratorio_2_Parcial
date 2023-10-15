namespace Rarug.Francisco.Parcial
{
    partial class FormModal2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModal2));
            Timer = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(156, 220);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(484, 30);
            progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 WGL4 BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 138);
            label1.Name = "label1";
            label1.Size = new Size(725, 35);
            label1.TabIndex = 3;
            label1.Text = "El operario Lauti esta trabajando para terminar su pedido...";
            // 
            // FormModal2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormModal2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "En proceso de creacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private ProgressBar progressBar1;
        private Label label1;
    }
}