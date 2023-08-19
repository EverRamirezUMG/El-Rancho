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
    public partial class INSUMOS : Form
    {
        public INSUMOS()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            INDEX frm = new INDEX();

            frm.Show();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
