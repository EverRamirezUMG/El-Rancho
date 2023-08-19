
namespace EL_RANCHO
{
    partial class INDEX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INDEX));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btActualizar1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btEmpleado = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btFactura1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btVentas1 = new FontAwesome.Sharp.IconButton();
            this.btInsumos1 = new FontAwesome.Sharp.IconButton();
            this.btMenu1 = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(57)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.btActualizar1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 664);
            this.panel1.TabIndex = 0;
            // 
            // btActualizar1
            // 
            this.btActualizar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btActualizar1.FlatAppearance.BorderSize = 0;
            this.btActualizar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar1.ForeColor = System.Drawing.Color.Moccasin;
            this.btActualizar1.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btActualizar1.IconColor = System.Drawing.Color.Moccasin;
            this.btActualizar1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btActualizar1.IconSize = 25;
            this.btActualizar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btActualizar1.Location = new System.Drawing.Point(16, 623);
            this.btActualizar1.Name = "btActualizar1";
            this.btActualizar1.Size = new System.Drawing.Size(107, 29);
            this.btActualizar1.TabIndex = 10;
            this.btActualizar1.Text = " Configuracíon";
            this.btActualizar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btActualizar1, "Actualizar");
            this.btActualizar1.UseVisualStyleBackColor = true;
            this.btActualizar1.Click += new System.EventHandler(this.btActualizar1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btFactura1);
            this.panel2.Controls.Add(this.btEmpleado);
            this.panel2.Controls.Add(this.btVentas1);
            this.panel2.Controls.Add(this.btInsumos1);
            this.panel2.Controls.Add(this.btMenu1);
            this.panel2.Location = new System.Drawing.Point(3, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 446);
            this.panel2.TabIndex = 0;
            // 
            // btEmpleado
            // 
            this.btEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btEmpleado.FlatAppearance.BorderSize = 0;
            this.btEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmpleado.ForeColor = System.Drawing.Color.DarkOrange;
            this.btEmpleado.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btEmpleado.IconColor = System.Drawing.Color.DarkOrange;
            this.btEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btEmpleado.IconSize = 40;
            this.btEmpleado.Location = new System.Drawing.Point(0, 106);
            this.btEmpleado.Name = "btEmpleado";
            this.btEmpleado.Size = new System.Drawing.Size(127, 40);
            this.btEmpleado.TabIndex = 7;
            this.btEmpleado.UseVisualStyleBackColor = true;
            this.btEmpleado.Click += new System.EventHandler(this.btEmpleado_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.ForeColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Location = new System.Drawing.Point(125, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(954, 662);
            this.panelContenedor.TabIndex = 6;
            // 
            // btFactura1
            // 
            this.btFactura1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btFactura1.FlatAppearance.BorderSize = 0;
            this.btFactura1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFactura1.ForeColor = System.Drawing.Color.DarkOrange;
            this.btFactura1.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btFactura1.IconColor = System.Drawing.Color.DarkOrange;
            this.btFactura1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btFactura1.IconSize = 35;
            this.btFactura1.Location = new System.Drawing.Point(0, 262);
            this.btFactura1.Name = "btFactura1";
            this.btFactura1.Size = new System.Drawing.Size(127, 40);
            this.btFactura1.TabIndex = 11;
            this.btFactura1.UseVisualStyleBackColor = true;
            this.btFactura1.Click += new System.EventHandler(this.btFactura1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btVentas1
            // 
            this.btVentas1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btVentas1.FlatAppearance.BorderSize = 0;
            this.btVentas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVentas1.ForeColor = System.Drawing.Color.DarkOrange;
            this.btVentas1.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.btVentas1.IconColor = System.Drawing.Color.DarkOrange;
            this.btVentas1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btVentas1.IconSize = 35;
            this.btVentas1.Location = new System.Drawing.Point(0, 223);
            this.btVentas1.Name = "btVentas1";
            this.btVentas1.Size = new System.Drawing.Size(127, 40);
            this.btVentas1.TabIndex = 10;
            this.btVentas1.UseVisualStyleBackColor = true;
            this.btVentas1.Click += new System.EventHandler(this.btVentas1_Click);
            // 
            // btInsumos1
            // 
            this.btInsumos1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btInsumos1.FlatAppearance.BorderSize = 0;
            this.btInsumos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsumos1.ForeColor = System.Drawing.Color.DarkOrange;
            this.btInsumos1.IconChar = FontAwesome.Sharp.IconChar.PepperHot;
            this.btInsumos1.IconColor = System.Drawing.Color.DarkOrange;
            this.btInsumos1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btInsumos1.IconSize = 35;
            this.btInsumos1.Location = new System.Drawing.Point(0, 184);
            this.btInsumos1.Name = "btInsumos1";
            this.btInsumos1.Size = new System.Drawing.Size(127, 40);
            this.btInsumos1.TabIndex = 9;
            this.btInsumos1.UseVisualStyleBackColor = true;
            this.btInsumos1.Click += new System.EventHandler(this.btInsumos1_Click);
            // 
            // btMenu1
            // 
            this.btMenu1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btMenu1.FlatAppearance.BorderSize = 0;
            this.btMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu1.ForeColor = System.Drawing.Color.DarkOrange;
            this.btMenu1.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btMenu1.IconColor = System.Drawing.Color.DarkOrange;
            this.btMenu1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMenu1.IconSize = 35;
            this.btMenu1.Location = new System.Drawing.Point(0, 145);
            this.btMenu1.Name = "btMenu1";
            this.btMenu1.Size = new System.Drawing.Size(127, 40);
            this.btMenu1.TabIndex = 8;
            this.btMenu1.UseVisualStyleBackColor = true;
            this.btMenu1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // INDEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1079, 661);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1050, 500);
            this.Name = "INDEX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El Rancho";
            this.Load += new System.EventHandler(this.INDEX_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btActualizar1;
        private FontAwesome.Sharp.IconButton btEmpleado;
        private FontAwesome.Sharp.IconButton btVentas1;
        private FontAwesome.Sharp.IconButton btInsumos1;
        private FontAwesome.Sharp.IconButton btMenu1;
        private FontAwesome.Sharp.IconButton btFactura1;
    }
}

