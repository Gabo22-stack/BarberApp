namespace CapaPresentacion
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.PanelPersonal = new System.Windows.Forms.Panel();
            this.BtnVolveraprincipal = new System.Windows.Forms.Button();
            this.btnBarber3 = new System.Windows.Forms.Button();
            this.btnBarber2 = new System.Windows.Forms.Button();
            this.btnBarber1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoRedonda1 = new CapaPresentacion.FotoRedonda();
            this.PanelPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoRedonda1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPersonal
            // 
            this.PanelPersonal.BackColor = System.Drawing.Color.White;
            this.PanelPersonal.Controls.Add(this.BtnVolveraprincipal);
            this.PanelPersonal.Controls.Add(this.btnBarber3);
            this.PanelPersonal.Controls.Add(this.btnBarber2);
            this.PanelPersonal.Controls.Add(this.btnBarber1);
            this.PanelPersonal.Controls.Add(this.label1);
            this.PanelPersonal.Controls.Add(this.fotoRedonda1);
            this.PanelPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPersonal.Location = new System.Drawing.Point(0, 0);
            this.PanelPersonal.Name = "PanelPersonal";
            this.PanelPersonal.Size = new System.Drawing.Size(360, 573);
            this.PanelPersonal.TabIndex = 0;
            // 
            // BtnVolveraprincipal
            // 
            this.BtnVolveraprincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolveraprincipal.BackgroundImage")));
            this.BtnVolveraprincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVolveraprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolveraprincipal.Location = new System.Drawing.Point(1, 1);
            this.BtnVolveraprincipal.Name = "BtnVolveraprincipal";
            this.BtnVolveraprincipal.Size = new System.Drawing.Size(38, 38);
            this.BtnVolveraprincipal.TabIndex = 26;
            this.BtnVolveraprincipal.UseVisualStyleBackColor = true;
            this.BtnVolveraprincipal.Click += new System.EventHandler(this.BtnVolveraprincipal_Click);
            // 
            // btnBarber3
            // 
            this.btnBarber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarber3.Image = ((System.Drawing.Image)(resources.GetObject("btnBarber3.Image")));
            this.btnBarber3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarber3.Location = new System.Drawing.Point(35, 356);
            this.btnBarber3.Name = "btnBarber3";
            this.btnBarber3.Size = new System.Drawing.Size(290, 76);
            this.btnBarber3.TabIndex = 23;
            this.btnBarber3.Text = "            Barbero 3";
            this.btnBarber3.UseVisualStyleBackColor = true;
            this.btnBarber3.Click += new System.EventHandler(this.btnBarber3_Click);
            // 
            // btnBarber2
            // 
            this.btnBarber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarber2.Image = ((System.Drawing.Image)(resources.GetObject("btnBarber2.Image")));
            this.btnBarber2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarber2.Location = new System.Drawing.Point(35, 265);
            this.btnBarber2.Name = "btnBarber2";
            this.btnBarber2.Size = new System.Drawing.Size(290, 76);
            this.btnBarber2.TabIndex = 22;
            this.btnBarber2.Text = "            Barbero 2";
            this.btnBarber2.UseVisualStyleBackColor = true;
            this.btnBarber2.Click += new System.EventHandler(this.btnBarber2_Click);
            // 
            // btnBarber1
            // 
            this.btnBarber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarber1.Image = ((System.Drawing.Image)(resources.GetObject("btnBarber1.Image")));
            this.btnBarber1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarber1.Location = new System.Drawing.Point(35, 170);
            this.btnBarber1.Name = "btnBarber1";
            this.btnBarber1.Size = new System.Drawing.Size(290, 76);
            this.btnBarber1.TabIndex = 21;
            this.btnBarber1.Text = "            Barbero 1";
            this.btnBarber1.UseVisualStyleBackColor = true;
            this.btnBarber1.Click += new System.EventHandler(this.btnBarber1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(192, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Barberos:";
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
            this.fotoRedonda1.Location = new System.Drawing.Point(35, 26);
            this.fotoRedonda1.Name = "fotoRedonda1";
            this.fotoRedonda1.Size = new System.Drawing.Size(128, 128);
            this.fotoRedonda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoRedonda1.TabIndex = 11;
            this.fotoRedonda1.TabStop = false;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 621);
            this.Controls.Add(this.PanelPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            this.PanelPersonal.ResumeLayout(false);
            this.PanelPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoRedonda1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPersonal;
        private FotoRedonda fotoRedonda1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBarber3;
        private System.Windows.Forms.Button btnBarber2;
        private System.Windows.Forms.Button btnBarber1;
        private System.Windows.Forms.Button BtnVolveraprincipal;
    }
}