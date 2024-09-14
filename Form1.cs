using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "Usuario")

            {
                txtUser.Text = "";
                txtUser.ForeColor= Color.DarkGray;
                
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == " ")
            {
                txtUser.Text ="Usuario";
                txtUser.ForeColor = Color.DarkGray;
                
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {

            if (textPass.Text == "Contraseña")

            {
                textPass.Text = " ";
                textPass.ForeColor = Color.DarkGray;
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == " ")
            {
                textPass.Text = "Contraseña";
                textPass.ForeColor = Color.DarkGray;
                textPass.UseSystemPasswordChar = false;
            }
        }

       
    }
}
.