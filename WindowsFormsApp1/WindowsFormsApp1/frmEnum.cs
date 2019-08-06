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
    public partial class frmEnum : Form
    {
        public frmEnum()
        {
            InitializeComponent();
        }

        enum TimeEnum
        {
            SaoPaulo,
            Curica,
            Palmeiras,
            Santos,
            Portuguesa

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.ToLower();
            nome = nome.Trim();
            TimeEnum time;
            if (nome == "fabio" || nome == "kleber"|| nome == "rossi"||nome == "vivian")
            {
                time = TimeEnum.Curica;
            }
            else if (nome == "patrick" || nome == "erik")
            {
                time = TimeEnum.Palmeiras;
            }
            else if (nome == "victor" || nome == "gennari")
            {
                time = TimeEnum.SaoPaulo;
            }
            else if (nome == "rogerio")
            {
                time = TimeEnum.Santos;
            }
            else
            {
                time = TimeEnum.Portuguesa;
            }
            switch (time)
            {
                case TimeEnum.SaoPaulo:
                    txtNome.Text =  $"{nome} seu time é de viado";
                    break;
                case TimeEnum.Curica:
                    txtNome.Text =  $"{nome} Time de parada Gay";
                    break;
                case TimeEnum.Palmeiras:
                    txtNome.Text =  $"{nome} O maior de todos Deca Campeão e 1º Campeão Mundial";
                    break;
                case TimeEnum.Santos:
                    txtNome.Text =  $"{nome} Sem o pelé não é nada";
                    break;
                case TimeEnum.Portuguesa:
                    txtNome.Text =  $"{nome} Vergonha";
                    break;
                default:
                    break;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
        }
    }
}
