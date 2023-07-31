namespace CapaPresentacion
{
    partial class PersonalManicura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalManicura));
            this.BtnVolveraprincipal = new System.Windows.Forms.Button();
            this.btnManicura2 = new System.Windows.Forms.Button();
            this.btnManicura1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoRedonda1 = new CapaPresentacion.FotoRedonda();
            ((System.ComponentModel.ISupportInitialize)(this.fotoRedonda1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolveraprincipal
            // 
            this.BtnVolveraprincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolveraprincipal.BackgroundImage")));
            this.BtnVolveraprincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVolveraprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolveraprincipal.Location = new System.Drawing.Point(0, 0);
            this.BtnVolveraprincipal.Name = "BtnVolveraprincipal";
            this.BtnVolveraprincipal.Size = new System.Drawing.Size(38, 38);
            this.BtnVolveraprincipal.TabIndex = 39;
            this.BtnVolveraprincipal.UseVisualStyleBackColor = true;
            this.BtnVolveraprincipal.Click += new System.EventHandler(this.BtnVolveraprincipal_Click);
            // 
            // btnManicura2
            // 
            this.btnManicura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManicura2.Image = ((System.Drawing.Image)(resources.GetObject("btnManicura2.Image")));
            this.btnManicura2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManicura2.Location = new System.Drawing.Point(35, 272);
            this.btnManicura2.Name = "btnManicura2";
            this.btnManicura2.Size = new System.Drawing.Size(290, 76);
            this.btnManicura2.TabIndex = 38;
            this.btnManicura2.Text = "              Manicurista 2";
            this.btnManicura2.UseVisualStyleBackColor = true;
            this.btnManicura2.Click += new System.EventHandler(this.btnManicura2_Click);
            // 
            // btnManicura1
            // 
            this.btnManicura1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManicura1.Image = ((System.Drawing.Image)(resources.GetObject("btnManicura1.Image")));
            this.btnManicura1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManicura1.Location = new System.Drawing.Point(35, 190);
            this.btnManicura1.Name = "btnManicura1";
            this.btnManicura1.Size = new System.Drawing.Size(290, 76);
            this.btnManicura1.TabIndex = 37;
            this.btnManicura1.Text = "              Manicurista 1";
            this.btnManicura1.UseVisualStyleBackColor = true;
            this.btnManicura1.Click += new System.EventHandler(this.btnManicura1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Manicuristas:";
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
            this.fotoRedonda1.Location = new System.Drawing.Point(35, 44);
            this.fotoRedonda1.Name = "fotoRedonda1";
            this.fotoRedonda1.Size = new System.Drawing.Size(128, 128);
            this.fotoRedonda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoRedonda1.TabIndex = 35;
            this.fotoRedonda1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 621);
            this.Controls.Add(this.BtnVolveraprincipal);
            this.Controls.Add(this.btnManicura2);
            this.Controls.Add(this.btnManicura1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fotoRedonda1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fotoRedonda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolveraprincipal;
        private System.Windows.Forms.Button btnManicura2;
        private System.Windows.Forms.Button btnManicura1;
        private System.Windows.Forms.Label label1;
        private FotoRedonda fotoRedonda1;
    }
}