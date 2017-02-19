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
    public partial class Pergunta4 : Form
    {
        public int id_jogador_banco;

        public Pergunta4(int id_jogador)
        {
            InitializeComponent();

            id_jogador_banco = id_jogador;
        }

        private void btnProxPergunta_Click(object sender, EventArgs e)
        {
            if (rdbResposta1.Checked == true)
            {
                MessageBox.Show("ACERTO!");
                //cadastrar no banco de dados a pergunta e a resposta
                using (SqlConnection conexao = new SqlConnection("Server=AME0556318W10-1\\SQLEXPRESSDatabase=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta, resposta_correta, id_jogador) values (@PERGUNTA4,@RESPOSTA1, @ID_JOGADOR)", conexao))
                    {
                        comando.Parameters.AddWithValue("PERGUNTA4", lblPergunta.Text);
                        comando.Parameters.AddWithValue("RESPOSTA1", rdbResposta1.Text);
                        comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_banco);
                        conexao.Open();
                        if (comando.ExecuteNonQuery() == 1)
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
    }
}
