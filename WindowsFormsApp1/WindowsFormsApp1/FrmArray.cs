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
    public partial class FrmArray : Form
    {
        public FrmArray()
        {
            InitializeComponent();
        }

        private void FrmArray_Load(object sender, EventArgs e)
        {

        }

        string[] alunos = new string[8];

        private void BtnOk_Click_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alunos.Length; i++)
                if (alunos[i] == null)
                {
                    alunos[i] = txtNome.Text;
                    lblTamanhoArray.Text += $"{txtNome.Text} \r\n";
                    txtNome.Text = string.Empty;
                    break;
                }
            {

            }

            /*string variavelString = "um unico valor";
            string[] arrayString = new string[] { "kleber", "Gennari" };

            string[] arrayTamanho = new string[10];

            int variavelInteiro;
            int[] arrayInteiro;

            DateTime dataHora;
            DateTime[] arrayDataHora;*/

                       
        }
    }
}
