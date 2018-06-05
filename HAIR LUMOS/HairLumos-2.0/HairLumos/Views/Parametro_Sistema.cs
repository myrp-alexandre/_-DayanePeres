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

namespace HairLumos.Views
{
    public partial class Parametro_Sistema : Form
    {

        public Parametro_Sistema()
        {
            InitializeComponent();
        }

       
        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg|png|*.png";
            //Após escolher verifica se tem mais de 1MB
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(ofd.FileName);

                if (file.Length <= 1048576)
                {
                    //Carrega a imagem no pictureBox, imagem esta que será transformada em bytes[] para ser armazenada no banco
                    pcbLogo.Image = Image.FromFile(ofd.FileName);
                    //pcbLogo.ImageLocation = ofd.FileName; //Carrega a imagem no pictureBox
                }
                else
                    MessageBox.Show("Arquivo maior que 1MB, por favor escolha um arquivo menor!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static byte[] ImageParaByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Controller.ParametrizacaoController _ctrParam = new Controller.ParametrizacaoController();

            string strMensagem = string.Empty;

            try
            {
                //validações
               
                if (string.IsNullOrWhiteSpace(ttbRazaoSocial.Text))
                    strMensagem += $"Informe a Razão Social!.";

                if (string.IsNullOrWhiteSpace(ttbNomeFantasia.Text))
                    strMensagem += $"Informe o Nome Fantasia!.";

                if (string.IsNullOrWhiteSpace(ttbEndereco.Text))
                    strMensagem += $"Informe o Endereço!.";

                if (string.IsNullOrWhiteSpace(ttbNum.Text))
                    strMensagem += $"Informe o Número!.";


                if (string.IsNullOrWhiteSpace(mskCelular.Text))
                    strMensagem += $"Informe o Celular!.";
                //verificar se houve alguma anormalidade no cadastro
                if (string.IsNullOrEmpty(strMensagem))
                {

                    DataTable dt = new DataTable();
                    dt = _ctrParam.retornaParametrização();
                    byte[] byteimg = ImageParaByteArray(pcbLogo.Image);//ImageToByteArray(pcbLogo.Image);

                    if (dt.Rows.Count == 0) // Não existe aparametrizãção cadastrada, então grava
                    {
                        btnLogo.Enabled = true;
                        int intRetorno = _ctrParam.gravarParametrizacao(0, ttbRazaoSocial.Text, ttbNomeFantasia.Text, ttbEmail.Text, ttbEndereco.Text,
                            ttbComplemento.Text, ttbNum.Text, mskTelefone.Text, mskCelular.Text, byteimg);

                        if (intRetorno == 1)
                        {
                            MessageBox.Show("Gravado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Gravar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(strMensagem, "Aviso!!");
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex + "");
            }
        }
    }
}
