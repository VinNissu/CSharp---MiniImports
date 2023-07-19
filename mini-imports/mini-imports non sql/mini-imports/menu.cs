using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_imports
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menuCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadfun outroform = new cadfun();
            this.Hide();
            outroform.ShowDialog();
        }

        private void cadastrarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadfor outroform = new cadfor();
            this.Hide();
            outroform.ShowDialog();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadprod outroform = new cadprod();
            this.Hide();
            outroform.ShowDialog();
        }

        private void registroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regivend outroform = new regivend();
            this.Hide();
            outroform.ShowDialog();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback outroform = new feedback();
            this.Hide();
            outroform.ShowDialog();
        }

        private void encomendarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarEncomend outroform = new pesquisarEncomend();
            this.Hide();
            outroform.ShowDialog();

        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            backup outroform = new backup();
            this.Hide();
            outroform.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            backup frl = new backup();
            this.Hide();
            frl.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuPanel frl = new MenuPanel();
            this.Hide();
            frl.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            MenuPanel frl = new MenuPanel();
            this.Hide();
            frl.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            backup frl = new backup();
            this.Hide();
            frl.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuPanel frl = new MenuPanel();
            this.Hide();
            frl.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            caixa frl = new caixa();
            this.Hide();
            frl.ShowDialog();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlestoq outroform = new ctrlestoq();
            this.Hide();
            outroform.ShowDialog();
        }

        private void cadastrarEncomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encomend outroform = new encomend();
            this.Hide();
            outroform.ShowDialog();
        }
    }
}
