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
    public partial class EMPLEADO : Form
    {
        public EMPLEADO()
        {
            InitializeComponent();
        }
        OracleConnection ora = new OracleConnection("Data Source = XEPDB1; User ID= SYSTEM; Password = 1530;");
       


        private void btGuardar_Click(object sender, EventArgs e)
        {
            


        }

        private void EMPLEADO_Load(object sender, EventArgs e)
        {
            ora.Open();

            //MOSTRAR EMPLEADOS
            OracleCommand comando = new OracleCommand("seleccionarEmpleados", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridEmpleados.DataSource = tabla;

            
            OracleCommand comando2 = new OracleCommand("seleccionarSalario", ora);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador2 = new OracleDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridSalario.DataSource = tabla2;
            

            ora.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btActualizar1_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarEmpleados", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridEmpleados.DataSource = tabla;

            ora.Close();

        }

        private void btModificar1_Click(object sender, EventArgs e)
        {
            modificarEMPLEADO frm = new modificarEMPLEADO();

            frm.Show();
        }


        private void btModificarSalario_Click_1(object sender, EventArgs e)
        {
            modificarSALARIO frm = new modificarSALARIO();

            frm.Show();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
