using ProjetoUninove.Model;
using ProjetoUninove.Model.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTecnico2023.Forms
{
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string password1 = "admin";

            if (txtUsuario.Text == User & password1 == "admin")
            {
                MessageBox.Show("acesso liberado");
                MainForm frmmain = new MainForm();
                frmmain.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("usuário/senha incorretos!");
            }

        }
    }
}
