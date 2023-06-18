namespace CapaPresentacion
{
    partial class PersonalBarber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalBarber));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAñadorMani = new System.Windows.Forms.Button();
            this.btnAñadirBarbero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.pbxBack);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 49);
            this.panel1.TabIndex = 74;
            // 
            // pbxBack
            // 
            this.pbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBack.Image")));
            this.pbxBack.Location = new System.Drawing.Point(3, 7);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(35, 33);
            this.pbxBack.TabIndex = 2;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "EMPLEADOS";
            // 
            // btnAñadorMani
            // 
            this.btnAñadorMani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAñadorMani.Location = new System.Drawing.Point(17, 388);
            this.btnAñadorMani.Name = "btnAñadorMani";
            this.btnAñadorMani.Size = new System.Drawing.Size(75, 23);
            this.btnAñadorMani.TabIndex = 81;
            this.btnAñadorMani.Text = "AÑADIR";
            this.btnAñadorMani.UseVisualStyleBackColor = false;
            this.btnAñadorMani.Click += new System.EventHandler(this.btnAñadorMani_Click);
            // 
            // btnAñadirBarbero
            // 
            this.btnAñadirBarbero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAñadirBarbero.Location = new System.Drawing.Point(17, 112);
            this.btnAñadirBarbero.Name = "btnAñadirBarbero";
            this.btnAñadirBarbero.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirBarbero.TabIndex = 80;
            this.btnAñadirBarbero.Text = "AÑADIR";
            this.btnAñadirBarbero.UseVisualStyleBackColor = false;
            this.btnAñadirBarbero.Click += new System.EventHandler(this.btnAñadirBarbero_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 27);
            this.label2.TabIndex = 79;
            this.label2.Text = "MANICURISTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "BARBEROS";
            // 
            // PersonalBarber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 627);
            this.Controls.Add(this.btnAñadorMani);
            this.Controls.Add(this.btnAñadirBarbero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalBarber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalBarber";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAñadorMani;
        private System.Windows.Forms.Button btnAñadirBarbero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}