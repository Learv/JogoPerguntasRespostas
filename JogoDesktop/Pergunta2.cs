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
    public partial class Pergunta2 : Form
    {
        public int id_jogador_banco;

        public Pergunta2(int id_jogador)
        {
            InitializeComponent();

            id_jogador_banco = id_jogador;
        }

        private void btnProxPergunta_Click(object sender, EventArgs e)
        {
            if (rdbResposta4.Checked == true)
            {
                MessageBox.Show("ACERTO!");
                //cadastrar no banco de dados a pergunta e a resposta
                using (SqlConnection conexao = new SqlConnection("Server=AME0556318W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta, resposta_correta, id_jogador) values (@PERGUNTA2,@RESPOSTA4, @ID_JOGADOR)", conexao))
                    {
                        comando.Parameters.AddWithValue("PERGUNTA2", lblPergunta.Text);
                        comando.Parameters.AddWithValue("RESPOSTA4", rdbResposta4.Text);
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
