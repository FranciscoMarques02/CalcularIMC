using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Tratamento de erros:
            try
            {
                //Substituir '.' por ','
                txbAltura.Text = txbAltura.Text.Replace('.', ',');
                txbPeso.Text = txbPeso.Text.Replace('.', ',');

                //Variável "imc" recebe o resultado da conta
                //e o TextBox recebe o imc com duas casas decimais
                double imc = double.Parse(txbPeso.Text) / Math.Pow(double.Parse(txbAltura.Text), 2);
                txbIMC.Text = Math.Round(imc, 2).ToString();

                //O label da classificação muda de acordo com o valor do imc
                if(imc < 18.5)
                {
                    lblClassificacao.Text = "ABAIXO DO PESO!";
                    lblClassificacao.ForeColor = Color.Yellow;
                }else if(imc  >= 18.5 && imc < 25)
                {
                    lblClassificacao.Text = "SAUDÁVEL";
                    lblClassificacao.ForeColor = Color.Green;
                }else if(imc >= 25 && imc < 30)
                {
                    lblClassificacao.Text = "ACIMA DO PESO!";
                    lblClassificacao.ForeColor = Color.Orange;
                }else if(imc >= 30 && imc < 35)
                {
                    lblClassificacao.Text = "OBESIDADE!";
                    lblClassificacao.ForeColor = Color.Red;
                }else if(imc >= 35 && imc < 40)
                {
                    lblClassificacao.Text = "OBESIDADE SEVERA!";
                    lblClassificacao.ForeColor = Color.DarkRed;
                } 
                else
                {
                    lblClassificacao.Text = "OBESIDADE MÓRBIDA!!!";
                    lblClassificacao.ForeColor = Color.DarkRed;
                }
            }
            catch
            {
                txbIMC.Text = "Erro!";
            }
        }
    }
}
