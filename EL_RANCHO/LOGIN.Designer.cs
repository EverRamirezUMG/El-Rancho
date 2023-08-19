
namespace EL_RANCHO
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btOcultar = new System.Windows.Forms.PictureBox();
            this.btMostrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TBusuario
            // 
            this.TBusuario.Location = new System.Drawing.Point(76, 259);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(136, 25);
            this.TBusuario.TabIndex = 1;
            // 
            // TBpass
            // 
            this.TBpass.Location = new System.Drawing.Point(76, 290);
            this.TBpass.Name = "TBpass";
            this.TBpass.PasswordChar = '*';
            this.TBpass.Size = new System.Drawing.Size(136, 25);
            this.TBpass.TabIndex = 2;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(76, 321);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(136, 28);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btOcultar
            // 
            this.btOcultar.BackColor = System.Drawing.Color.White;
            this.btOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOcultar.Image = ((System.Drawing.Image)(resources.GetObject("btOcultar.Image")));
            this.btOcultar.Location = new System.Drawing.Point(193, 296);
            this.btOcultar.Name = "btOcultar";
            this.btOcultar.Size = new System.Drawing.Size(15, 15);
            this.btOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btOcultar.TabIndex = 5;
            this.btOcultar.TabStop = false;
            this.btOcultar.Click += new System.EventHandler(this.btOcultar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.BackColor = System.Drawing.Color.White;
            this.btMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btMostrar.Image")));
            this.btMostrar.Location = new System.Drawing.Point(193, 296);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(15, 15);
            this.btMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMostrar.TabIndex = 6;
            this.btMostrar.TabStop = false;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(57)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(272, 377);
            this.Controls.Add(this.btOcultar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.TBusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btMostrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btOcultar;
        private System.Windows.Forms.PictureBox btMostrar;
    }
}