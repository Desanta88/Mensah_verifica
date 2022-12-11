namespace Mensah_verifica
{
    partial class listaVerifiche
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.AggiungiVerifica = new System.Windows.Forms.Button();
            this.textBoxMateria = new System.Windows.Forms.TextBox();
            this.textBoxVoto = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MV = new System.Windows.Forms.ToolStripMenuItem();
            this.CM = new System.Windows.Forms.ToolStripMenuItem();
            this.EV = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ricarica = new System.Windows.Forms.Button();
            this.OD = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elenco delle verifiche";
            // 
            // AggiungiVerifica
            // 
            this.AggiungiVerifica.Location = new System.Drawing.Point(518, 320);
            this.AggiungiVerifica.Name = "AggiungiVerifica";
            this.AggiungiVerifica.Size = new System.Drawing.Size(102, 42);
            this.AggiungiVerifica.TabIndex = 2;
            this.AggiungiVerifica.Text = "Aggiungi una verifica";
            this.AggiungiVerifica.UseVisualStyleBackColor = true;
            this.AggiungiVerifica.Click += new System.EventHandler(this.AggiungiVerifica_Click);
            // 
            // textBoxMateria
            // 
            this.textBoxMateria.Location = new System.Drawing.Point(491, 113);
            this.textBoxMateria.Name = "textBoxMateria";
            this.textBoxMateria.Size = new System.Drawing.Size(156, 23);
            this.textBoxMateria.TabIndex = 4;
            // 
            // textBoxVoto
            // 
            this.textBoxVoto.Location = new System.Drawing.Point(491, 191);
            this.textBoxVoto.Name = "textBoxVoto";
            this.textBoxVoto.Size = new System.Drawing.Size(156, 23);
            this.textBoxVoto.TabIndex = 5;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(491, 268);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(156, 23);
            this.textBoxData.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inserisci la materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "inserisci la valutazione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "inserisci la data di svolgimento";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MV,
            this.CM,
            this.EV});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 70);
            // 
            // MV
            // 
            this.MV.Name = "MV";
            this.MV.Size = new System.Drawing.Size(149, 22);
            this.MV.Text = "Modifica voto";
            this.MV.Click += new System.EventHandler(this.MV_Click);
            // 
            // CM
            // 
            this.CM.Name = "CM";
            this.CM.Size = new System.Drawing.Size(149, 22);
            this.CM.Text = "Calcola media";
            this.CM.Click += new System.EventHandler(this.CM_Click);
            // 
            // EV
            // 
            this.EV.Name = "EV";
            this.EV.Size = new System.Drawing.Size(149, 22);
            this.EV.Text = "Elimina Voto";
            this.EV.Click += new System.EventHandler(this.EV_Click);
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(53, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 379);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ricarica
            // 
            this.Ricarica.Location = new System.Drawing.Point(518, 49);
            this.Ricarica.Name = "Ricarica";
            this.Ricarica.Size = new System.Drawing.Size(99, 23);
            this.Ricarica.TabIndex = 14;
            this.Ricarica.Text = "Ricarica lista";
            this.Ricarica.UseVisualStyleBackColor = true;
            this.Ricarica.Click += new System.EventHandler(this.Ricarica_Click);
            // 
            // OD
            // 
            this.OD.Location = new System.Drawing.Point(518, 386);
            this.OD.Name = "OD";
            this.OD.Size = new System.Drawing.Size(99, 23);
            this.OD.TabIndex = 15;
            this.OD.Text = "ordina per data";
            this.OD.UseVisualStyleBackColor = true;
            this.OD.Click += new System.EventHandler(this.OD_Click);
            // 
            // listaVerifiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OD);
            this.Controls.Add(this.Ricarica);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxVoto);
            this.Controls.Add(this.textBoxMateria);
            this.Controls.Add(this.AggiungiVerifica);
            this.Controls.Add(this.label1);
            this.Name = "listaVerifiche";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button AggiungiVerifica;
        private TextBox textBoxMateria;
        private TextBox textBoxVoto;
        private TextBox textBoxData;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem MV;
        private ToolStripMenuItem CM;
        private ToolStripMenuItem EV;
        private ListView listView1;
        private Button Ricarica;
        private Button OD;
    }
}