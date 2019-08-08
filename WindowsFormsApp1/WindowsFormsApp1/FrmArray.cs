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
        string[] alunos = new string[8];
        public FrmArray()
        {
            InitializeComponent();

            alunos[0] = "Rossi";
            alunos[1] = "Patrick";
            alunos[2] = "Vivian";
            alunos[3] = "Gennari";
            alunos[4] = "Vitor";
            alunos[5] = "Erik";
            alunos[6] = "Rogerio";
            alunos[7] = "Fabio";
        }

        private void FrmArray_Load(object sender, EventArgs e)
        {
            

        }

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

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            #region Primeiro Item
            if (alunos.Length >=1)
            {
                lblPrimeiroItem.Text = alunos[0];
            }
            #endregion
            #region Nome Letra R
            lblNomeLetraR.Text = string.Empty;
            foreach (var alunos in alunos)
            {
                if (alunos.StartsWith("R"))
                {
                    lblNomeLetraR.Text += $"{alunos} , ";
                }
            }
            #endregion

            #region Desafio 1
            // Criar um Array com os alunos
            // cujo o nome começa com a letra R


            #endregion
        }
    }
}
