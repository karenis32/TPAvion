namespace TPAvionForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_PropAvionComercial = new System.Windows.Forms.Button();
            this.btn_DespegaAvionComercial = new System.Windows.Forms.Button();
            this.btn_AterrizaAvionComercial = new System.Windows.Forms.Button();
            this.btn_PropAvionCarga = new System.Windows.Forms.Button();
            this.btn_AterrizaAvionCarga = new System.Windows.Forms.Button();
            this.btn_DespegaAvionCarga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_PropAvionComercial
            // 
            this.btn_PropAvionComercial.BackColor = System.Drawing.Color.Green;
            this.btn_PropAvionComercial.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PropAvionComercial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PropAvionComercial.Location = new System.Drawing.Point(137, 99);
            this.btn_PropAvionComercial.Name = "btn_PropAvionComercial";
            this.btn_PropAvionComercial.Size = new System.Drawing.Size(163, 84);
            this.btn_PropAvionComercial.TabIndex = 0;
            this.btn_PropAvionComercial.Text = "Mostrar Propiedades Avión Comercial";
            this.btn_PropAvionComercial.UseVisualStyleBackColor = false;
            this.btn_PropAvionComercial.Click += new System.EventHandler(this.btn_PropAvionComercial_Click);
            // 
            // btn_DespegaAvionComercial
            // 
            this.btn_DespegaAvionComercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_DespegaAvionComercial.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.btn_DespegaAvionComercial.Location = new System.Drawing.Point(137, 207);
            this.btn_DespegaAvionComercial.Name = "btn_DespegaAvionComercial";
            this.btn_DespegaAvionComercial.Size = new System.Drawing.Size(163, 61);
            this.btn_DespegaAvionComercial.TabIndex = 1;
            this.btn_DespegaAvionComercial.Text = "Despegar Avion Comercial";
            this.btn_DespegaAvionComercial.UseVisualStyleBackColor = false;
            this.btn_DespegaAvionComercial.Click += new System.EventHandler(this.btn_DespegaAvionComercial_Click);
            // 
            // btn_AterrizaAvionComercial
            // 
            this.btn_AterrizaAvionComercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AterrizaAvionComercial.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.btn_AterrizaAvionComercial.Location = new System.Drawing.Point(137, 293);
            this.btn_AterrizaAvionComercial.Name = "btn_AterrizaAvionComercial";
            this.btn_AterrizaAvionComercial.Size = new System.Drawing.Size(163, 60);
            this.btn_AterrizaAvionComercial.TabIndex = 2;
            this.btn_AterrizaAvionComercial.Text = "Aterrizar Avion Comercial";
            this.btn_AterrizaAvionComercial.UseVisualStyleBackColor = false;
            this.btn_AterrizaAvionComercial.Click += new System.EventHandler(this.btn_AterrizaAvionComercial_Click);
            // 
            // btn_PropAvionCarga
            // 
            this.btn_PropAvionCarga.BackColor = System.Drawing.Color.Green;
            this.btn_PropAvionCarga.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.btn_PropAvionCarga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PropAvionCarga.Location = new System.Drawing.Point(480, 99);
            this.btn_PropAvionCarga.Name = "btn_PropAvionCarga";
            this.btn_PropAvionCarga.Size = new System.Drawing.Size(163, 84);
            this.btn_PropAvionCarga.TabIndex = 3;
            this.btn_PropAvionCarga.Text = "Mostrar Propiedades Avión de Carga";
            this.btn_PropAvionCarga.UseVisualStyleBackColor = false;
            this.btn_PropAvionCarga.Click += new System.EventHandler(this.btn_PropAvionCarga_Click);
            // 
            // btn_AterrizaAvionCarga
            // 
            this.btn_AterrizaAvionCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AterrizaAvionCarga.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.btn_AterrizaAvionCarga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AterrizaAvionCarga.Location = new System.Drawing.Point(480, 293);
            this.btn_AterrizaAvionCarga.Name = "btn_AterrizaAvionCarga";
            this.btn_AterrizaAvionCarga.Size = new System.Drawing.Size(163, 60);
            this.btn_AterrizaAvionCarga.TabIndex = 4;
            this.btn_AterrizaAvionCarga.Text = "Aterrizar Avion de Carga";
            this.btn_AterrizaAvionCarga.UseVisualStyleBackColor = false;
            this.btn_AterrizaAvionCarga.Click += new System.EventHandler(this.btn_AterrizaAvionCarga_Click);
            // 
            // btn_DespegaAvionCarga
            // 
            this.btn_DespegaAvionCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_DespegaAvionCarga.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.btn_DespegaAvionCarga.Location = new System.Drawing.Point(480, 207);
            this.btn_DespegaAvionCarga.Name = "btn_DespegaAvionCarga";
            this.btn_DespegaAvionCarga.Size = new System.Drawing.Size(163, 61);
            this.btn_DespegaAvionCarga.TabIndex = 5;
            this.btn_DespegaAvionCarga.Text = "Despegar Avion de Carga";
            this.btn_DespegaAvionCarga.UseVisualStyleBackColor = false;
            this.btn_DespegaAvionCarga.Click += new System.EventHandler(this.btn_DespegaAvionCarga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema de aviones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DespegaAvionCarga);
            this.Controls.Add(this.btn_AterrizaAvionCarga);
            this.Controls.Add(this.btn_PropAvionCarga);
            this.Controls.Add(this.btn_AterrizaAvionComercial);
            this.Controls.Add(this.btn_DespegaAvionComercial);
            this.Controls.Add(this.btn_PropAvionComercial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PropAvionComercial;
        private System.Windows.Forms.Button btn_DespegaAvionComercial;
        private System.Windows.Forms.Button btn_AterrizaAvionComercial;
        private System.Windows.Forms.Button btn_PropAvionCarga;
        private System.Windows.Forms.Button btn_AterrizaAvionCarga;
        private System.Windows.Forms.Button btn_DespegaAvionCarga;
        private System.Windows.Forms.Label label1;
    }
}

