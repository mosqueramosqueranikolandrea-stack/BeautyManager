namespace Detector2026
{
    partial class VentanaPrincipal
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAnalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.textBoxByte = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelValorEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonBuscar.Location = new System.Drawing.Point(694, 59);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(153, 43);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAnalizar
            // 
            this.buttonAnalizar.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonAnalizar.Enabled = false;
            this.buttonAnalizar.Location = new System.Drawing.Point(694, 126);
            this.buttonAnalizar.Name = "buttonAnalizar";
            this.buttonAnalizar.Size = new System.Drawing.Size(152, 35);
            this.buttonAnalizar.TabIndex = 1;
            this.buttonAnalizar.Text = "Analizar";
            this.buttonAnalizar.UseVisualStyleBackColor = false;
            this.buttonAnalizar.Click += new System.EventHandler(this.buttonAnalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta Archivo";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Enabled = false;
            this.textBoxRuta.Location = new System.Drawing.Point(53, 67);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(635, 26);
            this.textBoxRuta.TabIndex = 3;
            // 
            // textBoxByte
            // 
            this.textBoxByte.Enabled = false;
            this.textBoxByte.Location = new System.Drawing.Point(53, 116);
            this.textBoxByte.Multiline = true;
            this.textBoxByte.Name = "textBoxByte";
            this.textBoxByte.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxByte.Size = new System.Drawing.Size(635, 357);
            this.textBoxByte.TabIndex = 4;
            this.textBoxByte.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(694, 176);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(140, 20);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "Estado de parada ";
            this.labelEstado.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelValorEstado
            // 
            this.labelValorEstado.AutoSize = true;
            this.labelValorEstado.Location = new System.Drawing.Point(841, 176);
            this.labelValorEstado.Name = "labelValorEstado";
            this.labelValorEstado.Size = new System.Drawing.Size(0, 20);
            this.labelValorEstado.TabIndex = 6;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 512);
            this.Controls.Add(this.labelValorEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxByte);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnalizar);
            this.Controls.Add(this.buttonBuscar);
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana Antivirus";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAnalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.TextBox textBoxByte;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelValorEstado;
    }
}