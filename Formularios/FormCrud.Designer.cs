namespace Rarug.Francisco.Parcial
{
    partial class FormCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrud));
            btnCrudOper = new Button();
            btnCrudSuper = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCrudOper
            // 
            btnCrudOper.BackColor = Color.YellowGreen;
            btnCrudOper.Font = new Font("Futura Md BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrudOper.ForeColor = SystemColors.Desktop;
            btnCrudOper.Location = new Point(12, 61);
            btnCrudOper.Name = "btnCrudOper";
            btnCrudOper.Size = new Size(115, 68);
            btnCrudOper.TabIndex = 0;
            btnCrudOper.Text = "CRUD Operario";
            btnCrudOper.UseVisualStyleBackColor = false;
            btnCrudOper.Click += btnCrudOper_Click;
            // 
            // btnCrudSuper
            // 
            btnCrudSuper.BackColor = SystemColors.GradientActiveCaption;
            btnCrudSuper.Font = new Font("Futura Md BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrudSuper.Location = new Point(152, 61);
            btnCrudSuper.Name = "btnCrudSuper";
            btnCrudSuper.Size = new Size(116, 68);
            btnCrudSuper.TabIndex = 3;
            btnCrudSuper.Text = "CRUD Supervisor";
            btnCrudSuper.UseVisualStyleBackColor = false;
            btnCrudSuper.Click += btnCrudSuper_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Firebrick;
            btnCerrar.Font = new Font("Futura Bk BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(80, 161);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(108, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(110, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 11;
            label1.Text = "CRUD";
            // 
            // FormCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(285, 211);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnCrudSuper);
            Controls.Add(btnCrudOper);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrudOper;
        private Button btnCrudSuper;
        private Button btnCerrar;
        private Label label1;
    }
}