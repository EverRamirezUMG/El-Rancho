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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }
        OracleConnection ora = new OracleConnection("Data Source = XEPDB1; User ID= SYSTEM; Password = 1530;");

        private void btBorrarAlmuerzo_Click(object sender, EventArgs e)
        {

        }

        private void btModificarDesayuno_Click_1(object sender, EventArgs e)
        {
           modificarDESAYUNO frm = new modificarDESAYUNO();

            frm.Show();
        }

        private void btModificarAlmuerzo_Click_1(object sender, EventArgs e)
        {
            modificarALMUERZO frm = new modificarALMUERZO();

            frm.Show();
        }

        private void btModificarCena_Click_1(object sender, EventArgs e)
        {
            modificarCENA frm = new modificarCENA();

            frm.Show();
        }

        private void btModificarBebida_Click_1(object sender, EventArgs e)
        {
            modificarBEBIDA frm = new modificarBEBIDA();

            frm.Show();
        }

        private void btGuardarDesayuno_Click_1(object sender, EventArgs e)
        {

        }

        private void btActualizarDesayuno_Click(object sender, EventArgs e)
        {
            //seleccionarDesayuno
            ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarDesayuno", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridDesayuno.DataSource = tabla;

            ora.Close();
        }

        private void btBorrarDesayuno_Click(object sender, EventArgs e)
        {

        }

        private void MENU_Load(object sender, EventArgs e)
        {
            ora.Open();
            //DESAYUNO
            OracleCommand comando = new OracleCommand("seleccionarDesayuno", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridDesayuno.DataSource = tabla;

            //ALMUERZO
            OracleCommand comando2 = new OracleCommand("seleccionarAlmuerzo", ora);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador2 = new OracleDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridAlmuerzo.DataSource = tabla2;
            //CENA
            OracleCommand comando3 = new OracleCommand("seleccionarCena", ora);
            comando3.CommandType = System.Data.CommandType.StoredProcedure;
            comando3.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador3 = new OracleDataAdapter();
            adaptador3.SelectCommand = comando3;
            DataTable tabla3 = new DataTable();
            adaptador3.Fill(tabla3);
            dataGridCena.DataSource = tabla3;

            //BEBIDA
            OracleCommand comando4 = new OracleCommand("seleccionarBebidas", ora);
            comando4.CommandType = System.Data.CommandType.StoredProcedure;
            comando4.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador4 = new OracleDataAdapter();
            adaptador4.SelectCommand = comando4;
            DataTable tabla4 = new DataTable();
            adaptador4.Fill(tabla4);
            dataGridBebida.DataSource = tabla4;
            ora.Close();
        }
    }
}
