using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            bool valido = true;
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Preencher o nome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;
            }

            if (txtSobrenome.Text == string.Empty)
            {
                MessageBox.Show("preencher Sobrenome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;
            }

            if (txtDtNascimento.Text == string.Empty)
            {
                MessageBox.Show("preencher a data de nascimento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;
            }

            if (valido == false)
            {
                return;
            }

            string nome, sobrenome;
            DateTime dtNascimento;
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            dtNascimento = Convert.ToDateTime(txtDtNascimento.Text);

                                                                  

            MessageBox.Show($@"Nome: {nome} 
            sobrenome: {sobrenome}
            DataNascimento: {dtNascimento}");

            
        }
    }
}
