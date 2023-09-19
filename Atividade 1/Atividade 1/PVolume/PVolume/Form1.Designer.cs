namespace PVolume
{
    partial class Form1
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
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnResetar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.Location = new System.Drawing.Point(260, 114);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(45, 27);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Raio";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(242, 171);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(63, 27);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(245, 230);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(67, 27);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "Volume";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(222, 302);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 43);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(362, 302);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(97, 43);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // txtRaio
            // 
            this.txtRaio.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaio.Location = new System.Drawing.Point(318, 114);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 33);
            this.txtRaio.TabIndex = 5;
            this.txtRaio.Validated += new System.EventHandler(this.TxtRaio_Validated);
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(318, 171);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 33);
            this.txtAltura.TabIndex = 6;
            this.txtAltura.Validated += new System.EventHandler(this.TxtAltura_Validated);
            // 
            // txtVolume
            // 
            this.txtVolume.Enabled = false;
            this.txtVolume.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(318, 230);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 33);
            this.txtVolume.TabIndex = 7;
            this.txtVolume.TextChanged += new System.EventHandler(this.TxtVolume_TextChanged);
            // 
            // btnResetar1
            // 
            this.btnResetar1.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetar1.Location = new System.Drawing.Point(645, 384);
            this.btnResetar1.Name = "btnResetar1";
            this.btnResetar1.Size = new System.Drawing.Size(128, 54);
            this.btnResetar1.TabIndex = 8;
            this.btnResetar1.Text = "Resetar";
            this.btnResetar1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetar1);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblRaio);
            this.Name = "Form1";
            this.Text = "Cálculo do Volume do Cirilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnResetar1;
    }
}

