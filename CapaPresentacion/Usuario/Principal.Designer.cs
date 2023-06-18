namespace CapaPresentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PanelMenuFijo = new System.Windows.Forms.Panel();
            this.BtnComentarios = new System.Windows.Forms.Button();
            this.BtnCitas = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelHome = new System.Windows.Forms.Panel();
            this.BtnManicuraMujer = new System.Windows.Forms.Button();
            this.BtnManicuraHombre = new System.Windows.Forms.Button();
            this.BtnCorteFiguras = new System.Windows.Forms.Button();
            this.BtnCorteAdulto = new System.Windows.Forms.Button();
            this.BtnCorteNiño = new System.Windows.Forms.Button();
            this.fotoRedonda1 = new CapaPresentacion.FotoRedonda();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenuFijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoRedonda1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenuFijo
            // 
            this.PanelMenuFijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(201)))));
            this.PanelMenuFijo.Controls.Add(this.BtnComentarios);
            this.PanelMenuFijo.Controls.Add(this.BtnCitas);
            this.PanelMenuFijo.Controls.Add(this.btnPerfil);
            this.PanelMenuFijo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMenuFijo.Location = new System.Drawing.Point(0, 745);
            this.PanelMenuFijo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenuFijo.Name = "PanelMenuFijo";
            this.PanelMenuFijo.Size = new System.Drawing.Size(480, 75);
            this.PanelMenuFijo.TabIndex = 0;
            // 
            // BtnComentarios
            // 
            this.BtnComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(201)))));
            this.BtnComentarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnComentarios.BackgroundImage")));
            this.BtnComentarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnComentarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComentarios.Location = new System.Drawing.Point(356, 7);
            this.BtnComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnComentarios.Name = "BtnComentarios";
            this.BtnComentarios.Size = new System.Drawing.Size(95, 58);
            this.BtnComentarios.TabIndex = 2;
            this.BtnComentarios.UseVisualStyleBackColor = false;
            this.BtnComentarios.Click += new System.EventHandler(this.BtnComentarios_Click);
            // 
            // BtnCitas
            // 
            this.BtnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(201)))));
            this.BtnCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCitas.BackgroundImage")));
            this.BtnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCitas.Location = new System.Drawing.Point(35, 7);
            this.BtnCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Size = new System.Drawing.Size(95, 58);
            this.BtnCitas.TabIndex = 1;
            this.BtnCitas.UseVisualStyleBackColor = false;
            this.BtnCitas.Click += new System.EventHandler(this.BtnCitas_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(201)))));
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(195, 7);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(95, 58);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-63, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 607);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelHome
            // 
            this.PanelHome.BackColor = System.Drawing.Color.White;
            this.PanelHome.Controls.Add(this.BtnManicuraMujer);
            this.PanelHome.Controls.Add(this.BtnManicuraHombre);
            this.PanelHome.Controls.Add(this.BtnCorteFiguras);
            this.PanelHome.Controls.Add(this.BtnCorteAdulto);
            this.PanelHome.Controls.Add(this.BtnCorteNiño);
            this.PanelHome.Controls.Add(this.fotoRedonda1);
            this.PanelHome.Controls.Add(this.label1);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHome.Location = new System.Drawing.Point(0, 0);
            this.PanelHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(480, 746);
            this.PanelHome.TabIndex = 1;
            // 
            // BtnManicuraMujer
            // 
            this.BtnManicuraMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManicuraMujer.Image = ((System.Drawing.Image)(resources.GetObject("BtnManicuraMujer.Image")));
            this.BtnManicuraMujer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManicuraMujer.Location = new System.Drawing.Point(47, 623);
            this.BtnManicuraMujer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnManicuraMujer.Name = "BtnManicuraMujer";
            this.BtnManicuraMujer.Size = new System.Drawing.Size(387, 84);
            this.BtnManicuraMujer.TabIndex = 24;
            this.BtnManicuraMujer.Text = "Manicura para mujer       ";
            this.BtnManicuraMujer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnManicuraMujer.UseVisualStyleBackColor = true;
            this.BtnManicuraMujer.Click += new System.EventHandler(this.BtnManicuraMujer_Click);
            // 
            // BtnManicuraHombre
            // 
            this.BtnManicuraHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManicuraHombre.Image = ((System.Drawing.Image)(resources.GetObject("BtnManicuraHombre.Image")));
            this.BtnManicuraHombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManicuraHombre.Location = new System.Drawing.Point(47, 521);
            this.BtnManicuraHombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnManicuraHombre.Name = "BtnManicuraHombre";
            this.BtnManicuraHombre.Size = new System.Drawing.Size(387, 84);
            this.BtnManicuraHombre.TabIndex = 23;
            this.BtnManicuraHombre.Text = "Manicura para hombre     ";
            this.BtnManicuraHombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnManicuraHombre.UseVisualStyleBackColor = true;
            this.BtnManicuraHombre.Click += new System.EventHandler(this.BtnManicuraHombre_Click);
            // 
            // BtnCorteFiguras
            // 
            this.BtnCorteFiguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorteFiguras.Image = ((System.Drawing.Image)(resources.GetObject("BtnCorteFiguras.Image")));
            this.BtnCorteFiguras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCorteFiguras.Location = new System.Drawing.Point(47, 418);
            this.BtnCorteFiguras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCorteFiguras.Name = "BtnCorteFiguras";
            this.BtnCorteFiguras.Size = new System.Drawing.Size(387, 84);
            this.BtnCorteFiguras.TabIndex = 22;
            this.BtnCorteFiguras.Text = "Corte de pelo Con figuras";
            this.BtnCorteFiguras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCorteFiguras.UseVisualStyleBackColor = true;
            this.BtnCorteFiguras.Click += new System.EventHandler(this.BtnCorteFiguras_Click);
            // 
            // BtnCorteAdulto
            // 
            this.BtnCorteAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorteAdulto.Image = ((System.Drawing.Image)(resources.GetObject("BtnCorteAdulto.Image")));
            this.BtnCorteAdulto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCorteAdulto.Location = new System.Drawing.Point(47, 324);
            this.BtnCorteAdulto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCorteAdulto.Name = "BtnCorteAdulto";
            this.BtnCorteAdulto.Size = new System.Drawing.Size(387, 80);
            this.BtnCorteAdulto.TabIndex = 21;
            this.BtnCorteAdulto.Text = "Corte de pelo para adulto";
            this.BtnCorteAdulto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCorteAdulto.UseVisualStyleBackColor = true;
            this.BtnCorteAdulto.Click += new System.EventHandler(this.BtnCorteAdulto_Click);
            // 
            // BtnCorteNiño
            // 
            this.BtnCorteNiño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorteNiño.Image = ((System.Drawing.Image)(resources.GetObject("BtnCorteNiño.Image")));
            this.BtnCorteNiño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCorteNiño.Location = new System.Drawing.Point(47, 218);
            this.BtnCorteNiño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCorteNiño.Name = "BtnCorteNiño";
            this.BtnCorteNiño.Size = new System.Drawing.Size(387, 94);
            this.BtnCorteNiño.TabIndex = 20;
            this.BtnCorteNiño.Text = "Corte de pelo para niño   ";
            this.BtnCorteNiño.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCorteNiño.UseVisualStyleBackColor = true;
            this.BtnCorteNiño.Click += new System.EventHandler(this.BtnCorteNiño_Click);
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
            this.fotoRedonda1.Location = new System.Drawing.Point(47, 33);
            this.fotoRedonda1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoRedonda1.Name = "fotoRedonda1";
            this.fotoRedonda1.Size = new System.Drawing.Size(171, 171);
            this.fotoRedonda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoRedonda1.TabIndex = 10;
            this.fotoRedonda1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(259, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servicios:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 820);
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.PanelMenuFijo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PanelMenuFijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoRedonda1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuFijo;
        private System.Windows.Forms.Button BtnCitas;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnComentarios;
        private System.Windows.Forms.Panel PanelHome;
        private System.Windows.Forms.Label label1;
        private FotoRedonda fotoRedonda1;
        private System.Windows.Forms.Button BtnCorteFiguras;
        private System.Windows.Forms.Button BtnCorteAdulto;
        private System.Windows.Forms.Button BtnCorteNiño;
        private System.Windows.Forms.Button BtnManicuraMujer;
        private System.Windows.Forms.Button BtnManicuraHombre;
    }
}