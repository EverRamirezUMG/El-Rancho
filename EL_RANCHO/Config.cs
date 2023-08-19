using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL_RANCHO.Properties;
using System.Data.OracleClient;



namespace EL_RANCHO
{
    public partial class Config : Form
    {
      
        OracleConnection con = new OracleConnection("Data Source = XEPDB1; User ID= SYSTEM; Password = 1530;");

        public Config()
        {
            InitializeComponent();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            try
            {
            con.Open();
            LBversion.Text = "Version: " + "\n"+con.ServerVersion;
           // LBestado.Text += "Estado: ";
            LBestado.Text += con.State.ToString();
            LBestado.Text += "\nAcceso exitoso a la base de datos";
            }
            catch(Exception ex)
            {
                LBestado.Text = "Error al accedar a la base de datos. " + "\n"+ex.Message;

            }
            finally
            {
                con.Close();
                LBestado.Text += "\nEstado: " + con.State.ToString();
            }
            
        
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
         
        }


        string User = Settings.Default.User;
        string Pass = Settings.Default.Pass;
       
        private void btGuardar_Click(object sender, EventArgs e)
        {
           

            //cambiar cotraseña

            if (TBpassActual.Text == Pass)
            {
                Settings.Default.Pass = TBpassNuevo.Text;

                if (TBpassConfirm.Text != TBpassNuevo.Text)
                {
                    MessageBox.Show("la contraseña coincide", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Settings.Default.Save();
                    MessageBox.Show("Contraseña guardada!", "Cambio exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btGuardarUsuario_Click(object sender, EventArgs e)
        {
            //CAMBIAR NOMBRE DE USUARIO
            if (TBnomAct.Text == User)
            {
                Settings.Default.User = TBnomNew.Text;       
                    Settings.Default.Save();
                    MessageBox.Show("Nombre de usuario guardado!", "Cambio exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
