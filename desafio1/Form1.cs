using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio1
{
    public partial class Form1 : Form
    {
        decimal TotalCapital = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtMontoInicial.Text.ToString());
            double num2 = double.Parse(txtTasaAnual.Text.ToString())/100;
            double num3 = double.Parse(txtPeriodoInversion.Text.ToString());
            double tasa = Math.Pow(1 + num2, num3);
            double capitalTotal = num1 * tasa;
            double InteresesAcum= tasa * num3;
                
            button1 .Text = capitalTotal.ToString();
            button2 .Text = InteresesAcum.ToString();






        }
    }
}
