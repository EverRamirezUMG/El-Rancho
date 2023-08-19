using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace EL_RANCHO
{
    public partial class modificarEMPLEADO : Form
    {
        public modificarEMPLEADO()
        {
            InitializeComponent();
        }
        OracleConnection ora = new OracleConnection("Data Source = XEPDB1; User ID= SYSTEM; Password = 1530;");

        private void btGuardar_Click(object sender, EventArgs e)
        {
          /*  ora.Open();
            OracleCommand comando = new OracleCommand("modificarEmpleado", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("id", OracleType.Number).Value = Convert.ToInt32(TBid.Text);
            comando.Parameters.Add("nomd", OracleType.VarChar).Value = TBnombre.Text;
            comando.Parameters.Add("apell", OracleType.Number).Value = Convert.ToInt32(TBapellido.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Desayuno Actulizado");
            ora.Close();*/
        }
    }
}
