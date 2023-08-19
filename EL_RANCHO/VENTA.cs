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
    public partial class VENTA : Form
    {
        public VENTA()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            INDEX frm = new INDEX();

            frm.Show();
        }
    }
}
