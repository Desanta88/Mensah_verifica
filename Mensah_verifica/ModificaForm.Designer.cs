namespace Mensah_verifica
{
    partial class ModificaForm
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
            this.ModificaVotoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModificaVotoButton
            // 
            this.ModificaVotoButton.Location = new System.Drawing.Point(73, 176);
            this.ModificaVotoButton.MaximumSize = new System.Drawing.Size(95, 35);
            this.ModificaVotoButton.MinimumSize = new System.Drawing.Size(95, 35);
            this.ModificaVotoButton.Name = "ModificaVotoButton";
            this.ModificaVotoButton.Size = new System.Drawing.Size(95, 35);
            this.ModificaVotoButton.TabIndex = 0;
            this.ModificaVotoButton.Text = "cambia voto";
            this.ModificaVotoButton.UseVisualStyleBackColor = true;
            this.ModificaVotoButton.Click += new System.EventHandler(this.ModificaVotoButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "inserire il nuovo voto della verifica";
            // 
            // ModificaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ModificaVotoButton);
            this.Name = "ModificaForm";
            this.Text = "ModificaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ModificaVotoButton;
        private TextBox textBox1;
        private Label label1;
    }
}