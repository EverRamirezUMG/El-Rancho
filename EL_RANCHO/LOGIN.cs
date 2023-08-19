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

namespace EL_RANCHO
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        int valUsuario;
        int valPass;
        int totalvalidar;
        //string usuario = TBusuario.Text;
        //string paass = TBpass.Text;
        string pass = Settings.Default.Pass;
        string user = Settings.Default.User;
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (TBusuario.Text != user && TBpass.Text != pass) 
            {
                MessageBox.Show("Usuario y contraseña incorrecto!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                if (TBusuario.Text == user)
                {
                    valUsuario = 1;
                }

                else
                {
                    MessageBox.Show("Usuario incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valUsuario = 0;
                }
                if (TBpass.Text == pass)
                {
                    valPass = 1;
                }
                else
                {
                    MessageBox.Show("Contrasseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valPass = 0;
                }
            }
         
                totalvalidar = valUsuario + valPass;
                if (totalvalidar == 2)
                {
                    this.Hide();
                    INDEX frm = new INDEX();
                    frm.Show();
                }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btOcultar_Click(object sender, EventArgs e)
        {
            if (TBpass.PasswordChar == '*')
            {
                btMostrar.BringToFront();
                TBpass.PasswordChar = '\0'; 
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            if (TBpass.PasswordChar == '\0')
            {
                btOcultar.BringToFront();
                TBpass.PasswordChar = '*';
            }
        }
    }
}
