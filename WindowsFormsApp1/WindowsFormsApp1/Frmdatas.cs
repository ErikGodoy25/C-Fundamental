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
    public partial class Frmdatas : Form
    {
        public Frmdatas()
        {
            InitializeComponent();
        }

        private void Frmdatas_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtData.Text = string.Empty;
            txtQtDias.Text = string.Empty;
            txtQtMeses.Text = string.Empty;

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(txtData.Text);
            data = data.AddDays(Convert.ToInt32(txtQtDias.Text));
            //06-08-2019 - Forma de datas
            //dd-MM-yyyy
            //dd-MM-yy
            //dd-MMM-yy
            //dd-MMMM-yy
            //
            lblQtdDias.Text = data.ToString("dd-MMMM-yy");
            //lblQtMeses.Text = Convert.ToDateTime(txtQtDias.txt).AddMonths(Convert.ToInt32(txtQtMeses.Text))
            //  .ToString("dd/MM/yyyy")

            var dataMes = Convert.ToDateTime(txtData.Text);
            int qtdMeses = Convert.ToInt32(txtQtMeses.Text);
            dataMes = dataMes.AddMonths(qtdMeses);
            lblQtMeses.Text = dataMes.ToString("dd/MM/yyyy");
        }
    }
}
