using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public Pergunta1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProxPergunta_Click(object sender, EventArgs e)
        {
            if (rdbResposta1.Checked == true)
            {
                MessageBox.Show("ACERTO!");                                 
            }else
            {
                MessageBox.Show("ERRO!");
            }
        }
    }
}
