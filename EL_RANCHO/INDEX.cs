using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EL_RANCHO
{
    public partial class INDEX : Form
    {
        public INDEX()
        {
            InitializeComponent();
        }
        private void AbrirForm(Object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fa = formhijo as Form;
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fa);
            this.panelContenedor.Tag = fa;
            fa.Show();
        }
        private void btEmpleado_Click(object sender, EventArgs e)
        {
            AbrirForm(new EMPLEADO());
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirForm(new MENU());
        }
        private void btInsumos1_Click(object sender, EventArgs e)
        {
            AbrirForm(new INSUMOS());
        }
        private void btVentas1_Click(object sender, EventArgs e)
        {
            AbrirForm(new VENTA());
        }
        private void btFactura1_Click(object sender, EventArgs e)
        {
            AbrirForm(new FACTURA());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btInsumos_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

            private void INDEX_Load(object sender, EventArgs e)
        {
           
        }

        private void btFactura_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EMPLEADO frm = new EMPLEADO();
            frm.Close();
        }

        private void btActualizar1_Click(object sender, EventArgs e)
        {
            Config frm = new Config();

            frm.Show();

        }

       
    }
}
