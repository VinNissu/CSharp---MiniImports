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
    public partial class pesquisarFeed2 : Form
    {
        public pesquisarFeed2()
        {
            InitializeComponent();
        }

        private void pesquisarFeed2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.feedbackClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.feedbackClientesTableAdapter.Fill(this.mini_imports_realDataSet.feedbackClientes);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            alterarFeed frl = new alterarFeed();
            this.Hide();
            frl.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                feedbackClientesBindingSource.RemoveCurrent();
                feedbackClientesTableAdapter.Update(mini_imports_realDataSet.feedbackClientes); //salvar
                this.feedbackClientesTableAdapter.Fill(this.mini_imports_realDataSet.feedbackClientes);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                pesquisarFeed2 frl = new pesquisarFeed2();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                feedbackClientesBindingSource.Filter = string.Format("feedback_id={0}", textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                pesquisarFeed2 frl = new pesquisarFeed2();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                feedbackClientesBindingSource.Filter = string.Format("feedback_nmComprador like'%{0}%'", textBox2.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            feedback outroform = new feedback();
            this.Hide();
            outroform.ShowDialog();
        }
    }
}
