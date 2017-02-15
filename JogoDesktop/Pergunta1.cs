using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public int id_jogador_banco;

        public Pergunta1(int id_jogador)
        {
            InitializeComponent();

            id_jogador_banco = id_jogador;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProxPergunta_Click(object sender, EventArgs e)
        {
            if (rdbResposta1.Checked == true)
            {
                MessageBox.Show("ACERTO!");
                //cadastrar no banco de dados a pergunta e a resposta
                using (SqlConnection conexao = new SqlConnection("Server=AME0556318W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta, resposta_correta, id_jogador) values (@PERGUNTA1,@RESPOSTA1, @ID_JOGADOR)", conexao))
                    {
                        comando.Parameters.AddWithValue("PERGUNTA1", lblPergunta.Text);
                        comando.Parameters.AddWithValue("RESPOSTA1", rdbResposta1.Text);
                        comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_banco);
                        conexao.Open();
                        if(comando.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("SALVO");

                            this.Close();

                        }
                    }
                }
            }
            else
            {

                MessageBox.Show("ERRO!");
            }
        }

        private void Pergunta1_Load(object sender, EventArgs e)
        {

        }

        private void rdbResposta1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbResposta2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


