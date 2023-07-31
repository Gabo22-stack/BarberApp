namespace CapaPresentacion
{
    partial class PrincipalEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalEmpresa));
            this.fotoRedonda1 = new CapaPresentacion.FotoRedonda();
            this.btnBarberia = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoRedonda1)).BeginInit();
            this.SuspendLayout();
            // 
            // fotoRedonda1
            // 
            this.fotoRedonda1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.fotoRedonda1.BorderColor = System.Drawing.Color.Black;
            this.fotoRedonda1.BorderColor2 = System.Drawing.Color.Black;
            this.fotoRedonda1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.fotoRedonda1.BorderSize = 2;
            this.fotoRedonda1.GradientAngle = 50F;
            this.fotoRedonda1.Image = ((System.Drawing.Image)(resources.GetObject("fotoRedonda1.Image")));
            this.fotoRedonda1.Location = new System.Drawing.Point(92, 12);
            this.fotoRedonda1.Name = "fotoRedonda1";
            this.fotoRedonda1.Size = new System.Drawing.Size(164, 164);
            this.fotoRedonda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoRedonda1.TabIndex = 0;
            this.fotoRedonda1.TabStop = false;
            // 
            // btnBarberia
            // 
            this.btnBarberia.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarberia.Image = ((System.Drawing.Image)(resources.GetObject("btnBarberia.Image")));
            this.btnBarberia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarberia.Location = new System.Drawing.Point(72, 235);
            this.btnBarberia.Name = "btnBarberia";
            this.btnBarberia.Size = new System.Drawing.Size(206, 62);
            this.btnBarberia.TabIndex = 1;
            this.btnBarberia.Text = "TU BARBERIA";
            this.btnBarberia.UseVisualStyleBackColor = true;
            this.btnBarberia.Click += new System.EventHandler(this.btnBarberia_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(72, 317);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(206, 62);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(72, 402);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(206, 62);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Created by A.j";
            // 
            // PrincipalEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnBarberia);
            this.Controls.Add(this.fotoRedonda1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.fotoRedonda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FotoRedonda fotoRedonda1;
        private System.Windows.Forms.Button btnBarberia;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label label1;
    }
}