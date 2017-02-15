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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {

            if(txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome")
            {
                MessageBox.Show("Você deve informar seu nome", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            } else if (txtEmail.Text == "Digite seu e-mail") {
            
                MessageBox.Show("Você deve informar seu e-mail", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }

             //dfg//
                //início do código para inserir o jogador na tabela
                //using System.Data.SqlClient;
                using (SqlConnection conexao = new SqlConnection("Server=AME0556318W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using(SqlCommand comando = new SqlCommand("insert into tb_jogador(nome, sobrenome, email) OUTPUT INSERTED.ID values(@NOME, @SOBRENOME, @EMAIL)",conexao))
                    {
                    comando.Parameters.AddWithValue("NOME", txtNome.Text);
                    comando.Parameters.AddWithValue("SOBRENOME", txtSobrenome.Text);
                    comando.Parameters.AddWithValue("EMAIL", txtSobrenome.Text);
                    conexao.Open();

                        int id_jogador = (int)comando.ExecuteScalar();

                        if (id_jogador > 0)
                        {
                            
                            MessageBox.Show("O ID inserido foi: " + id_jogador);

                            MessageBox.Show("Olá " + txtNome.Text.ToUpper() + ". Você está pronto para continuar!!!", "PLAYYYY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                           /* System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                            player.SoundLocation = "c:\\vm\\teste\\som.wav";
                            player.Play();*/

                        
                            Pergunta1 p1 = new Pergunta1(id_jogador);
                            p1.ShowDialog();
                            Pergunta2 p2 = new Pergunta2(id_jogador);
                            p2.ShowDialog();
                            Pergunta3 p3 = new Pergunta3(id_jogador);
                            p3.ShowDialog();
                            Pergunta4 p4 = new Pergunta4(id_jogador);
                            p4.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("DEU RUIMMMM!!!! Algo aconteceu durante o insert");
                        }
                    }
                }
                //fim do código para inserir o jogador na tabela
            }
        }
    }

