using System;
using System.Windows.Forms;

namespace _01._4.IDisposable_Finalizador
{
    public partial class FrmMensagem : Form
    {
        public FrmMensagem()
        {
            InitializeComponent();

        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            //inicializando o mensageiro
            //MensageiroNotepad mensageiro = new MensageiroNotepad();
            //enviando a mensagem
            //mensageiro.EnviarMensagem(txtMensagem.Text);
            //liberando o recurso
            //mensageiro.Dispose();

            //com esse código, eu consigo inicializar o mensageiro, enviar a mensagem e liberar o recurso
            using (MensageiroNotepad mensageiro = new MensageiroNotepad())
            {
                mensageiro.EnviarMensagem(txtMensagem.Text);
            }

        }
    }
}
