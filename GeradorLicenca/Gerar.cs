using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorLicenca
{
    public partial class Gerar : MetroFramework.Forms.MetroForm
    {
        public Gerar()
        {
            InitializeComponent();
        }

        private void Gerar_Load(object sender, EventArgs e)
        {
            string produtoId = ComputerInfo.GetComputerId();
            txtProdutoId.Text = produtoId;
            txtSenha.Focus();

        }

        private void btnGerarLicenca_Click(object sender, EventArgs e)
        {
            try
            {
                string pasta = cl_Diretorio.PastaDiretorio();
                DateTime hj = DateTime.Now;
                string datahj = hj.ToString("dd/MM/yyyy");
               
                string lic = cl_Seguranca.Encrypt($"{txtProdutoId.Text};{txtContagem.Text};{txtExe.Text};{datahj};{txtData.Text}");

                using (StreamWriter writer = new StreamWriter($"{pasta}\\licence.lic"))
                {
                    writer.Write(lic);
                }

                MessageBox.Show("Salva com sucesso!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
           
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = cl_Diretorio.CaminhoAbrir("ARQUIVOS LICENÇA|*.lic", "", "");
                string licenca = "";
                using (StreamReader reader = new StreamReader(caminho))
                {
                    licenca = reader.ReadLine();
                }

                licenca = cl_Seguranca.Decrypt(licenca);

                string[] vetor = licenca.Split(';');
                txtProdutoId.Text = vetor[0];
                txtContagem.Text = vetor[1];
                txtExe.Text = vetor[2];
                txtData.Text = vetor[4];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
            
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtSenha.Text == "lammer27")
                {                   
                    txtExe.Enabled = true;
                    txtData.Enabled = true;
                    txtContagem.Enabled = true;
                }else
                {
                    txtExe.Enabled = false;
                    txtData.Enabled = false;
                    txtContagem.Enabled = false;
                }

            }
            catch 
            {

            }
        }
    }
}
